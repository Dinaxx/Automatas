using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    class controlador_automata : Icontrolador_automata
    {
        #region variables
        private Icontrolador_documento documento;
        private List<String> estado_automata;
        private List<String> elemento_alfabeto;
        private String estado_inicial;
        private List<String> estado_aceptacion;
        #endregion

        public controlador_automata(Icontrolador_documento documento)
        {
            this.documento = documento;
            this.estado_automata = null;
            this.elemento_alfabeto = null;
            this.estado_aceptacion = null;
            obtener_lineas_documento();
        }

        private void obtener_lineas_documento()
        {
            #region Lectura de documento
            try
            {
                using (StreamReader lector = new StreamReader(this.documento.obtenerContenido))
                {
                    String linea_documento;
                    while ((linea_documento = lector.ReadLine()) != null)
                    {
                        if (!clasificaicon_linea(linea_documento))
                        {
                            throw new System.ArgumentException("Error dentro del documento");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al intentar obtener el contenido del documento" + e.Message);
            }
            #endregion
        }

        private bool clasificaicon_linea(String linea_documento)
        {

            switch (linea_documento[0])
            {
                case 'Q':
                    {
                        if (!creaEstadosAutomata(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case 'E':
                    {
                        if (!creaElementosAlfabeto(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case 'i':
                    {
                        if (!creaEstadoIncial(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case 'A':
                    {
                        if (!creaEstadosAceptacion(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                default:
                    {
                        return false;
                    }
            }
            return true;
        }

        private bool creaEstadosAutomata(String linea_documento)
        {
            this.estado_automata = new List<string>();
            string cadena_auxilia = "";
            bool estado_inicial = true, busca_signo_igual = true, inicio_llave = false;
            foreach(char letra_linea in linea_documento)
            {
                if (estado_inicial)
                {
                    estado_inicial = false;
                    continue;
                }
                if(!estado_inicial && busca_signo_igual)
                {
                    if(letra_linea == '=')
                    {
                        busca_signo_igual = false;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                if(!estado_inicial && !busca_signo_igual && !inicio_llave)
                {
                    if(letra_linea == '{')
                    {
                        inicio_llave = true;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                if(inicio_llave)
                {
                    if(letra_linea != ',' && letra_linea != '}')
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if (letra_linea == '}')
                    {
                        this.estado_automata.Add(cadena_auxilia);
                        break;
                    }
                    else
                    {
                        this.estado_automata.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                return false;
            }
            return true;
        }

        private bool creaElementosAlfabeto(String linea_documento)
        {
            return true;
        }

        private bool creaEstadoIncial(String linea_documento)
        {
            return true;
        }

        private bool creaEstadosAceptacion(String linea_documento)
        {
            return true;
        }

        #region Get y Set
        public Icontrolador_documento fn_documento
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
        public List<String> fn_estado_automata
        {
            get
            {
                return this.estado_automata;
            }
            set
            {
                this.estado_automata = value;
            }
        }
        public List<String> fn_elemento_alfabeto
        {
            get
            {
                return this.elemento_alfabeto;
            }
            set
            {
                this.elemento_alfabeto = value;
            }
        }
        public String fn_estado_inicial
        {
            get
            {
                return this.estado_inicial;
            }
            set
            {
                this.estado_inicial = value;
            }
        }
        public List<String> fn_estado_aceptacion
        {
            get
            {
                return this.estado_aceptacion;
            }
            set
            {
                this.estado_aceptacion = value;
            }
        }
        #endregion
    }
}
