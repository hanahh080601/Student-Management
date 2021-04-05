using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBBClass();
        }

        public void SetCBBClass()
        {
            cbbLSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            for(int i = 0; i < CSDL_OOP.Instance.DBLSH.Count; i++)
            {
                cbbLSH.Items.Add(new CBBItem { Value = CSDL_OOP.Instance.DBLSH[i].ID_Lop, 
                    Text = CSDL_OOP.Instance.DBLSH[i].NameLop });
            }    
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CBBItem)cbbLSH.Items[cbbLSH.SelectedIndex]).Value;
            if (ID_Lop == 0)
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.DBSV;
            }
            else
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.getSVByIDLop(ID_Lop);
            }    
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.d("1");
            f.Show();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            DataGridViewRow dr = dataGridView1.CurrentRow;
            string index = dr.Cells["MSSV"].Value.ToString();
            f.d(index);
            f.Show();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            string index = dr.Cells["MSSV"].Value.ToString();
            CSDL_OOP.Instance.DeleteSVToCSDL(index);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string s = cbbLSH.SelectedItem.ToString();
            int id = CSDL_OOP.Instance.getIDClassByName(s);
            string name = textBox1.Text.ToString();
            if(s == "All")
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.getSVByName(name);
            }                
            else
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.SearchSV(id, name);
            }       
        }

        private void butSort_Click(object sender, EventArgs e)
        {

        }
    }
}
