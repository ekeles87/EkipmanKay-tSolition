using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkipmanKayıt
{
    public partial class ServisSurec : Form
    {
        public ServisSurec()
        {
            InitializeComponent();
        }

        private void ServisSureccs_Load(object sender, EventArgs e)
        {
            SqlBaglan bag = new SqlBaglan(CONNECTHELPER.conStrAl("DepoDb"));
            string sorgu = "SELECT MalzemeAdı,Özellikler,KullanımYeri,Arıza,GidişTarihi,GelişTarihi,ServisSüreci FROM Sarf Malzeme Sevis Süreç ";

          DataTable sonuc=  bag.TabloYaz(sorgu);
           
        }
    }
}
