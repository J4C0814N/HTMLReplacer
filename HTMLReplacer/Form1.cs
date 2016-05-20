using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

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
            List<string> HTMLOptions = new List<string>() { "Tag", "Attribute" };
            cbxHTMLOptions.DataSource = HTMLOptions;

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

        /// <summary>
        /// Copy the Outputted code back to the Import. (To process again?)
        /// </summary>
        private void btnCopyOutToIn_Click(object sender, EventArgs e)
        {
            txtInputAsCode.Text = txtOutputAsCode.Text;
        }

        /// <summary>
        /// Work out what needs to be done and do it.
        /// </summary>
        private void btnProcess_Click(object sender, EventArgs e)
        {

            var SelectedOptions = gbxOptions.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            switch(SelectedOptions.Name){
                case "rbGiveLabelForInputId":
                    string OutPut = string.Empty;
                    SetLabelForAttribute(txtInputAsCode.Text, out OutPut);
                    txtOutputAsCode.Text = OutPut;

                    break;

                default:
                    break;
            }

        }

        /// <summary>
        /// Parses the html and adds for= attribute to all label tags without.
        /// for= value is determined by the labels first child input tag
        /// </summary>
        /// <param name="Input">HTML as a string</param>
        /// <param name="Output">HTML as a string</param>
        private void SetLabelForAttribute(string Input, out string Output)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Input);
            foreach (HtmlNode label in doc.DocumentNode.SelectNodes("//label"))
            {
                if (!label.Attributes.Contains("For"))
                {
                    HtmlNode input = label.ChildNodes.Where(n => n.Name.Equals("input")).FirstOrDefault();
                    if(input != null)
                        label.Attributes.Add("For", input.Id);
                }
            }
            Output = doc.DocumentNode.OuterHtml;
        }

    }
}
