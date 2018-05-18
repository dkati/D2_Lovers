namespace D2_Lovers
{
    partial class Form1
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
            this.cb_d2se = new System.Windows.Forms.CheckBox();
            this.cb_plugy = new System.Windows.Forms.CheckBox();
            this.cb_median = new System.Windows.Forms.CheckBox();
            this.cb_d2multires = new System.Windows.Forms.CheckBox();
            this.cb_d2mr = new System.Windows.Forms.CheckBox();
            this.gb_plugins = new System.Windows.Forms.GroupBox();
            this.gb_patch = new System.Windows.Forms.GroupBox();
            this.rb_112 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fontfixer = new System.Windows.Forms.CheckBox();
            this.cb_glide = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_install = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_plugins.SuspendLayout();
            this.gb_patch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_d2se
            // 
            this.cb_d2se.AutoSize = true;
            this.cb_d2se.Location = new System.Drawing.Point(10, 85);
            this.cb_d2se.Name = "cb_d2se";
            this.cb_d2se.Size = new System.Drawing.Size(54, 17);
            this.cb_d2se.TabIndex = 0;
            this.cb_d2se.Text = "D2SE";
            this.cb_d2se.UseVisualStyleBackColor = true;
            // 
            // cb_plugy
            // 
            this.cb_plugy.AutoSize = true;
            this.cb_plugy.Location = new System.Drawing.Point(10, 108);
            this.cb_plugy.Name = "cb_plugy";
            this.cb_plugy.Size = new System.Drawing.Size(54, 17);
            this.cb_plugy.TabIndex = 0;
            this.cb_plugy.Text = "PlugY";
            this.cb_plugy.UseVisualStyleBackColor = true;
            // 
            // cb_median
            // 
            this.cb_median.AutoSize = true;
            this.cb_median.Location = new System.Drawing.Point(10, 131);
            this.cb_median.Name = "cb_median";
            this.cb_median.Size = new System.Drawing.Size(109, 17);
            this.cb_median.TabIndex = 0;
            this.cb_median.Text = "Latest Median XL";
            this.cb_median.UseVisualStyleBackColor = true;
            // 
            // cb_d2multires
            // 
            this.cb_d2multires.AutoSize = true;
            this.cb_d2multires.Location = new System.Drawing.Point(10, 154);
            this.cb_d2multires.Name = "cb_d2multires";
            this.cb_d2multires.Size = new System.Drawing.Size(84, 17);
            this.cb_d2multires.TabIndex = 0;
            this.cb_d2multires.Text = "D2 MultiRes";
            this.cb_d2multires.UseVisualStyleBackColor = true;
            // 
            // cb_d2mr
            // 
            this.cb_d2mr.AutoSize = true;
            this.cb_d2mr.Location = new System.Drawing.Point(10, 177);
            this.cb_d2mr.Name = "cb_d2mr";
            this.cb_d2mr.Size = new System.Drawing.Size(57, 17);
            this.cb_d2mr.TabIndex = 0;
            this.cb_d2mr.Text = "D2MR";
            this.cb_d2mr.UseVisualStyleBackColor = true;
            // 
            // gb_plugins
            // 
            this.gb_plugins.Controls.Add(this.gb_patch);
            this.gb_plugins.Controls.Add(this.cb_fontfixer);
            this.gb_plugins.Controls.Add(this.cb_d2se);
            this.gb_plugins.Controls.Add(this.cb_glide);
            this.gb_plugins.Controls.Add(this.cb_d2multires);
            this.gb_plugins.Controls.Add(this.cb_median);
            this.gb_plugins.Controls.Add(this.cb_d2mr);
            this.gb_plugins.Controls.Add(this.cb_plugy);
            this.gb_plugins.Location = new System.Drawing.Point(12, 27);
            this.gb_plugins.Name = "gb_plugins";
            this.gb_plugins.Size = new System.Drawing.Size(258, 248);
            this.gb_plugins.TabIndex = 2;
            this.gb_plugins.TabStop = false;
            this.gb_plugins.Text = "Plugins";
            // 
            // gb_patch
            // 
            this.gb_patch.Controls.Add(this.rb_112);
            this.gb_patch.Controls.Add(this.label1);
            this.gb_patch.Location = new System.Drawing.Point(10, 20);
            this.gb_patch.Name = "gb_patch";
            this.gb_patch.Size = new System.Drawing.Size(237, 59);
            this.gb_patch.TabIndex = 4;
            this.gb_patch.TabStop = false;
            this.gb_patch.Text = "Patch Selection";
            // 
            // rb_112
            // 
            this.rb_112.AutoSize = true;
            this.rb_112.Checked = true;
            this.rb_112.Location = new System.Drawing.Point(50, 22);
            this.rb_112.Name = "rb_112";
            this.rb_112.Size = new System.Drawing.Size(46, 17);
            this.rb_112.TabIndex = 3;
            this.rb_112.TabStop = true;
            this.rb_112.Text = "1.12";
            this.rb_112.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patch:";
            // 
            // cb_fontfixer
            // 
            this.cb_fontfixer.AutoSize = true;
            this.cb_fontfixer.Location = new System.Drawing.Point(10, 224);
            this.cb_fontfixer.Name = "cb_fontfixer";
            this.cb_fontfixer.Size = new System.Drawing.Size(69, 17);
            this.cb_fontfixer.TabIndex = 3;
            this.cb_fontfixer.Text = "Font fixer";
            this.cb_fontfixer.UseVisualStyleBackColor = true;
            // 
            // cb_glide
            // 
            this.cb_glide.AutoSize = true;
            this.cb_glide.Location = new System.Drawing.Point(10, 200);
            this.cb_glide.Name = "cb_glide";
            this.cb_glide.Size = new System.Drawing.Size(94, 17);
            this.cb_glide.TabIndex = 0;
            this.cb_glide.Text = "Glide Wrapper";
            this.cb_glide.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.contactToolStripMenuItem.Text = "About";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(19, 310);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(247, 78);
            this.btn_install.TabIndex = 5;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Warning: Diablo\'s root path has to be: C:\\Diablo II\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.gb_plugins);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_plugins.ResumeLayout(false);
            this.gb_plugins.PerformLayout();
            this.gb_patch.ResumeLayout(false);
            this.gb_patch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_d2se;
        private System.Windows.Forms.CheckBox cb_plugy;
        private System.Windows.Forms.CheckBox cb_median;
        private System.Windows.Forms.CheckBox cb_d2multires;
        private System.Windows.Forms.CheckBox cb_d2mr;
        private System.Windows.Forms.GroupBox gb_plugins;
        private System.Windows.Forms.CheckBox cb_fontfixer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_glide;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_patch;
        private System.Windows.Forms.RadioButton rb_112;
    }
}

