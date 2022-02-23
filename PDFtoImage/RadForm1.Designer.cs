namespace PDFtoImage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pdfViewer = new Telerik.WinControls.UI.RadPdfViewer();
            this.openPdf = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtDirectory = new Telerik.WinControls.UI.RadTextBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.txtSaveLocation = new Telerik.WinControls.UI.RadTextBox();
            this.savePdf = new System.Windows.Forms.SaveFileDialog();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaveLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfViewer
            // 
            this.pdfViewer.FitFullPage = true;
            this.pdfViewer.Location = new System.Drawing.Point(12, 48);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.PrintOrientation = Telerik.WinControls.UI.PrintOrientation.Portrait;
            this.pdfViewer.Size = new System.Drawing.Size(431, 465);
            this.pdfViewer.TabIndex = 0;
            this.pdfViewer.Text = "radPdfViewer1";
            this.pdfViewer.ThumbnailsScaleFactor = 0.15F;
            // 
            // openPdf
            // 
            this.openPdf.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(12, 519);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(117, 34);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open PDF";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(146, 528);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(297, 20);
            this.txtDirectory.TabIndex = 2;
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnconvert.Enabled = false;
            this.btnconvert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnconvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvert.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvert.ForeColor = System.Drawing.Color.White;
            this.btnconvert.Location = new System.Drawing.Point(12, 559);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(117, 34);
            this.btnconvert.TabIndex = 3;
            this.btnconvert.Text = "Convert to Images";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(146, 568);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(297, 20);
            this.txtSaveLocation.TabIndex = 3;
            // 
            // radPanel1
            // 
            this.radPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.radPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.btnClose);
            this.radPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(455, 33);
            this.radPanel1.TabIndex = 4;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(12, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(114, 24);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "PDF to Images";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(418, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.TextWrap = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "v.1.0.0 by Joshua Relatorres";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(455, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pdfViewer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaveLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPdfViewer pdfViewer;
        private System.Windows.Forms.OpenFileDialog openPdf;
        private System.Windows.Forms.Button btnOpen;
        private Telerik.WinControls.UI.RadTextBox txtDirectory;
        private System.Windows.Forms.Button btnconvert;
        private Telerik.WinControls.UI.RadTextBox txtSaveLocation;
        private System.Windows.Forms.SaveFileDialog savePdf;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Label label1;
    }
}