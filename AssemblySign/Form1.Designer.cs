namespace AssemblySign
{
    partial class MainForm
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
            this._btnBrowseAssemblyFolder = new System.Windows.Forms.Button();
            this._txtFolder = new System.Windows.Forms.TextBox();
            this._assemblies = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this._assemblyFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._assemblyPath = new System.Windows.Forms.TextBox();
            this._chkIsSigned = new System.Windows.Forms.CheckBox();
            this._signAssembly = new System.Windows.Forms.Button();
            this._txtKeyFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnBrowseKeyFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnBrowseAssemblyFolder
            // 
            this._btnBrowseAssemblyFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBrowseAssemblyFolder.Location = new System.Drawing.Point(671, 10);
            this._btnBrowseAssemblyFolder.Name = "_btnBrowseAssemblyFolder";
            this._btnBrowseAssemblyFolder.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseAssemblyFolder.TabIndex = 0;
            this._btnBrowseAssemblyFolder.Text = "&Browse";
            this._btnBrowseAssemblyFolder.UseVisualStyleBackColor = true;
            this._btnBrowseAssemblyFolder.Click += new System.EventHandler(this.BtnBrowseAssemblyFolderClick);
            // 
            // _txtFolder
            // 
            this._txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFolder.Location = new System.Drawing.Point(100, 12);
            this._txtFolder.Name = "_txtFolder";
            this._txtFolder.Size = new System.Drawing.Size(565, 20);
            this._txtFolder.TabIndex = 1;
            this._txtFolder.Text = "D:\\dev\\Rothko";
            // 
            // _assemblies
            // 
            this._assemblies.Location = new System.Drawing.Point(12, 84);
            this._assemblies.Name = "_assemblies";
            this._assemblies.ShowGroups = false;
            this._assemblies.Size = new System.Drawing.Size(249, 378);
            this._assemblies.TabIndex = 2;
            this._assemblies.UseCompatibleStateImageBehavior = false;
            this._assemblies.View = System.Windows.Forms.View.List;
            this._assemblies.SelectedIndexChanged += new System.EventHandler(this.AssembliesSelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._assemblyFullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._assemblyPath);
            this.groupBox1.Controls.Add(this._chkIsSigned);
            this.groupBox1.Controls.Add(this._signAssembly);
            this.groupBox1.Location = new System.Drawing.Point(281, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 378);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assembly Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Assembly Name";
            // 
            // _assemblyFullName
            // 
            this._assemblyFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assemblyFullName.Enabled = false;
            this._assemblyFullName.Location = new System.Drawing.Point(111, 54);
            this._assemblyFullName.Multiline = true;
            this._assemblyFullName.Name = "_assemblyFullName";
            this._assemblyFullName.Size = new System.Drawing.Size(348, 223);
            this._assemblyFullName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Path";
            // 
            // _assemblyPath
            // 
            this._assemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assemblyPath.Enabled = false;
            this._assemblyPath.Location = new System.Drawing.Point(111, 28);
            this._assemblyPath.Name = "_assemblyPath";
            this._assemblyPath.Size = new System.Drawing.Size(348, 20);
            this._assemblyPath.TabIndex = 2;
            // 
            // _chkIsSigned
            // 
            this._chkIsSigned.Enabled = false;
            this._chkIsSigned.Location = new System.Drawing.Point(26, 310);
            this._chkIsSigned.Name = "_chkIsSigned";
            this._chkIsSigned.Size = new System.Drawing.Size(266, 24);
            this._chkIsSigned.TabIndex = 1;
            this._chkIsSigned.Text = "Assembly is signed";
            this._chkIsSigned.UseVisualStyleBackColor = true;
            // 
            // _signAssembly
            // 
            this._signAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._signAssembly.Location = new System.Drawing.Point(298, 349);
            this._signAssembly.Name = "_signAssembly";
            this._signAssembly.Size = new System.Drawing.Size(161, 23);
            this._signAssembly.TabIndex = 0;
            this._signAssembly.Text = "&Sign The Assembly";
            this._signAssembly.UseVisualStyleBackColor = true;
            this._signAssembly.Click += new System.EventHandler(this.SignAssemblyClick);
            // 
            // _txtKeyFile
            // 
            this._txtKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtKeyFile.Location = new System.Drawing.Point(100, 47);
            this._txtKeyFile.Name = "_txtKeyFile";
            this._txtKeyFile.Size = new System.Drawing.Size(565, 20);
            this._txtKeyFile.TabIndex = 4;
            this._txtKeyFile.Text = "c:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Assembly Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key file";
            // 
            // _btnBrowseKeyFile
            // 
            this._btnBrowseKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBrowseKeyFile.Location = new System.Drawing.Point(671, 45);
            this._btnBrowseKeyFile.Name = "_btnBrowseKeyFile";
            this._btnBrowseKeyFile.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseKeyFile.TabIndex = 7;
            this._btnBrowseKeyFile.Text = "&Browse";
            this._btnBrowseKeyFile.UseVisualStyleBackColor = true;
            this._btnBrowseKeyFile.Click += new System.EventHandler(this.BtnBrowseKeyFileClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 487);
            this.Controls.Add(this._btnBrowseKeyFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtKeyFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._assemblies);
            this.Controls.Add(this._txtFolder);
            this.Controls.Add(this._btnBrowseAssemblyFolder);
            this.Name = "MainForm";
            this.Text = "Assembly Sign";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnBrowseAssemblyFolder;
        private System.Windows.Forms.TextBox _txtFolder;
        private System.Windows.Forms.ListView _assemblies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _signAssembly;
        private System.Windows.Forms.TextBox _txtKeyFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnBrowseKeyFile;
        private System.Windows.Forms.CheckBox _chkIsSigned;
        private System.Windows.Forms.TextBox _assemblyPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _assemblyFullName;
    }
}

