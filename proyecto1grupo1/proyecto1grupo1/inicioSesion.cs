using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto1grupo1
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicioSesion frm = new inicioSesion();
            Turnos frm1 = new Turnos();
            pantallaTurnos frm2 = new pantallaTurnos();


            this.Hide();
            frm1.Show();
            frm2.Show();
            
        }
    }
}
