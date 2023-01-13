using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visorImagenes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, cargue la
            // imagen que el usuario eligió.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {

            // Limpiara la imagen.
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo de color. Si el usuario hace clic en Aceptar, cambiara el
            // El fondo del control PictureBox al color elegido por el usuario.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Si el usuario selecciona la casilla de verificación Estirar,
            // cambiara el PictureBox
            // Propiedad SizeMode a "Estirar". Si el usuario borra
            // la casilla de verificación, cámbiera a "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }
    }
}
