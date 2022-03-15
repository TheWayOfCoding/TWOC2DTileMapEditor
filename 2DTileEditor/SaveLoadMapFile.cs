/*
 * TWOC 2D Tile Map Editor
 * Copyright 2015-2022, Scott Waldron
 * TheWayOfCoding.com
 * 
 * Official source location: 
 * https://github.com/TheWayOfCoding/TWOC2DTileMapEditor
 * 
 * This file is part of TWOC 2D Tile Map Editor.
 * 
 * TWOC 2D Tile Map Editor is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * TWOC 2D Tile Map Editor is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with TWOC 2D Tile Map Editor. If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2DTileEditor
{
    public static class SaveLoadMapFile
    {
        public static void saveMap(string filenameAndPath)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };

            //open the specified file for editing
            using (XmlWriter writer = XmlWriter.Create(filenameAndPath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("mapfile");

                //write map properties
                writer.WriteStartElement("mapproperties");

                writer.WriteStartElement("name");
                writer.WriteString(CurrentMapDetails.MapName);
                writer.WriteEndElement();

                writer.WriteStartElement("width");
                writer.WriteString(CurrentMapDetails.mapSize.Width.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("height");
                writer.WriteString(CurrentMapDetails.mapSize.Height.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("tilesize");
                writer.WriteString(CurrentMapDetails.TileSize.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("tileset");
                writer.WriteString(CurrentMapDetails.TileSetBitmapFilename);
                writer.WriteEndElement();

                writer.WriteStartElement("tilesetpixelswidth");
                writer.WriteString(CurrentMapDetails.tileSetImagePixelsWidth.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("tilesetpixelsheight");
                writer.WriteString(CurrentMapDetails.tileSetImagePixelsHeight.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement(); //mapproperties

                if(CurrentMapDetails.globalExtraProperties.Count > 0)
                {
                    writer.WriteStartElement("globalextras");

                    foreach (string singleExtra in CurrentMapDetails.globalExtraProperties)
                    {
                        writer.WriteStartElement("ge");
                        writer.WriteAttributeString("v", singleExtra);
                        writer.WriteEndElement();
                    }
                    
                    writer.WriteEndElement(); //globalextras
                }

                //write the collection of map layers

                writer.WriteStartElement("layerdata");
                for (int i = 0; i < CurrentMapDetails.mapLayers.Count; i++)
                {
                    //add details about this layer
                    writer.WriteStartElement("layer");
                    writer.WriteAttributeString("name", i.ToString());
                    writer.WriteAttributeString("width", CurrentMapDetails.mapLayers[i].MapSizeWidth.ToString());
                    writer.WriteAttributeString("height", CurrentMapDetails.mapLayers[i].MapSizeHeight.ToString());
                    writer.WriteAttributeString("tilesize", CurrentMapDetails.mapLayers[i].TileSize.ToString());

                    //loop through the entire set of layer data
                    for (int x = 0; x < CurrentMapDetails.mapLayers[i].MapSizeWidth; x++)
                    {
                        for (int y = 0; y < CurrentMapDetails.mapLayers[i].MapSizeHeight; y++)
                        {
                            writer.WriteStartElement("ti");

                            writer.WriteAttributeString("x", x.ToString() + "," + y.ToString());

                            if (CurrentMapDetails.mapLayers[i].items[x, y].collidable == true)
                            {
                                writer.WriteAttributeString("c", "t");
                            }
                            else
                            {
                                writer.WriteAttributeString("c", "f");
                            }
                            
                            writer.WriteAttributeString("p", CurrentMapDetails.mapLayers[i].items[x, y].tileSetPosition.X
                                + "," + CurrentMapDetails.mapLayers[i].items[x, y].tileSetPosition.Y);

                            if (CurrentMapDetails.mapLayers[i].items[x, y].extraProperties.Count > 0)
                            {
                                writer.WriteAttributeString("e", string.Join(",", 
                                    CurrentMapDetails.mapLayers[i].items[x, y].extraProperties.ToArray()));
                            }
                            else
                            {
                                writer.WriteAttributeString("e", "");
                            }
                            
                            writer.WriteEndElement(); //tileitem
                        }
                    }

                    writer.WriteEndElement(); //layer
                }
                writer.WriteEndElement(); //layerdata

                writer.WriteEndElement(); //mapfile
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        /// <summary>
        /// load the passed map file into global data structures
        /// </summary>
        /// <param name="filenameAndPath"></param>
        public static void loadMap(string filenameAndPath)
        {
            CurrentMapDetails.MapName = "";
            CurrentMapDetails.tileSetImage = null;
            CurrentMapDetails.tileSetImagePixelsWidth = 0;
            CurrentMapDetails.tileSetImagePixelsHeight = 0;
            CurrentMapDetails.tileSetLoaded = false;
            CurrentMapDetails.TileSize = 0;
            CurrentMapDetails.TileSetBitmapFilename = "";
            CurrentMapDetails.mapSize.Width = 0;
            CurrentMapDetails.mapSize.Height = 0;
            CurrentMapDetails.IsNewMap = false;
            CurrentMapDetails.mapLayers.Clear();
            CurrentMapDetails.globalExtraProperties.Clear();

            using (XmlReader reader = XmlReader.Create(filenameAndPath))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "mapfile":

                                break;
                                
                            case "globalextras":
                                using (XmlReader mapReader = reader.ReadSubtree())
                                {
                                    readGlobalExtrasProperties(mapReader);
                                    mapReader.Close();
                                }
                                break;

                            case "mapproperties":
                                using (XmlReader mapReader = reader.ReadSubtree())
                                {
                                    readMapProperties(mapReader);
                                    mapReader.Close(); 
                                }
                                break;

                            case "layerdata":
                                using (XmlReader layerDataReader = reader.ReadSubtree())
                                {
                                    readLayers(layerDataReader, CurrentMapDetails.mapLayers);
                                    layerDataReader.Close();
                                }
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// read the tag block related to general map properties
        /// </summary>
        /// <param name="reader"></param>
        private static void readGlobalExtrasProperties(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "ge":
                            string currentAttribute = reader.GetAttribute("v");
                            if(currentAttribute != null)
                            {
                                CurrentMapDetails.globalExtraProperties.Add(currentAttribute);
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// read the tag block related to general map properties
        /// </summary>
        /// <param name="reader"></param>
        private static void readMapProperties(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "name":
                            reader.MoveToContent();
                            reader.Read();
                            CurrentMapDetails.MapName = reader.Value.Trim();
                            break;

                        case "width":
                            reader.MoveToContent();
                            reader.Read();
                            int parsedWidth = 0;
                            if (int.TryParse(reader.Value.Trim(), out parsedWidth) == true)
                            {
                                CurrentMapDetails.mapSize.Width = parsedWidth;
                            }
                            break;

                        case "height":
                            reader.MoveToContent();
                            reader.Read();
                            int parsedHeight = 0;
                            if (int.TryParse(reader.Value.Trim(), out parsedHeight) == true)
                            {
                                CurrentMapDetails.mapSize.Height = parsedHeight;
                            }
                            break;

                        case "tilesize":
                            reader.MoveToContent();
                            reader.Read();
                            int parsedTileSize = 0;
                            if (int.TryParse(reader.Value.Trim(), out parsedTileSize) == true)
                            {
                                CurrentMapDetails.TileSize = parsedTileSize;
                            }
                            break;

                        case "tileset":
                            reader.MoveToContent();
                            reader.Read();
                            CurrentMapDetails.TileSetBitmapFilename = reader.Value.Trim();

                            //reference the bitmap under the application's exe path
                            string fileNameAndPath = Path.Combine(Globals.sourceImagePath, CurrentMapDetails.TileSetBitmapFilename);
                            if (File.Exists(fileNameAndPath) == true)
                            {
                                CurrentMapDetails.tileSetImage = new Bitmap(fileNameAndPath);
                                CurrentMapDetails.tileSetImagePixelsWidth = CurrentMapDetails.tileSetImage.Width;
                                CurrentMapDetails.tileSetImagePixelsHeight = CurrentMapDetails.tileSetImage.Height;
                                CurrentMapDetails.tileSetLoaded = true;
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// read the tag block that relates to all of the map layers
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="layerData"></param>
        private static void readLayers(XmlReader reader, List<LayerHandler> layerData)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "layer":
                            LayerHandler newLayer = new LayerHandler();

                            //read all of the layer's properties in the form of xml attributes
                            newLayer.name = reader.GetAttribute("name");

                            int parsedWidth = 0;
                            if (int.TryParse(reader.GetAttribute("width"), out parsedWidth) == true)
                            {
                                newLayer.MapSizeWidth = parsedWidth;
                            }

                            int parsedHeight = 0;
                            if (int.TryParse(reader.GetAttribute("height"), out parsedHeight) == true)
                            {
                                newLayer.MapSizeHeight = parsedHeight;
                            }

                            int parsedTileSize = 0;
                            if (int.TryParse(reader.GetAttribute("tilesize"), out parsedTileSize) == true)
                            {
                                newLayer.TileSize = parsedTileSize;
                            }

                            //size the internal data collection before we read the actual tile information
                            newLayer.items = new LayerHandler.LayerItem[newLayer.MapSizeWidth, newLayer.MapSizeHeight];

                            //read the tile information
                            using (XmlReader singleLayerReader = reader.ReadSubtree())
                            {
                                readSingleLayer(singleLayerReader, newLayer);
                                singleLayerReader.Close();
                            }

                            layerData.Add(newLayer);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// read all of the information about the passed single layer
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="currentLayer"></param>
        private static void readSingleLayer(XmlReader reader, LayerHandler currentLayer)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "ti": //tile item
                            int parsedX = 0;
                            int parsedY = 0;

                            string getXYValue = reader.GetAttribute("x");
                            string[] getXYValueSplit = getXYValue.Split(',');
                            if (getXYValueSplit.Length == 2 && int.TryParse(getXYValueSplit[0], out parsedX) 
                                && int.TryParse(getXYValueSplit[1], out parsedY))
                            {
                                //collidable
                                string collidableValue = reader.GetAttribute("c");
                                if (collidableValue.Trim().ToLower().Equals("t") == true)
                                {
                                    currentLayer.items[parsedX, parsedY].collidable = true;
                                }
                                else
                                {
                                    currentLayer.items[parsedX, parsedY].collidable = false;
                                }

                                //tilesetposition
                                string tspData = reader.GetAttribute("p").Trim();
                                string[] tspDataSplit = tspData.Split(',');
                                if (tspDataSplit.Length >= 2)
                                {
                                    int parsedTX = 0;
                                    if (int.TryParse(tspDataSplit[0], out parsedTX) == true)
                                    {
                                        currentLayer.items[parsedX, parsedY].tileSetPosition.X = parsedTX;
                                    }
                                    else
                                    {
                                        currentLayer.items[parsedX, parsedY].tileSetPosition.X = -1;
                                    }

                                    int parsedTY = 0;
                                    if (int.TryParse(tspDataSplit[1], out parsedTY) == true)
                                    {
                                        currentLayer.items[parsedX, parsedY].tileSetPosition.Y = parsedTY;
                                    }
                                    else
                                    {
                                        currentLayer.items[parsedX, parsedY].tileSetPosition.Y = -1;
                                    }
                                }

                                currentLayer.items[parsedX, parsedY].extraProperties = new List<string>();
                                string extras = reader.GetAttribute("e").Trim();
                                string[] extrasDataSplit = extras.Split(',');
                                if (extrasDataSplit.Length > 0)
                                {
                                    for (int i = 0; i < extrasDataSplit.Length; i++)
                                    {
                                        if (extrasDataSplit[i].Trim().Equals(string.Empty) == false)
                                        {
                                            currentLayer.items[parsedX, parsedY].extraProperties.Add(extrasDataSplit[i]);
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }

    }
}
