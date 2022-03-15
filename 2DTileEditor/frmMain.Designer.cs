namespace _2DTileEditor
{
    partial class frm2DTileEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMapMainDetails = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.clbLayerList = new System.Windows.Forms.CheckedListBox();
            this.btnAllLayersVisible = new System.Windows.Forms.Button();
            this.btnRemoveMapLayer = new System.Windows.Forms.Button();
            this.btnAddMapLayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelMapPropertyChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveMapProperties = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.nudMapTileSize = new System.Windows.Forms.NumericUpDown();
            this.nudMapWidth = new System.Windows.Forms.NumericUpDown();
            this.nudMapHeight = new System.Windows.Forms.NumericUpDown();
            this.tabMapProperties = new System.Windows.Forms.TabPage();
            this.btnGlobalExtrasCopySelection = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbGEPropertyList = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGENewText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabTiles = new System.Windows.Forms.TabPage();
            this.bTileLoad = new System.Windows.Forms.Button();
            this.sbTileHorizontalLocation = new System.Windows.Forms.HScrollBar();
            this.sbTileVerticalLocation = new System.Windows.Forms.VScrollBar();
            this.pbTileSet = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopySelectedTilePropertiesToClipboard = new System.Windows.Forms.Button();
            this.lbPropertiesExtrasList = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPropertiesExtraAddText = new System.Windows.Forms.TextBox();
            this.btnPropertiesExtraRemove = new System.Windows.Forms.Button();
            this.btnPropertiesExtraAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSelectionPosition = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCollidableState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbMouseModeSelect = new System.Windows.Forms.PictureBox();
            this.pbMouseModeDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLayerListTop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbViewModeSelector = new System.Windows.Forms.ComboBox();
            this.sbMapVerticalLocation = new System.Windows.Forms.VScrollBar();
            this.sbMapHorizontalLocation = new System.Windows.Forms.HScrollBar();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbMainSurface = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ofdOpenMap = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveMap = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabMapMainDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapTileSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).BeginInit();
            this.tabMapProperties.SuspendLayout();
            this.tabTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTileSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouseModeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouseModeDraw)).BeginInit();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMapMainDetails);
            this.tabControl1.Controls.Add(this.tabMapProperties);
            this.tabControl1.Controls.Add(this.tabTiles);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 325);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMapMainDetails
            // 
            this.tabMapMainDetails.Controls.Add(this.panel2);
            this.tabMapMainDetails.Controls.Add(this.panel1);
            this.tabMapMainDetails.Location = new System.Drawing.Point(4, 22);
            this.tabMapMainDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tabMapMainDetails.Name = "tabMapMainDetails";
            this.tabMapMainDetails.Size = new System.Drawing.Size(340, 299);
            this.tabMapMainDetails.TabIndex = 2;
            this.tabMapMainDetails.Text = "Map Main Details";
            this.tabMapMainDetails.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clbLayerList);
            this.panel2.Controls.Add(this.btnAllLayersVisible);
            this.panel2.Controls.Add(this.btnRemoveMapLayer);
            this.panel2.Controls.Add(this.btnAddMapLayer);
            this.panel2.Location = new System.Drawing.Point(3, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 161);
            this.panel2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Layers (from the bottom):";
            // 
            // clbLayerList
            // 
            this.clbLayerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clbLayerList.FormattingEnabled = true;
            this.clbLayerList.Location = new System.Drawing.Point(7, 25);
            this.clbLayerList.Name = "clbLayerList";
            this.clbLayerList.ScrollAlwaysVisible = true;
            this.clbLayerList.Size = new System.Drawing.Size(120, 109);
            this.clbLayerList.TabIndex = 24;
            this.clbLayerList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLayerList_ItemCheck);
            this.clbLayerList.SelectedIndexChanged += new System.EventHandler(this.clbLayerList_SelectedIndexChanged);
            // 
            // btnAllLayersVisible
            // 
            this.btnAllLayersVisible.Location = new System.Drawing.Point(133, 25);
            this.btnAllLayersVisible.Name = "btnAllLayersVisible";
            this.btnAllLayersVisible.Size = new System.Drawing.Size(118, 22);
            this.btnAllLayersVisible.TabIndex = 25;
            this.btnAllLayersVisible.Text = "Make All Visible";
            this.btnAllLayersVisible.UseVisualStyleBackColor = true;
            this.btnAllLayersVisible.Click += new System.EventHandler(this.btnAllLayersVisible_Click);
            // 
            // btnRemoveMapLayer
            // 
            this.btnRemoveMapLayer.Location = new System.Drawing.Point(133, 82);
            this.btnRemoveMapLayer.Name = "btnRemoveMapLayer";
            this.btnRemoveMapLayer.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveMapLayer.TabIndex = 20;
            this.btnRemoveMapLayer.Text = "- Remove Layer";
            this.btnRemoveMapLayer.UseVisualStyleBackColor = true;
            this.btnRemoveMapLayer.Click += new System.EventHandler(this.btnRemoveMapLayer_Click);
            // 
            // btnAddMapLayer
            // 
            this.btnAddMapLayer.Location = new System.Drawing.Point(133, 53);
            this.btnAddMapLayer.Name = "btnAddMapLayer";
            this.btnAddMapLayer.Size = new System.Drawing.Size(118, 23);
            this.btnAddMapLayer.TabIndex = 19;
            this.btnAddMapLayer.Text = "+ Add Layer";
            this.btnAddMapLayer.UseVisualStyleBackColor = true;
            this.btnAddMapLayer.Click += new System.EventHandler(this.btnAddMapLayer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancelMapPropertyChanges);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSaveMapProperties);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMapName);
            this.panel1.Controls.Add(this.nudMapTileSize);
            this.panel1.Controls.Add(this.nudMapWidth);
            this.panel1.Controls.Add(this.nudMapHeight);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 123);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tile Size (Pixels):";
            // 
            // btnCancelMapPropertyChanges
            // 
            this.btnCancelMapPropertyChanges.Location = new System.Drawing.Point(226, 51);
            this.btnCancelMapPropertyChanges.Name = "btnCancelMapPropertyChanges";
            this.btnCancelMapPropertyChanges.Size = new System.Drawing.Size(100, 23);
            this.btnCancelMapPropertyChanges.TabIndex = 27;
            this.btnCancelMapPropertyChanges.Text = "Cancel/Reset";
            this.btnCancelMapPropertyChanges.UseVisualStyleBackColor = true;
            this.btnCancelMapPropertyChanges.Click += new System.EventHandler(this.btnCancelMapPropertyChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Map Width:";
            // 
            // btnSaveMapProperties
            // 
            this.btnSaveMapProperties.Location = new System.Drawing.Point(226, 22);
            this.btnSaveMapProperties.Name = "btnSaveMapProperties";
            this.btnSaveMapProperties.Size = new System.Drawing.Size(100, 23);
            this.btnSaveMapProperties.TabIndex = 26;
            this.btnSaveMapProperties.Text = "Update";
            this.btnSaveMapProperties.UseVisualStyleBackColor = true;
            this.btnSaveMapProperties.Click += new System.EventHandler(this.btnSaveMapProperties_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Map Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Map Name:";
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(9, 26);
            this.txtMapName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(83, 20);
            this.txtMapName.TabIndex = 15;
            this.txtMapName.TextChanged += new System.EventHandler(this.txtMapName_TextChanged);
            // 
            // nudMapTileSize
            // 
            this.nudMapTileSize.Location = new System.Drawing.Point(120, 24);
            this.nudMapTileSize.Name = "nudMapTileSize";
            this.nudMapTileSize.Size = new System.Drawing.Size(83, 20);
            this.nudMapTileSize.TabIndex = 22;
            this.nudMapTileSize.ValueChanged += new System.EventHandler(this.nudMapTileSize_ValueChanged);
            // 
            // nudMapWidth
            // 
            this.nudMapWidth.Location = new System.Drawing.Point(10, 69);
            this.nudMapWidth.Name = "nudMapWidth";
            this.nudMapWidth.Size = new System.Drawing.Size(83, 20);
            this.nudMapWidth.TabIndex = 0;
            this.nudMapWidth.ValueChanged += new System.EventHandler(this.nudMapWidth_ValueChanged);
            // 
            // nudMapHeight
            // 
            this.nudMapHeight.Location = new System.Drawing.Point(120, 69);
            this.nudMapHeight.Name = "nudMapHeight";
            this.nudMapHeight.Size = new System.Drawing.Size(83, 20);
            this.nudMapHeight.TabIndex = 21;
            this.nudMapHeight.ValueChanged += new System.EventHandler(this.nudMapHeight_ValueChanged);
            // 
            // tabMapProperties
            // 
            this.tabMapProperties.Controls.Add(this.btnGlobalExtrasCopySelection);
            this.tabMapProperties.Controls.Add(this.label13);
            this.tabMapProperties.Controls.Add(this.lbGEPropertyList);
            this.tabMapProperties.Controls.Add(this.label12);
            this.tabMapProperties.Controls.Add(this.txtGENewText);
            this.tabMapProperties.Controls.Add(this.button1);
            this.tabMapProperties.Controls.Add(this.button2);
            this.tabMapProperties.Location = new System.Drawing.Point(4, 22);
            this.tabMapProperties.Name = "tabMapProperties";
            this.tabMapProperties.Size = new System.Drawing.Size(340, 299);
            this.tabMapProperties.TabIndex = 3;
            this.tabMapProperties.Text = "Map Properties";
            this.tabMapProperties.UseVisualStyleBackColor = true;
            // 
            // btnGlobalExtrasCopySelection
            // 
            this.btnGlobalExtrasCopySelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGlobalExtrasCopySelection.Location = new System.Drawing.Point(11, 232);
            this.btnGlobalExtrasCopySelection.Name = "btnGlobalExtrasCopySelection";
            this.btnGlobalExtrasCopySelection.Size = new System.Drawing.Size(175, 23);
            this.btnGlobalExtrasCopySelection.TabIndex = 37;
            this.btnGlobalExtrasCopySelection.Text = "Copy To Clipboard...";
            this.btnGlobalExtrasCopySelection.UseVisualStyleBackColor = true;
            this.btnGlobalExtrasCopySelection.Click += new System.EventHandler(this.btnGlobalExtrasCopySelection_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Global Map Properties:";
            // 
            // lbGEPropertyList
            // 
            this.lbGEPropertyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGEPropertyList.FormattingEnabled = true;
            this.lbGEPropertyList.Location = new System.Drawing.Point(11, 42);
            this.lbGEPropertyList.Name = "lbGEPropertyList";
            this.lbGEPropertyList.ScrollAlwaysVisible = true;
            this.lbGEPropertyList.Size = new System.Drawing.Size(175, 147);
            this.lbGEPropertyList.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "New Property:";
            // 
            // txtGENewText
            // 
            this.txtGENewText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGENewText.Location = new System.Drawing.Point(194, 60);
            this.txtGENewText.Margin = new System.Windows.Forms.Padding(2);
            this.txtGENewText.Name = "txtGENewText";
            this.txtGENewText.Size = new System.Drawing.Size(136, 20);
            this.txtGENewText.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(11, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "- Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(194, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "+ Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabTiles
            // 
            this.tabTiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabTiles.Controls.Add(this.bTileLoad);
            this.tabTiles.Controls.Add(this.sbTileHorizontalLocation);
            this.tabTiles.Controls.Add(this.sbTileVerticalLocation);
            this.tabTiles.Controls.Add(this.pbTileSet);
            this.tabTiles.Location = new System.Drawing.Point(4, 22);
            this.tabTiles.Margin = new System.Windows.Forms.Padding(2);
            this.tabTiles.Name = "tabTiles";
            this.tabTiles.Padding = new System.Windows.Forms.Padding(2);
            this.tabTiles.Size = new System.Drawing.Size(340, 299);
            this.tabTiles.TabIndex = 0;
            this.tabTiles.Text = "Tiles";
            // 
            // bTileLoad
            // 
            this.bTileLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bTileLoad.Location = new System.Drawing.Point(2, 272);
            this.bTileLoad.Margin = new System.Windows.Forms.Padding(2);
            this.bTileLoad.Name = "bTileLoad";
            this.bTileLoad.Size = new System.Drawing.Size(113, 23);
            this.bTileLoad.TabIndex = 3;
            this.bTileLoad.Text = "Load PNG File";
            this.bTileLoad.UseVisualStyleBackColor = true;
            this.bTileLoad.Click += new System.EventHandler(this.bTileLoad_Click);
            // 
            // sbTileHorizontalLocation
            // 
            this.sbTileHorizontalLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTileHorizontalLocation.Enabled = false;
            this.sbTileHorizontalLocation.Location = new System.Drawing.Point(2, 248);
            this.sbTileHorizontalLocation.Name = "sbTileHorizontalLocation";
            this.sbTileHorizontalLocation.Size = new System.Drawing.Size(316, 20);
            this.sbTileHorizontalLocation.TabIndex = 2;
            this.sbTileHorizontalLocation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTileHorizontalLocation_Scroll);
            // 
            // sbTileVerticalLocation
            // 
            this.sbTileVerticalLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTileVerticalLocation.Enabled = false;
            this.sbTileVerticalLocation.Location = new System.Drawing.Point(318, 2);
            this.sbTileVerticalLocation.Name = "sbTileVerticalLocation";
            this.sbTileVerticalLocation.Size = new System.Drawing.Size(20, 246);
            this.sbTileVerticalLocation.TabIndex = 1;
            this.sbTileVerticalLocation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTileVerticalLocation_Scroll);
            // 
            // pbTileSet
            // 
            this.pbTileSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTileSet.BackColor = System.Drawing.Color.White;
            this.pbTileSet.Location = new System.Drawing.Point(2, 2);
            this.pbTileSet.Margin = new System.Windows.Forms.Padding(2);
            this.pbTileSet.Name = "pbTileSet";
            this.pbTileSet.Size = new System.Drawing.Size(315, 246);
            this.pbTileSet.TabIndex = 0;
            this.pbTileSet.TabStop = false;
            this.pbTileSet.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTileSet_Paint);
            this.pbTileSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTileSet_MouseClick);
            this.pbTileSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTileSet_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCopySelectedTilePropertiesToClipboard);
            this.groupBox1.Controls.Add(this.lbPropertiesExtrasList);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPropertiesExtraAddText);
            this.groupBox1.Controls.Add(this.btnPropertiesExtraRemove);
            this.groupBox1.Controls.Add(this.btnPropertiesExtraAdd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblSelectionPosition);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCollidableState);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(348, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Properties";
            // 
            // btnCopySelectedTilePropertiesToClipboard
            // 
            this.btnCopySelectedTilePropertiesToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySelectedTilePropertiesToClipboard.Location = new System.Drawing.Point(15, 288);
            this.btnCopySelectedTilePropertiesToClipboard.Name = "btnCopySelectedTilePropertiesToClipboard";
            this.btnCopySelectedTilePropertiesToClipboard.Size = new System.Drawing.Size(175, 23);
            this.btnCopySelectedTilePropertiesToClipboard.TabIndex = 38;
            this.btnCopySelectedTilePropertiesToClipboard.Text = "Copy To Clipboard...";
            this.btnCopySelectedTilePropertiesToClipboard.UseVisualStyleBackColor = true;
            this.btnCopySelectedTilePropertiesToClipboard.Click += new System.EventHandler(this.btnCopySelectedTilePropertiesToClipboard_Click);
            // 
            // lbPropertiesExtrasList
            // 
            this.lbPropertiesExtrasList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPropertiesExtrasList.FormattingEnabled = true;
            this.lbPropertiesExtrasList.Location = new System.Drawing.Point(15, 120);
            this.lbPropertiesExtrasList.Name = "lbPropertiesExtrasList";
            this.lbPropertiesExtrasList.ScrollAlwaysVisible = true;
            this.lbPropertiesExtrasList.Size = new System.Drawing.Size(175, 121);
            this.lbPropertiesExtrasList.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "New Property:";
            // 
            // txtPropertiesExtraAddText
            // 
            this.txtPropertiesExtraAddText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropertiesExtraAddText.Location = new System.Drawing.Point(198, 138);
            this.txtPropertiesExtraAddText.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropertiesExtraAddText.Name = "txtPropertiesExtraAddText";
            this.txtPropertiesExtraAddText.Size = new System.Drawing.Size(136, 20);
            this.txtPropertiesExtraAddText.TabIndex = 29;
            // 
            // btnPropertiesExtraRemove
            // 
            this.btnPropertiesExtraRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPropertiesExtraRemove.Location = new System.Drawing.Point(15, 259);
            this.btnPropertiesExtraRemove.Name = "btnPropertiesExtraRemove";
            this.btnPropertiesExtraRemove.Size = new System.Drawing.Size(175, 23);
            this.btnPropertiesExtraRemove.TabIndex = 26;
            this.btnPropertiesExtraRemove.Text = "- Remove";
            this.btnPropertiesExtraRemove.UseVisualStyleBackColor = true;
            this.btnPropertiesExtraRemove.Click += new System.EventHandler(this.btnPropertiesExtraRemove_Click);
            // 
            // btnPropertiesExtraAdd
            // 
            this.btnPropertiesExtraAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPropertiesExtraAdd.Location = new System.Drawing.Point(198, 161);
            this.btnPropertiesExtraAdd.Name = "btnPropertiesExtraAdd";
            this.btnPropertiesExtraAdd.Size = new System.Drawing.Size(135, 23);
            this.btnPropertiesExtraAdd.TabIndex = 25;
            this.btnPropertiesExtraAdd.Text = "+ Add";
            this.btnPropertiesExtraAdd.UseVisualStyleBackColor = true;
            this.btnPropertiesExtraAdd.Click += new System.EventHandler(this.btnPropertiesExtraAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tile Properties:";
            // 
            // lblSelectionPosition
            // 
            this.lblSelectionPosition.AutoSize = true;
            this.lblSelectionPosition.Location = new System.Drawing.Point(115, 27);
            this.lblSelectionPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectionPosition.Name = "lblSelectionPosition";
            this.lblSelectionPosition.Size = new System.Drawing.Size(30, 13);
            this.lblSelectionPosition.TabIndex = 18;
            this.lblSelectionPosition.Text = "_ x _";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Position:";
            // 
            // cbCollidableState
            // 
            this.cbCollidableState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollidableState.FormattingEnabled = true;
            this.cbCollidableState.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbCollidableState.Location = new System.Drawing.Point(118, 56);
            this.cbCollidableState.Name = "cbCollidableState";
            this.cbCollidableState.Size = new System.Drawing.Size(121, 21);
            this.cbCollidableState.TabIndex = 16;
            this.cbCollidableState.SelectedIndexChanged += new System.EventHandler(this.cbCollidableState_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Collidable:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pbMouseModeSelect);
            this.flowLayoutPanel1.Controls.Add(this.pbMouseModeDraw);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cbLayerListTop);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.cbViewModeSelector);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(641, 43);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pbMouseModeSelect
            // 
            this.pbMouseModeSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMouseModeSelect.Image = global::_2DTileEditor.Properties.Resources.input_mouse;
            this.pbMouseModeSelect.Location = new System.Drawing.Point(3, 3);
            this.pbMouseModeSelect.Name = "pbMouseModeSelect";
            this.pbMouseModeSelect.Size = new System.Drawing.Size(34, 34);
            this.pbMouseModeSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMouseModeSelect.TabIndex = 10;
            this.pbMouseModeSelect.TabStop = false;
            this.pbMouseModeSelect.Click += new System.EventHandler(this.pbMouseModeSelect_Click);
            // 
            // pbMouseModeDraw
            // 
            this.pbMouseModeDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMouseModeDraw.Image = global::_2DTileEditor.Properties.Resources.applications_graphics;
            this.pbMouseModeDraw.Location = new System.Drawing.Point(43, 3);
            this.pbMouseModeDraw.Name = "pbMouseModeDraw";
            this.pbMouseModeDraw.Size = new System.Drawing.Size(34, 34);
            this.pbMouseModeDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMouseModeDraw.TabIndex = 9;
            this.pbMouseModeDraw.TabStop = false;
            this.pbMouseModeDraw.Click += new System.EventHandler(this.pbMouseModeDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Layer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLayerListTop
            // 
            this.cbLayerListTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayerListTop.FormattingEnabled = true;
            this.cbLayerListTop.Location = new System.Drawing.Point(141, 3);
            this.cbLayerListTop.Name = "cbLayerListTop";
            this.cbLayerListTop.Size = new System.Drawing.Size(121, 21);
            this.cbLayerListTop.TabIndex = 5;
            this.cbLayerListTop.SelectedIndexChanged += new System.EventHandler(this.cbLayerListTop_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "View:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbViewModeSelector
            // 
            this.cbViewModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewModeSelector.FormattingEnabled = true;
            this.cbViewModeSelector.Items.AddRange(new object[] {
            "Normal",
            "Collision",
            "Extra Properties"});
            this.cbViewModeSelector.Location = new System.Drawing.Point(321, 3);
            this.cbViewModeSelector.Name = "cbViewModeSelector";
            this.cbViewModeSelector.Size = new System.Drawing.Size(121, 21);
            this.cbViewModeSelector.TabIndex = 6;
            this.cbViewModeSelector.SelectedIndexChanged += new System.EventHandler(this.cbViewModeSelector_SelectedIndexChanged);
            // 
            // sbMapVerticalLocation
            // 
            this.sbMapVerticalLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMapVerticalLocation.Location = new System.Drawing.Point(622, 49);
            this.sbMapVerticalLocation.Name = "sbMapVerticalLocation";
            this.sbMapVerticalLocation.Size = new System.Drawing.Size(21, 594);
            this.sbMapVerticalLocation.TabIndex = 5;
            this.sbMapVerticalLocation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMapVerticalLocation_Scroll);
            // 
            // sbMapHorizontalLocation
            // 
            this.sbMapHorizontalLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMapHorizontalLocation.Location = new System.Drawing.Point(2, 645);
            this.sbMapHorizontalLocation.Name = "sbMapHorizontalLocation";
            this.sbMapHorizontalLocation.Size = new System.Drawing.Size(619, 21);
            this.sbMapHorizontalLocation.TabIndex = 6;
            this.sbMapHorizontalLocation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMapHorizontalLocation_Scroll);
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMainMenu.Size = new System.Drawing.Size(1007, 24);
            this.msMainMenu.TabIndex = 7;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newMapToolStripMenuItem.Text = "&New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveMapToolStripMenuItem.Text = "&Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadMapToolStripMenuItem.Text = "&Load Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.sbMapHorizontalLocation);
            this.splitContainer1.Panel1.Controls.Add(this.pbMainSurface);
            this.splitContainer1.Panel1.Controls.Add(this.sbMapVerticalLocation);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 668);
            this.splitContainer1.SplitterDistance = 645;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // pbMainSurface
            // 
            this.pbMainSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMainSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMainSurface.Location = new System.Drawing.Point(2, 49);
            this.pbMainSurface.Margin = new System.Windows.Forms.Padding(2);
            this.pbMainSurface.Name = "pbMainSurface";
            this.pbMainSurface.Size = new System.Drawing.Size(618, 594);
            this.pbMainSurface.TabIndex = 0;
            this.pbMainSurface.TabStop = false;
            this.pbMainSurface.Click += new System.EventHandler(this.pbMainSurface_Click_1);
            this.pbMainSurface.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMainSurface_Paint);
            this.pbMainSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMainSurface_MouseDown);
            this.pbMainSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMainSurface_MouseMove);
            this.pbMainSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMainSurface_MouseUp);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(352, 660);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 3;
            // 
            // ofdOpenMap
            // 
            this.ofdOpenMap.FileName = "openFileDialog1";
            // 
            // sfdSaveMap
            // 
            this.sfdSaveMap.DefaultExt = "map";
            this.sfdSaveMap.Filter = "Map File|*.map";
            // 
            // frm2DTileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 692);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm2DTileEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Tile Map Editor by Scott Waldron, TheWayOfCoding.com";
            this.Load += new System.EventHandler(this.frm2DTileEditor_Load);
            this.Resize += new System.EventHandler(this.frm2DTileEditor_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabMapMainDetails.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapTileSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).EndInit();
            this.tabMapProperties.ResumeLayout(false);
            this.tabMapProperties.PerformLayout();
            this.tabTiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTileSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouseModeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouseModeDraw)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainSurface)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainSurface;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.VScrollBar sbMapVerticalLocation;
        private System.Windows.Forms.HScrollBar sbMapHorizontalLocation;
        private System.Windows.Forms.TabPage tabMapMainDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar sbTileHorizontalLocation;
        private System.Windows.Forms.VScrollBar sbTileVerticalLocation;
        private System.Windows.Forms.PictureBox pbTileSet;
        private System.Windows.Forms.Button bTileLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRemoveMapLayer;
        private System.Windows.Forms.Button btnAddMapLayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMapTileSize;
        private System.Windows.Forms.NumericUpDown nudMapHeight;
        private System.Windows.Forms.NumericUpDown nudMapWidth;
        private System.Windows.Forms.CheckedListBox clbLayerList;
        private System.Windows.Forms.Button btnAllLayersVisible;
        private System.Windows.Forms.ComboBox cbLayerListTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbViewModeSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCollidableState;
        private System.Windows.Forms.Label lblSelectionPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelMapPropertyChanges;
        private System.Windows.Forms.Button btnSaveMapProperties;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMouseModeDraw;
        private System.Windows.Forms.PictureBox pbMouseModeSelect;
        private System.Windows.Forms.OpenFileDialog ofdOpenMap;
        private System.Windows.Forms.SaveFileDialog sfdSaveMap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPropertiesExtraAddText;
        private System.Windows.Forms.Button btnPropertiesExtraRemove;
        private System.Windows.Forms.Button btnPropertiesExtraAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbPropertiesExtrasList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabMapProperties;
        private System.Windows.Forms.ListBox lbGEPropertyList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGENewText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGlobalExtrasCopySelection;
        private System.Windows.Forms.Button btnCopySelectedTilePropertiesToClipboard;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

