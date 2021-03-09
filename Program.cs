using System;
using System.Data;
using System.Data.SqlClient;

namespace Hw6920
{
    class Program
    {
        private static object combobox1;

        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("C:\Users\Андрей\source\repos\Hw6920\Hw6920\Hw6920.csproj");
            SqlCommand cmd = new SqlCommand("select *, (str(IDSell)+' '+SFIO) as idplusfio from Sells", conn);
            DataTable dt = new DataTable("sell");
            conn.Open();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, conn);
            DA.Fill(dt);
            conn.Close();

            combobox1.DataSource = dt;
            combobox1.DisplayMember = idpricesell;
int studid = (int)combobox1.Items[combobox1.SelectedIndex]["IDSTUDENT"];
        }
    }
}
