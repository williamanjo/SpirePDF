using System;
using System.IO;
using System.Windows.Forms;
using Spire.Pdf;

namespace SpirePDF
{
    public partial class Form2 : Form
    {
        Spire.PdfViewer.Forms.PdfViewer pdfViewer;

        public Form2(Spire.PdfViewer.Forms.PdfViewer pdfViewer1)
        {
            pdfViewer = pdfViewer1; 
            InitializeComponent();
            pdfViewer.CloseDocument();
        }

        private void SaveAsMerge_Click(object sender, EventArgs e)
        {
            if (pdfViewerStream.PageCount > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "PDF document (*.pdf)|*.pdf",
                    FileName = "Merged.pdf"
                };
                DialogResult result = dialog.ShowDialog();
                string fileName = dialog.FileName;
                if (result == DialogResult.OK)
                {
                    pdfViewerStream.SaveToFile(fileName);
                    MessageBox.Show("Documento Gerado em :\n" + fileName, "Spire.PdfViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void OpenFiles_Click(object sender, EventArgs e)
        {
            PdfDocument pdfDoc = new PdfDocument();
            
            Stream pdfNew = new MemoryStream();

            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF document (*.pdf)|*.pdf",
                Title = "Selecione PDF's para juntar"
            };
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Size = new System.Drawing.Size(950, 750);
                foreach (String file in dialog.FileNames)
                {
                    PdfDocument pdfDoc2 = new PdfDocument();
                    pdfDoc2.LoadFromFile(file);
                    pdfDoc.AppendPage(pdfDoc2);
                }
                
                pdfDoc.SaveToStream(pdfNew);
                pdfViewerStream.LoadFromStream(pdfNew);
                
                SaveAsMerge.Enabled = true;
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            toolStripContainer1.Size = new System.Drawing.Size(this.Size.Width - 16, this.Size.Height - 45);
            pdfViewerStream.Size = toolStripContainer1.Size;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfViewerStream.CloseDocument();
            Dispose();
        }
    }
}
