using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {    

            MessageBox.Show("Elemento Agregado");
            Datos agregar = new Datos();
            string autor, titulo, contenido, fecha, año, mes, dia;

            titulo = Convert.ToString(textBoxTitulo.Text);
            autor = Convert.ToString(textBoxAutor.Text);
            contenido = Convert.ToString(RichText.Text);
            año = Calendario.SelectionEnd.Year.ToString();
            mes = Calendario.SelectionEnd.Month.ToString();
            dia = Calendario.SelectionEnd.Day.ToString();
            fecha = año + "-" + mes + "-" + dia;

            agregar.insertar(autor, titulo,  contenido,fecha);
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            RichText.Text = "";
            Calendario.SelectionStart = Calendario.TodayDate;
            


        }

        
    }
}
