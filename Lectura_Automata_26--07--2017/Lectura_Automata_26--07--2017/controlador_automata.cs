/*
 *  Autor: Raul Alejandro Hernandez Barahona
 *  Fecha de creacion: 27-07-2017
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Lectura_Automata_26__07__2017
{
    class controlador_automata : Icontrolador_automata
    {
        #region variables
        private Icontrolador_documento  documento;
        private List<String>            estado_automata;
        private List<String>            elemento_alfabeto;
        private String                  estado_inicial;
        private List<String>            estado_aceptacion;
        private const char              indicador_estado_automata = 'Q';
        private const char              indicador_elemento_alfabeto = 'E';
        private const char              indicador_estado_inicial = 'i';
        private const char              indicador_estado_aceptacion = 'A';
        #endregion

        public controlador_automata(Icontrolador_documento documento)
        {
            this.documento          = documento;
            this.estado_automata    = null;
            this.elemento_alfabeto  = null;
            this.estado_aceptacion  = null;
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
                            throw new System.ArgumentException("La sintaxis del documento es incorrecta.\n");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException("Ha ocurrido un error dentro del documento.\n" + e.Message);
            }
            #endregion
        }

        private bool clasificaicon_linea(String linea_documento)
        {

            switch (linea_documento[0])
            {
                case indicador_estado_automata:
                    {
                        if (!creaEstadosAutomata(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case indicador_elemento_alfabeto:
                    {
                        if (!creaElementosAlfabeto(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case indicador_estado_inicial:
                    {
                        if (!creaEstadoIncial(linea_documento))
                        {
                            return false;
                        }
                        break;
                    }
                case indicador_estado_aceptacion:
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

        #region Control Estados Automata
        private bool creaEstadosAutomata(String linea_documento)
        {
            this.estado_automata    = new List<string>();
            string cadena_auxilia   = "";
            bool estado_inicial     = true
                ,busca_signo_igual  = true
                ,inicio_llave       = false;

            foreach(char letra_linea in linea_documento)
            {
                if (letra_linea == ' ' || letra_linea == '\t')
                {
                    continue;
                }
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
                        return true;
                    }
                    else
                    {
                        this.estado_automata.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                this.estado_automata = null;
                return false;
            }
            this.estado_automata = null;
            return false;
        }
        #endregion

        #region Control Elementos Alfabeto
        private bool creaElementosAlfabeto(String linea_documento)
        {
            this.elemento_alfabeto  = new List<string>();
            string cadena_auxilia   = "";
            bool estado_inicial     = true
                ,busca_signo_igual  = true
                ,inicio_llave       = false;

            foreach(char letra_linea in linea_documento)
            {
                if (letra_linea == ' ' || letra_linea == '\t')
                {
                    continue;
                }
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
                if (inicio_llave)
                {
                    if(letra_linea != ',' && letra_linea != '}')
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if(letra_linea == '}')
                    {
                        this.elemento_alfabeto.Add(cadena_auxilia);
                        return true;
                    }
                    else
                    {
                        this.elemento_alfabeto.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                this.elemento_alfabeto = null;
                return false;
            }
            this.elemento_alfabeto = null;
            return false;
        }
        #endregion

        #region Control Estado Inicial
        private bool creaEstadoIncial(String linea_documento)
        {
            bool estado_inicial = true
                , busca_signo_igual = true;
            foreach(char letra_linea in linea_documento)
            {
                if (letra_linea == ' ' || letra_linea == '\t')
                {
                    continue;
                }
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
                if(!estado_inicial && !busca_signo_igual)
                {
                    if(letra_linea == ',' || letra_linea == '{' || letra_linea == '}')
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                return false;
            }
            return true;
        }
        #endregion

        #region Control estados aceptacion
        private bool creaEstadosAceptacion(String linea_documento)
        {
            this.fn_estado_aceptacion = new List<string>();
            string cadena_auxilia = "";
            bool estado_inicial = true
                , busca_signo_igual = true
                , inicio_llave = false;

            foreach(char letra_linea in linea_documento)
            {
                if (letra_linea == ' ' || letra_linea == '\t')
                {
                    continue;
                }
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
                if (inicio_llave)
                {
                    if(letra_linea != ',' && letra_linea != '}')
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if(letra_linea == '}')
                    {
                        this.estado_aceptacion.Add(cadena_auxilia);
                        return true;
                    }
                    else
                    {
                        this.estado_aceptacion.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                this.estado_aceptacion = null;
                return false;
            }
            this.estado_aceptacion = null;
            return false;
        }
        #endregion

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
