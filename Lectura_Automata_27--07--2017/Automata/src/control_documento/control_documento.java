/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control_documento;

import java.io.File;
import javax.swing.JFileChooser;
import javax.swing.JPanel;

/**
 *
 * @author Alejandro
 */
public class control_documento implements Icontrol_documento {
    
    private JFileChooser documento_selecto;
    private File documento;
    
    public control_documento(){
        this.documento_selecto = new JFileChooser();
    }
    
    //<editor-fold defaultstate="collapsed" desc=" Get y Set ">

    /**
     *
     * @param documento_selector
     */
    @Override
    public void setDocumentoSelector(JFileChooser documento_selector){
        this.documento_selecto = documento_selector;
    }

    /**
     *
     * @return
     */
    @Override
    public JFileChooser getDocumentoSelector(){
        return this.documento_selecto;
    }
    
    /**
     *
     * @param documento
     */
    @Override
    public void setDocumento(File documento){
        this.documento = documento;
    }

    /**
     *
     * @return
     */
    @Override
    public File getDocumento(){
        return this.documento;
    }

    /**
     *
     * @return
     */
    @Override
    public String getNombreDocumento(){
        return this.documento.getName();
    }
    //</editor-fold>
    
    /**
     *
     * @param parent
     */
    @Override
    public void seleccionDocumento(JPanel parent){
        this.documento_selecto.setCurrentDirectory(new File(System.getProperty("user.home")));
        int result = this.documento_selecto.showOpenDialog(parent);
        if(result == JFileChooser.APPROVE_OPTION){
            this.documento = this.documento_selecto.getSelectedFile();
        }
    }
}
