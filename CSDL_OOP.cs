using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    class CSDL_OOP
    {
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set
            {
            }
        }
        private static CSDL_OOP _Instance;

        public List<SV> DBSV;
        public List<LSH> DBLSH;

        //public static int numSV = ;
        //public static int numLSH = ;

        public void getAllSV()
        {
            DBSV = new List<SV>();
            for (int i = 0; i < CSDL.Instance.DTSV.Rows.Count; i++)
            {
                SV temp = new SV();
                temp.MSSV = CSDL.Instance.DTSV.Rows[i]["MSSV"].ToString();
                temp.Name = CSDL.Instance.DTSV.Rows[i]["NameSV"].ToString();
                temp.Gender = Convert.ToBoolean(CSDL.Instance.DTSV.Rows[i]["Gender"]);
                temp.ID_Lop = Convert.ToInt32(CSDL.Instance.DTSV.Rows[i]["ID_Lop"]);
                temp.NS = Convert.ToDateTime(CSDL.Instance.DTSV.Rows[i]["NS"]);
                DBSV.Add(temp);
            }
        }

        public void getAllClass()
        {
            DBLSH = new List<LSH>();
            for (int i = 0; i < CSDL.Instance.DTLSH.Rows.Count; i++)
            {
                LSH temp = new LSH();
                temp.ID_Lop = Convert.ToInt32(CSDL.Instance.DTLSH.Rows[i]["ID_Lop"]);
                temp.NameLop = CSDL.Instance.DTLSH.Rows[i]["NameLop"].ToString();
                DBLSH.Add(temp);
            }
        }

        private CSDL_OOP()
        {
            getAllSV();
            getAllClass();
        }

        public int getIDClassByName(string nameLSH)
        {
            foreach(LSH i in DBLSH)
            {
                if (nameLSH == i.NameLop) return Convert.ToInt32(i.ID_Lop);
            }
            return -1;
        }

        public string getClassByIDLop(int id)
        {
            for(int i = 0; i < CSDL_OOP.Instance.DBLSH.Count; i++)
            {
                if (id == DBLSH[i].ID_Lop) return DBLSH[i].NameLop;
            }
            return "";
        }

        public List<SV> getSVByIDLop(int id)
        {
            List<SV> temp = new List<SV>();
            for(int i = 1; i < CSDL.Instance.DTSV.Rows.Count; i++)
            {
                if(id == DBSV[i].ID_Lop)
                {
                    temp.Add(DBSV[i]);
                }    
            }    
            return temp;
        }

        public bool IsTrue(string id)
        {
            foreach (SV i in DBSV)
            {
                if (id == i.MSSV) return true;
            }
            return false;
        }

        public int IndexOfSV(string mssv)
        {
            for (int i = 0; i < CSDL.Instance.DTSV.Rows.Count; i++)
            {
                if (mssv == DBSV[i].MSSV) return i;
            }
            return -1;
        }

        public void AddSVToCSDL(SV s)
        {
            // đầu tiên add vô list trước rồi syn qua csdl sau :V, rồi làm đi 
            DBSV.Add(s);
            DataRow dr = CSDL.Instance.DTSV.NewRow();
            dr["MSSV"] = s.MSSV; //dr["MSSV"] = DBSV[DBSV.Count-1].MSSV;
            dr["NameSV"] = s.Name;
            dr["Gender"] = s.Gender;
            dr["ID_Lop"] = s.ID_Lop;
            dr["NS"] = s.NS;
            CSDL.Instance.DTSV.Rows.Add(dr);
            getAllSV();
        }

        public void EditSVToCSDL(SV s)
        {
            int index = CSDL_OOP.Instance.IndexOfSV(s.MSSV);
            DBSV[index] = s;
            CSDL.Instance.DTSV.Rows[index]["MSSV"] = s.MSSV;
            CSDL.Instance.DTSV.Rows[index]["NameSV"] = s.Name;
            CSDL.Instance.DTSV.Rows[index]["Gender"] = s.Gender;
            CSDL.Instance.DTSV.Rows[index]["ID_Lop"] = s.ID_Lop;
            CSDL.Instance.DTSV.Rows[index]["NS"] = s.NS;
            getAllSV();
        }

        public void DeleteSVToCSDL(string mssv)
        {
            int index = CSDL_OOP.Instance.IndexOfSV(mssv);
            CSDL_OOP.Instance.DBSV.RemoveAt(index);
            CSDL.Instance.DTSV.Rows.RemoveAt(index);
            getAllSV();
        }

        public List<SV> getSVByName(string name)
        {
            int n = CSDL_OOP.Instance.DBSV.Count;
            List<SV> l = new List<SV>();
            for(int i = 0; i < n; i++)
            {
                if (name == CSDL_OOP.Instance.DBSV[i].Name) l.Add(DBSV[i]);
            }
            return l;
        }

        public List<SV> SearchSV(int id, string name)
        {
            List<SV> l = new List<SV>();
            List<SV> temp = CSDL_OOP.Instance.getSVByName(name);
            for(int i = 0; i < temp.Count; i++)
            {
                if (id == temp[i].ID_Lop) l.Add(temp[i]);
            }
            return l;
        }

    }
}
