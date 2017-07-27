using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    public partial class fm_Resultado : Form
    {
        private Icontrolador_automata automata;

        public fm_Resultado(Icontrolador_documento documento)
        {
            InitializeComponent();
            #region variables
            this.automata = new controlador_automata(documento);
            #endregion
            foreach(String estados_automara in automata.fn_estado_automata)
            {
                txt_estados_automata.Text += estados_automara + Environment.NewLine;
            }
        }

        public Icontrolador_automata fn_controldor_autoamta
        {
            get
            {
                return this.automata;
            }
            set
            {
                this.automata = value;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_seleccion_documento_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fm_Inicio form_inicio = new fm_Inicio();
            form_inicio.Show();
        }
    }
}
