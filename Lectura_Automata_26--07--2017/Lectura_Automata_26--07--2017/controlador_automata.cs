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
        private List<List<String>>      funcion_transicion;
        
        private const char              indicador_estado_automata = 'Q';
        private const char              indicador_elemento_alfabeto = 'E';
        private const char              indicador_estado_inicial = 'i';
        private const char              indicador_estado_aceptacion = 'A';
        private const char              indicador_funcion_transicion = 'w';
        #endregion

        public controlador_automata(Icontrolador_documento documento)
        {
            this.documento          = documento;
            this.estado_automata    = null;
            this.elemento_alfabeto  = null;
            this.estado_aceptacion  = null;
            this.funcion_transicion = null;
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
                        clasificaicon_linea(linea_documento);
                    }
                }
            }
            catch (Exception e)
            {
                throw new System.ArgumentException("Ha ocurrido un error dentro del documento.\n" + e.Message);
            }
            #endregion
        }

        private void clasificaicon_linea(String linea_documento)
        {
            try
            {
                switch (linea_documento[0])
                {
                    case indicador_estado_automata:
                        {
                            creaEstadosAutomata(linea_documento);
                            break;
                        }
                    case indicador_elemento_alfabeto:
                        {
                            creaElementosAlfabeto(linea_documento);
                            break;
                        }
                    case indicador_estado_inicial:
                        {
                            creaEstadoIncial(linea_documento);
                            break;
                        }
                    case indicador_estado_aceptacion:
                        {
                            creaEstadosAceptacion(linea_documento);
                            break;
                        }
                    case indicador_funcion_transicion:
                        {
                            creaFuncionTransicion(linea_documento);
                            break;
                        }
                    case '(':
                        {
                            creaFuncionTransicion(linea_documento);
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("\nSe ha encontrado un caracter no definido.");
                        }
                }
            }
            catch(Exception e)
            {
                throw new ArgumentException("\nError en la clasificacion del documento.\n" + e.Message);
            }
        }

        #region Control Estados Automata
        private void creaEstadosAutomata(String linea_documento)
        {
            this.estado_automata    = new List<string>();
            string cadena_auxilia   = "";
            bool estado_inicial     = true
                ,busca_signo_igual  = true
                ,inicio_llave       = false;

            foreach(Char letra_linea in linea_documento)
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
                        throw new ArgumentException("\n No se ha encontrado el signo '=' en los estados del automata.\n");
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
                        throw new ArgumentException("No se ha encontrado el signo '{' en los estados del automata.\n");
                    }
                }
                if(inicio_llave)
                {
                    
                    if(letra_linea != ',' && letra_linea != '}' && letra_linea != 68)
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if (letra_linea == '}' || letra_linea == 68)
                    {
                        this.estado_automata.Add(cadena_auxilia);
                        return;
                    }
                    else
                    {
                        this.estado_automata.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                //this.estado_automata = null;
                throw new ArgumentException("\nHa ocurrido un error inesperado en los estados del automata.\n");
            }
            //this.estado_automata = null;
            //throw new ArgumentException("\nNo se ha encontrado el signo '}' en los estados del automata,\n");
        }
        #endregion

        #region Control Elementos Alfabeto
        private void creaElementosAlfabeto(String linea_documento)
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
                        throw new ArgumentException("\nNo se ha encontrado el signo '=' en los elementos del alfabeto.\n");
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
                        throw new ArgumentException("\nNo se ha encontrado el signo '{' en los elementos del alfabeto.\n");
                    }
                }
                if (inicio_llave)
                {
                    Console.WriteLine("Codigo: " + Convert.ToInt32(letra_linea) + " letra: " + letra_linea);
                    if(letra_linea != ',' && letra_linea != '}' && letra_linea != 68)
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if(letra_linea == '}' || letra_linea == 68)
                    {
                        this.elemento_alfabeto.Add(cadena_auxilia);
                        return;
                    }
                    else
                    {
                        this.elemento_alfabeto.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                //this.elemento_alfabeto = null;
                throw new ArgumentException("\nHa ocurrido un error inesperado en durante la lectura de los elementos del alfabeto.\n");
            }
            //this.elemento_alfabeto = null;
            //throw new ArgumentException("\nNo se ha encontrado el signo '}' en los elementos del alfabeto.\n");
        }
        #endregion

        #region Control Estado Inicial
        private void creaEstadoIncial(String linea_documento)
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
                        throw new ArgumentException("\nNo se ha encontrado el signo '=' en el estado inicial del automata.\n");
                    }
                }
                if(!estado_inicial && !busca_signo_igual)
                {
                    if(letra_linea == ',' || letra_linea == '{' || letra_linea == '}')
                    {
                        throw new ArgumentException("\nSe encontraron un signos que no eran pertenecientes al estado inicial del automata.\n");
                    }
                    else
                    {
                        continue;
                    }
                }
                throw new ArgumentException("\nHa ocurrido un error inesperado en el estado inicial del automata.\n");
            }
            return;
        }
        #endregion

        #region Control estados aceptacion
        private void creaEstadosAceptacion(String linea_documento)
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
                        throw new ArgumentException("\nNo se ha encontrado el signo '=' en los estados de aceptacion del automata.\n");
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
                        throw new ArgumentException("\nNo se ha encontrado el signo '{' en los estados de aceptacion del automata.\n");
                    }
                }
                if (inicio_llave)
                {
                    if(letra_linea != ',' && letra_linea != '}' && letra_linea != 68)
                    {
                        cadena_auxilia += letra_linea;
                        continue;
                    }
                    else if(letra_linea == '}' || letra_linea == 68)
                    {
                        this.estado_aceptacion.Add(cadena_auxilia);
                        return;
                    }
                    else
                    {
                        this.estado_aceptacion.Add(cadena_auxilia);
                        cadena_auxilia = "";
                        continue;
                    }
                }
                //this.estado_aceptacion = null;
                //throw new ArgumentException("\nHa ocurrido un error inesperado en los estados de aceptacion del automata.\n");
            }
            //this.estado_aceptacion = null;
            throw new ArgumentException("\nNo se ha encontrado el signo '}' en los estados de aceptacion del automata.\n");
        }

        public void creaFuncionTransicion(String linea_transicion)
        {
            bool estado_inicial = true
                ,busca_igual
                ,comenzar_busqueda = true;
            this.funcion_transicion = new List<List<String>>();
            List<String> funcion_auxiliar = new List<String>();
            if(linea_transicion[0] == '(')
            {
                busca_igual = false;
            }
            else
            {
                busca_igual = true;
            }
            foreach(char letra_linea in linea_transicion)
            {
                if (estado_inicial)
                {
                    continue;
                }
                if (busca_igual)
                {
                    if (letra_linea == '=')
                    {
                        continue;
                    }
                    else
                    {
                        throw new ArgumentException("\nNo se ha encontrado el signo '=' en la esprecion");
                    }
                }
                if (!busca_igual)
                {
                    if(letra_linea == '{')
                    {
                        continue;
                    }
                }
                if(letra_linea == '(')
                {
                    continue;
                }
                if(letra_linea != ',' || letra_linea != '(')
                {
                }
            }
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
