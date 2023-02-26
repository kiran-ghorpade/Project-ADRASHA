namespace ADRASHA_Main
{
    partial class RegistryBookForm
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.main_panelcontrol = new ADRASHA_Main.PanelControl();
            this.form_head_panelcontrol = new ADRASHA_Main.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.main_panelcontrol);
            this.kryptonPanel1.Controls.Add(this.form_head_panelcontrol);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1562, 796);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // main_panelcontrol
            // 
            this.main_panelcontrol.Angle = 0F;
            this.main_panelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.main_panelcontrol.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Location = new System.Drawing.Point(238, 182);
            this.main_panelcontrol.Name = "main_panelcontrol";
            this.main_panelcontrol.Rounding = 0;
            this.main_panelcontrol.Size = new System.Drawing.Size(990, 654);
            this.main_panelcontrol.TabIndex = 0;
            this.main_panelcontrol.Load += new System.EventHandler(this.main_panelcontrol_Load);
            // 
            // form_head_panelcontrol
            // 
            this.form_head_panelcontrol.Angle = 0F;
            this.form_head_panelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.form_head_panelcontrol.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.form_head_panelcontrol.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.form_head_panelcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.form_head_panelcontrol.Location = new System.Drawing.Point(0, 0);
            this.form_head_panelcontrol.Name = "form_head_panelcontrol";
            this.form_head_panelcontrol.Rounding = 0;
            this.form_head_panelcontrol.Size = new System.Drawing.Size(1562, 176);
            this.form_head_panelcontrol.TabIndex = 0;
            // 
            // RegistryBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 796);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RegistryBookForm";
            this.Text = "RegistryBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PanelControl form_head_panelcontrol;
        private PanelControl main_panelcontrol;
    }
}