using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clipboardsearchandreplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // http://stackoverflow.com/questions/35867427/read-text-from-clipboard
        // http://stackoverflow.com/questions/3546016/how-to-copy-data-to-clipboard-in-c-sharp
        // Clipboard.SetText("Hello, clipboard");
        //http://stackoverflow.com/questions/13509532/how-to-find-and-replace-text-in-a-file-with-c-sharp
        private void btndosearchandreplace_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                string newtext = clipboardText.Replace(txtFind.Text, txtReplace.Text);
                newtext = "\""+newtext+"\"";
                Clipboard.SetText(newtext);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFind.Text = "\"";
            txtReplace.Text = "'";
        }
    }
}
