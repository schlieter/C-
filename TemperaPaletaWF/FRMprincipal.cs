using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase08.Colecciones;

namespace TemperaPaletaWF
{
    public partial class FRMprincipal : Form
    {
        private List<Tempera> Temperas = new List<Tempera>(); 
        public FRMprincipal()
        {
            InitializeComponent();
            this.Text = "Gestion de temperas";
            this.WindowState = FormWindowState.Maximized;//maximiza el form
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempera temp = new FrmTempera();
            temp.StartPosition = FormStartPosition.CenterScreen;//centra el form
            if (DialogResult.OK == temp.ShowDialog())//temp.ShowDialog()-->hasta que no se cierre no sigue ejecutando la siguiente linea. Si retorna OK agrega.
                this.Temperas.Add(temp.Tempera);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.Temperas);
            mostrar.Show();
        }

        
    }
}
