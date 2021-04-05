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
    public partial class Form2 : Form
    {
        private static int index = 0;
        public delegate void MyDel(string s);
        public MyDel d;
        public void GetIndexOfEdit(string s)
        {
            index = CSDL_OOP.Instance.IndexOfSV(s);
        }

        public Form2()
        {
            d = new MyDel(GetIndexOfEdit);
            InitializeComponent();
            SetCBBShow2();
        }

        public void SetCBBShow2()
        {
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                cbbLSH2.Items.Add(new CBBItem
                {
                    Value = Convert.ToInt32(i["ID_Lop"].ToString()),
                    Text = i["NameLop"].ToString(),
                });
            }
        }

        public void AddSV()
        {
            SV temp = new SV();
            temp.MSSV = txtMSSV.Text.ToString();
            temp.Name = txtName.Text.ToString();
            if (rdbFemale.ToString() == "true") temp.Gender = true;
            else temp.Gender = false;
            temp.ID_Lop = CSDL_OOP.Instance.getIDClassByName(cbbLSH2.SelectedItem.ToString());
            temp.NS = Convert.ToDateTime(dateTimePicker1.Value);
            CSDL_OOP.Instance.AddSVToCSDL(temp);
        }

        public void EditSV(string mssv)
        {
            int index = CSDL_OOP.Instance.IndexOfSV(mssv);
            SV temp = CSDL_OOP.Instance.DBSV[index];
            txtMSSV.Enabled = false;
            temp.Name = txtName.Text.ToString();
            if (rdbFemale.ToString() == "true") temp.Gender = true;
            else temp.Gender = false;
            temp.ID_Lop = CSDL_OOP.Instance.getIDClassByName(cbbLSH2.SelectedItem.ToString());
            temp.NS = Convert.ToDateTime(dateTimePicker1.Value);
            CSDL_OOP.Instance.DBSV[index] = temp;
            CSDL_OOP.Instance.EditSVToCSDL(CSDL_OOP.Instance.DBSV[index]);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                AddSV();
            }
            else
            {
                EditSV(CSDL_OOP.Instance.DBSV[index].MSSV);
            }
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(index != -1)
            {
                SV temp = new SV();
                temp = CSDL_OOP.Instance.DBSV[index];
                txtMSSV.Text = temp.MSSV;
                txtMSSV.Enabled = false;
                txtName.Text = temp.Name;
                cbbLSH2.Text = CSDL_OOP.Instance.getClassByIDLop(temp.ID_Lop);
                if (temp.Gender == true)
                {
                    rdbMale.Checked = true;
                }
                else rdbFemale.Checked = true;
                dateTimePicker1.Value = temp.NS;
            }    
        }
    }


}
