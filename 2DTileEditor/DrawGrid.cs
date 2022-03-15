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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _2DTileEditor
{
    class DrawGrid
    {
        PictureBox mainScreen = null;

        LayerHandler mainLayer = null;
        public LayerHandler MainLayer
        {
            set
            {
                if (value != null)
                {
                    mainLayer = value;
                    calculatePositioning();
                }
            }
        }

        List<LayerHandler> mainLayerMultiple = null;
        public List<LayerHandler> MainLayerMultiple
        {
            set
            {
                if (value != null)
                {
                    mainLayerMultiple = value;

                    if (mainLayerMultiple != null && mainLayerMultiple.Count > 0)
                    {
                        mainLayer = mainLayerMultiple[0];
                    }

                    calculatePositioning();
                }
            }
        }

        HScrollBar horizontalScrollBar = null;
        VScrollBar verticalScrollBar = null;
        InputHandler inputHandler = null;

        float tilePositionXPrecise = 0;
        float tilePositionYPrecise = 0;
        int tileOffsetX = 0;
        int tileOffsetY = 0;
        int tilesPerScreenX = 0;
        int tilesPerScreenY = 0;

        bool mouseClickHappened = false;
        public bool MouseClickHappened
        {
            set
            {
                mouseClickHappened = value;
            }
        }

        private DrawGrid() { }

        /// <summary>
        /// constructor for a single layer
        /// </summary>
        /// <param name="mainScreenReference"></param>
        /// <param name="mainLayerReference"></param>
        /// <param name="horizontalScrollBarReference"></param>
        /// <param name="verticalScrollBarReference"></param>
        /// <param name="mainInputHandler"></param>
        public DrawGrid(PictureBox mainScreenReference, LayerHandler mainLayerReference,
        HScrollBar horizontalScrollBarReference, VScrollBar verticalScrollBarReference, InputHandler mainInputHandler)
        {
            mainScreen = mainScreenReference;
            mainLayer = mainLayerReference;
            mainLayerMultiple = null;
            horizontalScrollBar = horizontalScrollBarReference;
            verticalScrollBar = verticalScrollBarReference;
            inputHandler = mainInputHandler;

            calculatePositioning();
        }

        /// <summary>
        /// constructor for multiple layers
        /// </summary>
        /// <param name="mainScreenReference"></param>
        /// <param name="mainLayerMultipleReference"></param>
        /// <param name="horizontalScrollBarReference"></param>
        /// <param name="verticalScrollBarReference"></param>
        /// <param name="mainInputHandler"></param>
        public DrawGrid(PictureBox mainScreenReference, List<LayerHandler> mainLayerMultipleReference,
        HScrollBar horizontalScrollBarReference, VScrollBar verticalScrollBarReference, InputHandler mainInputHandler)
        {
            mainScreen = mainScreenReference;

            mainLayerMultiple = mainLayerMultipleReference;
            if (mainLayerMultiple != null && mainLayerMultiple.Count > 0)
            {
                mainLayer = mainLayerMultiple[0];
            }

            horizontalScrollBar = horizontalScrollBarReference;
            verticalScrollBar = verticalScrollBarReference;
            inputHandler = mainInputHandler;

            calculatePositioning();
        }

        /// <summary>
        /// 
        /// </summary>
        public void calculatePositioning()
        {
            tilesPerScreenX = mainScreen.Width / mainLayer.TileSize + 1;
            tilesPerScreenY = mainScreen.Height / mainLayer.TileSize + 1;

            if (tilesPerScreenX > mainLayer.MapSizeWidth)
            {
                tilesPerScreenX = mainLayer.MapSizeWidth;
                horizontalScrollBar.Enabled = false;
                horizontalScrollBar.Value = 0;
                horizontalScrollBar.Maximum = 0;
            }
            else
            {
                horizontalScrollBar.Enabled = true;
                horizontalScrollBar.Maximum = ((mainLayer.MapSizeWidth * mainLayer.TileSize) - mainScreen.Width)
                    + (horizontalScrollBar.LargeChange);
            }

            if (tilesPerScreenY > mainLayer.MapSizeHeight)
            {
                tilesPerScreenY = mainLayer.MapSizeHeight;
                verticalScrollBar.Enabled = false;
                verticalScrollBar.Value = 0;
                verticalScrollBar.Maximum = 0;
            }
            else
            {
                verticalScrollBar.Enabled = true;
                verticalScrollBar.Maximum = ((mainLayer.MapSizeHeight * mainLayer.TileSize) - mainScreen.Height)
                    + (verticalScrollBar.LargeChange);
            }

            tilePositionXPrecise = (float)horizontalScrollBar.Value / (float)mainLayer.TileSize;
            tilePositionYPrecise = (float)verticalScrollBar.Value / (float)mainLayer.TileSize;

            if (mainLayer.MapSizeWidth - tilePositionXPrecise < tilesPerScreenX)
            {
                tilesPerScreenX = mainLayer.MapSizeWidth - (int)tilePositionXPrecise;
            }

            if (mainLayer.MapSizeHeight - tilePositionYPrecise < tilesPerScreenY)
            {
                tilesPerScreenY = mainLayer.MapSizeHeight - (int)tilePositionYPrecise;
            }

            if (horizontalScrollBar.Value != 0)
            {
                tileOffsetX = (int)(mainLayer.TileSize * Math.Abs(Math.Truncate(tilePositionXPrecise) - tilePositionXPrecise));
            }
            else
            {
                tileOffsetX = 0;
            }

            if (verticalScrollBar.Value != 0)
            {
                tileOffsetY = (int)(mainLayer.TileSize * Math.Abs(Math.Truncate(tilePositionYPrecise) - tilePositionYPrecise));
            }
            else
            {
                tileOffsetY = 0;
            }

            inputHandler.setCurrentMapScreenOrigin(tileOffsetX, tileOffsetY, tilePositionXPrecise,
                tilePositionYPrecise, horizontalScrollBar.Value, verticalScrollBar.Value, tilesPerScreenX, tilesPerScreenY);

            //when the user clicks down, we need to tell the input handler that something happened
            if (mouseClickHappened == true)
            {
                inputHandler.processMousePosition(mainLayer, horizontalScrollBar.Value, verticalScrollBar.Value, true);
                mouseClickHappened = false;
            }
            else
            {
                inputHandler.processMousePosition(mainLayer, horizontalScrollBar.Value, verticalScrollBar.Value, false);
            }
        }

        /// <summary>
        /// display a tiled map grid based on a related collection
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sourceImage"></param>
        public void displayTiledMap(PaintEventArgs e, Image sourceImage)
        {
            calculatePositioning();

            Graphics g = e.Graphics;

            //set up an array that will allow us to display colored overlays over tiles that are set to collidable == true
            bool[,] collisionTiles = new bool[mainLayer.MapSizeWidth, mainLayer.MapSizeHeight];
            for (int x = 0; x < mainLayer.MapSizeWidth; x++)
            {
                for (int y = 0; y < mainLayer.MapSizeHeight; y++)
                {
                    collisionTiles[x, y] = false;
                }
            }

            //set up an array that will allow us to display colored overlays over tiles that have extra properties
            bool[,] extraPropertiesTiles = new bool[mainLayer.MapSizeWidth, mainLayer.MapSizeHeight];
            for (int x = 0; x < mainLayer.MapSizeWidth; x++)
            {
                for (int y = 0; y < mainLayer.MapSizeHeight; y++)
                {
                    extraPropertiesTiles[x, y] = false;
                }
            }

            //see if this is a multi-layer map
            if (mainLayerMultiple == null)
            {
                //draw a single layer
                for (int x = 0; x < tilesPerScreenX; x++)
                {
                    for (int y = 0; y < tilesPerScreenY; y++)
                    {
                        Point sourceTilePosition = mainLayer.items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].tileSetPosition;

                        g.DrawImage(sourceImage,
                            new Rectangle(x * mainLayer.TileSize - tileOffsetX, y * mainLayer.TileSize - tileOffsetY, mainLayer.TileSize, mainLayer.TileSize),
                            new Rectangle(sourceTilePosition.X * mainLayer.TileSize, sourceTilePosition.Y * mainLayer.TileSize, mainLayer.TileSize, mainLayer.TileSize), 
                            GraphicsUnit.Pixel);

                        if (Globals.currentViewMode == Globals.ViewMode.Collision)
                        {
                            //save a list of tiles that have at least one layer with collision enabled (only visible layers)
                            if (mainLayer.items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].collidable == true)
                            {
                                collisionTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] = true;
                            }
                        }

                        if (Globals.currentViewMode == Globals.ViewMode.ExtraProperties)
                        {
                            if (mainLayer.items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].extraProperties.Count > 0)
                            {
                                extraPropertiesTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] = true;
                            }
                        }
                    }
                }
            }
            else
            {
                //draw all layers if they exist and are set as visible
                for (int layerCounter = 0; layerCounter < mainLayerMultiple.Count; layerCounter++)
                {
                    //only draw this layer if it is flagged as visible to the user
                    if (mainLayerMultiple[layerCounter].currentlyVisible == true)
                    {
                        for (int x = 0; x < tilesPerScreenX; x++)
                        {
                            for (int y = 0; y < tilesPerScreenY; y++)
                            {
                                Point sourceTilePosition = mainLayerMultiple[layerCounter].items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].tileSetPosition;

                                g.DrawImage(sourceImage,
                                    new Rectangle(x * mainLayerMultiple[layerCounter].TileSize - tileOffsetX, 
                                        y * mainLayerMultiple[layerCounter].TileSize - tileOffsetY, 
                                        mainLayerMultiple[layerCounter].TileSize, 
                                        mainLayerMultiple[layerCounter].TileSize),
                                    new Rectangle(sourceTilePosition.X * mainLayerMultiple[layerCounter].TileSize, 
                                        sourceTilePosition.Y * mainLayerMultiple[layerCounter].TileSize, 
                                        mainLayerMultiple[layerCounter].TileSize, 
                                        mainLayerMultiple[layerCounter].TileSize), 
                                        GraphicsUnit.Pixel);

                                if (Globals.currentViewMode == Globals.ViewMode.Collision)
                                {
                                    //save a list of tiles that have at least one layer with collision enabled (only visible layers)
                                    if (mainLayerMultiple[layerCounter].items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].collidable == true)
                                    {
                                        collisionTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] = true;
                                    }
                                }

                                if (Globals.currentViewMode == Globals.ViewMode.ExtraProperties)
                                {
                                    if (mainLayerMultiple[layerCounter].items[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise].extraProperties.Count > 0)
                                    {
                                        extraPropertiesTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //draw the colored overlay if the view mode is collision
            if (Globals.currentViewMode == Globals.ViewMode.Collision)
            {
                //translucent bright red overlay
                Brush brush = new SolidBrush(Color.FromArgb(180, 255, 0, 0));
                for (int x = 0; x < tilesPerScreenX; x++)
                {
                    for (int y = 0; y < tilesPerScreenY; y++)
                    {
                        if (collisionTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] == true)
                        {
                            g.FillRectangle(brush, new Rectangle(
                                x * mainLayer.TileSize - tileOffsetX,
                                y * mainLayer.TileSize - tileOffsetY,
                                mainLayer.TileSize,
                                mainLayer.TileSize));
                        }
                    }
                }
            }

            //draw the colored overlay if the view mode is extra properties
            if (Globals.currentViewMode == Globals.ViewMode.ExtraProperties)
            {
                Brush brush = new SolidBrush(Color.FromArgb(180, 50, 100, 255));
                for (int x = 0; x < tilesPerScreenX; x++)
                {
                    for (int y = 0; y < tilesPerScreenY; y++)
                    {
                        if (extraPropertiesTiles[x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise] == true)
                        {
                            g.FillRectangle(brush, new Rectangle(
                                x * mainLayer.TileSize - tileOffsetX,
                                y * mainLayer.TileSize - tileOffsetY,
                                mainLayer.TileSize,
                                mainLayer.TileSize));
                        }
                    }
                }
            }

        }

        /// <summary>
        /// display the tile based grid on the screen as a guide for the user
        /// </summary>
        /// <param name="e"></param>
        public void displayGrid(PaintEventArgs e)
        {
            calculatePositioning();

            Graphics g = e.Graphics;

            if (mainLayer.backgroundImage != null)
            {
                g.DrawImage(mainLayer.backgroundImage,
                    new Rectangle(0, 0, mainScreen.Right, mainScreen.Bottom),
                    new Rectangle(horizontalScrollBar.Value, verticalScrollBar.Value, mainScreen.Right, mainScreen.Bottom),
                    GraphicsUnit.Pixel);
            }

            for (int x = 0; x < tilesPerScreenX; x++)
            {
                for (int y = 0; y < tilesPerScreenY; y++)
                {
                    Point sourceDataPosition = new Point(x + (int)tilePositionXPrecise, y + (int)tilePositionYPrecise);

                    if(sourceDataPosition.X < mainLayer.MapSizeWidth && sourceDataPosition.Y < mainLayer.MapSizeHeight)
                    {
                        Point sourceTilePosition = mainLayer.items[sourceDataPosition.X, sourceDataPosition.Y].tileSetPosition;

                        g.DrawRectangle(System.Drawing.Pens.DarkGray, 
                            new Rectangle(x * mainLayer.TileSize - tileOffsetX, y * mainLayer.TileSize - tileOffsetY, mainLayer.TileSize, mainLayer.TileSize));
                    }
                }
            }

            inputHandler.drawMouseRect(mainLayer, g);
            inputHandler.drawSelectionRect(mainLayer, g);
        }
    }
}
