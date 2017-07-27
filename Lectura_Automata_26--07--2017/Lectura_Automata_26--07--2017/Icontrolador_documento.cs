using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    interface Icontrolador_documento
    {
        OpenFileDialog Files { get; set; }
        void obtenerDocumentoSelector();
        void obtenerDocumentoPath(String path_documento);
        String NombreDocumento { get; set; }
        bool inicializacion { get; }
    }
}
