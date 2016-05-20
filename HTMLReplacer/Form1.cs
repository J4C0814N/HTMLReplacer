using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog ImportDialog = new OpenFileDialog();

            // Set filter options and filter index.
            ImportDialog.Filter = "All Files (*.*)|*.*";
            ImportDialog.FilterIndex = 1;
            ImportDialog.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult SelectedDialogOption = ImportDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (SelectedDialogOption == DialogResult.OK)
            {
                // Open the selected file to read.
                System.IO.Stream fileStream = ImportDialog.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    txtInputAsCode.Text = reader.ReadToEnd();
                }
                fileStream.Close();
            }
        }
    }
}
