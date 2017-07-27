/*
 *  Autor: Raul Alejandro Hernandez Barahona
 *  Fecha de creacion: 27-07-2017
 */
using System;
using System.IO;
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
            try
            {
                this.automata = new controlador_automata(documento);
                #endregion
                using (StreamReader lector = new StreamReader(this.automata.fn_documento.obtenerContenido))
                {
                    String linea_documento;
                    while ((linea_documento = lector.ReadLine()) != null)
                    {
                        txt_contenido_documento.Text += linea_documento + Environment.NewLine;
                    }
                }
                if (automata.fn_estado_automata != null)
                {
                    foreach (String estados_automara in automata.fn_estado_automata)
                    {
                        txt_estados_automata.Text += estados_automara + Environment.NewLine;
                    }
                }
                if (automata.fn_elemento_alfabeto != null)
                {
                    foreach (String elementos_alfabeto in automata.fn_elemento_alfabeto)
                    {
                        txt_elementos_alfabeto.Text += elementos_alfabeto + Environment.NewLine;
                    }
                }
                if(automata.fn_estado_aceptacion != null)
                {
                    foreach(String estados_aceptacion in automata.fn_estado_aceptacion)
                    {
                        txt_estados_aceptacion.Text += estados_aceptacion + Environment.NewLine;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error durante la ejecucion");
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
