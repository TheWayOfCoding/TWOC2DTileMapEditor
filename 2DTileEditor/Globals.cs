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

namespace _2DTileEditor
{
    public static class Globals
    {
        /// <summary>
        /// 
        /// </summary>
        public enum MouseMode
        {
            Selection,
            Drawing
        }

        /// <summary>
        /// 
        /// </summary>
        public enum ViewMode
        {
            Normal,
            Collision,
            ExtraProperties
            //Object,
            //Floor,
            //Play
        }

        public static MouseMode currentMouseMode = Globals.MouseMode.Selection;
        public static ViewMode currentViewMode = Globals.ViewMode.Normal;

        public static string sourceImagePath = AppDomain.CurrentDomain.BaseDirectory;
    }
}
