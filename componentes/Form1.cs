using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

//Luis Alejandro Palma Mena   5 de marzo del 2024

//Esta aplicación utiliza Windows Media Player para reutilizar componentes.
//El código forma parte de una aplicación que ofrece las siguientes funcionalidades:
//1 Abrir archivos PDF: Cuando el usuario selecciona la opción “Abrir PDF” desde el menú,
//se muestra un cuadro de diálogo para elegir un archivo PDF.
//2 Reproducir videos: Al hacer clic en el botón ("llamado “btn”), se reproduce un archivo de video MP4.
//3 Navegador web (“navegador”): Es un componente que se encuentra en la aplicación. Cuando el usuario
//ingresa una URL en la caja de texto y hace clic en el botón “btn1”,el navegador web carga esa URL
//y muestra el contenido correspondiente en la ventana de la aplicación.


namespace componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.ShowDialog();
                PDF1.src = openFileDialog1.FileName;

                    }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(Application.StartupPath);
              


            }
        }
       
        private void btn_Click(object sender, EventArgs e)
        {
            musica.URL = @"C:\\Users\\Usuario\\source\\repos\\componentes\\componentes\\bin\\Debug\\c# Chris Jedi, Gaby Music, Dei V, Anuel, Ozuna - BAD BOY (Official Video) ft. Anuel AA, Ozuna.mp4";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            navegador.Navigate(txt1.Text);
        }
    }
}
