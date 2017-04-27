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
    public partial class FrmMostrar : Form
    {
        private List<Tempera> _temperas;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(List<Tempera> lista):this()
        {
            this._temperas = lista;
        }

        private void _refresh()
        {
            this.listBox1.Items.Clear();
            foreach (Tempera a in this._temperas)
                this.listBox1.Items.Add(Tempera.Mostrar(a));
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            _refresh();
        }
        //Generar boton modificar, que se levante una istancia de frm tempera y modifico desde el form
        private void button1_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if(indice >-1)
                this._temperas.RemoveAt(indice);
            _refresh();
        }
    }
}
