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
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DTileEditor
{
    public partial class frm2DTileEditor : Form
    {
        /// <summary>
        /// class-wide variables
        /// </summary>
        LayerHandler layerHandlerTiles;
        InputHandler inputHandler;
        InputHandler inputHandlerTileGrid;
        DrawGrid drawGrid;
        DrawGrid drawTileGrid;

        int currentMapLayerSelected = -1;
        bool extendedMouseClick = false;
        Point currentlySelectedTile = new Point(-1, -1);

        /// <summary>
        /// change the form controls related to the current view state
        /// </summary>
        private void updateViewControls()
        {
            switch (Globals.currentViewMode)
            {
                case Globals.ViewMode.Normal:
                    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Normal");
                    break;

                case Globals.ViewMode.Collision:
                    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Collision");
                    break;

                case Globals.ViewMode.ExtraProperties:
                    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Extra Properties");
                    break;

                    //case Globals.ViewMode.Object:
                    //    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Object");
                    //    break;

                    //case Globals.ViewMode.Floor:
                    //    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Floor");
                    //    break;

                    //case Globals.ViewMode.Play:
                    //    cbViewModeSelector.SelectedIndex = cbViewModeSelector.Items.IndexOf("Play");
                    //    break;
            }

        }

        /// <summary>
        /// set the global variable that stores the current view state
        /// </summary>
        private void assignViewSelection()
        {
            if (cbViewModeSelector.SelectedIndex > -1)
            {
                switch (cbViewModeSelector.Items[cbViewModeSelector.SelectedIndex].ToString())
                {
                    case "Normal":
                        Globals.currentViewMode = Globals.ViewMode.Normal;
                        break;

                    case "Collision":
                        Globals.currentViewMode = Globals.ViewMode.Collision;
                        break;

                    case "Extra Properties":
                        Globals.currentViewMode = Globals.ViewMode.ExtraProperties;
                        break;

                        //case "Object":
                        //    Globals.currentViewMode = Globals.ViewMode.Object;
                        //    break;

                        //case "Floor":
                        //    Globals.currentViewMode = Globals.ViewMode.Floor;
                        //    break;

                        //case "Play":
                        //    Globals.currentViewMode = Globals.ViewMode.Play;
                        //    break;
                }
            }
            else
            {
                Globals.currentViewMode = Globals.ViewMode.Normal;
            }
        }

        /// <summary>
        /// set the related windows controls to the current mouse control state
        /// </summary>
        private void updateMouseModeControls()
        {
            if (Globals.currentMouseMode == Globals.MouseMode.Selection)
            {
                pbMouseModeSelect.BorderStyle = BorderStyle.Fixed3D;
                pbMouseModeDraw.BorderStyle = BorderStyle.FixedSingle;
                pbMouseModeSelect.BackColor = SystemColors.Highlight;
                pbMouseModeDraw.BackColor = SystemColors.Control;
            }
            else
            {
                pbMouseModeSelect.BorderStyle = BorderStyle.FixedSingle;
                pbMouseModeDraw.BorderStyle = BorderStyle.Fixed3D;
                pbMouseModeSelect.BackColor = SystemColors.Control;
                pbMouseModeDraw.BackColor = SystemColors.Highlight;
            }
        }

        /// <summary>
        /// deal with mouse movement and clicks
        /// </summary>
        /// <param name="mousePosition"></param>
        private void processMouseActions(int mousePositionX, int mousePositionY, bool inMovement, MouseButtons buttonPressed)
        {
            inputHandler.saveMousePosition(mousePositionX, mousePositionY);
            drawGrid.calculatePositioning();

            Point selectionPointMainMap = new Point(-1, -1);

            if (inMovement == true)
            {
                selectionPointMainMap = inputHandler.getMapPosition();
            }
            else
            {
                selectionPointMainMap = inputHandler.getMapSelectionPosition();
            }

            if (extendedMouseClick == true && selectionPointMainMap.X > -1 && selectionPointMainMap.Y > -1 && currentMapLayerSelected > -1)
            {
                switch (Globals.currentMouseMode)
                {
                    case Globals.MouseMode.Drawing:
                        //assign a tile if possible
                        if (CurrentMapDetails.tileSetLoaded == true)
                        {
                            Point selectionPointTileSet = inputHandlerTileGrid.getMapSelectionPosition();
                            if (selectionPointTileSet.X > -1 && selectionPointTileSet.Y > -1)
                            {
                                switch (buttonPressed)
                                {
                                    //assign the selected tile or collision state
                                    case System.Windows.Forms.MouseButtons.Left:
                                        switch (Globals.currentViewMode)
                                        {
                                            case Globals.ViewMode.Normal:
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                   .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                   .tileSetPosition.X = selectionPointTileSet.X;
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                    .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                    .tileSetPosition.Y = selectionPointTileSet.Y;
                                                break;

                                            case Globals.ViewMode.Collision:
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                    .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                    .collidable = true;
                                                break;
                                        }
                                        break;

                                    //clear out the map tile or collision state
                                    case System.Windows.Forms.MouseButtons.Right:
                                        switch (Globals.currentViewMode)
                                        {
                                            case Globals.ViewMode.Normal:
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                   .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                   .tileSetPosition.X = -1;
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                    .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                    .tileSetPosition.Y = -1;
                                                break;

                                            case Globals.ViewMode.Collision:
                                                CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                    .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                    .collidable = false;
                                                break;
                                        }
                                        break;
                                }
                            }
                            else //no tile was selected, but there are other cases that can happen that need action
                            {
                                switch (buttonPressed)
                                {
                                    //assign the selected tile or collision state
                                    case System.Windows.Forms.MouseButtons.Left:
                                        if (Globals.currentViewMode == Globals.ViewMode.Collision)
                                        {
                                            CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                .collidable = true;
                                        }
                                        break;

                                    //clear out the map tile or collision state
                                    case System.Windows.Forms.MouseButtons.Right:
                                        if (Globals.currentViewMode == Globals.ViewMode.Collision)
                                        {
                                            CurrentMapDetails.mapLayers[currentMapLayerSelected]
                                                .items[selectionPointMainMap.X, selectionPointMainMap.Y]
                                                .collidable = false;
                                        }
                                        break;
                                }
                            }
                        }

                        updateSelectionPropertiesControls(selectionPointMainMap);
                        break;

                    case Globals.MouseMode.Selection:
                        //set the selection (properties section)
                        updateSelectionPropertiesControls(selectionPointMainMap);
                        break;
                }
            }

            pbMainSurface.Refresh();
        }

        /// <summary>
        /// refresh the properties container controls with values from the selected tile/layer
        /// </summary>
        /// <param name="selectionPosition"></param>
        private void updateSelectionPropertiesControls(Point selectionPosition)
        {
            if (selectionPosition.X > -1 && selectionPosition.Y > -1 && currentMapLayerSelected > -1)
            {
                LayerHandler.LayerItem extractedLayerItemDetails = CurrentMapDetails.mapLayers[currentMapLayerSelected].items[selectionPosition.X, selectionPosition.Y];

                //assign the variable that tracks selection so that properties can be saved
                currentlySelectedTile.X = selectionPosition.X;
                currentlySelectedTile.Y = selectionPosition.Y;

                //set the position value
                lblSelectionPosition.Text = (selectionPosition.X + 1).ToString() + " x " + (selectionPosition.Y + 1).ToString();

                //set the collidable state
                if (extractedLayerItemDetails.collidable == true)
                {
                    cbCollidableState.SelectedIndex = 0;
                }
                else
                {
                    cbCollidableState.SelectedIndex = 1;
                }

                //fill the extras list if needed
                lbPropertiesExtrasList.Items.Clear();
                if (extractedLayerItemDetails.extraProperties.Count > 0)
                {
                    lbPropertiesExtrasList.Items.AddRange(extractedLayerItemDetails.extraProperties.ToArray());
                }
            }
        }

        /// <summary>
        /// a simple function to fill the window's layer listings
        /// </summary>
        private void fillLayerLists()
        {
            clbLayerList.SelectedIndex = -1;
            cbLayerListTop.SelectedIndex = -1;
            clbLayerList.Items.Clear();
            cbLayerListTop.Items.Clear();
            for (int i = 0; i < CurrentMapDetails.mapLayers.Count; i++)
            {
                clbLayerList.Items.Add(i.ToString());
                clbLayerList.SetItemCheckState(i, CheckState.Checked);
                cbLayerListTop.Items.Add(i.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void initializeDefaultMap()
        {
            CurrentMapDetails.TileSize = 32;
            CurrentMapDetails.mapSize.Width = 25;
            CurrentMapDetails.mapSize.Height = 25;

            //initialize the map input handler with needed references
            CurrentMapDetails.mapLayers.Add(new LayerHandler(CurrentMapDetails.TileSize, CurrentMapDetails.mapSize.Width, CurrentMapDetails.mapSize.Height));

            inputHandler = new InputHandler(pbMainSurface, CurrentMapDetails.mapLayers[0]);

            drawGrid = new DrawGrid(pbMainSurface, CurrentMapDetails.mapLayers, sbMapHorizontalLocation, sbMapVerticalLocation, inputHandler);

            layerHandlerTiles = new LayerHandler(CurrentMapDetails.TileSize, 1, 1);
            inputHandlerTileGrid = new InputHandler(pbTileSet, layerHandlerTiles);
            drawTileGrid = new DrawGrid(pbTileSet, layerHandlerTiles, sbTileHorizontalLocation, sbTileVerticalLocation, inputHandlerTileGrid);

            updateMapPropertiesControls(false);

            //set the default layer to being selected
            cbLayerListTop.SelectedIndex = 0;
        }

        /// <summary>
        /// change the properties of the current map based on user inputs
        /// </summary>
        private void updateMapPropertiesControls(bool saveFormInputs)
        {
            if (saveFormInputs == true)
            {
                CurrentMapDetails.MapName = txtMapName.Text;

                //adjust the tile size if needed
                if (CurrentMapDetails.TileSize != (int)nudMapTileSize.Value)
                {
                    CurrentMapDetails.TileSize = (int)nudMapTileSize.Value;
                    layerHandlerTiles.TileSize = CurrentMapDetails.TileSize;

                    drawTileGrid.MainLayer = layerHandlerTiles;

                    for (int i = 0; i < CurrentMapDetails.mapLayers.Count; i++)
                    {
                        CurrentMapDetails.mapLayers[i].TileSize = CurrentMapDetails.TileSize;
                    }
                }

                //adjust the map size if needed
                if (CurrentMapDetails.mapSize.Width != (int)nudMapWidth.Value ||
                CurrentMapDetails.mapSize.Height != (int)nudMapHeight.Value)
                {
                    CurrentMapDetails.mapSize.Width = (int)nudMapWidth.Value;
                    CurrentMapDetails.mapSize.Height = (int)nudMapHeight.Value;

                    for (int i = 0; i < CurrentMapDetails.mapLayers.Count; i++)
                    {
                        CurrentMapDetails.mapLayers[i].resizeLayerItemArray(CurrentMapDetails.mapSize.Width, CurrentMapDetails.mapSize.Height);
                    }
                }
            }
            else //update the form controls with current values
            {
                txtMapName.Text = CurrentMapDetails.MapName;

                nudMapWidth.Value = CurrentMapDetails.mapSize.Width;
                nudMapHeight.Value = CurrentMapDetails.mapSize.Height;

                nudMapTileSize.Value = CurrentMapDetails.TileSize;

                fillLayerLists();
            }

            pbMainSurface.Refresh();
            pbTileSet.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        public frm2DTileEditor()
        {
            InitializeComponent();

            pbMainSurface.MouseWheel += new MouseEventHandler(pbMainSurface_MouseWheel);
            pbMainSurface.MouseHover += new EventHandler(pbMainSurface_MouseHover);
        }

        void pbMainSurface_MouseHover(object sender, EventArgs e)
        {
            pbMainSurface.Focus();
        }

        void pbMainSurface_MouseWheel(object sender, MouseEventArgs e)
        {
            //if the user pressed a button down, scroll the horizontal scrollbar
            if (extendedMouseClick == true)
            {
                if (e.Delta < 0)
                {
                    if (sbMapHorizontalLocation.Maximum >= sbMapHorizontalLocation.Value + sbMapHorizontalLocation.LargeChange)
                    {
                        sbMapHorizontalLocation.Value += sbMapHorizontalLocation.LargeChange;
                    }
                    else
                    {
                        sbMapHorizontalLocation.Value = sbMapHorizontalLocation.Maximum;
                    }
                }
                else if (e.Delta > 0)
                {
                    if (sbMapHorizontalLocation.Value - sbMapHorizontalLocation.LargeChange >= 0)
                    {
                        sbMapHorizontalLocation.Value -= sbMapHorizontalLocation.LargeChange;
                    }
                    else
                    {
                        sbMapHorizontalLocation.Value = 0;
                    }
                }
            }
            else //vertical scroll bar
            {
                if (e.Delta < 0)
                {
                    if (sbMapVerticalLocation.Maximum >= sbMapVerticalLocation.Value + sbMapVerticalLocation.LargeChange)
                    {
                        sbMapVerticalLocation.Value += sbMapVerticalLocation.LargeChange;
                    }
                    else
                    {
                        sbMapVerticalLocation.Value = sbMapVerticalLocation.Maximum;
                    }
                }
                else if (e.Delta > 0)
                {
                    if (sbMapVerticalLocation.Value - sbMapVerticalLocation.LargeChange >= 0)
                    {
                        sbMapVerticalLocation.Value -= sbMapVerticalLocation.LargeChange;
                    }
                    else
                    {
                        sbMapVerticalLocation.Value = 0;
                    }
                }
            }



            pbMainSurface.Refresh();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMainSurface_Paint(object sender, PaintEventArgs e)
        {
            if (CurrentMapDetails.tileSetImage != null)
            {
                drawGrid.displayTiledMap(e, CurrentMapDetails.tileSetImage);
            }

            if (drawGrid != null)
            {
                drawGrid.displayGrid(e);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewMap newMapForm = new frmNewMap();
            
            newMapForm.ShowDialog();

            if (CurrentMapDetails.IsNewMap == true)
            {
                CurrentMapDetails.mapLayers.Clear();
                CurrentMapDetails.globalExtraProperties.Clear();

                //initialize the map input handler with needed references
                CurrentMapDetails.mapLayers.Add(new LayerHandler(CurrentMapDetails.TileSize, CurrentMapDetails.mapSize.Width, CurrentMapDetails.mapSize.Height));
                inputHandler = new InputHandler(pbMainSurface, CurrentMapDetails.mapLayers[0]);
                drawGrid = new DrawGrid(pbMainSurface, CurrentMapDetails.mapLayers, sbMapHorizontalLocation, sbMapVerticalLocation, inputHandler);

                layerHandlerTiles = new LayerHandler(CurrentMapDetails.TileSize, 1, 1);
                inputHandlerTileGrid = new InputHandler(pbTileSet, layerHandlerTiles);
                drawTileGrid = new DrawGrid(pbTileSet, layerHandlerTiles, sbTileHorizontalLocation, sbTileVerticalLocation, inputHandlerTileGrid);

                updateMapPropertiesControls(false);

                //cbLayerListTop.SelectedIndex = 0;
                clbLayerList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm2DTileEditor_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format("TWOC 2D Tile Map Editor v{0}.{1}.{2}, R{3}",
                version.Major, version.Minor, version.Build, version.Revision);

            initializeDefaultMap();

            Globals.currentMouseMode = Globals.MouseMode.Selection;
            updateMouseModeControls();

            Globals.currentViewMode = Globals.ViewMode.Normal;
            updateViewControls();

            lblSelectionPosition.Text = "";

            pbMainSurface.Refresh();
        }

        private void sbMapVerticalLocation_Scroll(object sender, ScrollEventArgs e)
        {
            pbMainSurface.Refresh();
        }

        private void sbMapHorizontalLocation_Scroll(object sender, ScrollEventArgs e)
        {
            pbMainSurface.Refresh();
        }

        private void pbMainSurface_MouseMove(object sender, MouseEventArgs e)
        {
            processMouseActions(e.X, e.Y, true, e.Button);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTileLoad_Click(object sender, EventArgs e)
        {
            frmLoadTileSet newLoadTileset = new frmLoadTileSet();

            newLoadTileset.ShowDialog();

            if (newLoadTileset.dialogLocationString != null && newLoadTileset.dialogLocationString.Length > 0)
            {
                layerHandlerTiles = new LayerHandler(CurrentMapDetails.TileSize, newLoadTileset.dialogLocationString);

                drawTileGrid.MainLayer = layerHandlerTiles; //refresh the grid drawing system to handle the new size

                CurrentMapDetails.TileSetBitmapFilename = newLoadTileset.dialogFilenameString;

                CurrentMapDetails.tileSetImage = new Bitmap(newLoadTileset.dialogLocationString);

                CurrentMapDetails.tileSetImagePixelsWidth = CurrentMapDetails.tileSetImage.Width;
                CurrentMapDetails.tileSetImagePixelsHeight = CurrentMapDetails.tileSetImage.Height;

                CurrentMapDetails.tileSetLoaded = true;

                pbTileSet.Refresh();
            }
        }

        private void pbTileSet_Paint(object sender, PaintEventArgs e)
        {
            if (CurrentMapDetails.tileSetLoaded == true)
            {
                drawTileGrid.displayGrid(e);
            }
        }

        private void sbTileVerticalLocation_Scroll(object sender, ScrollEventArgs e)
        {
            pbTileSet.Refresh();
        }

        private void sbTileHorizontalLocation_Scroll(object sender, ScrollEventArgs e)
        {
            pbTileSet.Refresh();
        }

        private void pbTileSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (inputHandlerTileGrid != null)
            {
                inputHandlerTileGrid.saveMousePosition(e.X, e.Y);
                drawTileGrid.MouseClickHappened = false;
                pbTileSet.Refresh();
            }
        }

        private void pbTileSet_MouseClick(object sender, MouseEventArgs e)
        {
            inputHandlerTileGrid.saveMousePosition(e.X, e.Y);
            drawTileGrid.MouseClickHappened = true;
            pbTileSet.Refresh();
        }

        private void frm2DTileEditor_Resize(object sender, EventArgs e)
        {
            if (drawGrid != null)
            {
                drawGrid.calculatePositioning();
                pbMainSurface.Refresh();
            }

            if (drawTileGrid != null)
            {
                drawTileGrid.calculatePositioning();
                pbTileSet.Refresh();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            if (drawGrid != null)
            {
                drawGrid.calculatePositioning();
                pbMainSurface.Refresh();
            }

            if (drawTileGrid != null)
            {
                drawTileGrid.calculatePositioning();
                pbTileSet.Refresh();
            }
        }

        private void btnUpdateMapProperties_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefreshMapProperties_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMapName_TextChanged(object sender, EventArgs e)
        {
            //updateMapPropertiesControls(true);
        }

        private void nudMapWidth_ValueChanged(object sender, EventArgs e)
        {
            //updateMapPropertiesControls(true);
        }

        private void nudMapHeight_ValueChanged(object sender, EventArgs e)
        {
            //updateMapPropertiesControls(true);
        }

        private void nudMapTileSize_ValueChanged(object sender, EventArgs e)
        {
            //updateMapPropertiesControls(true);
        }

        private void btnAddMapLayer_Click(object sender, EventArgs e)
        {
            //see if the user wants it inserted or added to the bottom of the list
            if (clbLayerList.SelectedIndex > -1 && clbLayerList.SelectedIndex < clbLayerList.Items.Count - 1)
            {
                CurrentMapDetails.mapLayers.Insert(clbLayerList.SelectedIndex, 
                    new LayerHandler(CurrentMapDetails.TileSize, CurrentMapDetails.mapSize.Width, CurrentMapDetails.mapSize.Height));
            }
            else //add an item to the end of the list because nothing is selected
            {
                CurrentMapDetails.mapLayers.Add(new LayerHandler(CurrentMapDetails.TileSize, CurrentMapDetails.mapSize.Width, CurrentMapDetails.mapSize.Height));
            }

            currentMapLayerSelected = -1;

            fillLayerLists();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllLayersVisible_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLayerList.Items.Count; i++)
            {
                clbLayerList.SetItemChecked(i, true);
            }

            pbMainSurface.Refresh();
        }

        private void btnRemoveMapLayer_Click(object sender, EventArgs e)
        {
            if (clbLayerList.SelectedIndex > -1)
            {
                if (CurrentMapDetails.mapLayers.Count > 1)
                {
                    CurrentMapDetails.mapLayers.RemoveAt(clbLayerList.SelectedIndex);

                    currentMapLayerSelected = -1;

                    fillLayerLists();

                    pbMainSurface.Refresh();
                }
            }
        }

        private void pbMainSurface_Click(object sender, EventArgs e)
        {

        }

        private void clbLayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbLayerList.SelectedIndex > -1)
            {
                if (clbLayerList.Items.Count > cbLayerListTop.SelectedIndex)
                {
                    cbLayerListTop.SelectedIndex = clbLayerList.SelectedIndex;
                }
                currentMapLayerSelected = clbLayerList.SelectedIndex;

                //attempt to refresh the selected tile properties because the user might have changed layers
                Point currentSelection = inputHandler.getMapSelectionPosition();
                if (currentSelection.X > -1 && currentSelection.Y > -1)
                {
                    updateSelectionPropertiesControls(currentSelection);
                }
            }
        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if (drawTileGrid != null)
            {
                drawTileGrid.calculatePositioning();
                pbTileSet.Refresh();
            }
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            if (drawGrid != null)
            {
                drawGrid.calculatePositioning();
                pbMainSurface.Refresh();
            }

            if (drawTileGrid != null)
            {
                drawTileGrid.calculatePositioning();
                pbTileSet.Refresh();
            }
        }

        private void cbLayerListTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLayerListTop.SelectedIndex > -1)
            {
                if (clbLayerList.Items.Count > cbLayerListTop.SelectedIndex)
                {
                    clbLayerList.SelectedIndex = cbLayerListTop.SelectedIndex;
                }
                currentMapLayerSelected = clbLayerList.SelectedIndex;
            }
        }

        private void pbMainSurface_MouseDown(object sender, MouseEventArgs e)
        {
            drawGrid.MouseClickHappened = true;
            extendedMouseClick = true;
            processMouseActions(e.X, e.Y, false, e.Button);
        }

        private void pbMainSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawGrid.MouseClickHappened = true;
            processMouseActions(e.X, e.Y, false, e.Button);
            extendedMouseClick = false;
        }

        private void clbLayerList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked) 
            {
                CurrentMapDetails.mapLayers[e.Index].currentlyVisible = true;
            }
            else
            {
                CurrentMapDetails.mapLayers[e.Index].currentlyVisible = false;
            }

            pbMainSurface.Refresh();
        }

        private void cbCollidableState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentlySelectedTile.X > -1 && currentlySelectedTile.Y > -1 && currentMapLayerSelected > -1)
            {
                //0 = yes
                if(cbCollidableState.SelectedIndex == 0)
                {
                    CurrentMapDetails.mapLayers[currentMapLayerSelected].items[currentlySelectedTile.X, currentlySelectedTile.Y].collidable = true;
                }
                else
                {
                    CurrentMapDetails.mapLayers[currentMapLayerSelected].items[currentlySelectedTile.X, currentlySelectedTile.Y].collidable = false;
                }

                pbMainSurface.Refresh();
            }
        }

        private void pbMouseModeSelect_Click(object sender, EventArgs e)
        {
            Globals.currentMouseMode = Globals.MouseMode.Selection;
            updateMouseModeControls();
        }

        private void pbMouseModeDraw_Click(object sender, EventArgs e)
        {
            Globals.currentMouseMode = Globals.MouseMode.Drawing;
            updateMouseModeControls();

        }

        private void cbViewModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignViewSelection();
            pbMainSurface.Refresh();
        }

        private void btnSaveMapProperties_Click(object sender, EventArgs e)
        {
            updateMapPropertiesControls(true);
            pbMainSurface.Refresh();
        }

        private void btnCancelMapPropertyChanges_Click(object sender, EventArgs e)
        {
            updateMapPropertiesControls(false);
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveResult = sfdSaveMap.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                SaveLoadMapFile.saveMap(sfdSaveMap.FileName);
            }
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult loadResult = ofdOpenMap.ShowDialog();
            if (loadResult == DialogResult.OK)
            {
                SaveLoadMapFile.loadMap(ofdOpenMap.FileName);

                inputHandler = new InputHandler(pbMainSurface, CurrentMapDetails.mapLayers[0]);
                drawGrid = new DrawGrid(pbMainSurface, CurrentMapDetails.mapLayers, sbMapHorizontalLocation, sbMapVerticalLocation, inputHandler);

                string fileNameAndPath = Path.Combine(Globals.sourceImagePath, CurrentMapDetails.TileSetBitmapFilename);
                if (File.Exists(fileNameAndPath) == true)
                {
                    layerHandlerTiles = new LayerHandler(CurrentMapDetails.TileSize, fileNameAndPath);
                }
                
                inputHandlerTileGrid = new InputHandler(pbTileSet, layerHandlerTiles);
                drawTileGrid = new DrawGrid(pbTileSet, layerHandlerTiles, sbTileHorizontalLocation, sbTileVerticalLocation, inputHandlerTileGrid);
                drawTileGrid.MainLayer = layerHandlerTiles; //refresh the grid drawing system to handle the new size

                updateMapPropertiesControls(false);
                currentMapLayerSelected = 0;
                cbLayerListTop.SelectedIndex = 0;

                lbGEPropertyList.Items.Clear();
                if(CurrentMapDetails.globalExtraProperties.Count > 0)
                {
                    lbGEPropertyList.Items.AddRange(CurrentMapDetails.globalExtraProperties.ToArray<string>());
                }

                pbMainSurface.Refresh();
                pbTileSet.Refresh();
            }
        }

        private void btnPropertiesExtraAdd_Click(object sender, EventArgs e)
        {
            if (currentlySelectedTile.X > -1 && currentlySelectedTile.Y > -1 && currentMapLayerSelected > -1)
            {
                List<string> currentSelection = CurrentMapDetails.mapLayers[currentMapLayerSelected].items[currentlySelectedTile.X, currentlySelectedTile.Y].extraProperties;

                string cleanedAddition = txtPropertiesExtraAddText.Text.Trim().Replace(",", ""); 

                txtPropertiesExtraAddText.Text = cleanedAddition;

                if (cleanedAddition.Equals(String.Empty) == false && currentSelection.Contains(cleanedAddition) == false)
                {
                    currentSelection.Add(cleanedAddition);

                    lbPropertiesExtrasList.Items.Clear();
                    lbPropertiesExtrasList.Items.AddRange(currentSelection.ToArray<string>());

                    txtPropertiesExtraAddText.Text = "";

                    pbMainSurface.Refresh();
                }
            }
        }

        private void btnPropertiesExtraRemove_Click(object sender, EventArgs e)
        {
            if (currentlySelectedTile.X > -1 && currentlySelectedTile.Y > -1 && currentMapLayerSelected > -1)
            {
                if (lbPropertiesExtrasList.SelectedIndex >= 0)
                {
                    CurrentMapDetails.mapLayers[currentMapLayerSelected]
                        .items[currentlySelectedTile.X, currentlySelectedTile.Y]
                        .extraProperties.Remove(lbPropertiesExtrasList.Items[lbPropertiesExtrasList.SelectedIndex].ToString());

                    lbPropertiesExtrasList.ClearSelected();
                    lbPropertiesExtrasList.Items.Clear();
                    lbPropertiesExtrasList.Items.AddRange(CurrentMapDetails.mapLayers[currentMapLayerSelected]
                        .items[currentlySelectedTile.X, currentlySelectedTile.Y]
                        .extraProperties.ToArray());

                    pbMainSurface.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cleanedAddition = txtGENewText.Text.Trim().Replace(",", "");

            txtGENewText.Text = cleanedAddition;

            if (cleanedAddition.Equals(String.Empty) == false)
            {
                CurrentMapDetails.globalExtraProperties.Add(cleanedAddition);

                lbGEPropertyList.Items.Clear();
                lbGEPropertyList.Items.AddRange(CurrentMapDetails.globalExtraProperties.ToArray<string>());

                txtGENewText.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbGEPropertyList.SelectedIndex >= 0)
            {
                CurrentMapDetails.globalExtraProperties.Remove(lbGEPropertyList.Items[lbGEPropertyList.SelectedIndex].ToString());
                lbGEPropertyList.ClearSelected();
                lbGEPropertyList.Items.Clear();
                lbGEPropertyList.Items.AddRange(CurrentMapDetails.globalExtraProperties.ToArray());
            }
        }

        private void btnGlobalExtrasCopySelection_Click(object sender, EventArgs e)
        {
            if (lbGEPropertyList.SelectedIndex >= 0)
            {
                System.Windows.Forms.Clipboard.SetText(lbGEPropertyList.Items[lbGEPropertyList.SelectedIndex].ToString());
            }
        }

        private void btnCopySelectedTilePropertiesToClipboard_Click(object sender, EventArgs e)
        {
            if (lbPropertiesExtrasList.SelectedIndex >= 0)
            {
                System.Windows.Forms.Clipboard.SetText(lbPropertiesExtrasList.Items[lbPropertiesExtrasList.SelectedIndex].ToString());
            }
        }

        private void pbMainSurface_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAbout()).ShowDialog();
        }
    }
}
