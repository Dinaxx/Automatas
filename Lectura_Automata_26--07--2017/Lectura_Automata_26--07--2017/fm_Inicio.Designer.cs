namespace Lectura_Automata_26__07__2017
{
    partial class fm_Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nombre_documento = new System.Windows.Forms.Label();
            this.btn_seleccion_documento = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_estados_aceptacion = new System.Windows.Forms.TextBox();
            this.txt_estados_automata = new System.Windows.Forms.TextBox();
            this.txt_elementos_alfabeto = new System.Windows.Forms.TextBox();
            this.txt_contenido_documento = new System.Windows.Forms.TextBox();
            this.txt_funcion_transicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectura de automata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selecconar documento mediante explorador de archivos";
            // 
            // lbl_nombre_documento
            // 
            this.lbl_nombre_documento.AutoSize = true;
            this.lbl_nombre_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_documento.Location = new System.Drawing.Point(202, 123);
            this.lbl_nombre_documento.Name = "lbl_nombre_documento";
            this.lbl_nombre_documento.Size = new System.Drawing.Size(210, 20);
            this.lbl_nombre_documento.TabIndex = 5;
            this.lbl_nombre_documento.Text = "Ningun archivo seleccionado";
            // 
            // btn_seleccion_documento
            // 
            this.btn_seleccion_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccion_documento.Location = new System.Drawing.Point(32, 108);
            this.btn_seleccion_documento.Name = "btn_seleccion_documento";
            this.btn_seleccion_documento.Size = new System.Drawing.Size(164, 35);
            this.btn_seleccion_documento.TabIndex = 6;
            this.btn_seleccion_documento.Text = "Seleccionar documento";
            this.btn_seleccion_documento.UseVisualStyleBackColor = true;
            this.btn_seleccion_documento.Click += new System.EventHandler(this.btn_seleccion_documento_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(1045, 519);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(164, 35);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir del programa";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_estados_aceptacion
            // 
            this.txt_estados_aceptacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_estados_aceptacion.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_estados_aceptacion.Enabled = false;
            this.txt_estados_aceptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estados_aceptacion.Location = new System.Drawing.Point(780, 168);
            this.txt_estados_aceptacion.Multiline = true;
            this.txt_estados_aceptacion.Name = "txt_estados_aceptacion";
            this.txt_estados_aceptacion.ReadOnly = true;
            this.txt_estados_aceptacion.Size = new System.Drawing.Size(201, 315);
            this.txt_estados_aceptacion.TabIndex = 11;
            this.txt_estados_aceptacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_estados_automata
            // 
            this.txt_estados_automata.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_estados_automata.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_estados_automata.Enabled = false;
            this.txt_estados_automata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estados_automata.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_estados_automata.Location = new System.Drawing.Point(278, 168);
            this.txt_estados_automata.Multiline = true;
            this.txt_estados_automata.Name = "txt_estados_automata";
            this.txt_estados_automata.ReadOnly = true;
            this.txt_estados_automata.Size = new System.Drawing.Size(229, 315);
            this.txt_estados_automata.TabIndex = 10;
            this.txt_estados_automata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_elementos_alfabeto
            // 
            this.txt_elementos_alfabeto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_elementos_alfabeto.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_elementos_alfabeto.Enabled = false;
            this.txt_elementos_alfabeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elementos_alfabeto.Location = new System.Drawing.Point(527, 168);
            this.txt_elementos_alfabeto.Multiline = true;
            this.txt_elementos_alfabeto.Name = "txt_elementos_alfabeto";
            this.txt_elementos_alfabeto.ReadOnly = true;
            this.txt_elementos_alfabeto.Size = new System.Drawing.Size(231, 315);
            this.txt_elementos_alfabeto.TabIndex = 9;
            this.txt_elementos_alfabeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_contenido_documento
            // 
            this.txt_contenido_documento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_contenido_documento.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_contenido_documento.Enabled = false;
            this.txt_contenido_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contenido_documento.Location = new System.Drawing.Point(23, 168);
            this.txt_contenido_documento.Multiline = true;
            this.txt_contenido_documento.Name = "txt_contenido_documento";
            this.txt_contenido_documento.ReadOnly = true;
            this.txt_contenido_documento.Size = new System.Drawing.Size(231, 324);
            this.txt_contenido_documento.TabIndex = 12;
            // 
            // txt_funcion_transicion
            // 
            this.txt_funcion_transicion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_funcion_transicion.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_funcion_transicion.Enabled = false;
            this.txt_funcion_transicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcion_transicion.Location = new System.Drawing.Point(1008, 168);
            this.txt_funcion_transicion.Multiline = true;
            this.txt_funcion_transicion.Name = "txt_funcion_transicion";
            this.txt_funcion_transicion.ReadOnly = true;
            this.txt_funcion_transicion.Size = new System.Drawing.Size(201, 315);
            this.txt_funcion_transicion.TabIndex = 13;
            this.txt_funcion_transicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 566);
            this.Controls.Add(this.txt_funcion_transicion);
            this.Controls.Add(this.txt_contenido_documento);
            this.Controls.Add(this.txt_estados_aceptacion);
            this.Controls.Add(this.txt_estados_automata);
            this.Controls.Add(this.txt_elementos_alfabeto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_seleccion_documento);
            this.Controls.Add(this.lbl_nombre_documento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "fm_Inicio";
            this.Text = "Lectura de automata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nombre_documento;
        private System.Windows.Forms.Button btn_seleccion_documento;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_estados_aceptacion;
        private System.Windows.Forms.TextBox txt_estados_automata;
        private System.Windows.Forms.TextBox txt_elementos_alfabeto;
        private System.Windows.Forms.TextBox txt_contenido_documento;
        private System.Windows.Forms.TextBox txt_funcion_transicion;
    }
}

