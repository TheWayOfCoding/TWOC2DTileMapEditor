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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DTileEditor
{
    public partial class frmNewMap : Form
    {
        public frmNewMap()
        {
            InitializeComponent();
        }

        private void btnCancelNewMap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNewMapStart_Click(object sender, EventArgs e)
        {
            bool newMapProcessSuccessful = true;

            CurrentMapDetails.MapName = txtNewMapName.Text;

            if (nudMapWidth.Value > 0)
            {
                CurrentMapDetails.mapSize.Width = (int)nudMapWidth.Value;
            }
            else
            {
                newMapProcessSuccessful = false;
            }

            if (nudMapHeight.Value > 0)
            {
                CurrentMapDetails.mapSize.Height = (int)nudMapHeight.Value;
            }
            else
            {
                newMapProcessSuccessful = false;
            }


            if (nudMapTileSize.Value > 0)
            {
                CurrentMapDetails.TileSize = (int)nudMapTileSize.Value;
            }
            else
            {
                newMapProcessSuccessful = false;
            }

            if (newMapProcessSuccessful == true)
            {
                CurrentMapDetails.IsNewMap = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("There was an issue with your new map details.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openTileSetDialog.Filter = "PNG Files (.png)|*.png";
            openTileSetDialog.FilterIndex = 1;

            if (DialogResult.OK == openTileSetDialog.ShowDialog())
            {
                txtNewMapTilesetPath.Text = openTileSetDialog.FileName;
            }
        }

        private void frmNewMap_Load(object sender, EventArgs e)
        {

        }
    }
}
