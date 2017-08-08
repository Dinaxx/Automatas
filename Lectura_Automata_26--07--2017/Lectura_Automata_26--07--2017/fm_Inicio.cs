/*
 *  Autor: Raul Alejandro Hernandez Barahona
 *  Fecha de creacion: 27-07-2017
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lectura_Automata_26__07__2017
{
    public partial class fm_Inicio : Form
    {
        private Icontrolador_documento documento;
        private Icontrolador_automata automata;
        public fm_Inicio()
        {
            documento   = new controlador_documento();
            InitializeComponent();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_seleccion_documento_Click(object sender, EventArgs e)
        {
            documento.obtenerDocumentoSelector();
            lbl_nombre_documento.Text = this.documento.NombreDocumento;
            this.automata = new controlador_automata(documento);

            #region limpieza de text box
            txt_contenido_documento.Text    = "";
            txt_elementos_alfabeto.Text     = "";
            txt_estados_aceptacion.Text     = "";
            txt_estados_automata.Text       = "";
            txt_funcion_transicion.Text     = "";
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
            if (automata.fn_estado_aceptacion != null)
            {
                foreach (String estados_aceptacion in automata.fn_estado_aceptacion)
                {
                    txt_estados_aceptacion.Text += estados_aceptacion + Environment.NewLine;
                }
            }
            if(automata.fn_funcion_transicion != null)
            {
                String[] elementos_alfabeto     = this.automata.fn_elemento_alfabeto.ToArray();
                String[] estados_automata       = this.automata.fn_estado_automata.ToArray();
                txt_funcion_transicion.Text     += String.Format("| {0,2} | ", "  ");
                foreach (String elemento in elementos_alfabeto)
                {
                    txt_funcion_transicion.Text += String.Format("{0,1} | ", elemento);
                }
                foreach(String estado in estados_automata)
                {
                    txt_funcion_transicion.Text += Environment.NewLine;
                    txt_funcion_transicion.Text += String.Format("| {0,1} | ", estado);
                    foreach(String elemento in elementos_alfabeto)
                    {
                        foreach(List<String> funciones_transcion in this.automata.fn_funcion_transicion)
                        {
                            bool inicio = true
                            , alfabeto  = false
                            , final     = false;
                            foreach (String contenido_funcion in funciones_transcion)
                            {
                                if (inicio)
                                {
                                    inicio   = false;
                                    alfabeto = true;
                                    if(contenido_funcion != estado)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                if(!inicio && alfabeto)
                                {
                                    alfabeto    = false;
                                    final       = true;
                                    if(contenido_funcion != elemento)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                if(!inicio && !alfabeto && final)
                                {
                                    txt_funcion_transicion.Text += String.Format("{0,1} | ", contenido_funcion);
                                    //Console.WriteLine(String.Format("Estado: {0}, Alfabeto: {1}, Resultado: {2}", estado, elemento, contenido_funcion));
                                    break;
                                }
                            }
                        }
//                        txt_funcion_transicion.Text += String.Format("{0,1} | ", 'x');
                    }
                }
                /*foreach(List<String> funciones_transicion in automata.fn_funcion_transicion)
                {
                    txt_funcion_transicion.Text += "| ";
                    foreach(String contenido_funcion in funciones_transicion)
                    {
                        txt_funcion_transicion.Text += contenido_funcion + " | ";
                        //txt_funcion_transicion.Text += funcion_transicion;
                    }
                    txt_funcion_transicion
                }*/
            }
        }
        
    }
}