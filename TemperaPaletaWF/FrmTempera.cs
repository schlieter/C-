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
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;

        public Tempera Tempera
        {
            get { return this._tempera; }
        }
        public FrmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor a in Enum.GetValues(typeof(ConsoleColor)))//Enum.GetValues(typeof(ConsoleColor)) devuelve un array de un enumerado
            {
                this.comboBox1.Items.Add(a);//para agregar cada color al combo
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant;
            ConsoleColor col = (ConsoleColor)this.comboBox1.SelectedItem;
            int.TryParse(this.textBox2.Text,out cant);
            this._tempera = new Tempera(col,this.textBox1.Text,cant);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;//para que cada vez que tocamos aceptar se ponga en OK el dialogresult
        }

        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }
    }
}
