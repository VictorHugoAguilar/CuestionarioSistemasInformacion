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
			this.lblPregunta = new System.Windows.Forms.Label();
			this.rbtn4 = new System.Windows.Forms.RadioButton();
			this.lblRespuesta4 = new System.Windows.Forms.Label();
			this.rbtn3 = new System.Windows.Forms.RadioButton();
			this.lblRespuesta3 = new System.Windows.Forms.Label();
			this.rbtn2 = new System.Windows.Forms.RadioButton();
			this.lblRespuesta2 = new System.Windows.Forms.Label();
			this.rbtn1 = new System.Windows.Forms.RadioButton();
			this.grpPuntuacion = new System.Windows.Forms.GroupBox();
			this.lblPuntuacionTotal = new System.Windows.Forms.Label();
			this.lblPuntuacionIncorrecta = new System.Windows.Forms.Label();
			this.lblPuntuacionCorrecta = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblIncorrecta = new System.Windows.Forms.Label();
			this.lblCorrecta = new System.Windows.Forms.Label();
			this.btnAñadirPregunta = new System.Windows.Forms.Button();
			this.btnEliminarPregunta = new System.Windows.Forms.Button();
			this.btnComenzar = new System.Windows.Forms.Button();
			this.grpTotal = new System.Windows.Forms.GroupBox();
			this.lblRegistroUltimo = new System.Windows.Forms.Label();
			this.lblRegistrosprimero = new System.Windows.Forms.Label();
			this.lblRegistrode = new System.Windows.Forms.Label();
			this.lblRegistro = new System.Windows.Forms.Label();
			this.btnEvaluar = new System.Windows.Forms.Button();
			this.grpPregunta.SuspendLayout();
			this.grpPuntuacion.SuspendLayout();
			this.grpTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Location = new System.Drawing.Point(18, 363);
			this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(84, 31);
			this.btnSiguiente.TabIndex = 0;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// lblRespuesta1
			// 
			this.lblRespuesta1.AutoSize = true;
			this.lblRespuesta1.Location = new System.Drawing.Point(48, 102);
			this.lblRespuesta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRespuesta1.Name = "lblRespuesta1";
			this.lblRespuesta1.Size = new System.Drawing.Size(91, 13);
			this.lblRespuesta1.TabIndex = 1;
			this.lblRespuesta1.Text = "Primera respuesta";
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
			this.grpPregunta.Location = new System.Drawing.Point(22, 32);
			this.grpPregunta.Margin = new System.Windows.Forms.Padding(2);
			this.grpPregunta.Name = "grpPregunta";
			this.grpPregunta.Padding = new System.Windows.Forms.Padding(2);
			this.grpPregunta.Size = new System.Drawing.Size(856, 416);
			this.grpPregunta.TabIndex = 2;
			this.grpPregunta.TabStop = false;
			this.grpPregunta.Text = "Pregunta";
			// 
			// lblPregunta
			// 
			this.lblPregunta.AutoSize = true;
			this.lblPregunta.Location = new System.Drawing.Point(15, 41);
			this.lblPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(50, 13);
			this.lblPregunta.TabIndex = 9;
			this.lblPregunta.Text = "Pregunta";
			// 
			// rbtn4
			// 
			this.rbtn4.AutoSize = true;
			this.rbtn4.Location = new System.Drawing.Point(18, 309);
			this.rbtn4.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn4.Name = "rbtn4";
			this.rbtn4.Size = new System.Drawing.Size(14, 13);
			this.rbtn4.TabIndex = 8;
			this.rbtn4.TabStop = true;
			this.rbtn4.UseVisualStyleBackColor = true;
			this.rbtn4.CheckedChanged += new System.EventHandler(this.rbtn4_CheckedChanged);
			// 
			// lblRespuesta4
			// 
			this.lblRespuesta4.AutoSize = true;
			this.lblRespuesta4.Location = new System.Drawing.Point(48, 310);
			this.lblRespuesta4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRespuesta4.Name = "lblRespuesta4";
			this.lblRespuesta4.Size = new System.Drawing.Size(92, 13);
			this.lblRespuesta4.TabIndex = 7;
			this.lblRespuesta4.Text = "Cuarta Respuesta";
			// 
			// rbtn3
			// 
			this.rbtn3.AutoSize = true;
			this.rbtn3.Location = new System.Drawing.Point(18, 237);
			this.rbtn3.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn3.Name = "rbtn3";
			this.rbtn3.Size = new System.Drawing.Size(14, 13);
			this.rbtn3.TabIndex = 6;
			this.rbtn3.TabStop = true;
			this.rbtn3.UseVisualStyleBackColor = true;
			this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
			// 
			// lblRespuesta3
			// 
			this.lblRespuesta3.AutoSize = true;
			this.lblRespuesta3.Location = new System.Drawing.Point(48, 238);
			this.lblRespuesta3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRespuesta3.Name = "lblRespuesta3";
			this.lblRespuesta3.Size = new System.Drawing.Size(103, 13);
			this.lblRespuesta3.TabIndex = 5;
			this.lblRespuesta3.Text = "Tercera Respuestas";
			// 
			// rbtn2
			// 
			this.rbtn2.AutoSize = true;
			this.rbtn2.Location = new System.Drawing.Point(18, 169);
			this.rbtn2.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn2.Name = "rbtn2";
			this.rbtn2.Size = new System.Drawing.Size(14, 13);
			this.rbtn2.TabIndex = 4;
			this.rbtn2.TabStop = true;
			this.rbtn2.UseVisualStyleBackColor = true;
			this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
			// 
			// lblRespuesta2
			// 
			this.lblRespuesta2.AutoSize = true;
			this.lblRespuesta2.Location = new System.Drawing.Point(48, 170);
			this.lblRespuesta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRespuesta2.Name = "lblRespuesta2";
			this.lblRespuesta2.Size = new System.Drawing.Size(104, 13);
			this.lblRespuesta2.TabIndex = 3;
			this.lblRespuesta2.Text = "Segunda Respuesta";
			// 
			// rbtn1
			// 
			this.rbtn1.AutoSize = true;
			this.rbtn1.Location = new System.Drawing.Point(18, 101);
			this.rbtn1.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn1.Name = "rbtn1";
			this.rbtn1.Size = new System.Drawing.Size(14, 13);
			this.rbtn1.TabIndex = 2;
			this.rbtn1.TabStop = true;
			this.rbtn1.UseVisualStyleBackColor = true;
			this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
			// 
			// grpPuntuacion
			// 
			this.grpPuntuacion.Controls.Add(this.lblPuntuacionTotal);
			this.grpPuntuacion.Controls.Add(this.lblPuntuacionIncorrecta);
			this.grpPuntuacion.Controls.Add(this.lblPuntuacionCorrecta);
			this.grpPuntuacion.Controls.Add(this.lblTotal);
			this.grpPuntuacion.Controls.Add(this.lblIncorrecta);
			this.grpPuntuacion.Controls.Add(this.lblCorrecta);
			this.grpPuntuacion.Location = new System.Drawing.Point(894, 34);
			this.grpPuntuacion.Margin = new System.Windows.Forms.Padding(2);
			this.grpPuntuacion.Name = "grpPuntuacion";
			this.grpPuntuacion.Padding = new System.Windows.Forms.Padding(2);
			this.grpPuntuacion.Size = new System.Drawing.Size(100, 229);
			this.grpPuntuacion.TabIndex = 3;
			this.grpPuntuacion.TabStop = false;
			this.grpPuntuacion.Text = "Puntuacion";
			// 
			// lblPuntuacionTotal
			// 
			this.lblPuntuacionTotal.AutoSize = true;
			this.lblPuntuacionTotal.Location = new System.Drawing.Point(36, 198);
			this.lblPuntuacionTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPuntuacionTotal.Name = "lblPuntuacionTotal";
			this.lblPuntuacionTotal.Size = new System.Drawing.Size(13, 13);
			this.lblPuntuacionTotal.TabIndex = 9;
			this.lblPuntuacionTotal.Text = "0";
			// 
			// lblPuntuacionIncorrecta
			// 
			this.lblPuntuacionIncorrecta.AutoSize = true;
			this.lblPuntuacionIncorrecta.Location = new System.Drawing.Point(36, 133);
			this.lblPuntuacionIncorrecta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPuntuacionIncorrecta.Name = "lblPuntuacionIncorrecta";
			this.lblPuntuacionIncorrecta.Size = new System.Drawing.Size(13, 13);
			this.lblPuntuacionIncorrecta.TabIndex = 8;
			this.lblPuntuacionIncorrecta.Text = "0";
			// 
			// lblPuntuacionCorrecta
			// 
			this.lblPuntuacionCorrecta.AutoSize = true;
			this.lblPuntuacionCorrecta.Location = new System.Drawing.Point(36, 68);
			this.lblPuntuacionCorrecta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPuntuacionCorrecta.Name = "lblPuntuacionCorrecta";
			this.lblPuntuacionCorrecta.Size = new System.Drawing.Size(13, 13);
			this.lblPuntuacionCorrecta.TabIndex = 7;
			this.lblPuntuacionCorrecta.Text = "0";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(10, 167);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(90, 13);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "Total Promediado";
			this.lblTotal.Click += new System.EventHandler(this.label7_Click);
			// 
			// lblIncorrecta
			// 
			this.lblIncorrecta.AutoSize = true;
			this.lblIncorrecta.Location = new System.Drawing.Point(10, 100);
			this.lblIncorrecta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIncorrecta.Name = "lblIncorrecta";
			this.lblIncorrecta.Size = new System.Drawing.Size(60, 13);
			this.lblIncorrecta.TabIndex = 5;
			this.lblIncorrecta.Text = "Incorrectas";
			// 
			// lblCorrecta
			// 
			this.lblCorrecta.AutoSize = true;
			this.lblCorrecta.Location = new System.Drawing.Point(10, 38);
			this.lblCorrecta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCorrecta.Name = "lblCorrecta";
			this.lblCorrecta.Size = new System.Drawing.Size(47, 13);
			this.lblCorrecta.TabIndex = 4;
			this.lblCorrecta.Text = "Correcta";
			// 
			// btnAñadirPregunta
			// 
			this.btnAñadirPregunta.Location = new System.Drawing.Point(40, 474);
			this.btnAñadirPregunta.Margin = new System.Windows.Forms.Padding(2);
			this.btnAñadirPregunta.Name = "btnAñadirPregunta";
			this.btnAñadirPregunta.Size = new System.Drawing.Size(162, 31);
			this.btnAñadirPregunta.TabIndex = 9;
			this.btnAñadirPregunta.Text = "Añadir Pregunta";
			this.btnAñadirPregunta.UseVisualStyleBackColor = true;
			this.btnAñadirPregunta.Click += new System.EventHandler(this.btnAñadirPregunta_Click);
			// 
			// btnEliminarPregunta
			// 
			this.btnEliminarPregunta.Location = new System.Drawing.Point(231, 474);
			this.btnEliminarPregunta.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminarPregunta.Name = "btnEliminarPregunta";
			this.btnEliminarPregunta.Size = new System.Drawing.Size(162, 31);
			this.btnEliminarPregunta.TabIndex = 10;
			this.btnEliminarPregunta.Text = "Eliminar Pregunta";
			this.btnEliminarPregunta.UseVisualStyleBackColor = true;
			this.btnEliminarPregunta.Click += new System.EventHandler(this.btnEliminarPregunta_Click);
			// 
			// btnComenzar
			// 
			this.btnComenzar.Location = new System.Drawing.Point(417, 474);
			this.btnComenzar.Margin = new System.Windows.Forms.Padding(2);
			this.btnComenzar.Name = "btnComenzar";
			this.btnComenzar.Size = new System.Drawing.Size(162, 31);
			this.btnComenzar.TabIndex = 11;
			this.btnComenzar.Text = "Comenzar";
			this.btnComenzar.UseVisualStyleBackColor = true;
			this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
			// 
			// grpTotal
			// 
			this.grpTotal.Controls.Add(this.lblRegistroUltimo);
			this.grpTotal.Controls.Add(this.lblRegistrosprimero);
			this.grpTotal.Controls.Add(this.lblRegistrode);
			this.grpTotal.Controls.Add(this.lblRegistro);
			this.grpTotal.Location = new System.Drawing.Point(894, 267);
			this.grpTotal.Margin = new System.Windows.Forms.Padding(2);
			this.grpTotal.Name = "grpTotal";
			this.grpTotal.Padding = new System.Windows.Forms.Padding(2);
			this.grpTotal.Size = new System.Drawing.Size(100, 181);
			this.grpTotal.TabIndex = 10;
			this.grpTotal.TabStop = false;
			this.grpTotal.Text = "Contestadas";
			// 
			// lblRegistroUltimo
			// 
			this.lblRegistroUltimo.AutoSize = true;
			this.lblRegistroUltimo.Location = new System.Drawing.Point(36, 133);
			this.lblRegistroUltimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRegistroUltimo.Name = "lblRegistroUltimo";
			this.lblRegistroUltimo.Size = new System.Drawing.Size(13, 13);
			this.lblRegistroUltimo.TabIndex = 8;
			this.lblRegistroUltimo.Text = "0";
			// 
			// lblRegistrosprimero
			// 
			this.lblRegistrosprimero.AutoSize = true;
			this.lblRegistrosprimero.Location = new System.Drawing.Point(36, 74);
			this.lblRegistrosprimero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRegistrosprimero.Name = "lblRegistrosprimero";
			this.lblRegistrosprimero.Size = new System.Drawing.Size(13, 13);
			this.lblRegistrosprimero.TabIndex = 7;
			this.lblRegistrosprimero.Text = "0";
			// 
			// lblRegistrode
			// 
			this.lblRegistrode.AutoSize = true;
			this.lblRegistrode.Location = new System.Drawing.Point(10, 102);
			this.lblRegistrode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRegistrode.Name = "lblRegistrode";
			this.lblRegistrode.Size = new System.Drawing.Size(19, 13);
			this.lblRegistrode.TabIndex = 5;
			this.lblRegistrode.Text = "de";
			// 
			// lblRegistro
			// 
			this.lblRegistro.AutoSize = true;
			this.lblRegistro.Location = new System.Drawing.Point(10, 41);
			this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRegistro.Name = "lblRegistro";
			this.lblRegistro.Size = new System.Drawing.Size(66, 13);
			this.lblRegistro.TabIndex = 4;
			this.lblRegistro.Text = "Contestadas";
			// 
			// btnEvaluar
			// 
			this.btnEvaluar.Location = new System.Drawing.Point(603, 474);
			this.btnEvaluar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEvaluar.Name = "btnEvaluar";
			this.btnEvaluar.Size = new System.Drawing.Size(162, 31);
			this.btnEvaluar.TabIndex = 10;
			this.btnEvaluar.Text = "Evaluar";
			this.btnEvaluar.UseVisualStyleBackColor = true;
			this.btnEvaluar.Click += new System.EventHandler(this.button1_Click);
			// 
			// Cuestionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 561);
			this.Controls.Add(this.btnEvaluar);
			this.Controls.Add(this.grpTotal);
			this.Controls.Add(this.btnComenzar);
			this.Controls.Add(this.btnEliminarPregunta);
			this.Controls.Add(this.btnAñadirPregunta);
			this.Controls.Add(this.grpPuntuacion);
			this.Controls.Add(this.grpPregunta);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Cuestionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cuestionario";
			this.Load += new System.EventHandler(this.Cuestionario_Load);
			this.grpPregunta.ResumeLayout(false);
			this.grpPregunta.PerformLayout();
			this.grpPuntuacion.ResumeLayout(false);
			this.grpPuntuacion.PerformLayout();
			this.grpTotal.ResumeLayout(false);
			this.grpTotal.PerformLayout();
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
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.GroupBox grpTotal;
		private System.Windows.Forms.Label lblRegistroUltimo;
		private System.Windows.Forms.Label lblRegistrosprimero;
		private System.Windows.Forms.Label lblRegistrode;
		private System.Windows.Forms.Label lblRegistro;
		private System.Windows.Forms.Button btnEvaluar;
	}
}

