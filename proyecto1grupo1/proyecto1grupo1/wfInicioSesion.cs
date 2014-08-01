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
    public partial class wfInicioSesion : Form
    {
        public wfInicioSesion()
        {
            InitializeComponent();
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wfInicioSesion frm = new wfInicioSesion();
            wfMenuTurnos frm1 = new wfMenuTurnos();
            wfPantallaTurnos frm2 = new wfPantallaTurnos();


            this.Hide();
            frm1.Show();
            frm2.Show();
            
        }
    }
}
