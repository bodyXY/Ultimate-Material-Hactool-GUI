using System;

namespace Ultimate_Material_Hactool_GUI
{
    partial class GUI_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.NspOutTextbox = new System.Windows.Forms.TextBox();
            this.NspInTextbox = new System.Windows.Forms.TextBox();
            this.NspKeysTextbox = new System.Windows.Forms.TextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.NsptabPage = new System.Windows.Forms.TabPage();
            this.NspExtractButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NspFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NspSwitchKeysLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NspOutoutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.KeysButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NspOutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NspInButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NcaExtractButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NcaFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NcaSwtichKeysLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NcaOutputLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NcaKeysBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NcaOutBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NcaInBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NcaInTextbox = new System.Windows.Forms.TextBox();
            this.NcaKeysTextbox = new System.Windows.Forms.TextBox();
            this.NcaOutTextbox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.XciExtractButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.XciFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.XciSwitchKeysLabel = new MaterialSkin.Controls.MaterialLabel();
            this.XciOutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.XciKeysBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.XciOutBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.XciInBrowseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.XciInTextbox = new System.Windows.Forms.TextBox();
            this.XciKeysTextbox = new System.Windows.Forms.TextBox();
            this.XciOutTextbox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RomFSExtractButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.romFSKeysButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.romFSOutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.romFSInButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.romFSInTextbox = new System.Windows.Forms.TextBox();
            this.romFSKeysTextbox = new System.Windows.Forms.TextBox();
            this.romFSOutTextbox = new System.Windows.Forms.TextBox();
            this.VersionsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.NsptabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NspOutTextbox
            // 
            this.NspOutTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NspOutTextbox.Location = new System.Drawing.Point(247, 58);
            this.NspOutTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NspOutTextbox.Name = "NspOutTextbox";
            this.NspOutTextbox.Size = new System.Drawing.Size(325, 29);
            this.NspOutTextbox.TabIndex = 4;
            // 
            // NspInTextbox
            // 
            this.NspInTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NspInTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NspInTextbox.Location = new System.Drawing.Point(247, 10);
            this.NspInTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NspInTextbox.Name = "NspInTextbox";
            this.NspInTextbox.Size = new System.Drawing.Size(325, 29);
            this.NspInTextbox.TabIndex = 1;
            // 
            // NspKeysTextbox
            // 
            this.NspKeysTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NspKeysTextbox.Location = new System.Drawing.Point(247, 106);
            this.NspKeysTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NspKeysTextbox.Name = "NspKeysTextbox";
            this.NspKeysTextbox.Size = new System.Drawing.Size(325, 29);
            this.NspKeysTextbox.TabIndex = 10;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.NsptabPage);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialTabControl1.Location = new System.Drawing.Point(12, 132);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(673, 215);
            this.materialTabControl1.TabIndex = 14;
            // 
            // NsptabPage
            // 
            this.NsptabPage.Controls.Add(this.NspExtractButton);
            this.NsptabPage.Controls.Add(this.NspFileLabel);
            this.NsptabPage.Controls.Add(this.NspSwitchKeysLabel);
            this.NsptabPage.Controls.Add(this.NspOutoutLabel);
            this.NsptabPage.Controls.Add(this.KeysButton);
            this.NsptabPage.Controls.Add(this.NspOutButton);
            this.NsptabPage.Controls.Add(this.NspInButton);
            this.NsptabPage.Controls.Add(this.NspInTextbox);
            this.NsptabPage.Controls.Add(this.NspKeysTextbox);
            this.NsptabPage.Controls.Add(this.NspOutTextbox);
            this.NsptabPage.Font = new System.Drawing.Font("Roboto", 14F);
            this.NsptabPage.Location = new System.Drawing.Point(4, 24);
            this.NsptabPage.Name = "NsptabPage";
            this.NsptabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NsptabPage.Size = new System.Drawing.Size(665, 187);
            this.NsptabPage.TabIndex = 0;
            this.NsptabPage.Text = "NSP";
            this.NsptabPage.UseVisualStyleBackColor = true;
            this.NsptabPage.Click += new System.EventHandler(this.NsptabPage_Click);
            // 
            // NspExtractButton
            // 
            this.NspExtractButton.AutoSize = true;
            this.NspExtractButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NspExtractButton.Depth = 0;
            this.NspExtractButton.Location = new System.Drawing.Point(29, 151);
            this.NspExtractButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NspExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspExtractButton.Name = "NspExtractButton";
            this.NspExtractButton.Primary = false;
            this.NspExtractButton.Size = new System.Drawing.Size(72, 36);
            this.NspExtractButton.TabIndex = 16;
            this.NspExtractButton.Text = "Extract";
            this.NspExtractButton.UseVisualStyleBackColor = true;
            this.NspExtractButton.Click += new System.EventHandler(this.NspExtractButton_Click);
            // 
            // NspFileLabel
            // 
            this.NspFileLabel.AutoSize = true;
            this.NspFileLabel.Depth = 0;
            this.NspFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NspFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NspFileLabel.Location = new System.Drawing.Point(31, 14);
            this.NspFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspFileLabel.Name = "NspFileLabel";
            this.NspFileLabel.Size = new System.Drawing.Size(70, 19);
            this.NspFileLabel.TabIndex = 15;
            this.NspFileLabel.Text = "NSP File:";
            // 
            // NspSwitchKeysLabel
            // 
            this.NspSwitchKeysLabel.AutoSize = true;
            this.NspSwitchKeysLabel.Depth = 0;
            this.NspSwitchKeysLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NspSwitchKeysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NspSwitchKeysLabel.Location = new System.Drawing.Point(31, 108);
            this.NspSwitchKeysLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspSwitchKeysLabel.Name = "NspSwitchKeysLabel";
            this.NspSwitchKeysLabel.Size = new System.Drawing.Size(94, 19);
            this.NspSwitchKeysLabel.TabIndex = 15;
            this.NspSwitchKeysLabel.Text = "Switch Keys:";
            // 
            // NspOutoutLabel
            // 
            this.NspOutoutLabel.AutoSize = true;
            this.NspOutoutLabel.Depth = 0;
            this.NspOutoutLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NspOutoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NspOutoutLabel.Location = new System.Drawing.Point(31, 60);
            this.NspOutoutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspOutoutLabel.Name = "NspOutoutLabel";
            this.NspOutoutLabel.Size = new System.Drawing.Size(90, 19);
            this.NspOutoutLabel.TabIndex = 15;
            this.NspOutoutLabel.Text = "Output path:";
            // 
            // KeysButton
            // 
            this.KeysButton.AutoSize = true;
            this.KeysButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KeysButton.Depth = 0;
            this.KeysButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.KeysButton.Location = new System.Drawing.Point(583, 102);
            this.KeysButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.KeysButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.KeysButton.Name = "KeysButton";
            this.KeysButton.Primary = false;
            this.KeysButton.Size = new System.Drawing.Size(67, 36);
            this.KeysButton.TabIndex = 11;
            this.KeysButton.Text = "Browse";
            this.KeysButton.UseVisualStyleBackColor = true;
            this.KeysButton.Click += new System.EventHandler(this.KeysButton_Click);
            // 
            // NspOutButton
            // 
            this.NspOutButton.AutoSize = true;
            this.NspOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NspOutButton.Depth = 0;
            this.NspOutButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.NspOutButton.Location = new System.Drawing.Point(583, 54);
            this.NspOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NspOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspOutButton.Name = "NspOutButton";
            this.NspOutButton.Primary = false;
            this.NspOutButton.Size = new System.Drawing.Size(67, 36);
            this.NspOutButton.TabIndex = 11;
            this.NspOutButton.Text = "Browse";
            this.NspOutButton.UseVisualStyleBackColor = true;
            this.NspOutButton.Click += new System.EventHandler(this.NspOutButton_Click);
            // 
            // NspInButton
            // 
            this.NspInButton.AutoSize = true;
            this.NspInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NspInButton.Depth = 0;
            this.NspInButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.NspInButton.Location = new System.Drawing.Point(583, 6);
            this.NspInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NspInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NspInButton.Name = "NspInButton";
            this.NspInButton.Primary = false;
            this.NspInButton.Size = new System.Drawing.Size(67, 36);
            this.NspInButton.TabIndex = 11;
            this.NspInButton.Text = "Browse";
            this.NspInButton.UseVisualStyleBackColor = true;
            this.NspInButton.Click += new System.EventHandler(this.NspInButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NcaExtractButton);
            this.tabPage2.Controls.Add(this.NcaFileLabel);
            this.tabPage2.Controls.Add(this.NcaSwtichKeysLabel);
            this.tabPage2.Controls.Add(this.NcaOutputLabel);
            this.tabPage2.Controls.Add(this.NcaKeysBrowseButton);
            this.tabPage2.Controls.Add(this.NcaOutBrowseButton);
            this.tabPage2.Controls.Add(this.NcaInBrowseButton);
            this.tabPage2.Controls.Add(this.NcaInTextbox);
            this.tabPage2.Controls.Add(this.NcaKeysTextbox);
            this.tabPage2.Controls.Add(this.NcaOutTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NCA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NcaExtractButton
            // 
            this.NcaExtractButton.AutoSize = true;
            this.NcaExtractButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NcaExtractButton.Depth = 0;
            this.NcaExtractButton.Location = new System.Drawing.Point(29, 151);
            this.NcaExtractButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NcaExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaExtractButton.Name = "NcaExtractButton";
            this.NcaExtractButton.Primary = false;
            this.NcaExtractButton.Size = new System.Drawing.Size(72, 36);
            this.NcaExtractButton.TabIndex = 26;
            this.NcaExtractButton.Text = "Extract";
            this.NcaExtractButton.UseVisualStyleBackColor = true;
            this.NcaExtractButton.Click += new System.EventHandler(this.NcaExtractButton_Click);
            // 
            // NcaFileLabel
            // 
            this.NcaFileLabel.AutoSize = true;
            this.NcaFileLabel.Depth = 0;
            this.NcaFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NcaFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NcaFileLabel.Location = new System.Drawing.Point(31, 14);
            this.NcaFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaFileLabel.Name = "NcaFileLabel";
            this.NcaFileLabel.Size = new System.Drawing.Size(72, 19);
            this.NcaFileLabel.TabIndex = 23;
            this.NcaFileLabel.Text = "NCA File:";
            this.NcaFileLabel.Click += new System.EventHandler(this.NcaFileLabel_Click);
            // 
            // NcaSwtichKeysLabel
            // 
            this.NcaSwtichKeysLabel.AutoSize = true;
            this.NcaSwtichKeysLabel.Depth = 0;
            this.NcaSwtichKeysLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NcaSwtichKeysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NcaSwtichKeysLabel.Location = new System.Drawing.Point(31, 108);
            this.NcaSwtichKeysLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaSwtichKeysLabel.Name = "NcaSwtichKeysLabel";
            this.NcaSwtichKeysLabel.Size = new System.Drawing.Size(94, 19);
            this.NcaSwtichKeysLabel.TabIndex = 24;
            this.NcaSwtichKeysLabel.Text = "Switch Keys:";
            // 
            // NcaOutputLabel
            // 
            this.NcaOutputLabel.AutoSize = true;
            this.NcaOutputLabel.Depth = 0;
            this.NcaOutputLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NcaOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NcaOutputLabel.Location = new System.Drawing.Point(31, 60);
            this.NcaOutputLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaOutputLabel.Name = "NcaOutputLabel";
            this.NcaOutputLabel.Size = new System.Drawing.Size(90, 19);
            this.NcaOutputLabel.TabIndex = 25;
            this.NcaOutputLabel.Text = "Output path:";
            // 
            // NcaKeysBrowseButton
            // 
            this.NcaKeysBrowseButton.AutoSize = true;
            this.NcaKeysBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NcaKeysBrowseButton.Depth = 0;
            this.NcaKeysBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.NcaKeysBrowseButton.Location = new System.Drawing.Point(583, 102);
            this.NcaKeysBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NcaKeysBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaKeysBrowseButton.Name = "NcaKeysBrowseButton";
            this.NcaKeysBrowseButton.Primary = false;
            this.NcaKeysBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.NcaKeysBrowseButton.TabIndex = 20;
            this.NcaKeysBrowseButton.Text = "Browse";
            this.NcaKeysBrowseButton.UseVisualStyleBackColor = true;
            this.NcaKeysBrowseButton.Click += new System.EventHandler(this.NcaKeysBrowseButton_Click);
            // 
            // NcaOutBrowseButton
            // 
            this.NcaOutBrowseButton.AutoSize = true;
            this.NcaOutBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NcaOutBrowseButton.Depth = 0;
            this.NcaOutBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.NcaOutBrowseButton.Location = new System.Drawing.Point(583, 54);
            this.NcaOutBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NcaOutBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaOutBrowseButton.Name = "NcaOutBrowseButton";
            this.NcaOutBrowseButton.Primary = false;
            this.NcaOutBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.NcaOutBrowseButton.TabIndex = 21;
            this.NcaOutBrowseButton.Text = "Browse";
            this.NcaOutBrowseButton.UseVisualStyleBackColor = true;
            this.NcaOutBrowseButton.Click += new System.EventHandler(this.NcaOutBrowseButton_Click);
            // 
            // NcaInBrowseButton
            // 
            this.NcaInBrowseButton.AutoSize = true;
            this.NcaInBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NcaInBrowseButton.Depth = 0;
            this.NcaInBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.NcaInBrowseButton.Location = new System.Drawing.Point(583, 6);
            this.NcaInBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NcaInBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NcaInBrowseButton.Name = "NcaInBrowseButton";
            this.NcaInBrowseButton.Primary = false;
            this.NcaInBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.NcaInBrowseButton.TabIndex = 22;
            this.NcaInBrowseButton.Text = "Browse";
            this.NcaInBrowseButton.UseVisualStyleBackColor = true;
            this.NcaInBrowseButton.Click += new System.EventHandler(this.NcaInBrowseButton_Click);
            // 
            // NcaInTextbox
            // 
            this.NcaInTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NcaInTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NcaInTextbox.Location = new System.Drawing.Point(247, 10);
            this.NcaInTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NcaInTextbox.Name = "NcaInTextbox";
            this.NcaInTextbox.Size = new System.Drawing.Size(325, 29);
            this.NcaInTextbox.TabIndex = 17;
            // 
            // NcaKeysTextbox
            // 
            this.NcaKeysTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NcaKeysTextbox.Location = new System.Drawing.Point(247, 106);
            this.NcaKeysTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NcaKeysTextbox.Name = "NcaKeysTextbox";
            this.NcaKeysTextbox.Size = new System.Drawing.Size(325, 29);
            this.NcaKeysTextbox.TabIndex = 19;
            // 
            // NcaOutTextbox
            // 
            this.NcaOutTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.NcaOutTextbox.Location = new System.Drawing.Point(247, 58);
            this.NcaOutTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.NcaOutTextbox.Name = "NcaOutTextbox";
            this.NcaOutTextbox.Size = new System.Drawing.Size(325, 29);
            this.NcaOutTextbox.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.XciExtractButton);
            this.tabPage1.Controls.Add(this.XciFileLabel);
            this.tabPage1.Controls.Add(this.XciSwitchKeysLabel);
            this.tabPage1.Controls.Add(this.XciOutLabel);
            this.tabPage1.Controls.Add(this.XciKeysBrowseButton);
            this.tabPage1.Controls.Add(this.XciOutBrowseButton);
            this.tabPage1.Controls.Add(this.XciInBrowseButton);
            this.tabPage1.Controls.Add(this.XciInTextbox);
            this.tabPage1.Controls.Add(this.XciKeysTextbox);
            this.tabPage1.Controls.Add(this.XciOutTextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(665, 187);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "XCI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // XciExtractButton
            // 
            this.XciExtractButton.AutoSize = true;
            this.XciExtractButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XciExtractButton.Depth = 0;
            this.XciExtractButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.XciExtractButton.Location = new System.Drawing.Point(29, 151);
            this.XciExtractButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.XciExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciExtractButton.Name = "XciExtractButton";
            this.XciExtractButton.Primary = false;
            this.XciExtractButton.Size = new System.Drawing.Size(72, 36);
            this.XciExtractButton.TabIndex = 26;
            this.XciExtractButton.Text = "Extract";
            this.XciExtractButton.UseVisualStyleBackColor = true;
            this.XciExtractButton.Click += new System.EventHandler(this.XciExtractButton_Click);
            // 
            // XciFileLabel
            // 
            this.XciFileLabel.AutoSize = true;
            this.XciFileLabel.Depth = 0;
            this.XciFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.XciFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XciFileLabel.Location = new System.Drawing.Point(31, 14);
            this.XciFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciFileLabel.Name = "XciFileLabel";
            this.XciFileLabel.Size = new System.Drawing.Size(64, 19);
            this.XciFileLabel.TabIndex = 23;
            this.XciFileLabel.Text = "XCI File:";
            // 
            // XciSwitchKeysLabel
            // 
            this.XciSwitchKeysLabel.AutoSize = true;
            this.XciSwitchKeysLabel.Depth = 0;
            this.XciSwitchKeysLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.XciSwitchKeysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XciSwitchKeysLabel.Location = new System.Drawing.Point(31, 108);
            this.XciSwitchKeysLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciSwitchKeysLabel.Name = "XciSwitchKeysLabel";
            this.XciSwitchKeysLabel.Size = new System.Drawing.Size(94, 19);
            this.XciSwitchKeysLabel.TabIndex = 24;
            this.XciSwitchKeysLabel.Text = "Switch Keys:";
            // 
            // XciOutLabel
            // 
            this.XciOutLabel.AutoSize = true;
            this.XciOutLabel.Depth = 0;
            this.XciOutLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.XciOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XciOutLabel.Location = new System.Drawing.Point(31, 60);
            this.XciOutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciOutLabel.Name = "XciOutLabel";
            this.XciOutLabel.Size = new System.Drawing.Size(90, 19);
            this.XciOutLabel.TabIndex = 25;
            this.XciOutLabel.Text = "Output path:";
            // 
            // XciKeysBrowseButton
            // 
            this.XciKeysBrowseButton.AutoSize = true;
            this.XciKeysBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XciKeysBrowseButton.Depth = 0;
            this.XciKeysBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.XciKeysBrowseButton.Location = new System.Drawing.Point(583, 102);
            this.XciKeysBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.XciKeysBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciKeysBrowseButton.Name = "XciKeysBrowseButton";
            this.XciKeysBrowseButton.Primary = false;
            this.XciKeysBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.XciKeysBrowseButton.TabIndex = 20;
            this.XciKeysBrowseButton.Text = "Browse";
            this.XciKeysBrowseButton.UseVisualStyleBackColor = true;
            this.XciKeysBrowseButton.Click += new System.EventHandler(this.XciKeysBrowseButton_Click);
            // 
            // XciOutBrowseButton
            // 
            this.XciOutBrowseButton.AutoSize = true;
            this.XciOutBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XciOutBrowseButton.Depth = 0;
            this.XciOutBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.XciOutBrowseButton.Location = new System.Drawing.Point(583, 54);
            this.XciOutBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.XciOutBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciOutBrowseButton.Name = "XciOutBrowseButton";
            this.XciOutBrowseButton.Primary = false;
            this.XciOutBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.XciOutBrowseButton.TabIndex = 21;
            this.XciOutBrowseButton.Text = "Browse";
            this.XciOutBrowseButton.UseVisualStyleBackColor = true;
            this.XciOutBrowseButton.Click += new System.EventHandler(this.XciOutBrowseButton_Click);
            // 
            // XciInBrowseButton
            // 
            this.XciInBrowseButton.AutoSize = true;
            this.XciInBrowseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XciInBrowseButton.Depth = 0;
            this.XciInBrowseButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.XciInBrowseButton.Location = new System.Drawing.Point(583, 6);
            this.XciInBrowseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.XciInBrowseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.XciInBrowseButton.Name = "XciInBrowseButton";
            this.XciInBrowseButton.Primary = false;
            this.XciInBrowseButton.Size = new System.Drawing.Size(67, 36);
            this.XciInBrowseButton.TabIndex = 22;
            this.XciInBrowseButton.Text = "Browse";
            this.XciInBrowseButton.UseVisualStyleBackColor = true;
            this.XciInBrowseButton.Click += new System.EventHandler(this.XciInBrowseButton_Click);
            // 
            // XciInTextbox
            // 
            this.XciInTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.XciInTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.XciInTextbox.Location = new System.Drawing.Point(247, 10);
            this.XciInTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.XciInTextbox.Name = "XciInTextbox";
            this.XciInTextbox.Size = new System.Drawing.Size(325, 29);
            this.XciInTextbox.TabIndex = 17;
            // 
            // XciKeysTextbox
            // 
            this.XciKeysTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.XciKeysTextbox.Location = new System.Drawing.Point(247, 106);
            this.XciKeysTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.XciKeysTextbox.Name = "XciKeysTextbox";
            this.XciKeysTextbox.Size = new System.Drawing.Size(325, 29);
            this.XciKeysTextbox.TabIndex = 19;
            // 
            // XciOutTextbox
            // 
            this.XciOutTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.XciOutTextbox.Location = new System.Drawing.Point(247, 58);
            this.XciOutTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.XciOutTextbox.Name = "XciOutTextbox";
            this.XciOutTextbox.Size = new System.Drawing.Size(325, 29);
            this.XciOutTextbox.TabIndex = 18;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RomFSExtractButton);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.romFSKeysButton);
            this.tabPage4.Controls.Add(this.romFSOutButton);
            this.tabPage4.Controls.Add(this.romFSInButton);
            this.tabPage4.Controls.Add(this.romFSInTextbox);
            this.tabPage4.Controls.Add(this.romFSKeysTextbox);
            this.tabPage4.Controls.Add(this.romFSOutTextbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(665, 187);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "romFS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RomFSExtractButton
            // 
            this.RomFSExtractButton.AutoSize = true;
            this.RomFSExtractButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RomFSExtractButton.Depth = 0;
            this.RomFSExtractButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.RomFSExtractButton.Location = new System.Drawing.Point(29, 151);
            this.RomFSExtractButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RomFSExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RomFSExtractButton.Name = "RomFSExtractButton";
            this.RomFSExtractButton.Primary = false;
            this.RomFSExtractButton.Size = new System.Drawing.Size(72, 36);
            this.RomFSExtractButton.TabIndex = 36;
            this.RomFSExtractButton.Text = "Extract";
            this.RomFSExtractButton.UseVisualStyleBackColor = true;
            this.RomFSExtractButton.Click += new System.EventHandler(this.RomFSExtractButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(31, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "romFS File:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(31, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Switch Keys:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(31, 60);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Output path:";
            // 
            // romFSKeysButton
            // 
            this.romFSKeysButton.AutoSize = true;
            this.romFSKeysButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.romFSKeysButton.Depth = 0;
            this.romFSKeysButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.romFSKeysButton.Location = new System.Drawing.Point(583, 102);
            this.romFSKeysButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.romFSKeysButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.romFSKeysButton.Name = "romFSKeysButton";
            this.romFSKeysButton.Primary = false;
            this.romFSKeysButton.Size = new System.Drawing.Size(67, 36);
            this.romFSKeysButton.TabIndex = 30;
            this.romFSKeysButton.Text = "Browse";
            this.romFSKeysButton.UseVisualStyleBackColor = true;
            this.romFSKeysButton.Click += new System.EventHandler(this.RomFSKeysButton_Click);
            // 
            // romFSOutButton
            // 
            this.romFSOutButton.AutoSize = true;
            this.romFSOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.romFSOutButton.Depth = 0;
            this.romFSOutButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.romFSOutButton.Location = new System.Drawing.Point(583, 54);
            this.romFSOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.romFSOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.romFSOutButton.Name = "romFSOutButton";
            this.romFSOutButton.Primary = false;
            this.romFSOutButton.Size = new System.Drawing.Size(67, 36);
            this.romFSOutButton.TabIndex = 31;
            this.romFSOutButton.Text = "Browse";
            this.romFSOutButton.UseVisualStyleBackColor = true;
            this.romFSOutButton.Click += new System.EventHandler(this.RomFSOutButton_Click);
            // 
            // romFSInButton
            // 
            this.romFSInButton.AutoSize = true;
            this.romFSInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.romFSInButton.Depth = 0;
            this.romFSInButton.Font = new System.Drawing.Font("Roboto", 14F);
            this.romFSInButton.Location = new System.Drawing.Point(583, 6);
            this.romFSInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.romFSInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.romFSInButton.Name = "romFSInButton";
            this.romFSInButton.Primary = false;
            this.romFSInButton.Size = new System.Drawing.Size(67, 36);
            this.romFSInButton.TabIndex = 32;
            this.romFSInButton.Text = "Browse";
            this.romFSInButton.UseVisualStyleBackColor = true;
            this.romFSInButton.Click += new System.EventHandler(this.RomFSInButton_Click);
            // 
            // romFSInTextbox
            // 
            this.romFSInTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.romFSInTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.romFSInTextbox.Location = new System.Drawing.Point(247, 10);
            this.romFSInTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.romFSInTextbox.Name = "romFSInTextbox";
            this.romFSInTextbox.Size = new System.Drawing.Size(325, 29);
            this.romFSInTextbox.TabIndex = 27;
            // 
            // romFSKeysTextbox
            // 
            this.romFSKeysTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.romFSKeysTextbox.Location = new System.Drawing.Point(247, 106);
            this.romFSKeysTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.romFSKeysTextbox.Name = "romFSKeysTextbox";
            this.romFSKeysTextbox.Size = new System.Drawing.Size(325, 29);
            this.romFSKeysTextbox.TabIndex = 29;
            // 
            // romFSOutTextbox
            // 
            this.romFSOutTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.romFSOutTextbox.Location = new System.Drawing.Point(247, 58);
            this.romFSOutTextbox.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.romFSOutTextbox.Name = "romFSOutTextbox";
            this.romFSOutTextbox.Size = new System.Drawing.Size(325, 29);
            this.romFSOutTextbox.TabIndex = 28;
            // 
            // VersionsLabel
            // 
            this.VersionsLabel.AutoSize = true;
            this.VersionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionsLabel.Depth = 0;
            this.VersionsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.VersionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VersionsLabel.Location = new System.Drawing.Point(600, 413);
            this.VersionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.VersionsLabel.Name = "VersionsLabel";
            this.VersionsLabel.Size = new System.Drawing.Size(85, 19);
            this.VersionsLabel.TabIndex = 15;
            this.VersionsLabel.Text = "Version 0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ultimate_Material_Hactool_GUI.Properties.Resources.BigN_Share_community_sig1;
            this.pictureBox1.Location = new System.Drawing.Point(157, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 87);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(673, 39);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(697, 441);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VersionsLabel);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("8BIT WONDER", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.Name = "GUI_Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Material Hactool GUI";
            this.materialTabControl1.ResumeLayout(false);
            this.NsptabPage.ResumeLayout(false);
            this.NsptabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NspOutTextbox;
        private System.Windows.Forms.TextBox NspInTextbox;
        private System.Windows.Forms.TextBox NspKeysTextbox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage NsptabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialFlatButton KeysButton;
        private MaterialSkin.Controls.MaterialFlatButton NspOutButton;
        private MaterialSkin.Controls.MaterialFlatButton NspInButton;
        private MaterialSkin.Controls.MaterialLabel VersionsLabel;
        private MaterialSkin.Controls.MaterialFlatButton NspExtractButton;
        private MaterialSkin.Controls.MaterialLabel NspFileLabel;
        private MaterialSkin.Controls.MaterialLabel NspSwitchKeysLabel;
        private MaterialSkin.Controls.MaterialLabel NspOutoutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton NcaExtractButton;
        private MaterialSkin.Controls.MaterialLabel NcaFileLabel;
        private MaterialSkin.Controls.MaterialLabel NcaSwtichKeysLabel;
        private MaterialSkin.Controls.MaterialLabel NcaOutputLabel;
        private MaterialSkin.Controls.MaterialFlatButton NcaKeysBrowseButton;
        private MaterialSkin.Controls.MaterialFlatButton NcaOutBrowseButton;
        private MaterialSkin.Controls.MaterialFlatButton NcaInBrowseButton;
        private System.Windows.Forms.TextBox NcaInTextbox;
        private System.Windows.Forms.TextBox NcaKeysTextbox;
        private System.Windows.Forms.TextBox NcaOutTextbox;
        private MaterialSkin.Controls.MaterialFlatButton XciExtractButton;
        private MaterialSkin.Controls.MaterialLabel XciFileLabel;
        private MaterialSkin.Controls.MaterialLabel XciSwitchKeysLabel;
        private MaterialSkin.Controls.MaterialLabel XciOutLabel;
        private MaterialSkin.Controls.MaterialFlatButton XciKeysBrowseButton;
        private MaterialSkin.Controls.MaterialFlatButton XciOutBrowseButton;
        private MaterialSkin.Controls.MaterialFlatButton XciInBrowseButton;
        private System.Windows.Forms.TextBox XciInTextbox;
        private System.Windows.Forms.TextBox XciKeysTextbox;
        private System.Windows.Forms.TextBox XciOutTextbox;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton romFSKeysButton;
        private MaterialSkin.Controls.MaterialFlatButton romFSOutButton;
        private MaterialSkin.Controls.MaterialFlatButton romFSInButton;
        private System.Windows.Forms.TextBox romFSInTextbox;
        private System.Windows.Forms.TextBox romFSKeysTextbox;
        private System.Windows.Forms.TextBox romFSOutTextbox;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton RomFSExtractButton;
    }
}