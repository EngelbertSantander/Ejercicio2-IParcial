namespace Ejercicio2_IParcial
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota1Txt = new System.Windows.Forms.TextBox();
            this.Nota2Txt = new System.Windows.Forms.TextBox();
            this.Nota3Txt = new System.Windows.Forms.TextBox();
            this.Nota4Txt = new System.Windows.Forms.TextBox();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.LimpiarButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota primer parcial: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota segundo parcial: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota tercer parcial: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota cuarto parcial: ";
            // 
            // Nota1Txt
            // 
            this.Nota1Txt.Location = new System.Drawing.Point(266, 81);
            this.Nota1Txt.Name = "Nota1Txt";
            this.Nota1Txt.Size = new System.Drawing.Size(155, 22);
            this.Nota1Txt.TabIndex = 4;
            // 
            // Nota2Txt
            // 
            this.Nota2Txt.Location = new System.Drawing.Point(266, 142);
            this.Nota2Txt.Name = "Nota2Txt";
            this.Nota2Txt.Size = new System.Drawing.Size(155, 22);
            this.Nota2Txt.TabIndex = 5;
            // 
            // Nota3Txt
            // 
            this.Nota3Txt.Location = new System.Drawing.Point(266, 198);
            this.Nota3Txt.Name = "Nota3Txt";
            this.Nota3Txt.Size = new System.Drawing.Size(155, 22);
            this.Nota3Txt.TabIndex = 6;
            // 
            // Nota4Txt
            // 
            this.Nota4Txt.Location = new System.Drawing.Point(266, 248);
            this.Nota4Txt.Name = "Nota4Txt";
            this.Nota4Txt.Size = new System.Drawing.Size(155, 22);
            this.Nota4Txt.TabIndex = 7;
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(118, 313);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(139, 41);
            this.CalcularButton1.TabIndex = 8;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // LimpiarButton2
            // 
            this.LimpiarButton2.Location = new System.Drawing.Point(282, 313);
            this.LimpiarButton2.Name = "LimpiarButton2";
            this.LimpiarButton2.Size = new System.Drawing.Size(139, 41);
            this.LimpiarButton2.TabIndex = 9;
            this.LimpiarButton2.Text = "Limpiar";
            this.LimpiarButton2.UseVisualStyleBackColor = true;
            this.LimpiarButton2.Click += new System.EventHandler(this.LimpiarButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 420);
            this.Controls.Add(this.LimpiarButton2);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.Nota4Txt);
            this.Controls.Add(this.Nota3Txt);
            this.Controls.Add(this.Nota2Txt);
            this.Controls.Add(this.Nota1Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nota1Txt;
        private System.Windows.Forms.TextBox Nota2Txt;
        private System.Windows.Forms.TextBox Nota3Txt;
        private System.Windows.Forms.TextBox Nota4Txt;
        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.Button LimpiarButton2;
    }
}

