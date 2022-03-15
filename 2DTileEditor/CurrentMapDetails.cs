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
    public static class CurrentMapDetails
    {
        static bool isNewMap = false;
        public static bool IsNewMap
        {
            get { return isNewMap; }
            set { isNewMap = value; }
        }

        static string mapName = "";
        public static string MapName
        {
            get { return mapName; }
            set { mapName = value; }
        }

        public static Size mapSize = new Size();

        static int tileSize = 0;
        public static int TileSize
        {
            get { return tileSize; }
            set { tileSize = value; }
        }

        static string tileSetBitmapFilename = "";
        public static string TileSetBitmapFilename
        {
            get { return tileSetBitmapFilename; }
            set { tileSetBitmapFilename = value; }
        }

        public static List<LayerHandler> mapLayers = new List<LayerHandler>();

        public static bool tileSetLoaded = false;

        public static Image tileSetImage = null;

        public static int tileSetImagePixelsWidth = 0;
        public static int tileSetImagePixelsHeight = 0;

        public static List<string> globalExtraProperties = new List<string>();
    }
}
