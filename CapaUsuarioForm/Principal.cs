using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaUsuarioForm
{
    public partial class Principal : Form
    {
        private Persona persona;
        public Principal()
        {
            InitializeComponent();
        }

        private void butCrear_Click(object sender, EventArgs e)
        {
            FCrear fc = new FCrear();
            fc.ShowDialog();
            
            persona = fc.Per;
        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            if (persona != null)
            {
                FMostrar fm = new FMostrar(persona);
                fm.ShowDialog();
            }
            else
                MessageBox.Show("No hay persona creada");
        }
    }
}
