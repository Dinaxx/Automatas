/*
 *  Autor: Raul Alejandro Hernandez Barahona
 *  Fecha de creacion: 27-07-2017
 */
using System;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    public partial class fm_Inicio : Form
    {
        private Icontrolador_documento file;
        public fm_Inicio()
        {
            file = new controlador_documento();
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_seleccion_documento_Click(object sender, EventArgs e)
        {
            file.obtenerDocumentoSelector();
            lbl_nombre_documento.Text = this.file.NombreDocumento;
        }

        private void btn_buscar_documento_Click(object sender, EventArgs e)
        {

        }

        private void btn_leer_automata_Click(object sender, EventArgs e)
        {
            if (this.file.inicializacion)
            {
                this.Visible = false;
                fm_Resultado form_resultado = new fm_Resultado(this.file);
                form_resultado.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un documento antes de pasar a esta opcion");
            }
        }
    }
}