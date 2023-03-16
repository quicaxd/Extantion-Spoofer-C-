using Spoofer.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoofer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.CurrentDirectory;
                ofd.Title = "Extantion Spoofer by quicaxd";
                ofd.Filter = "Select a exe file (*.exe)|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    guna2TextBox1.Text = ofd.FileName;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == String.Empty)
            {
                MessageBox.Show("Please Select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!File.Exists(guna2TextBox1.Text))
            {
                MessageBox.Show("Invalid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string extantionMethod = guna2ComboBox1.SelectedItem.ToString();
                    File.Copy(guna2TextBox1.Text, İnjector.ExtantionSpoofer(guna2TextBox1.Text, extantionMethod));

                    MessageBox.Show("Spoofing was succesful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] chars = { ".pdf", ".png", ".jpg", ".docx", ".xlsx"};
            foreach(string charss in chars)
            {
                guna2ComboBox1.Items.Add(charss);
            }
            guna2ComboBox1.SelectedIndex = 0;
        }
    }
}
