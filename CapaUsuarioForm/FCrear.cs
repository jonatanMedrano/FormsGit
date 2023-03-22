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
    public partial class FCrear : Form
    {
        private Persona per;
        public FCrear()
        {
            InitializeComponent();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            
            int d = int.Parse(this.textBoxDNI.Text);
            string n = this.textBoxNombre.Text;
            DateTime f = this.dateTimePicker1.Value;
            per = new Persona(d, n, f);
            this.Close();
        }

        private void butCancdelar_Click(object sender, EventArgs e)
        {
            per = null;
            this.Close();
        }
        public Persona Per
        {
            get { return per; }
        }
    }
}
