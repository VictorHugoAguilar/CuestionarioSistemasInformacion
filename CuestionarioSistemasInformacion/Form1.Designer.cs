namespace CuestionarioSistemasInformacion
{
    partial class Cuestionario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblRespuesta1 = new System.Windows.Forms.Label();
            this.grpPregunta = new System.Windows.Forms.GroupBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.lblRespuesta2 = new System.Windows.Forms.Label();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.lblRespuesta3 = new System.Windows.Forms.Label();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.lblRespuesta4 = new System.Windows.Forms.Label();
            this.grpPuntuacion = new System.Windows.Forms.GroupBox();
            this.lblCorrecta = new System.Windows.Forms.Label();
            this.lblIncorrecta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPuntuacionCorrecta = new System.Windows.Forms.Label();
            this.lblPuntuacionIncorrecta = new System.Windows.Forms.Label();
            this.lblPuntuacionTotal = new System.Windows.Forms.Label();
            this.btnAñadirPregunta = new System.Windows.Forms.Button();
            this.btnEliminarPregunta = new System.Windows.Forms.Button();
            this.btnAuxiliar = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.grpPregunta.SuspendLayout();
            this.grpPuntuacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(35, 699);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(167, 60);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblRespuesta1
            // 
            this.lblRespuesta1.AutoSize = true;
            this.lblRespuesta1.Location = new System.Drawing.Point(97, 196);
            this.lblRespuesta1.Name = "lblRespuesta1";
            this.lblRespuesta1.Size = new System.Drawing.Size(70, 25);
            this.lblRespuesta1.TabIndex = 1;
            this.lblRespuesta1.Text = "label1";
            this.lblRespuesta1.Click += new System.EventHandler(this.lblPregunta1_Click);
            // 
            // grpPregunta
            // 
            this.grpPregunta.Controls.Add(this.lblPregunta);
            this.grpPregunta.Controls.Add(this.rbtn4);
            this.grpPregunta.Controls.Add(this.btnSiguiente);
            this.grpPregunta.Controls.Add(this.lblRespuesta4);
            this.grpPregunta.Controls.Add(this.rbtn3);
            this.grpPregunta.Controls.Add(this.lblRespuesta3);
            this.grpPregunta.Controls.Add(this.rbtn2);
            this.grpPregunta.Controls.Add(this.lblRespuesta2);
            this.grpPregunta.Controls.Add(this.rbtn1);
            this.grpPregunta.Controls.Add(this.lblRespuesta1);
            this.grpPregunta.Location = new System.Drawing.Point(44, 61);
            this.grpPregunta.Name = "grpPregunta";
            this.grpPregunta.Size = new System.Drawing.Size(1713, 800);
            this.grpPregunta.TabIndex = 2;
            this.grpPregunta.TabStop = false;
            this.grpPregunta.Text = "Pregunta";
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(35, 195);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(27, 26);
            this.rbtn1.TabIndex = 2;
            this.rbtn1.TabStop = true;
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(35, 325);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(27, 26);
            this.rbtn2.TabIndex = 4;
            this.rbtn2.TabStop = true;
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta2
            // 
            this.lblRespuesta2.AutoSize = true;
            this.lblRespuesta2.Location = new System.Drawing.Point(97, 326);
            this.lblRespuesta2.Name = "lblRespuesta2";
            this.lblRespuesta2.Size = new System.Drawing.Size(70, 25);
            this.lblRespuesta2.TabIndex = 3;
            this.lblRespuesta2.Text = "label2";
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(35, 456);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(27, 26);
            this.rbtn3.TabIndex = 6;
            this.rbtn3.TabStop = true;
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta3
            // 
            this.lblRespuesta3.AutoSize = true;
            this.lblRespuesta3.Location = new System.Drawing.Point(97, 457);
            this.lblRespuesta3.Name = "lblRespuesta3";
            this.lblRespuesta3.Size = new System.Drawing.Size(70, 25);
            this.lblRespuesta3.TabIndex = 5;
            this.lblRespuesta3.Text = "label3";
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Location = new System.Drawing.Point(35, 595);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(27, 26);
            this.rbtn4.TabIndex = 8;
            this.rbtn4.TabStop = true;
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta4
            // 
            this.lblRespuesta4.AutoSize = true;
            this.lblRespuesta4.Location = new System.Drawing.Point(97, 596);
            this.lblRespuesta4.Name = "lblRespuesta4";
            this.lblRespuesta4.Size = new System.Drawing.Size(70, 25);
            this.lblRespuesta4.TabIndex = 7;
            this.lblRespuesta4.Text = "label4";
            // 
            // grpPuntuacion
            // 
            this.grpPuntuacion.Controls.Add(this.lblPuntuacionTotal);
            this.grpPuntuacion.Controls.Add(this.lblPuntuacionIncorrecta);
            this.grpPuntuacion.Controls.Add(this.lblPuntuacionCorrecta);
            this.grpPuntuacion.Controls.Add(this.lblTotal);
            this.grpPuntuacion.Controls.Add(this.lblIncorrecta);
            this.grpPuntuacion.Controls.Add(this.lblCorrecta);
            this.grpPuntuacion.Location = new System.Drawing.Point(1788, 65);
            this.grpPuntuacion.Name = "grpPuntuacion";
            this.grpPuntuacion.Size = new System.Drawing.Size(200, 440);
            this.grpPuntuacion.TabIndex = 3;
            this.grpPuntuacion.TabStop = false;
            this.grpPuntuacion.Text = "Puntucacion";
            // 
            // lblCorrecta
            // 
            this.lblCorrecta.AutoSize = true;
            this.lblCorrecta.Location = new System.Drawing.Point(21, 74);
            this.lblCorrecta.Name = "lblCorrecta";
            this.lblCorrecta.Size = new System.Drawing.Size(94, 25);
            this.lblCorrecta.TabIndex = 4;
            this.lblCorrecta.Text = "Correcta";
            // 
            // lblIncorrecta
            // 
            this.lblIncorrecta.AutoSize = true;
            this.lblIncorrecta.Location = new System.Drawing.Point(21, 192);
            this.lblIncorrecta.Name = "lblIncorrecta";
            this.lblIncorrecta.Size = new System.Drawing.Size(118, 25);
            this.lblIncorrecta.TabIndex = 5;
            this.lblIncorrecta.Text = "Incorrectas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPuntuacionCorrecta
            // 
            this.lblPuntuacionCorrecta.AutoSize = true;
            this.lblPuntuacionCorrecta.Location = new System.Drawing.Point(72, 131);
            this.lblPuntuacionCorrecta.Name = "lblPuntuacionCorrecta";
            this.lblPuntuacionCorrecta.Size = new System.Drawing.Size(24, 25);
            this.lblPuntuacionCorrecta.TabIndex = 7;
            this.lblPuntuacionCorrecta.Text = "0";
            // 
            // lblPuntuacionIncorrecta
            // 
            this.lblPuntuacionIncorrecta.AutoSize = true;
            this.lblPuntuacionIncorrecta.Location = new System.Drawing.Point(72, 256);
            this.lblPuntuacionIncorrecta.Name = "lblPuntuacionIncorrecta";
            this.lblPuntuacionIncorrecta.Size = new System.Drawing.Size(24, 25);
            this.lblPuntuacionIncorrecta.TabIndex = 8;
            this.lblPuntuacionIncorrecta.Text = "0";
            // 
            // lblPuntuacionTotal
            // 
            this.lblPuntuacionTotal.AutoSize = true;
            this.lblPuntuacionTotal.Location = new System.Drawing.Point(72, 381);
            this.lblPuntuacionTotal.Name = "lblPuntuacionTotal";
            this.lblPuntuacionTotal.Size = new System.Drawing.Size(24, 25);
            this.lblPuntuacionTotal.TabIndex = 9;
            this.lblPuntuacionTotal.Text = "0";
            // 
            // btnAñadirPregunta
            // 
            this.btnAñadirPregunta.Location = new System.Drawing.Point(79, 912);
            this.btnAñadirPregunta.Name = "btnAñadirPregunta";
            this.btnAñadirPregunta.Size = new System.Drawing.Size(325, 60);
            this.btnAñadirPregunta.TabIndex = 9;
            this.btnAñadirPregunta.Text = "Añadir Pregunta";
            this.btnAñadirPregunta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPregunta
            // 
            this.btnEliminarPregunta.Location = new System.Drawing.Point(462, 912);
            this.btnEliminarPregunta.Name = "btnEliminarPregunta";
            this.btnEliminarPregunta.Size = new System.Drawing.Size(325, 60);
            this.btnEliminarPregunta.TabIndex = 10;
            this.btnEliminarPregunta.Text = "Eliminar Pregunta";
            this.btnEliminarPregunta.UseVisualStyleBackColor = true;
            // 
            // btnAuxiliar
            // 
            this.btnAuxiliar.Location = new System.Drawing.Point(834, 912);
            this.btnAuxiliar.Name = "btnAuxiliar";
            this.btnAuxiliar.Size = new System.Drawing.Size(325, 60);
            this.btnAuxiliar.TabIndex = 11;
            this.btnAuxiliar.Text = "Auxiliar";
            this.btnAuxiliar.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(30, 78);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(99, 25);
            this.lblPregunta.TabIndex = 9;
            this.lblPregunta.Text = "Pregunta";
            // 
            // Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1034);
            this.Controls.Add(this.btnAuxiliar);
            this.Controls.Add(this.btnEliminarPregunta);
            this.Controls.Add(this.btnAñadirPregunta);
            this.Controls.Add(this.grpPuntuacion);
            this.Controls.Add(this.grpPregunta);
            this.Name = "Cuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cuestionario_Load);
            this.grpPregunta.ResumeLayout(false);
            this.grpPregunta.PerformLayout();
            this.grpPuntuacion.ResumeLayout(false);
            this.grpPuntuacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblRespuesta1;
        private System.Windows.Forms.GroupBox grpPregunta;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.Label lblRespuesta4;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.Label lblRespuesta3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Label lblRespuesta2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.GroupBox grpPuntuacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIncorrecta;
        private System.Windows.Forms.Label lblCorrecta;
        private System.Windows.Forms.Label lblPuntuacionTotal;
        private System.Windows.Forms.Label lblPuntuacionIncorrecta;
        private System.Windows.Forms.Label lblPuntuacionCorrecta;
        private System.Windows.Forms.Button btnAñadirPregunta;
        private System.Windows.Forms.Button btnEliminarPregunta;
        private System.Windows.Forms.Button btnAuxiliar;
        private System.Windows.Forms.Label lblPregunta;
    }
}

