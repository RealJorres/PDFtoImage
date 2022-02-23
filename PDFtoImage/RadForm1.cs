using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFtoImage
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openPdf.Title = "Select a PDF file";
            openPdf.RestoreDirectory = true;
            openPdf.DefaultExt = "pdf";
            openPdf.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            
            if(openPdf.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = openPdf.FileName;
                pdfViewer.LoadDocument(openPdf.FileName);
                btnconvert.Enabled = true;
            }
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            savePdf.Title = "Select a location";
            savePdf.RestoreDirectory = true;
            savePdf.Filter = "JPEG (*.jpeg)|*jpeg|PNG (*.png)|*.png";
            if(savePdf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtSaveLocation.Text = savePdf.FileName;
                    var images = pdfViewer.ExportPages(1, true, ImageFormat.Png);
                    int count = 1;

                    switch (savePdf.FilterIndex)
                    {
                        case 1:
                            foreach (var i in images)
                            {
                                i.Save(savePdf.FileName + $"{count}.jpeg");
                                count++;
                            }
                            break;

                        case 2:
                            foreach (var i in images)
                            {
                                i.Save(savePdf.FileName + $"{count}.png");
                                count++;
                            }
                            break;
                    }

                    MessageBox.Show("PDF successfully coverted to Images.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnconvert.Enabled = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to quit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
