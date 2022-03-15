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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DTileEditor
{
    public class LayerHandler
    {
        public struct LayerItem
        {
            public Point tileSetPosition;
            public bool collidable;
            public List<string> extraProperties;
        }

        public LayerItem[,] items;

        public Image backgroundImage = null;

        public bool currentlyVisible = true;

        public string name = "";

        /// <summary>
        /// initialize the 2d array of tiles for this map layer
        /// </summary>
        public void initalizeLayerItemArray()
        {
            items = new LayerItem[mapSizeWidth, mapSizeHeight];

            for(int x = 0; x < mapSizeWidth; x++)
            {
                for (int y = 0; y < mapSizeHeight; y++)
                {
                    items[x, y].collidable = false;
                    items[x, y].tileSetPosition = new Point(-1, -1);
                    items[x, y].extraProperties = new List<string>();
                }
            }
        }

        /// <summary>
        /// a safe way to resize the array without losing data
        /// </summary>
        public void resizeLayerItemArray(int newWidth, int newHeight)
        {
            LayerItem[,] newArray = new LayerItem[newWidth, newHeight];

            //loop through the data and push it to the new array
            //use the smaller ones as the loop limits
            bool newArrayLarger = false;

            int dataCopyWidth = 0;
            if (mapSizeWidth < newWidth)
            {
                dataCopyWidth = mapSizeWidth;
                newArrayLarger = true;
            }
            else
            {
                dataCopyWidth = newWidth;
            }

            int dataCopyHeight = 0;
            if (mapSizeHeight < newHeight)
            {
                dataCopyHeight = mapSizeHeight;
                newArrayLarger = true;
            }
            else
            {
                dataCopyHeight = newHeight;
            }

            //push all of the old data to the new array
            for (int x = 0; x < dataCopyWidth; x++)
            {
                for (int y = 0; y < dataCopyHeight; y++)
                {
                    newArray[x, y].collidable = items[x, y].collidable;
                    newArray[x, y].tileSetPosition = items[x, y].tileSetPosition;
                    newArray[x, y].extraProperties = items[x, y].extraProperties;
                }
            }

            //initialize the remainder of the new tile pieces
            if (newArrayLarger == true)
            {
                for (int x = dataCopyWidth - 1; x < newWidth; x++)
                {
                    for (int y = 0; y < newHeight; y++)
                    {
                        newArray[x, y].collidable = false;
                        newArray[x, y].tileSetPosition = new Point(-1, -1);
                        newArray[x, y].extraProperties = new List<string>();
                    }
                }

                for (int y = dataCopyHeight - 1; y < newHeight; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        newArray[x, y].collidable = false;
                        newArray[x, y].tileSetPosition = new Point(-1, -1);
                        newArray[x, y].extraProperties = new List<string>();
                    }
                }
            }

            //discard the old array with the new one
            items = newArray;

            mapSizeWidth = newWidth;
            mapSizeHeight = newHeight;
        }

        /// <summary>
        /// The size of each tile in the map in pixels, this is the same for the width and height of the tile.
        /// </summary>
        private int tileSize = 0;
        public int TileSize
        {
            get { return tileSize; }
            set { tileSize = value; }
        }

        /// <summary>
        /// Total width of the map in number of tiles.
        /// </summary>
        private int mapSizeWidth = 0;
        public int MapSizeWidth
        {
            get { return mapSizeWidth; }
            set 
            { 
                mapSizeWidth = value;
                //resizeLayerItemArray(mapSizeWidth, mapSizeHeight);
            }
        }

        /// <summary>
        /// Total height of the map in tiles.
        /// </summary>
        private int mapSizeHeight = 0;
        public int MapSizeHeight
        {
            get { return mapSizeHeight; }
            set 
            { 
                mapSizeHeight = value;
                //resizeLayerItemArray(mapSizeWidth, mapSizeHeight);
            }
        }

        public LayerHandler()
        {
            tileSize = 128;
            mapSizeWidth = 100;
            mapSizeHeight = 50;

            initalizeLayerItemArray();
        }

        public LayerHandler(int tileSize, int mapSizeWidthInTiles, int mapSizeHeightInTiles)
        {
            this.tileSize = tileSize;
            this.mapSizeWidth = mapSizeWidthInTiles;
            this.mapSizeHeight = mapSizeHeightInTiles;

            initalizeLayerItemArray();
        }

        /// <summary>
        /// constructor used when loading a background image
        /// </summary>
        /// <param name="tileSize"></param>
        /// <param name="backgroundImageFilename"></param>
        public LayerHandler(int tileSize, string backgroundImageFilename)
        {
            this.tileSize = tileSize;

            backgroundImage = new Bitmap(backgroundImageFilename);

            this.mapSizeWidth = backgroundImage.Width / CurrentMapDetails.TileSize;
            this.mapSizeHeight = backgroundImage.Height / CurrentMapDetails.TileSize;

            initalizeLayerItemArray();
        }

        /// <summary>
        /// get the calculated size of this map in pixels
        /// </summary>
        /// <returns>a "Size" instance</returns>
        public Size currentSizeInPixels()
        {
            return new Size(mapSizeWidth * tileSize, mapSizeHeight * tileSize);
        }
    }
}
