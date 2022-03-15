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
using System.Windows.Forms;

namespace _2DTileEditor
{
    class InputHandler
    {
        PictureBox mainScreen;
        LayerHandler mainLayer;

        Point currentMousePosition = new Point();
        Point currentMousePositionTiled = new Point(-1, -1); //true map position
        Point tileSelected = new Point(-1, -1);
        Point currentScrollbarPosition = new Point();

        Point currentTileOffset = new Point();
        PointF currentTilePosition = new PointF();

        Rectangle currentSelectionPosition = new Rectangle();
        Rectangle currentCursorPosition = new Rectangle();

        Size tilesPerScreen = new Size();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainScreenReference"></param>
        /// <param name="mainLayerReference"></param>
        public InputHandler(PictureBox mainScreenReference, LayerHandler mainLayerReference)
        {
            mainScreen = mainScreenReference;
            mainLayer = mainLayerReference;
        }

        /// <summary>
        /// gets the true map position of the last click on the display screen
        /// </summary>
        /// <returns></returns>
        public Point getMapSelectionPosition()
        {
            return tileSelected;
        }

        /// <summary>
        /// gets the true map position of the mouse on the display screen
        /// </summary>
        /// <returns></returns>
        public Point getMapPosition()
        {
            return currentMousePositionTiled;
        }

        /// <summary>
        /// this needs to be called in the mouse move of the given picturebox or other control that will be drawn on
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        public void saveMousePosition(int xPosition, int yPosition)
        {
            currentMousePosition.X = xPosition + currentTileOffset.X;
            currentMousePosition.Y = yPosition + currentTileOffset.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentLayer"></param>
        /// <param name="scrollPositionX"></param>
        /// <param name="scrollPositionY"></param>
        /// <param name="clickHappened"></param>
        public void processMousePosition(LayerHandler currentLayer, int scrollPositionX, int scrollPositionY, Boolean clickHappened)
        {
            int mouseX = scrollPositionX / currentLayer.TileSize + currentMousePosition.X / currentLayer.TileSize;
            int mouseY = scrollPositionY / currentLayer.TileSize + currentMousePosition.Y / currentLayer.TileSize;

            //see if the user clicked on the map
            if (clickHappened == true)
            {
                //don't let the user select something outside of the layer's total size
                if (mouseX < currentLayer.MapSizeWidth && mouseY < currentLayer.MapSizeHeight)
                {
                    //save the map position, taking into account the scrollbar positions
                    tileSelected.X = mouseX;
                    tileSelected.Y = mouseY;
                }
            }
            else
            {
                //don't let the user select something outside of the layer's total size
                if (mouseX < currentLayer.MapSizeWidth && mouseY < currentLayer.MapSizeHeight)
                {
                    currentMousePositionTiled.X = mouseX;
                    currentMousePositionTiled.Y = mouseY;
                }
                else
                {
                    currentMousePositionTiled.X = -1;
                    currentMousePositionTiled.Y = -1;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xTileOffsetPosition"></param>
        /// <param name="yTileOffsetPosition"></param>
        /// <param name="tilePositionXPrecise"></param>
        /// <param name="tilePositionYPrecise"></param>
        /// <param name="scrollPositionX"></param>
        /// <param name="scrollPositionY"></param>
        public void setCurrentMapScreenOrigin(int xTileOffsetPosition, int yTileOffsetPosition, 
        float tilePositionXPrecise, float tilePositionYPrecise, 
        int scrollPositionX, int scrollPositionY, int tilesPerScreenX, int tilesPerScreenY)
        {
            currentTileOffset.X = xTileOffsetPosition;
            currentTileOffset.Y = yTileOffsetPosition;
            currentTilePosition.X = tilePositionXPrecise;
            currentTilePosition.Y = tilePositionYPrecise;
            currentScrollbarPosition.X = scrollPositionX;
            currentScrollbarPosition.Y = scrollPositionY;
            tilesPerScreen.Width = tilesPerScreenX;
            tilesPerScreen.Height = tilesPerScreenY;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentLayer"></param>
        /// <param name="g"></param>
        public void drawSelectionRect(LayerHandler currentLayer, Graphics g)
        {
            int currentScrollOriginX = currentScrollbarPosition.X / currentLayer.TileSize;
            int currentScrollOriginY = currentScrollbarPosition.Y / currentLayer.TileSize;
            
            //only draw if the tile selected is currently visible on the screen
            if (tileSelected.X >= currentScrollOriginX && tileSelected.X <= currentScrollOriginX + tilesPerScreen.Width
            && tileSelected.Y >= currentScrollOriginY && tileSelected.Y <= currentScrollOriginY + tilesPerScreen.Height)
            {
                currentSelectionPosition.X = (int)((tileSelected.X - currentScrollOriginX) * currentLayer.TileSize - currentTileOffset.X);
                currentSelectionPosition.Y = (int)((tileSelected.Y - currentScrollOriginY) * currentLayer.TileSize - currentTileOffset.Y);
                currentSelectionPosition.Width = currentLayer.TileSize;
                currentSelectionPosition.Height = currentLayer.TileSize;
                g.DrawRectangle(System.Drawing.Pens.Blue, currentSelectionPosition);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentLayer"></param>
        /// <param name="g"></param>
        public void drawMouseRect(LayerHandler currentLayer, Graphics g)
        {
            float tileSelectedX = currentMousePosition.X / currentLayer.TileSize;
            float tileSelectedY = currentMousePosition.Y / currentLayer.TileSize;

            if (tileSelectedX < tilesPerScreen.Width && tileSelectedY < tilesPerScreen.Height
            && tileSelectedX < currentLayer.MapSizeWidth && tileSelectedY < currentLayer.MapSizeHeight)
            {
                currentCursorPosition.X = (int)(tileSelectedX * currentLayer.TileSize - currentTileOffset.X);
                currentCursorPosition.Y = (int)(tileSelectedY * currentLayer.TileSize - currentTileOffset.Y);
                currentCursorPosition.Width = currentLayer.TileSize;
                currentCursorPosition.Height = currentLayer.TileSize;
            }

            g.DrawRectangle(System.Drawing.Pens.Red, currentCursorPosition);
        }
    }
}
