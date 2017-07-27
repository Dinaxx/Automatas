using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    class controlador_documento : Icontrolador_documento
    {
        private OpenFileDialog documento;
        private bool inicializado;

        public controlador_documento()
        {
            this.documento = new OpenFileDialog();
            inicializado = false;
        }

        #region Get Set
        public OpenFileDialog Files
        {
            get
            {
                return this.documento;
            }
            set
            {
                this.documento = value;
            }
        }
        public String NombreDocumento
        {
            get
            {
                return this.documento.FileName;
            }
            set
            {
                this.documento.FileName = value;
            }
        }
        public bool inicializacion
        {
            get
            {
                return this.inicializado;
            }
        }
        public Stream obtenerContenido
        {
            get
            {
                return this.documento.OpenFile();
            }
        }
        #endregion

        public void obtenerDocumentoSelector()
        {
            this.documento.Title = "Seleccion de documento";
            this.documento.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.documento.Filter = "All files (*.*)|*.*|Documento de texto (*.txt)|*.txt";
            this.documento.FilterIndex = 2;
            this.documento.RestoreDirectory = true;
            if (this.documento.ShowDialog() == DialogResult.OK)
            {
                this.inicializado = true;
            }
        }

        public void obtenerDocumentoPath(String path_documento)
        {

        }

    }
}
