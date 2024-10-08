﻿namespace ADRASHA_Main
{
    partial class Setting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Form));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.confirm_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.new_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.current_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblashaname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl3 = new ADRASHA_Main.PanelControl();
            this.main_panelcontrol = new ADRASHA_Main.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pnlSecurity);
            this.kryptonPanel1.Controls.Add(this.lblashaname);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.panelControl3);
            this.kryptonPanel1.Controls.Add(this.main_panelcontrol);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1562, 796);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pnlSecurity
            // 
            this.pnlSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.pnlSecurity.Controls.Add(this.confirm_password);
            this.pnlSecurity.Controls.Add(this.new_password);
            this.pnlSecurity.Controls.Add(this.current_password);
            this.pnlSecurity.Controls.Add(this.btnUpdate);
            this.pnlSecurity.Controls.Add(this.label7);
            this.pnlSecurity.Controls.Add(this.label8);
            this.pnlSecurity.Controls.Add(this.label9);
            this.pnlSecurity.Controls.Add(this.label12);
            this.pnlSecurity.Location = new System.Drawing.Point(80, 284);
            this.pnlSecurity.Name = "pnlSecurity";
            this.pnlSecurity.Size = new System.Drawing.Size(1414, 512);
            this.pnlSecurity.TabIndex = 0;
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(664, 391);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '*';
            this.confirm_password.Size = new System.Drawing.Size(327, 38);
            this.confirm_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirm_password.StateCommon.Border.Rounding = 5;
            this.confirm_password.StateCommon.Border.Width = 1;
            this.confirm_password.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password.TabIndex = 0;
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(664, 273);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(327, 38);
            this.new_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.new_password.StateCommon.Border.Rounding = 5;
            this.new_password.StateCommon.Border.Width = 1;
            this.new_password.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password.TabIndex = 0;
            // 
            // current_password
            // 
            this.current_password.Location = new System.Drawing.Point(664, 156);
            this.current_password.Name = "current_password";
            this.current_password.PasswordChar = '*';
            this.current_password.Size = new System.Drawing.Size(327, 38);
            this.current_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.current_password.StateCommon.Border.Rounding = 5;
            this.current_password.StateCommon.Border.Width = 1;
            this.current_password.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_password.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1091, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 52);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 20;
            this.btnUpdate.StateCommon.Border.Width = 2;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.label7.Font = new System.Drawing.Font("Aladin", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(46, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 61);
            this.label7.TabIndex = 0;
            this.label7.Text = "Security";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(445, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(445, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "New Password ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(445, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "Confirm Password";
            // 
            // lblashaname
            // 
            this.lblashaname.AutoSize = true;
            this.lblashaname.BackColor = System.Drawing.Color.Transparent;
            this.lblashaname.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblashaname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblashaname.Location = new System.Drawing.Point(174, 44);
            this.lblashaname.Name = "lblashaname";
            this.lblashaname.Size = new System.Drawing.Size(222, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "Setting";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Angle = 0F;
            this.panelControl3.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Rounding = 0;
            this.panelControl3.Size = new System.Drawing.Size(150, 125);
            this.panelControl3.TabIndex = 0;
            // 
            // main_panelcontrol
            // 
            this.main_panelcontrol.Angle = 0F;
            this.main_panelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.main_panelcontrol.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Location = new System.Drawing.Point(69, 273);
            this.main_panelcontrol.Name = "main_panelcontrol";
            this.main_panelcontrol.Rounding = 0;
            this.main_panelcontrol.Size = new System.Drawing.Size(1436, 563);
            this.main_panelcontrol.TabIndex = 0;
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 796);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Setting_Form";
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl main_panelcontrol;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label lblashaname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PanelControl panelControl3;
        private System.Windows.Forms.Panel pnlSecurity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox confirm_password;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox new_password;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox current_password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}