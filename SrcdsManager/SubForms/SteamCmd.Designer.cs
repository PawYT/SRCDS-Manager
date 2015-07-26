namespace SrcdsManager.SubForms
{
    partial class SteamCmd
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
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.CheckBox();
            this.browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.Location = new System.Drawing.Point(12, 25);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(260, 20);
            this.path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SteamCmd Folder:";
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(197, 51);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Location = new System.Drawing.Point(28, 55);
            this.download.Name = "download";
            this.download.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.download.Size = new System.Drawing.Size(74, 17);
            this.download.TabIndex = 3;
            this.download.Text = ":Download";
            this.download.UseVisualStyleBackColor = true;
            // 
            // browse
            // 
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Location = new System.Drawing.Point(116, 51);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // SteamCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.download);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SteamCmd";
            this.Text = "SteamCmd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox download;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}