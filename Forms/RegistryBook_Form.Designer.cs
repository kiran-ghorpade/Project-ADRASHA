﻿namespace ADRASHA_Main
{
    partial class RegistryBook_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryBook_Form));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ListViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFamily = new System.Windows.Forms.Button();
            this.panelControl4 = new ADRASHA_Main.PanelControl();
            this.lblashaname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl3 = new ADRASHA_Main.PanelControl();
            this.main_panelcontrol = new ADRASHA_Main.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ListViewPanel);
            this.kryptonPanel1.Controls.Add(this.btnAddFamily);
            this.kryptonPanel1.Controls.Add(this.panelControl4);
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
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ListViewPanel
            // 
            this.ListViewPanel.AutoScroll = true;
            this.ListViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListViewPanel.Location = new System.Drawing.Point(412, 287);
            this.ListViewPanel.Name = "ListViewPanel";
            this.ListViewPanel.Size = new System.Drawing.Size(1078, 536);
            this.ListViewPanel.TabIndex = 0;
            this.ListViewPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ListViewPanel_Scroll);
            // 
            // btnAddFamily
            // 
            this.btnAddFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.btnAddFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFamily.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFamily.Location = new System.Drawing.Point(783, 180);
            this.btnAddFamily.Name = "btnAddFamily";
            this.btnAddFamily.Size = new System.Drawing.Size(313, 44);
            this.btnAddFamily.TabIndex = 2;
            this.btnAddFamily.Text = "Add Family";
            this.btnAddFamily.UseVisualStyleBackColor = false;
            this.btnAddFamily.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Angle = 0F;
            this.panelControl4.BackColor = System.Drawing.Color.Transparent;
            this.panelControl4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl4.Location = new System.Drawing.Point(774, 163);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Rounding = 0;
            this.panelControl4.Size = new System.Drawing.Size(334, 74);
            this.panelControl4.TabIndex = 7;
            // 
            // lblashaname
            // 
            this.lblashaname.AutoSize = true;
            this.lblashaname.BackColor = System.Drawing.Color.Transparent;
            this.lblashaname.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblashaname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblashaname.Location = new System.Drawing.Point(174, 44);
            this.lblashaname.Name = "lblashaname";
            this.lblashaname.Size = new System.Drawing.Size(251, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "Registry";
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
            this.main_panelcontrol.Location = new System.Drawing.Point(400, 273);
            this.main_panelcontrol.Name = "main_panelcontrol";
            this.main_panelcontrol.Rounding = 0;
            this.main_panelcontrol.Size = new System.Drawing.Size(1105, 563);
            this.main_panelcontrol.TabIndex = 0;
            // 
            // RegistryBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 796);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RegistryBook_Form";
            this.Text = "RegistryBookForm";
            this.Load += new System.EventHandler(this.RegistryBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label lblashaname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PanelControl panelControl3;
        private PanelControl main_panelcontrol;
        private System.Windows.Forms.Button btnAddFamily;
        private PanelControl panelControl4;
        private System.Windows.Forms.FlowLayoutPanel ListViewPanel;
    }
}