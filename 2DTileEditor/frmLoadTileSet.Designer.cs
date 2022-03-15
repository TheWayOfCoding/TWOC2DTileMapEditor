namespace _2DTileEditor
{
    partial class frmLoadTileSet
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
            this.tbLocationTileset = new System.Windows.Forms.TextBox();
            this.bBrowseTileSet = new System.Windows.Forms.Button();
            this.bOkayTileSet = new System.Windows.Forms.Button();
            this.bCancelTileset = new System.Windows.Forms.Button();
            this.ofdDialogBoxTileSet = new System.Windows.Forms.OpenFileDialog();
            this.pbPreviewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLocationTileset
            // 
            this.tbLocationTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocationTileset.Location = new System.Drawing.Point(9, 11);
            this.tbLocationTileset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLocationTileset.Name = "tbLocationTileset";
            this.tbLocationTileset.Size = new System.Drawing.Size(249, 20);
            this.tbLocationTileset.TabIndex = 0;
            // 
            // bBrowseTileSet
            // 
            this.bBrowseTileSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseTileSet.Location = new System.Drawing.Point(262, 11);
            this.bBrowseTileSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bBrowseTileSet.Name = "bBrowseTileSet";
            this.bBrowseTileSet.Size = new System.Drawing.Size(56, 19);
            this.bBrowseTileSet.TabIndex = 1;
            this.bBrowseTileSet.Text = "Browse";
            this.bBrowseTileSet.UseVisualStyleBackColor = true;
            this.bBrowseTileSet.Click += new System.EventHandler(this.bBrowseTileSet_Click);
            // 
            // bOkayTileSet
            // 
            this.bOkayTileSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOkayTileSet.Location = new System.Drawing.Point(202, 209);
            this.bOkayTileSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bOkayTileSet.Name = "bOkayTileSet";
            this.bOkayTileSet.Size = new System.Drawing.Size(56, 32);
            this.bOkayTileSet.TabIndex = 2;
            this.bOkayTileSet.Text = "Okay";
            this.bOkayTileSet.UseVisualStyleBackColor = true;
            this.bOkayTileSet.Click += new System.EventHandler(this.bOkayTileSet_Click);
            // 
            // bCancelTileset
            // 
            this.bCancelTileset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelTileset.Location = new System.Drawing.Point(262, 209);
            this.bCancelTileset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCancelTileset.Name = "bCancelTileset";
            this.bCancelTileset.Size = new System.Drawing.Size(56, 32);
            this.bCancelTileset.TabIndex = 3;
            this.bCancelTileset.Text = "Cancel";
            this.bCancelTileset.UseVisualStyleBackColor = true;
            this.bCancelTileset.Click += new System.EventHandler(this.bCancelTileset_Click);
            // 
            // ofdDialogBoxTileSet
            // 
            this.ofdDialogBoxTileSet.Filter = "PNG Files|*.png";
            // 
            // pbPreviewImage
            // 
            this.pbPreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreviewImage.Location = new System.Drawing.Point(12, 36);
            this.pbPreviewImage.Name = "pbPreviewImage";
            this.pbPreviewImage.Size = new System.Drawing.Size(305, 168);
            this.pbPreviewImage.TabIndex = 4;
            this.pbPreviewImage.TabStop = false;
            // 
            // frmLoadTileSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 252);
            this.Controls.Add(this.pbPreviewImage);
            this.Controls.Add(this.bCancelTileset);
            this.Controls.Add(this.bOkayTileSet);
            this.Controls.Add(this.bBrowseTileSet);
            this.Controls.Add(this.tbLocationTileset);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoadTileSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Tileset File...";
            this.Load += new System.EventHandler(this.frmLoadTileSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLocationTileset;
        private System.Windows.Forms.Button bBrowseTileSet;
        private System.Windows.Forms.Button bOkayTileSet;
        private System.Windows.Forms.Button bCancelTileset;
        private System.Windows.Forms.OpenFileDialog ofdDialogBoxTileSet;
        private System.Windows.Forms.PictureBox pbPreviewImage;
    }
}