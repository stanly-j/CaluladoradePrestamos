using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularprestamo{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double prestamo, interes, periodo;
            double interesmensual, totalinteres, totalprestamo, cuota;
            //Entrada de datos
            prestamo=double.Parse(txtprestamo.Text);
            interes=double.Parse(txtinteres.Text);
            periodo=double.Parse(txtperiodo.Text);
            //proceso
            interesmensual=prestamo*interes;
            totalinteres=interesmensual*periodo;
            totalprestamo=prestamo+totalinteres;
            cuota=totalprestamo/periodo;
            //Salida de informacion
            txtinteresmensual.Text= Convert.ToString (interesmensual);
            txttotalinteres.Text= Convert.ToString(totalinteres);
            txttotalprestamo.Text= Convert.ToString(totalprestamo);
            txtcuota.Text= Convert.ToString(cuota);





       }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtprestamo.Clear();
            txtinteres.Clear();
            txtperiodo.Clear();
            txttotalinteres.Clear();
            txtinteresmensual.Clear();
            txttotalprestamo.Clear();
            txtcuota.Clear();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtprestamo_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
