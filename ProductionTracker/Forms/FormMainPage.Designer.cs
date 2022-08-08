
namespace ProductionTracker
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bottles = new FontAwesome.Sharp.IconButton();
            this.unpacking = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnMaximise = new FontAwesome.Sharp.IconButton();
            this.btnMinimise = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblChildFormTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactText = new System.Windows.Forms.RichTextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.bottles);
            this.panelMenu.Controls.Add(this.unpacking);
            this.panelMenu.Controls.Add(this.Dashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // bottles
            // 
            this.bottles.BackColor = System.Drawing.Color.Black;
            this.bottles.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottles.FlatAppearance.BorderSize = 0;
            this.bottles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottles.ForeColor = System.Drawing.Color.White;
            this.bottles.IconChar = FontAwesome.Sharp.IconChar.WineBottle;
            this.bottles.IconColor = System.Drawing.Color.White;
            this.bottles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bottles.IconSize = 38;
            this.bottles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bottles.Location = new System.Drawing.Point(0, 260);
            this.bottles.Name = "bottles";
            this.bottles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bottles.Size = new System.Drawing.Size(220, 60);
            this.bottles.TabIndex = 3;
            this.bottles.Text = "Bottling";
            this.bottles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bottles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bottles.UseVisualStyleBackColor = false;
            this.bottles.Click += new System.EventHandler(this.bottles_Click);
            // 
            // unpacking
            // 
            this.unpacking.BackColor = System.Drawing.Color.Black;
            this.unpacking.Dock = System.Windows.Forms.DockStyle.Top;
            this.unpacking.FlatAppearance.BorderSize = 0;
            this.unpacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpacking.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpacking.ForeColor = System.Drawing.Color.White;
            this.unpacking.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.unpacking.IconColor = System.Drawing.Color.White;
            this.unpacking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.unpacking.IconSize = 38;
            this.unpacking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unpacking.Location = new System.Drawing.Point(0, 200);
            this.unpacking.Name = "unpacking";
            this.unpacking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.unpacking.Size = new System.Drawing.Size(220, 60);
            this.unpacking.TabIndex = 2;
            this.unpacking.Text = "Un-Packing";
            this.unpacking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unpacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unpacking.UseVisualStyleBackColor = false;
            this.unpacking.Click += new System.EventHandler(this.unpacking_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Black;
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.Blackboard;
            this.Dashboard.IconColor = System.Drawing.Color.White;
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 38;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 140);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Dashboard.Size = new System.Drawing.Size(220, 60);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ProductionTracker.Properties.Resources.Patritti_Logo_Est_FINAL_WHITE_RGB;
            this.btnHome.Location = new System.Drawing.Point(12, 35);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 69);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Black;
            this.titleBar.Controls.Add(this.btnMaximise);
            this.titleBar.Controls.Add(this.btnMinimise);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.lblChildFormTitle);
            this.titleBar.Controls.Add(this.iconCurrentChildForm);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(220, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(836, 60);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnMaximise.IconColor = System.Drawing.Color.White;
            this.btnMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximise.IconSize = 20;
            this.btnMaximise.Location = new System.Drawing.Point(787, 2);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Padding = new System.Windows.Forms.Padding(1);
            this.btnMaximise.Size = new System.Drawing.Size(20, 20);
            this.btnMaximise.TabIndex = 4;
            this.btnMaximise.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.IconChar = FontAwesome.Sharp.IconChar.DownLeftAndUpRightToCenter;
            this.btnMinimise.IconColor = System.Drawing.Color.White;
            this.btnMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimise.IconSize = 20;
            this.btnMinimise.Location = new System.Drawing.Point(761, 3);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Padding = new System.Windows.Forms.Padding(1);
            this.btnMinimise.Size = new System.Drawing.Size(20, 20);
            this.btnMinimise.TabIndex = 3;
            this.btnMinimise.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(813, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(1);
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChildFormTitle
            // 
            this.lblChildFormTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChildFormTitle.AutoSize = true;
            this.lblChildFormTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblChildFormTitle.Location = new System.Drawing.Point(420, 20);
            this.lblChildFormTitle.Name = "lblChildFormTitle";
            this.lblChildFormTitle.Size = new System.Drawing.Size(56, 19);
            this.lblChildFormTitle.TabIndex = 1;
            this.lblChildFormTitle.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 38;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(376, 11);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(38, 38);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.contactText);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(836, 490);
            this.panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProductionTracker.Properties.Resources.Patritti_Logo_Est_FINAL_GOLD_RGB;
            this.pictureBox1.Location = new System.Drawing.Point(269, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contactText
            // 
            this.contactText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactText.Location = new System.Drawing.Point(269, 170);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(296, 310);
            this.contactText.TabIndex = 1;
            this.contactText.Text = resources.GetString("contactText.Text");
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 550);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomePage";
            this.Text = "Production Home";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Dashboard;
        private FontAwesome.Sharp.IconButton bottles;
        private FontAwesome.Sharp.IconButton unpacking;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel titleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblChildFormTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMaximise;
        private FontAwesome.Sharp.IconButton btnMinimise;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.RichTextBox contactText;
    }
}

