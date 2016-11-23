namespace PasswordEncryption
{
    partial class Main
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
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfigDirectory = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkWoff2 = new System.Windows.Forms.CheckBox();
            this.chkTs = new System.Windows.Forms.CheckBox();
            this.chkJson = new System.Windows.Forms.CheckBox();
            this.chkCshtml = new System.Windows.Forms.CheckBox();
            this.chkConfig = new System.Windows.Forms.CheckBox();
            this.chkRdlc = new System.Windows.Forms.CheckBox();
            this.chkEot = new System.Windows.Forms.CheckBox();
            this.chkSvg = new System.Windows.Forms.CheckBox();
            this.chkWoff = new System.Windows.Forms.CheckBox();
            this.chkTtf = new System.Windows.Forms.CheckBox();
            this.chkJpg = new System.Windows.Forms.CheckBox();
            this.chkGif = new System.Windows.Forms.CheckBox();
            this.chkPng = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.chkDll = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.tabPageConfigDate = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkEmptyTargetFolder = new System.Windows.Forms.CheckBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConfigDirectory.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(675, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogs);
            this.groupBox3.Location = new System.Drawing.Point(12, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 132);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfigDirectory);
            this.tabControl1.Controls.Add(this.tabPageConfigDate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 427);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageConfigDirectory
            // 
            this.tabPageConfigDirectory.Controls.Add(this.groupBox4);
            this.tabPageConfigDirectory.Controls.Add(this.dtpDate);
            this.tabPageConfigDirectory.Controls.Add(this.label3);
            this.tabPageConfigDirectory.Controls.Add(this.groupBox2);
            this.tabPageConfigDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConfigDirectory.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigDirectory.Name = "tabPageConfigDirectory";
            this.tabPageConfigDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigDirectory.Size = new System.Drawing.Size(730, 401);
            this.tabPageConfigDirectory.TabIndex = 0;
            this.tabPageConfigDirectory.Text = "General setting";
            this.tabPageConfigDirectory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkWoff2);
            this.groupBox4.Controls.Add(this.chkTs);
            this.groupBox4.Controls.Add(this.chkJson);
            this.groupBox4.Controls.Add(this.chkCshtml);
            this.groupBox4.Controls.Add(this.chkConfig);
            this.groupBox4.Controls.Add(this.chkRdlc);
            this.groupBox4.Controls.Add(this.chkEot);
            this.groupBox4.Controls.Add(this.chkSvg);
            this.groupBox4.Controls.Add(this.chkWoff);
            this.groupBox4.Controls.Add(this.chkTtf);
            this.groupBox4.Controls.Add(this.chkJpg);
            this.groupBox4.Controls.Add(this.chkGif);
            this.groupBox4.Controls.Add(this.chkPng);
            this.groupBox4.Controls.Add(this.chkAll);
            this.groupBox4.Controls.Add(this.chkCss);
            this.groupBox4.Controls.Add(this.chkJs);
            this.groupBox4.Controls.Add(this.chkHtml);
            this.groupBox4.Controls.Add(this.chkDll);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(705, 146);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Includes file extensions";
            // 
            // chkWoff2
            // 
            this.chkWoff2.AutoSize = true;
            this.chkWoff2.Checked = true;
            this.chkWoff2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWoff2.Location = new System.Drawing.Point(144, 64);
            this.chkWoff2.Name = "chkWoff2";
            this.chkWoff2.Size = new System.Drawing.Size(63, 17);
            this.chkWoff2.TabIndex = 17;
            this.chkWoff2.Text = "WOFF2";
            this.chkWoff2.UseVisualStyleBackColor = true;
            // 
            // chkTs
            // 
            this.chkTs.AutoSize = true;
            this.chkTs.Checked = true;
            this.chkTs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTs.Location = new System.Drawing.Point(415, 19);
            this.chkTs.Name = "chkTs";
            this.chkTs.Size = new System.Drawing.Size(94, 17);
            this.chkTs.TabIndex = 16;
            this.chkTs.Text = "TS (typescript)";
            this.chkTs.UseVisualStyleBackColor = true;
            // 
            // chkJson
            // 
            this.chkJson.AutoSize = true;
            this.chkJson.Checked = true;
            this.chkJson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJson.Location = new System.Drawing.Point(355, 19);
            this.chkJson.Name = "chkJson";
            this.chkJson.Size = new System.Drawing.Size(54, 17);
            this.chkJson.TabIndex = 15;
            this.chkJson.Text = "JSON";
            this.chkJson.UseVisualStyleBackColor = true;
            // 
            // chkCshtml
            // 
            this.chkCshtml.AutoSize = true;
            this.chkCshtml.Checked = true;
            this.chkCshtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCshtml.Location = new System.Drawing.Point(279, 19);
            this.chkCshtml.Name = "chkCshtml";
            this.chkCshtml.Size = new System.Drawing.Size(70, 17);
            this.chkCshtml.TabIndex = 14;
            this.chkCshtml.Text = "CSHTML";
            this.chkCshtml.UseVisualStyleBackColor = true;
            // 
            // chkConfig
            // 
            this.chkConfig.AutoSize = true;
            this.chkConfig.Checked = true;
            this.chkConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfig.Location = new System.Drawing.Point(144, 87);
            this.chkConfig.Name = "chkConfig";
            this.chkConfig.Size = new System.Drawing.Size(66, 17);
            this.chkConfig.TabIndex = 13;
            this.chkConfig.Text = "CONFIG";
            this.chkConfig.UseVisualStyleBackColor = true;
            // 
            // chkRdlc
            // 
            this.chkRdlc.AutoSize = true;
            this.chkRdlc.Checked = true;
            this.chkRdlc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRdlc.Location = new System.Drawing.Point(9, 87);
            this.chkRdlc.Name = "chkRdlc";
            this.chkRdlc.Size = new System.Drawing.Size(91, 17);
            this.chkRdlc.TabIndex = 12;
            this.chkRdlc.Text = "RDLC (report)";
            this.chkRdlc.UseVisualStyleBackColor = true;
            // 
            // chkEot
            // 
            this.chkEot.AutoSize = true;
            this.chkEot.Checked = true;
            this.chkEot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEot.Location = new System.Drawing.Point(279, 64);
            this.chkEot.Name = "chkEot";
            this.chkEot.Size = new System.Drawing.Size(48, 17);
            this.chkEot.TabIndex = 11;
            this.chkEot.Text = "EOT";
            this.chkEot.UseVisualStyleBackColor = true;
            // 
            // chkSvg
            // 
            this.chkSvg.AutoSize = true;
            this.chkSvg.Checked = true;
            this.chkSvg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSvg.Location = new System.Drawing.Point(8, 64);
            this.chkSvg.Name = "chkSvg";
            this.chkSvg.Size = new System.Drawing.Size(48, 17);
            this.chkSvg.TabIndex = 10;
            this.chkSvg.Text = "SVG";
            this.chkSvg.UseVisualStyleBackColor = true;
            // 
            // chkWoff
            // 
            this.chkWoff.AutoSize = true;
            this.chkWoff.Checked = true;
            this.chkWoff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWoff.Location = new System.Drawing.Point(74, 64);
            this.chkWoff.Name = "chkWoff";
            this.chkWoff.Size = new System.Drawing.Size(57, 17);
            this.chkWoff.TabIndex = 9;
            this.chkWoff.Text = "WOFF";
            this.chkWoff.UseVisualStyleBackColor = true;
            // 
            // chkTtf
            // 
            this.chkTtf.AutoSize = true;
            this.chkTtf.Checked = true;
            this.chkTtf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTtf.Location = new System.Drawing.Point(215, 64);
            this.chkTtf.Name = "chkTtf";
            this.chkTtf.Size = new System.Drawing.Size(46, 17);
            this.chkTtf.TabIndex = 8;
            this.chkTtf.Text = "TTF";
            this.chkTtf.UseVisualStyleBackColor = true;
            // 
            // chkJpg
            // 
            this.chkJpg.AutoSize = true;
            this.chkJpg.Checked = true;
            this.chkJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpg.Location = new System.Drawing.Point(144, 42);
            this.chkJpg.Name = "chkJpg";
            this.chkJpg.Size = new System.Drawing.Size(46, 17);
            this.chkJpg.TabIndex = 7;
            this.chkJpg.Text = "JPG";
            this.chkJpg.UseVisualStyleBackColor = true;
            // 
            // chkGif
            // 
            this.chkGif.AutoSize = true;
            this.chkGif.Checked = true;
            this.chkGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGif.Location = new System.Drawing.Point(74, 42);
            this.chkGif.Name = "chkGif";
            this.chkGif.Size = new System.Drawing.Size(43, 17);
            this.chkGif.TabIndex = 6;
            this.chkGif.Text = "GIF";
            this.chkGif.UseVisualStyleBackColor = true;
            // 
            // chkPng
            // 
            this.chkPng.AutoSize = true;
            this.chkPng.Checked = true;
            this.chkPng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPng.Location = new System.Drawing.Point(8, 42);
            this.chkPng.Name = "chkPng";
            this.chkPng.Size = new System.Drawing.Size(49, 17);
            this.chkPng.TabIndex = 5;
            this.chkPng.Text = "PNG";
            this.chkPng.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(9, 115);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 17);
            this.chkAll.TabIndex = 4;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCss.Location = new System.Drawing.Point(215, 19);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(47, 17);
            this.chkCss.TabIndex = 3;
            this.chkCss.Text = "CSS";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Checked = true;
            this.chkJs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJs.Location = new System.Drawing.Point(74, 19);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(38, 17);
            this.chkJs.TabIndex = 2;
            this.chkJs.Text = "JS";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHtml.Location = new System.Drawing.Point(144, 19);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(56, 17);
            this.chkHtml.TabIndex = 1;
            this.chkHtml.Text = "HTML";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // chkDll
            // 
            this.chkDll.AutoSize = true;
            this.chkDll.Checked = true;
            this.chkDll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDll.Location = new System.Drawing.Point(9, 19);
            this.chkDll.Name = "chkDll";
            this.chkDll.Size = new System.Drawing.Size(46, 17);
            this.chkDll.TabIndex = 0;
            this.chkDll.Text = "DLL";
            this.chkDll.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(13, 206);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modified date of files should be copied from";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSource);
            this.groupBox2.Controls.Add(this.btnBrowseDestination);
            this.groupBox2.Controls.Add(this.btnBrowseSource);
            this.groupBox2.Controls.Add(this.txtDestination);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.ForeColor = System.Drawing.Color.Green;
            this.txtSource.Location = new System.Drawing.Point(6, 39);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(612, 32);
            this.txtSource.TabIndex = 0;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDestination.Location = new System.Drawing.Point(625, 91);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(75, 32);
            this.btnBrowseDestination.TabIndex = 4;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSource.Location = new System.Drawing.Point(624, 36);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 32);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.ForeColor = System.Drawing.Color.Blue;
            this.txtDestination.Location = new System.Drawing.Point(6, 94);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(612, 32);
            this.txtDestination.TabIndex = 3;
            // 
            // tabPageConfigDate
            // 
            this.tabPageConfigDate.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigDate.Name = "tabPageConfigDate";
            this.tabPageConfigDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigDate.Size = new System.Drawing.Size(730, 447);
            this.tabPageConfigDate.TabIndex = 1;
            this.tabPageConfigDate.Text = "Date setting";
            this.tabPageConfigDate.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(594, 584);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 31);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkEmptyTargetFolder
            // 
            this.chkEmptyTargetFolder.AutoSize = true;
            this.chkEmptyTargetFolder.Checked = true;
            this.chkEmptyTargetFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmptyTargetFolder.Location = new System.Drawing.Point(474, 592);
            this.chkEmptyTargetFolder.Name = "chkEmptyTargetFolder";
            this.chkEmptyTargetFolder.Size = new System.Drawing.Size(114, 17);
            this.chkEmptyTargetFolder.TabIndex = 10;
            this.chkEmptyTargetFolder.Text = "Empty target folder";
            this.chkEmptyTargetFolder.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(6, 19);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(726, 107);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 627);
            this.Controls.Add(this.chkEmptyTargetFolder);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Name = "Main";
            this.Text = "Deployment";
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfigDirectory.ResumeLayout(false);
            this.tabPageConfigDirectory.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfigDirectory;
        private System.Windows.Forms.TabPage tabPageConfigDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.CheckBox chkDll;
        private System.Windows.Forms.CheckBox chkPng;
        private System.Windows.Forms.CheckBox chkJpg;
        private System.Windows.Forms.CheckBox chkGif;
        private System.Windows.Forms.CheckBox chkEot;
        private System.Windows.Forms.CheckBox chkSvg;
        private System.Windows.Forms.CheckBox chkWoff;
        private System.Windows.Forms.CheckBox chkTtf;
        private System.Windows.Forms.CheckBox chkRdlc;
        private System.Windows.Forms.CheckBox chkCshtml;
        private System.Windows.Forms.CheckBox chkConfig;
        private System.Windows.Forms.CheckBox chkJson;
        private System.Windows.Forms.CheckBox chkTs;
        private System.Windows.Forms.CheckBox chkWoff2;
        private System.Windows.Forms.CheckBox chkEmptyTargetFolder;
        private System.Windows.Forms.RichTextBox txtLogs;
    }
}

