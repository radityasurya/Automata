using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Automata
{
    public partial class AutomataUI : Form
    {
        private AutomataManager am;

        public AutomataUI()
        {
            InitializeComponent();
            am = new AutomataManager();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFileDialog = new OpenFileDialog();
            browseFileDialog.Title = "Open Text File";
            browseFileDialog.Filter = "TXT files|*.txt";
            browseFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbBrowse.Text = "";
                tbBrowse.Select(tbBrowse.TextLength + 1, 0);
                tbBrowse.SelectedText = browseFileDialog.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tbBrowse.Text != "")
            {
                am.readNDFA(tbBrowse.Text);
                updateForm();
            } else
            {
                MessageBox.Show("File is not selected!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + "\\abc.png";
            pbDiagram.ImageLocation = imagePath;
            
        }

        private void updateForm()
        {
            if (am.isDFA())
            {
                lbDFA.BackColor = Color.LightGreen;
            } else
            {
                lbDFA.BackColor = Color.Red;

            }

            //if (am.isFinite())
            //{
            //    lbFinite.BackColor = Color.LightGreen;
            //} else
            //{
            //    lbFinite.BackColor = Color.Red;

            //}

            if (am.isWords())
            {
                lbWords.BackColor = Color.LightGreen;
            } else
            {
                lbWords.BackColor = Color.Red;

            }
        }
    }
}
