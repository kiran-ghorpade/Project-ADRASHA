namespace ADRASHA_Main.Forms
{
    partial class Report_Generator
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
            this.label2 = new System.Windows.Forms.Label();
            this.pnlReportTemplates = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlTemplates = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblashaname = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSaveAs = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPnlClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.FileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Btn_SaveReport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelControl1 = new ADRASHA_Main.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReportTemplates)).BeginInit();
            this.pnlReportTemplates.SuspendLayout();
            this.pnlTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSaveAs)).BeginInit();
            this.pnlSaveAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Aladin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Report Preview";
            // 
            // pnlReportTemplates
            // 
            this.pnlReportTemplates.Controls.Add(this.pnlTemplates);
            this.pnlReportTemplates.Controls.Add(this.label2);
            this.pnlReportTemplates.Location = new System.Drawing.Point(42, 404);
            this.pnlReportTemplates.Name = "pnlReportTemplates";
            this.pnlReportTemplates.Size = new System.Drawing.Size(1124, 394);
            this.pnlReportTemplates.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.pnlReportTemplates.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnlReportTemplates.StateCommon.ColorAngle = 45F;
            this.pnlReportTemplates.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.pnlReportTemplates.TabIndex = 0;
            // 
            // pnlTemplates
            // 
            this.pnlTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.pnlTemplates.Controls.Add(this.reportViewer1);
            this.pnlTemplates.Location = new System.Drawing.Point(24, 45);
            this.pnlTemplates.Name = "pnlTemplates";
            this.pnlTemplates.Size = new System.Drawing.Size(1076, 331);
            this.pnlTemplates.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Location = new System.Drawing.Point(11, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblashaname
            // 
            this.lblashaname.AutoSize = true;
            this.lblashaname.BackColor = System.Drawing.Color.Transparent;
            this.lblashaname.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblashaname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblashaname.Location = new System.Drawing.Point(363, 9);
            this.lblashaname.Name = "lblashaname";
            this.lblashaname.Size = new System.Drawing.Size(481, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "Report Generator";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pnlSaveAs);
            this.kryptonPanel1.Controls.Add(this.Btn_SaveReport);
            this.kryptonPanel1.Controls.Add(this.btnRemove);
            this.kryptonPanel1.Controls.Add(this.pnlReportTemplates);
            this.kryptonPanel1.Controls.Add(this.btnAdd);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.panelControl1);
            this.kryptonPanel1.Controls.Add(this.lblashaname);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1207, 835);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pnlSaveAs
            // 
            this.pnlSaveAs.Controls.Add(this.btnPnlClose);
            this.pnlSaveAs.Controls.Add(this.btnSave);
            this.pnlSaveAs.Controls.Add(this.FileName);
            this.pnlSaveAs.Controls.Add(this.label1);
            this.pnlSaveAs.Controls.Add(this.label3);
            this.pnlSaveAs.Controls.Add(this.label21);
            this.pnlSaveAs.Location = new System.Drawing.Point(420, 352);
            this.pnlSaveAs.Name = "pnlSaveAs";
            this.pnlSaveAs.Size = new System.Drawing.Size(503, 313);
            this.pnlSaveAs.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.pnlSaveAs.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnlSaveAs.StateCommon.ColorAngle = 45F;
            this.pnlSaveAs.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.pnlSaveAs.TabIndex = 0;
            // 
            // btnPnlClose
            // 
            this.btnPnlClose.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlClose.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnPnlClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPnlClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPnlClose.Location = new System.Drawing.Point(154, 175);
            this.btnPnlClose.Name = "btnPnlClose";
            this.btnPnlClose.Size = new System.Drawing.Size(141, 45);
            this.btnPnlClose.TabIndex = 4;
            this.btnPnlClose.Text = "Cancel";
            this.btnPnlClose.UseVisualStyleBackColor = false;
            this.btnPnlClose.Click += new System.EventHandler(this.btnPnlClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(320, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(145, 94);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(327, 38);
            this.FileName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FileName.StateCommon.Border.Rounding = 5;
            this.FileName.StateCommon.Border.Width = 1;
            this.FileName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(20, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note:   Reports will be Save in \"Saved Reports\" tab.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "FileName:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Aladin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Cyan;
            this.label21.Location = new System.Drawing.Point(17, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 42);
            this.label21.TabIndex = 0;
            this.label21.Text = "Save as -";
            // 
            // Btn_SaveReport
            // 
            this.Btn_SaveReport.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_SaveReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveReport.Location = new System.Drawing.Point(919, 198);
            this.Btn_SaveReport.Name = "Btn_SaveReport";
            this.Btn_SaveReport.Size = new System.Drawing.Size(190, 60);
            this.Btn_SaveReport.TabIndex = 0;
            this.Btn_SaveReport.Text = "Save Report";
            this.Btn_SaveReport.UseVisualStyleBackColor = false;
            this.Btn_SaveReport.Click += new System.EventHandler(this.Btn_SaveReport_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnRemove.Location = new System.Drawing.Point(340, 256);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 56);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = " Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnAdd.Location = new System.Drawing.Point(340, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.listBox1);
            this.kryptonPanel2.Location = new System.Drawing.Point(27, 88);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(292, 291);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.kryptonPanel2.StateCommon.ColorAngle = 45F;
            this.kryptonPanel2.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.listBox2);
            this.kryptonPanel3.Location = new System.Drawing.Point(469, 88);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(291, 291);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.kryptonPanel3.StateCommon.ColorAngle = 45F;
            this.kryptonPanel3.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel3.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBox2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(13, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(266, 260);
            this.listBox2.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Angle = 0F;
            this.panelControl1.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl1.Location = new System.Drawing.Point(27, 392);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Rounding = 0;
            this.panelControl1.Size = new System.Drawing.Size(1151, 420);
            this.panelControl1.TabIndex = 0;
            // 
            // Report_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 835);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report_Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Generator";
            this.Load += new System.EventHandler(this.Report_Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlReportTemplates)).EndInit();
            this.pnlReportTemplates.ResumeLayout(false);
            this.pnlReportTemplates.PerformLayout();
            this.pnlTemplates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSaveAs)).EndInit();
            this.pnlSaveAs.ResumeLayout(false);
            this.pnlSaveAs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlReportTemplates;
        private PanelControl panelControl1;
        private System.Windows.Forms.Label lblashaname;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel pnlTemplates;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_SaveReport;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSaveAs;
        private System.Windows.Forms.Button btnPnlClose;
        private System.Windows.Forms.Button btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
    }
}