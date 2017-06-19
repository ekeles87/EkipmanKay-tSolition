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
    public partial class İlkfrm : Form
    {
        public İlkfrm()
        {
            InitializeComponent();
        }

        private void btnServisSüreç_Click(object sender, EventArgs e)
        {
            ServisSurec frm = new ServisSurec();
            frm.Show();


        }
    }
}
