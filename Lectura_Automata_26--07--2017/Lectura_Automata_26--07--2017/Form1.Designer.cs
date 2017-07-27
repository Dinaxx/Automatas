namespace Lectura_Automata_26__07__2017
{
    partial class Form1
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
            this.txt_path_documento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_seleccion_documento = new System.Windows.Forms.Button();
            this.btn_leer_automata = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectura de automata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el path del documento:";
            // 
            // txt_path_documento
            // 
            this.txt_path_documento.Location = new System.Drawing.Point(269, 114);
            this.txt_path_documento.Name = "txt_path_documento";
            this.txt_path_documento.Size = new System.Drawing.Size(225, 20);
            this.txt_path_documento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccionar documento mediante path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selecconar documento mediante explorador de archivos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ningun archivo seleccionado";
            // 
            // btn_seleccion_documento
            // 
            this.btn_seleccion_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccion_documento.Location = new System.Drawing.Point(32, 212);
            this.btn_seleccion_documento.Name = "btn_seleccion_documento";
            this.btn_seleccion_documento.Size = new System.Drawing.Size(164, 35);
            this.btn_seleccion_documento.TabIndex = 6;
            this.btn_seleccion_documento.Text = "Seleccionar documento";
            this.btn_seleccion_documento.UseVisualStyleBackColor = true;
            // 
            // btn_leer_automata
            // 
            this.btn_leer_automata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer_automata.Location = new System.Drawing.Point(489, 291);
            this.btn_leer_automata.Name = "btn_leer_automata";
            this.btn_leer_automata.Size = new System.Drawing.Size(126, 36);
            this.btn_leer_automata.TabIndex = 7;
            this.btn_leer_automata.Text = "Leer automata";
            this.btn_leer_automata.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(32, 292);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(164, 35);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir del programa";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 339);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_leer_automata);
            this.Controls.Add(this.btn_seleccion_documento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_path_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_path_documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_seleccion_documento;
        private System.Windows.Forms.Button btn_leer_automata;
        private System.Windows.Forms.Button btn_salir;
    }
}

