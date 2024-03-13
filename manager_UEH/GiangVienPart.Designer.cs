namespace manager_UEH
{
    partial class GiangVienPart
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.avarInfo = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.avar = new System.Windows.Forms.PictureBox();
            this.class_pn = new System.Windows.Forms.Panel();
            this.class_btn = new System.Windows.Forms.Button();
            this.essay_pn = new System.Windows.Forms.Panel();
            this.essay_btn = new System.Windows.Forms.Button();
            this.choice_pn = new System.Windows.Forms.Panel();
            this.choice_btn = new System.Windows.Forms.Button();
            this.search_pn = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.avarInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avar)).BeginInit();
            this.class_pn.SuspendLayout();
            this.essay_pn.SuspendLayout();
            this.choice_pn.SuspendLayout();
            this.search_pn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.sidebar.Controls.Add(this.pl_menu);
            this.sidebar.Controls.Add(this.avarInfo);
            this.sidebar.Controls.Add(this.class_pn);
            this.sidebar.Controls.Add(this.essay_pn);
            this.sidebar.Controls.Add(this.choice_pn);
            this.sidebar.Controls.Add(this.search_pn);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(287, 685);
            this.sidebar.MinimumSize = new System.Drawing.Size(78, 685);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(287, 685);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pl_menu.Controls.Add(this.label2);
            this.pl_menu.Controls.Add(this.pictureBox2);
            this.pl_menu.Location = new System.Drawing.Point(3, 3);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(284, 54);
            this.pl_menu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(85, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::manager_UEH.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(0, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // avarInfo
            // 
            this.avarInfo.BackColor = System.Drawing.Color.Gray;
            this.avarInfo.Controls.Add(this.info);
            this.avarInfo.Controls.Add(this.avar);
            this.avarInfo.Location = new System.Drawing.Point(3, 63);
            this.avarInfo.MaximumSize = new System.Drawing.Size(284, 166);
            this.avarInfo.MinimumSize = new System.Drawing.Size(284, 46);
            this.avarInfo.Name = "avarInfo";
            this.avarInfo.Size = new System.Drawing.Size(284, 166);
            this.avarInfo.TabIndex = 1;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info.Location = new System.Drawing.Point(140, 71);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(110, 28);
            this.info.TabIndex = 1;
            this.info.Text = "Username";
            // 
            // avar
            // 
            this.avar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avar.Image = global::manager_UEH.Properties.Resources.avatar;
            this.avar.Location = new System.Drawing.Point(30, 35);
            this.avar.MaximumSize = new System.Drawing.Size(95, 96);
            this.avar.MinimumSize = new System.Drawing.Size(50, 50);
            this.avar.Name = "avar";
            this.avar.Size = new System.Drawing.Size(95, 96);
            this.avar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avar.TabIndex = 0;
            this.avar.TabStop = false;
            // 
            // class_pn
            // 
            this.class_pn.Controls.Add(this.class_btn);
            this.class_pn.Location = new System.Drawing.Point(3, 235);
            this.class_pn.Name = "class_pn";
            this.class_pn.Size = new System.Drawing.Size(284, 46);
            this.class_pn.TabIndex = 2;
            // 
            // class_btn
            // 
            this.class_btn.BackColor = System.Drawing.Color.Transparent;
            this.class_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.class_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.class_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.class_btn.Image = global::manager_UEH.Properties.Resources.class1;
            this.class_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class_btn.Location = new System.Drawing.Point(-10, -14);
            this.class_btn.Name = "class_btn";
            this.class_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.class_btn.Size = new System.Drawing.Size(315, 72);
            this.class_btn.TabIndex = 0;
            this.class_btn.Text = "               Lớp học";
            this.class_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class_btn.UseVisualStyleBackColor = false;
            this.class_btn.Click += new System.EventHandler(this.class_btn_Click);
            // 
            // essay_pn
            // 
            this.essay_pn.Controls.Add(this.essay_btn);
            this.essay_pn.Location = new System.Drawing.Point(3, 287);
            this.essay_pn.Name = "essay_pn";
            this.essay_pn.Size = new System.Drawing.Size(284, 46);
            this.essay_pn.TabIndex = 5;
            // 
            // essay_btn
            // 
            this.essay_btn.BackColor = System.Drawing.Color.Transparent;
            this.essay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.essay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.essay_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.essay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.essay_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essay_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.essay_btn.Image = global::manager_UEH.Properties.Resources.Tuluan__1_;
            this.essay_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.essay_btn.Location = new System.Drawing.Point(-10, -14);
            this.essay_btn.Name = "essay_btn";
            this.essay_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.essay_btn.Size = new System.Drawing.Size(315, 72);
            this.essay_btn.TabIndex = 0;
            this.essay_btn.Text = "               Môn học";
            this.essay_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.essay_btn.UseVisualStyleBackColor = false;
            this.essay_btn.Click += new System.EventHandler(this.essay_btn_Click);
            // 
            // choice_pn
            // 
            this.choice_pn.Controls.Add(this.choice_btn);
            this.choice_pn.Location = new System.Drawing.Point(3, 339);
            this.choice_pn.Name = "choice_pn";
            this.choice_pn.Size = new System.Drawing.Size(284, 46);
            this.choice_pn.TabIndex = 6;
            // 
            // choice_btn
            // 
            this.choice_btn.BackColor = System.Drawing.Color.Transparent;
            this.choice_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choice_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.choice_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.choice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choice_btn.Image = global::manager_UEH.Properties.Resources.vote__2___1_;
            this.choice_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice_btn.Location = new System.Drawing.Point(-10, -14);
            this.choice_btn.Name = "choice_btn";
            this.choice_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.choice_btn.Size = new System.Drawing.Size(315, 72);
            this.choice_btn.TabIndex = 0;
            this.choice_btn.Text = "               Lịch giảng dạy";
            this.choice_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice_btn.UseVisualStyleBackColor = false;
            // 
            // search_pn
            // 
            this.search_pn.Controls.Add(this.search_btn);
            this.search_pn.Location = new System.Drawing.Point(3, 391);
            this.search_pn.Name = "search_pn";
            this.search_pn.Size = new System.Drawing.Size(284, 46);
            this.search_pn.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Image = global::manager_UEH.Properties.Resources.search__2_;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(-10, -14);
            this.search_btn.Name = "search_btn";
            this.search_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.search_btn.Size = new System.Drawing.Size(315, 72);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "               Tài liệu";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 46);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::manager_UEH.Properties.Resources.search__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-10, -14);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(315, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "               Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 685);
            this.panel1.TabIndex = 3;
            // 
            // GiangVienPart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiangVienPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVienPart";
            this.sidebar.ResumeLayout(false);
            this.pl_menu.ResumeLayout(false);
            this.pl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.avarInfo.ResumeLayout(false);
            this.avarInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avar)).EndInit();
            this.class_pn.ResumeLayout(false);
            this.essay_pn.ResumeLayout(false);
            this.choice_pn.ResumeLayout(false);
            this.search_pn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel avarInfo;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox avar;
        private System.Windows.Forms.Panel class_pn;
        private System.Windows.Forms.Button class_btn;
        private System.Windows.Forms.Panel essay_pn;
        private System.Windows.Forms.Button essay_btn;
        private System.Windows.Forms.Panel choice_pn;
        private System.Windows.Forms.Button choice_btn;
        private System.Windows.Forms.Panel search_pn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}