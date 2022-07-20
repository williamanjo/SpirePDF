using System;
using System.Windows.Forms;
namespace SpirePDF
{


    public partial class SpirePDF : Form
    {

        public SpirePDF()
        {
            InitializeComponent();

        }

        void PageChanged_Event(object send, System.EventArgs ar)
        {
            CurrentPage.Text = pdfViewer1.CurrentPageNumber.ToString();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "PDF document (*.pdf)|*.pdf"
            };
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string pdfFile = dialog.FileName;
                    pdfViewer1.LoadFromFile(pdfFile);
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Erro ao Abrir Arquivo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            if (this.pdfViewer1.PageCount > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "PDF document (*.pdf)|*.pdf"
                };
                DialogResult result = dialog.ShowDialog();
                string fileName = dialog.FileName;
                if (result == DialogResult.OK)
                {
                    pdfViewer1.SaveToFile(fileName);
                    MessageBox.Show("Arquivo salvo em:\n" + fileName, "Spire.PdfViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void PdfViewer1_Open(object sender, EventArgs e)
        {

            pageHandle.Text = "de " + pdfViewer1.PageCount.ToString();
        }
        void GoToPage() {
            try
            {
                pdfViewer1.GoToPage(Int32.Parse(CurrentPage.Text));
            }
            catch{}

        }
        private void PageChanged_EventEnter(object sender, EventArgs e)
        {
            GoToPage();
        }

        private void CurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                GoToPage(); 
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            toolStripContainer1.Size = new System.Drawing.Size(this.Size.Width - 16, this.Size.Height - 45);
        }

        private void MergePdfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mergePdfForm = new Form2(pdfViewer1);
            mergePdfForm.ShowDialog();
        }

        private void SpirePDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfViewer1.CloseDocument();
            Dispose();
        }
    }
}