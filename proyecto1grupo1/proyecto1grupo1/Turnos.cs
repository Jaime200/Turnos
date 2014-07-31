using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;  //Permite leer el texto
using System.Speech.Recognition; //permite Reconocer la voz
using System.Threading;

namespace proyecto1grupo1
{
   
    public partial class Turnos : Form
    {
        int contadorReparacion = 0;
        int contadorVentas = 0;
        int contadorAtencion = 0;
        int contadorPagos = 0;



        inicioSesion frmInicio = new inicioSesion(); 
        pantallaTurnos frmEspera= new pantallaTurnos();


        public Turnos()
        {
            InitializeComponent();

            timer1.Start();
        }
 
       
        SpeechSynthesizer sSynth = new SpeechSynthesizer();// 
        PromptBuilder pBuilder = new PromptBuilder();// Promtp que nos dice que hablar
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        public void Hablar() {
            pBuilder.ClearContent(); // limpia el contenido que sera escrito
                 pBuilder.AppendText(textBox1.Text);
                    sSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    sSynth.Rate = -5;
                //sSynth.GetInstalledVoices(new System.Globalization.CultureInfo("es-ES"));  //ESTE ES PARA IDIOMA
            sSynth.Speak(pBuilder);
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            contadorReparacion += 1;
                 textBox1.AppendText("Your Turn is: R,E," + contadorReparacion);
                    Hablar();
                 MessageBox.Show("Su turno es: RE-" + contadorReparacion);
            textBox1.Text = "";
            //TextBox txt = (TextBox)frmEspera.Controls["label3"];
           // txt.Text = "RE-";
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            contadorAtencion += 1;
            textBox1.AppendText("Your Turn is: A,T," + contadorAtencion);
            Hablar();
            MessageBox.Show("Su turno es: AT- " + contadorAtencion);
            textBox1.Text = "";
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            contadorVentas += 1;
            textBox1.AppendText("Your Turn is: V,E," + contadorVentas);
            Hablar();
            MessageBox.Show("Su turno es: VE-" + contadorVentas);
            textBox1.Text = "";
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            contadorPagos += 1;
            textBox1.AppendText("Your Turn is: P,A," + contadorPagos);
            Hablar();
            MessageBox.Show("Su turno es: PA-" + contadorPagos);
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblHora.Text = dateTime.ToString();
            //this.lblHora.Text = dateTime.ToShortTimeString();
           // this.lblFecha.Text = dateTime.ToShortDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

      

       
   
       
      
    }
}
