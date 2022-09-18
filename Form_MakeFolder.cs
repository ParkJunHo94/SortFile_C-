using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_By_Filename
{
    public partial class Form_MakeFolder : Form
    {
        public Form_MakeFolder()
        {
            InitializeComponent();
        }

        List<string[]> Filelist3 = new List<string[]>();

        private void Form_MakeFolder_Load(object sender, EventArgs e)
        {
            Main frm = (Main)this.Owner;
            string[] temp = { };
            string[] temp2 = { };

            int i = 0;

            for (i = 0; i < frm.Filelist.Count; i++)
            {
                temp = frm.Filelist[i][0].Split('.');
                Filelist3.Add(new string[] { temp[0] });
            }

            temp = new string[] { };
            for (i = 0; i < Filelist3.Count; i++)
            {
                try
                {
                    temp = Filelist3[i][0].Split(' ');
                    listBox1.Items.Add(temp[0]);
                }
                catch
                {
                }
            }

            temp = new string[] { };
            for (i = 0; i < Filelist3.Count; i++)
            {
                try
                {
                    temp = Filelist3[i][0].Split(' ');
                    listBox2.Items.Add(temp[1]);
                }
                catch
                {
                }
            }

            temp = new string[] { };
            for (i = 0; i < Filelist3.Count; i++)
            {
                try
                {
                    temp = Filelist3[i][0].Split(' ');
                    listBox3.Items.Add(temp[2]);
                }
                catch
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            catch { }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox2.SelectedItem.ToString();
            }
            catch { }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox3.SelectedItem.ToString();
            }
            catch { };
        }

        private void Form_MakeFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = (Main)this.Owner;
            frm.FolderName = textBox1.Text;
            
        }
    }
}
