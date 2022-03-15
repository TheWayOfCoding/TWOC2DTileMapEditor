namespace _2DTileEditor
{
    partial class frmNewMap
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
            this.btnCancelNewMap = new System.Windows.Forms.Button();
            this.btnCreateNewMapStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewMapName = new System.Windows.Forms.TextBox();
            this.txtNewMapTilesetPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoadTileset = new System.Windows.Forms.Button();
            this.openTileSetDialog = new System.Windows.Forms.OpenFileDialog();
            this.nudMapWidth = new System.Windows.Forms.NumericUpDown();
            this.nudMapHeight = new System.Windows.Forms.NumericUpDown();
            this.nudMapTileSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapTileSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelNewMap
            // 
            this.btnCancelNewMap.Location = new System.Drawing.Point(262, 264);
            this.btnCancelNewMap.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelNewMap.Name = "btnCancelNewMap";
            this.btnCancelNewMap.Size = new System.Drawing.Size(56, 22);
            this.btnCancelNewMap.TabIndex = 0;
            this.btnCancelNewMap.Text = "Cancel";
            this.btnCancelNewMap.UseVisualStyleBackColor = true;
            this.btnCancelNewMap.Click += new System.EventHandler(this.btnCancelNewMap_Click);
            // 
            // btnCreateNewMapStart
            // 
            this.btnCreateNewMapStart.Location = new System.Drawing.Point(141, 264);
            this.btnCreateNewMapStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewMapStart.Name = "btnCreateNewMapStart";
            this.btnCreateNewMapStart.Size = new System.Drawing.Size(106, 22);
            this.btnCreateNewMapStart.TabIndex = 1;
            this.btnCreateNewMapStart.Text = "Create New Map";
            this.btnCreateNewMapStart.UseVisualStyleBackColor = true;
            this.btnCreateNewMapStart.Click += new System.EventHandler(this.btnCreateNewMapStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tile Size (Pixels):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Map Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Map Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Map Name:";
            // 
            // txtNewMapName
            // 
            this.txtNewMapName.Location = new System.Drawing.Point(11, 24);
            this.txtNewMapName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewMapName.Name = "txtNewMapName";
            this.txtNewMapName.Size = new System.Drawing.Size(200, 20);
            this.txtNewMapName.TabIndex = 13;
            // 
            // txtNewMapTilesetPath
            // 
            this.txtNewMapTilesetPath.Location = new System.Drawing.Point(11, 202);
            this.txtNewMapTilesetPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewMapTilesetPath.Name = "txtNewMapTilesetPath";
            this.txtNewMapTilesetPath.ReadOnly = true;
            this.txtNewMapTilesetPath.Size = new System.Drawing.Size(308, 20);
            this.txtNewMapTilesetPath.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Tileset:";
            // 
            // btnLoadTileset
            // 
            this.btnLoadTileset.Location = new System.Drawing.Point(9, 224);
            this.btnLoadTileset.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadTileset.Name = "btnLoadTileset";
            this.btnLoadTileset.Size = new System.Drawing.Size(96, 19);
            this.btnLoadTileset.TabIndex = 16;
            this.btnLoadTileset.Text = "Load Tileset";
            this.btnLoadTileset.UseVisualStyleBackColor = true;
            this.btnLoadTileset.Click += new System.EventHandler(this.button3_Click);
            // 
            // openTileSetDialog
            // 
            this.openTileSetDialog.Filter = "PNG Files|*.png";
            // 
            // nudMapWidth
            // 
            this.nudMapWidth.Location = new System.Drawing.Point(11, 80);
            this.nudMapWidth.Name = "nudMapWidth";
            this.nudMapWidth.Size = new System.Drawing.Size(84, 20);
            this.nudMapWidth.TabIndex = 17;
            // 
            // nudMapHeight
            // 
            this.nudMapHeight.Location = new System.Drawing.Point(121, 80);
            this.nudMapHeight.Name = "nudMapHeight";
            this.nudMapHeight.Size = new System.Drawing.Size(84, 20);
            this.nudMapHeight.TabIndex = 18;
            // 
            // nudMapTileSize
            // 
            this.nudMapTileSize.Location = new System.Drawing.Point(12, 144);
            this.nudMapTileSize.Name = "nudMapTileSize";
            this.nudMapTileSize.Size = new System.Drawing.Size(84, 20);
            this.nudMapTileSize.TabIndex = 19;
            this.nudMapTileSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // frmNewMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 294);
            this.Controls.Add(this.nudMapTileSize);
            this.Controls.Add(this.nudMapHeight);
            this.Controls.Add(this.nudMapWidth);
            this.Controls.Add(this.btnLoadTileset);
            this.Controls.Add(this.txtNewMapTilesetPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewMapName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateNewMapStart);
            this.Controls.Add(this.btnCancelNewMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewMap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Map";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNewMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapTileSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelNewMap;
        private System.Windows.Forms.Button btnCreateNewMapStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewMapName;
        private System.Windows.Forms.TextBox txtNewMapTilesetPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoadTileset;
        private System.Windows.Forms.OpenFileDialog openTileSetDialog;
        private System.Windows.Forms.NumericUpDown nudMapWidth;
        private System.Windows.Forms.NumericUpDown nudMapHeight;
        private System.Windows.Forms.NumericUpDown nudMapTileSize;
    }
}