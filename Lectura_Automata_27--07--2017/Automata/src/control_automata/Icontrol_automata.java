/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control_automata;

import control_documento.Icontrol_documento;
import java.awt.List;

/**
 *
 * @author rbarahona
 */
public interface Icontrol_automata {
    public void setEstadosAutomata(List estado_automata);
    public List getEstadosAutomata();
    public void setElementosAlfabeto(List elemento_alfabeto);
    public List getElementosAlfabeto();
    public void setEstadosAceptacion(List estado_aceptacion);
    public List getEstadosAcrptacion();
    public void setControlDocumento(Icontrol_documento documento);
    public Icontrol_documento getControlDocumento();
    public String obtenerContenidoDocumento();
}
