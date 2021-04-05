using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSV
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {
            }
        }
        private static CSDL _Instance;

        private CSDL()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NS", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(int)),
            });

            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = "101";
            dr["NameSV"] = "NVA";
            dr["Gender"] = true;
            dr["NS"] = DateTime.Now;
            dr["ID_Lop"] = 1;
            DTSV.Rows.Add(dr);

            DataRow dr1 = DTSV.NewRow();
            dr1["MSSV"] = "102";
            dr1["NameSV"] = "NVB";
            dr1["Gender"] = false;
            dr1["NS"] = DateTime.Now;
            dr1["ID_Lop"] = 1;
            DTSV.Rows.Add(dr1);

            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "103";
            dr2["NameSV"] = "NVC";
            dr2["Gender"] = true;
            dr2["NS"] = DateTime.Now;
            dr2["ID_Lop"] = 2;
            DTSV.Rows.Add(dr2);


            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Lop", typeof(int)),
                new DataColumn("NameLop", typeof(string)),
            });

            DataRow dr3 = DTLSH.NewRow();
            dr3["ID_Lop"] = 1;
            dr3["NameLop"] = "LSH1";
            DTLSH.Rows.Add(dr3);

            DataRow dr4 = DTLSH.NewRow();
            dr4["ID_Lop"] = 2;
            dr4["NameLop"] = "LSH2";
            DTLSH.Rows.Add(dr4);

            DataRow dr5 = DTLSH.NewRow();
            dr5["ID_Lop"] = 3;
            dr5["NameLop"] = "LSH3";
            DTLSH.Rows.Add(dr5);
        }



    }
}
