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
using System.IO;
using System.Windows.Forms;

namespace _2DTileEditor
{
    public partial class frmLoadTileSet : Form
    {
        public string dialogLocationString = "";
        public string dialogFilenameString = "";

        public frmLoadTileSet()
        {
            InitializeComponent();
        }

        private void bBrowseTileSet_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdDialogBoxTileSet.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                tbLocationTileset.Text = ofdDialogBoxTileSet.FileName;
                dialogFilenameString = ofdDialogBoxTileSet.SafeFileName;

                //attempt do display a preview of the image
                if (tbLocationTileset.Text.Equals(string.Empty) == false && File.Exists(tbLocationTileset.Text) == true)
                {
                    pbPreviewImage.Load(tbLocationTileset.Text);
                }
            }
            else
            {
                dialogFilenameString = "";
                dialogLocationString = "";
            }
        }

        private void bOkayTileSet_Click(object sender, EventArgs e)
        {
            if(tbLocationTileset.Text.Length > 0)
            {
                dialogLocationString = tbLocationTileset.Text; 
            }

            this.Close();
        }

        private void bCancelTileset_Click(object sender, EventArgs e)
        {
            dialogLocationString = "";
            this.Close();
        }

        private void frmLoadTileSet_Load(object sender, EventArgs e)
        {

        }
    }
}
