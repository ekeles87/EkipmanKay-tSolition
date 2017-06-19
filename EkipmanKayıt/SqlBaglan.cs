using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SqlBaglan
{
    public SqlConnection connet { get; set; }
    public SqlCommand command { get; set; }
	public  SqlBaglan (string constr)
	{
        this.connet = new SqlConnection();
        this.command = this.connet.CreateCommand();
       
    }
    public DataTable TabloYaz(string query)
    {
        DataTable dt = new DataTable();
        this.command.CommandText = query;
        SqlDataAdapter adap = new SqlDataAdapter(this.command);
        adap.Fill(dt);

        return dt;
    }

    public object ilkTekVeri(string query)
    {
        object sonuc = null;
        this.command.CommandText = query;
        this.connet.Open();
        sonuc = this.command.ExecuteScalar();
        this.connet.Close();
        return sonuc;
    }
}
