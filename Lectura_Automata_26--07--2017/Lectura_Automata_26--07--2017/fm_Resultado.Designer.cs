namespace Lectura_Automata_26__07__2017
{
    partial class fm_Resultado
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contenido_documento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_elementos_alfabeto = new System.Windows.Forms.TextBox();
            this.txt_estados_automata = new System.Windows.Forms.TextBox();
            this.txt_estados_aceptacion = new System.Windows.Forms.TextBox();
            this.btn_seleccion_documento = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_documento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectura de automata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contenido del archivo";
            // 
            // txt_contenido_documento
            // 
            this.txt_contenido_documento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_contenido_documento.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_contenido_documento.Enabled = false;
            this.txt_contenido_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contenido_documento.Location = new System.Drawing.Point(43, 112);
            this.txt_contenido_documento.Multiline = true;
            this.txt_contenido_documento.Name = "txt_contenido_documento";
            this.txt_contenido_documento.ReadOnly = true;
            this.txt_contenido_documento.Size = new System.Drawing.Size(291, 471);
            this.txt_contenido_documento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elementos del alfabeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estados del automata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(913, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estados de aceptación";
            // 
            // txt_elementos_alfabeto
            // 
            this.txt_elementos_alfabeto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_elementos_alfabeto.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_elementos_alfabeto.Enabled = false;
            this.txt_elementos_alfabeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elementos_alfabeto.Location = new System.Drawing.Point(643, 112);
            this.txt_elementos_alfabeto.Multiline = true;
            this.txt_elementos_alfabeto.Name = "txt_elementos_alfabeto";
            this.txt_elementos_alfabeto.ReadOnly = true;
            this.txt_elementos_alfabeto.Size = new System.Drawing.Size(231, 471);
            this.txt_elementos_alfabeto.TabIndex = 6;
            this.txt_elementos_alfabeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_estados_automata
            // 
            this.txt_estados_automata.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_estados_automata.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_estados_automata.Enabled = false;
            this.txt_estados_automata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estados_automata.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_estados_automata.Location = new System.Drawing.Point(369, 112);
            this.txt_estados_automata.Multiline = true;
            this.txt_estados_automata.Name = "txt_estados_automata";
            this.txt_estados_automata.ReadOnly = true;
            this.txt_estados_automata.Size = new System.Drawing.Size(229, 471);
            this.txt_estados_automata.TabIndex = 7;
            this.txt_estados_automata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_estados_aceptacion
            // 
            this.txt_estados_aceptacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_estados_aceptacion.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_estados_aceptacion.Enabled = false;
            this.txt_estados_aceptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estados_aceptacion.Location = new System.Drawing.Point(917, 112);
            this.txt_estados_aceptacion.Multiline = true;
            this.txt_estados_aceptacion.Name = "txt_estados_aceptacion";
            this.txt_estados_aceptacion.ReadOnly = true;
            this.txt_estados_aceptacion.Size = new System.Drawing.Size(201, 471);
            this.txt_estados_aceptacion.TabIndex = 8;
            this.txt_estados_aceptacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_seleccion_documento
            // 
            this.btn_seleccion_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccion_documento.Location = new System.Drawing.Point(1033, 592);
            this.btn_seleccion_documento.Name = "btn_seleccion_documento";
            this.btn_seleccion_documento.Size = new System.Drawing.Size(136, 45);
            this.btn_seleccion_documento.TabIndex = 9;
            this.btn_seleccion_documento.Text = "Seleccionar otro documento";
            this.btn_seleccion_documento.UseVisualStyleBackColor = true;
            this.btn_seleccion_documento.Click += new System.EventHandler(this.btn_seleccion_documento_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(43, 595);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(142, 38);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir del programa";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // txt_nombre_documento
            // 
            this.txt_nombre_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_documento.Location = new System.Drawing.Point(726, 595);
            this.txt_nombre_documento.Multiline = true;
            this.txt_nombre_documento.Name = "txt_nombre_documento";
            this.txt_nombre_documento.Size = new System.Drawing.Size(290, 42);
            this.txt_nombre_documento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre del documento:";
            // 
            // fm_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 649);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nombre_documento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_seleccion_documento);
            this.Controls.Add(this.txt_estados_aceptacion);
            this.Controls.Add(this.txt_estados_automata);
            this.Controls.Add(this.txt_elementos_alfabeto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contenido_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fm_Resultado";
            this.Text = "Lectura de automata";
            this.Load += new System.EventHandler(this.fm_Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contenido_documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_elementos_alfabeto;
        private System.Windows.Forms.TextBox txt_estados_automata;
        private System.Windows.Forms.TextBox txt_estados_aceptacion;
        private System.Windows.Forms.Button btn_seleccion_documento;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_documento;
        private System.Windows.Forms.Label label7;
    }
}