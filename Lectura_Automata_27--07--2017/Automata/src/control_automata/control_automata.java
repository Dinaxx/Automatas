/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control_automata;

import control_documento.Icontrol_documento;
import java.awt.List;
import java.io.BufferedReader;
import java.io.FileReader;

/**
 *
 * @author rbarahona
 */
public class control_automata implements Icontrol_automata {
   
    private Icontrol_documento documento;
    private List estado_automata;
    private List elemento_alfabeto;
    private List estado_aceptacion;
    private String contenido_documento;
    private final char ind_estado_automata = 'Q';
    private final char ind_elemento_alfabeto = 'E';
    private final char ind_estado_aceptacion = 'A';
    
    
    public control_automata(Icontrol_documento documento){
        this.documento = documento;
        this.estado_automata = null;
        this.elemento_alfabeto = null;
        this.estado_aceptacion = null;
        this.contenido_documento = "";
        try{
            ValidaContenido();
        }
        catch(Exception e){
            throw new IllegalArgumentException("\nError de sintaxis en el documento.\n" + e.getMessage());
        }
    }
    
    private void ValidaContenido(){
        try(BufferedReader lector = new BufferedReader(new FileReader(this.documento.getDocumento()))){
            for(String linea_documento; (linea_documento = lector.readLine()) != null;){
                this.contenido_documento += linea_documento + '\n';
            }
        }
        catch(Exception e){
            throw new IllegalArgumentException("\nError en la lectura del documento.\n" + e.getMessage());
        }
    }
    
    @Override
    public String obtenerContenidoDocumento(){
        return this.contenido_documento;
    }

    @Override
    public void setEstadosAutomata(List estado_automata) {
        this.estado_automata = estado_automata;
    }
    @Override
    public List getEstadosAutomata() {
        return this.estado_automata;
    }

    @Override
    public void setElementosAlfabeto(List elemento_alfabeto) {
        this.elemento_alfabeto = elemento_alfabeto;
    }
    @Override
    public List getElementosAlfabeto() {
        return this.elemento_alfabeto;
    }

    @Override
    public void setEstadosAceptacion(List estado_aceptacion) {
        this.estado_aceptacion = estado_aceptacion;
    }
    @Override
    public List getEstadosAcrptacion() {
        return this.estado_aceptacion;
    }

    @Override
    public void setControlDocumento(Icontrol_documento documento) {
        this.documento = documento;
    }
    @Override
    public Icontrol_documento getControlDocumento() {
        return this.documento;
    }
}
