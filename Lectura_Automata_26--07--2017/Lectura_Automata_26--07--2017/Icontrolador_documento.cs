using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    public interface Icontrolador_documento
    {
        OpenFileDialog Files { get; set; }
        String NombreDocumento { get; set; }
        bool inicializacion { get; }
        Stream obtenerContenido { get; }

        void obtenerDocumentoSelector();
        void obtenerDocumentoPath(String path_documento);
    }
}
