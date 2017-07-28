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
public interface Icontrol_documento {
    public void setDocumentoSelector(JFileChooser documento_selector);
    public JFileChooser getDocumentoSelector();
    public void setDocumento(File documento);
    public File getDocumento();
    public String getNombreDocumento();
    public void seleccionDocumento(JPanel parent);
}
