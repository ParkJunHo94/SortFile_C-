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
    public partial class Ext_Form : Form
    {
        List<string> Extlist = new List<string>();
        List<string[]> Filelist_ExtForm = new List<string[]>();

        public Ext_Form()
        {
            InitializeComponent();
        }

        public void Ext_Form_Load(object sender, EventArgs e)
        {
            Main frm = (Main)this.Owner;
            int index = 0;


            listBox_original.Items.Add(frm.Filelist[0][1]); // 밑에 for 문 돌리기 위해서 하나만 먼저 추가.

            for (int i = 0; i < frm.Filelist.Count; i++)
            {
                index = listBox_original.FindStringExact(frm.Filelist[i][1], -1);
                if (index == -1)
                {
                    listBox_original.Items.Add(frm.Filelist[i][1]);
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int index = listBox_tochnage.FindString(listBox_original.SelectedItem.ToString(), -1);
            if (index == -1)
            {
                listBox_tochnage.Items.Add(listBox_original.SelectedItem);
            }
        }

        private void listBox_original_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox_tochnage.FindString(listBox_original.SelectedItem.ToString(), -1);
            if (index == -1)
            {
                listBox_tochnage.Items.Add(listBox_original.SelectedItem);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            listBox_tochnage.Items.Remove(listBox_tochnage.SelectedItem);
        }

        private void listBox_tochnage_DoubleClick(object sender, EventArgs e)
        {
            listBox_tochnage.Items.Remove(listBox_tochnage.SelectedItem);
        }

        private void Ext_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main frm = (Main)this.Owner;
            frm.listBox_Files.Items.Clear();

            for (int i = 0; i < listBox_tochnage.Items.Count; i++)
            {
                Extlist.Add(listBox_tochnage.Items[i].ToString());
            }

            for ( int i = 0; i < frm.Filelist.Count; i++)
            {
                for( int j = 0; j < Extlist.Count; j++)
                {
                    if (frm.Filelist[i][1] == Extlist[j])
                        Filelist_ExtForm.Add(new string[] { frm.Filelist[i][0], frm.Filelist[i][1] });
                }
            }

            frm.Filelist.Clear();

            for( int i = 0; i < Filelist_ExtForm.Count; i++)
            {
                frm.listBox_Files.Items.Add(Filelist_ExtForm[i][0]);
                frm.Filelist.Add(new string[] { Filelist_ExtForm[i][0].ToString(), Filelist_ExtForm[i][1].ToString() });
            }

            frm.label_count.Text = Filelist_ExtForm.Count.ToString();
        }
    }

}


