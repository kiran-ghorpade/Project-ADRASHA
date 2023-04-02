namespace ADRASHA_Main.Reports
{
    partial class Report_Preview
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Btn_SaveReport = new System.Windows.Forms.Button();
            this.pnlSaveAs = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPnlClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.FileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSaveAs)).BeginInit();
            this.pnlSaveAs.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(975, 658);
            this.reportViewer.TabIndex = 0;
            // 
            // Btn_SaveReport
            // 
            this.Btn_SaveReport.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_SaveReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveReport.Location = new System.Drawing.Point(794, 0);
            this.Btn_SaveReport.Name = "Btn_SaveReport";
            this.Btn_SaveReport.Size = new System.Drawing.Size(145, 38);
            this.Btn_SaveReport.TabIndex = 1;
            this.Btn_SaveReport.Text = "Save Report";
            this.Btn_SaveReport.UseVisualStyleBackColor = false;
            this.Btn_SaveReport.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // pnlSaveAs
            // 
            this.pnlSaveAs.Controls.Add(this.btnPnlClose);
            this.pnlSaveAs.Controls.Add(this.btnSave);
            this.pnlSaveAs.Controls.Add(this.FileName);
            this.pnlSaveAs.Controls.Add(this.label2);
            this.pnlSaveAs.Controls.Add(this.label1);
            this.pnlSaveAs.Controls.Add(this.label21);
            this.pnlSaveAs.Location = new System.Drawing.Point(242, 155);
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
            this.FileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vaccination_Place_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(20, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note:   Reports will be Save in \"Saved Reports\" tab.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileName:";
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
            // Report_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 658);
            this.Controls.Add(this.pnlSaveAs);
            this.Controls.Add(this.Btn_SaveReport);
            this.Controls.Add(this.reportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Report_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Preview";
            this.Load += new System.EventHandler(this.Report_Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSaveAs)).EndInit();
            this.pnlSaveAs.ResumeLayout(false);
            this.pnlSaveAs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button Btn_SaveReport;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSaveAs;
        private System.Windows.Forms.Button btnPnlClose;
        private System.Windows.Forms.Button btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
    }
}