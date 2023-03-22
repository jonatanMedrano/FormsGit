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
    public partial class FMostrar : Form
    {
        public FMostrar(Persona per)
        {
            InitializeComponent();
            this.mostrar(per);
        }

        public void mostrar(Persona p)
        {
            this.labelDni.Text = "DNI: "+p.Dni.ToString();
            this.labelNombre.Text = p.Nombre;
            this.labelEdad.Text = "tiene "+p.edad().ToString()+" años";
        }
    }
}
