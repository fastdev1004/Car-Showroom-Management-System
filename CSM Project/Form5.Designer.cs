﻿namespace CSM_Project
{
    partial class SaleManCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManCtrl));
            this.hireBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.contactBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.addressBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.pinBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.emailBoxErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameExpLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBoxErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBoxErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // hireBtn
            // 
            this.hireBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.hireBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hireBtn.FlatAppearance.BorderSize = 0;
            this.hireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireBtn.ForeColor = System.Drawing.Color.White;
            this.hireBtn.Location = new System.Drawing.Point(303, 389);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(88, 53);
            this.hireBtn.TabIndex = 2;
            this.hireBtn.Text = "Hire";
            this.hireBtn.UseVisualStyleBackColor = false;
            this.hireBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hireBtn_MouseClick_1);
            this.hireBtn.MouseEnter += new System.EventHandler(this.hireBtn_MouseEnter);
            this.hireBtn.MouseLeave += new System.EventHandler(this.hireBtn_MouseLeave);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(62, 148);
            this.nameBox.MaxLength = 25;
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 28);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // pinBox
            // 
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.Location = new System.Drawing.Point(505, 148);
            this.pinBox.MaxLength = 8;
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(300, 28);
            this.pinBox.TabIndex = 4;
            this.pinBox.TextChanged += new System.EventHandler(this.pinBox_TextChanged);
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinBox_KeyPress);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // contactBox
            // 
            this.contactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactBox.Location = new System.Drawing.Point(62, 224);
            this.contactBox.MaxLength = 11;
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(300, 28);
            this.contactBox.TabIndex = 5;
            this.contactBox.TextChanged += new System.EventHandler(this.contactBox_TextChanged);
            this.contactBox.Enter += new System.EventHandler(this.contactBox_Enter);
            this.contactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactBox_KeyPress);
            this.contactBox.Leave += new System.EventHandler(this.contactBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(505, 224);
            this.addressBox.MaxLength = 50;
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(300, 28);
            this.addressBox.TabIndex = 6;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox_KeyPress);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(283, 297);
            this.emailBox.MaxLength = 25;
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(300, 28);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            this.emailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailBox_KeyPress);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label2.Location = new System.Drawing.Point(500, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label4.Location = new System.Drawing.Point(57, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label5.Location = new System.Drawing.Point(500, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label6.Location = new System.Drawing.Point(387, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(455, 389);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(88, 53);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateBtn_MouseClick);
            this.updateBtn.MouseEnter += new System.EventHandler(this.updateBtn_MouseEnter);
            this.updateBtn.MouseLeave += new System.EventHandler(this.updateBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 79);
            this.panel1.TabIndex = 42;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 79);
            this.backBtn.TabIndex = 41;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(837, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Employee\'s Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(260, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // nameBoxErrorIcon
            // 
            this.nameBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameBoxErrorIcon.BackgroundImage")));
            this.nameBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nameBoxErrorIcon.Location = new System.Drawing.Point(338, 150);
            this.nameBoxErrorIcon.Name = "nameBoxErrorIcon";
            this.nameBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.nameBoxErrorIcon.TabIndex = 43;
            this.nameBoxErrorIcon.TabStop = false;
            // 
            // contactBoxErrorIcon
            // 
            this.contactBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.contactBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactBoxErrorIcon.BackgroundImage")));
            this.contactBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contactBoxErrorIcon.Location = new System.Drawing.Point(338, 226);
            this.contactBoxErrorIcon.Name = "contactBoxErrorIcon";
            this.contactBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.contactBoxErrorIcon.TabIndex = 44;
            this.contactBoxErrorIcon.TabStop = false;
            // 
            // addressBoxErrorIcon
            // 
            this.addressBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.addressBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addressBoxErrorIcon.BackgroundImage")));
            this.addressBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addressBoxErrorIcon.Location = new System.Drawing.Point(782, 226);
            this.addressBoxErrorIcon.Name = "addressBoxErrorIcon";
            this.addressBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.addressBoxErrorIcon.TabIndex = 45;
            this.addressBoxErrorIcon.TabStop = false;
            // 
            // pinBoxErrorIcon
            // 
            this.pinBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.pinBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinBoxErrorIcon.BackgroundImage")));
            this.pinBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pinBoxErrorIcon.Location = new System.Drawing.Point(782, 150);
            this.pinBoxErrorIcon.Name = "pinBoxErrorIcon";
            this.pinBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.pinBoxErrorIcon.TabIndex = 46;
            this.pinBoxErrorIcon.TabStop = false;
            // 
            // emailBoxErrorIcon
            // 
            this.emailBoxErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.emailBoxErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailBoxErrorIcon.BackgroundImage")));
            this.emailBoxErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.emailBoxErrorIcon.Location = new System.Drawing.Point(560, 299);
            this.emailBoxErrorIcon.Name = "emailBoxErrorIcon";
            this.emailBoxErrorIcon.Size = new System.Drawing.Size(21, 23);
            this.emailBoxErrorIcon.TabIndex = 47;
            this.emailBoxErrorIcon.TabStop = false;
            // 
            // nameExpLbl
            // 
            this.nameExpLbl.AutoSize = true;
            this.nameExpLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.nameExpLbl.Location = new System.Drawing.Point(173, 176);
            this.nameExpLbl.Name = "nameExpLbl";
            this.nameExpLbl.Size = new System.Drawing.Size(189, 14);
            this.nameExpLbl.TabIndex = 48;
            this.nameExpLbl.Text = "e.g. Ali Ahmad (Max 25 Char)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(170, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 14);
            this.label12.TabIndex = 50;
            this.label12.Text = "e.g. 0321-1234567 (11 Char)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(519, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 14);
            this.label13.TabIndex = 51;
            this.label13.Text = "e.g. Main Street # 12, Lahore (Max 50 Char)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label14.Location = new System.Drawing.Point(300, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(283, 14);
            this.label14.TabIndex = 52;
            this.label14.Text = "e.g. aliahmad123@gmail.com (Max 25 Char)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label17.Location = new System.Drawing.Point(621, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 14);
            this.label17.TabIndex = 55;
            this.label17.Text = "e.g. 98374673 (Max 8 Char)";
            // 
            // SaleManCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 468);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameExpLbl);
            this.Controls.Add(this.emailBoxErrorIcon);
            this.Controls.Add(this.pinBoxErrorIcon);
            this.Controls.Add(this.addressBoxErrorIcon);
            this.Controls.Add(this.contactBoxErrorIcon);
            this.Controls.Add(this.nameBoxErrorIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.hireBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleManCtrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Managment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinBoxErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBoxErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hireBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox nameBoxErrorIcon;
        private System.Windows.Forms.PictureBox contactBoxErrorIcon;
        private System.Windows.Forms.PictureBox addressBoxErrorIcon;
        private System.Windows.Forms.PictureBox pinBoxErrorIcon;
        private System.Windows.Forms.PictureBox emailBoxErrorIcon;
        private System.Windows.Forms.Label nameExpLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
    }
}