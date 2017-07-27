using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    public interface Icontrolador_automata
    {
        Icontrolador_documento fn_documento { get; set; }
        List<String> fn_estado_automata { get; set; }
        List<String> fn_elemento_alfabeto { get; set; }
        String fn_estado_inicial { get; set; }
        List<String> fn_estado_aceptacion { get; set; }
    }
}
