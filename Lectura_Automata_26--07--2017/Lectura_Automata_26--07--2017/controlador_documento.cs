using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    class controlador_documento : Icontrolador_documento
    {
        private OpenFileDialog File;
        private bool inicializado;
        public controlador_documento()
        {
            File = new OpenFileDialog();
            inicializado = false;
        }

        public OpenFileDialog Files
        {
            get
            {
                return this.File;
            }
            set
            {
                this.File = value;
            }
        }

        public void obtenerDocumentoSelector()
        {
            this.File.Title = "Seleccion de documento";
            this.File.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.File.Filter = "All files (*.*)|*.*|Documento de texto (*.txt)|*.txt";
            this.File.FilterIndex = 2;
            this.File.RestoreDirectory = true;
            if (this.File.ShowDialog() == DialogResult.OK)
            {
                this.inicializado = true;
            }
        }

        public void obtenerDocumentoPath(String path_documento)
        {

        }

        public String NombreDocumento
        {
            get
            {
                return this.File.FileName;
            }
            set
            {
                this.File.FileName = value;
            }
        }
        public bool inicializacion
        {
            get
            {
                return this.inicializado;
            }
        }
    }
}
