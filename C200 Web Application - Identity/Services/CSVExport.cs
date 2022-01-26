using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Services
{
    public static class CSVExport
    {
        static string SQL_TEMPLATE = "SELECT * FROM {0}";
        static List<string> TABLE_LIST = GetSQLTables(DB);
        static readonly string DB = "mask-detection-mysqldb";
        static readonly List<string> PERMIT_DB = null;

        private static List<string> GetSQLTables(string db)
        {
            string sql = "SHOW TABLES FROM `{0}`";
            List<string> tables = DBUtl.GetList<string>(sql, db);
            return tables;
        }

        public static void DownloadCSV()
        {
            
        }

        private static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
