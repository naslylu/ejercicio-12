namespace eje_12
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cbo_Paises = new System.Windows.Forms.ComboBox();
            this.txt_Continente = new System.Windows.Forms.TextBox();
            this.txt_Capital = new System.Windows.Forms.TextBox();
            this.txt_Presidente = new System.Windows.Forms.TextBox();
            this.txt_Gobierno = new System.Windows.Forms.TextBox();
            this.txt_Poblacion = new System.Windows.Forms.TextBox();
            this.txt_Idioma = new System.Windows.Forms.TextBox();
            this.txt_Moneda = new System.Windows.Forms.TextBox();
            this.txt_Religion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(539, 111);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(155, 45);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(539, 176);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(155, 45);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cbo_Paises
            // 
            this.cbo_Paises.FormattingEnabled = true;
            this.cbo_Paises.Items.AddRange(new object[] {
            "Estados Unidos",
            "Canada",
            "Mexico",
            "España",
            "Francia",
            "Republica Dominicana"});
            this.cbo_Paises.Location = new System.Drawing.Point(92, 37);
            this.cbo_Paises.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Paises.Name = "cbo_Paises";
            this.cbo_Paises.Size = new System.Drawing.Size(166, 21);
            this.cbo_Paises.TabIndex = 3;
            this.cbo_Paises.SelectedIndexChanged += new System.EventHandler(this.cbo_Paises_SelectedIndexChanged);
            // 
            // txt_Continente
            // 
            this.txt_Continente.Location = new System.Drawing.Point(303, 107);
            this.txt_Continente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Continente.Name = "txt_Continente";
            this.txt_Continente.Size = new System.Drawing.Size(174, 20);
            this.txt_Continente.TabIndex = 4;
            // 
            // txt_Capital
            // 
            this.txt_Capital.Location = new System.Drawing.Point(303, 145);
            this.txt_Capital.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Capital.Name = "txt_Capital";
            this.txt_Capital.Size = new System.Drawing.Size(174, 20);
            this.txt_Capital.TabIndex = 5;
            // 
            // txt_Presidente
            // 
            this.txt_Presidente.Location = new System.Drawing.Point(303, 188);
            this.txt_Presidente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Presidente.Name = "txt_Presidente";
            this.txt_Presidente.Size = new System.Drawing.Size(174, 20);
            this.txt_Presidente.TabIndex = 6;
            // 
            // txt_Gobierno
            // 
            this.txt_Gobierno.Location = new System.Drawing.Point(303, 228);
            this.txt_Gobierno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Gobierno.Name = "txt_Gobierno";
            this.txt_Gobierno.Size = new System.Drawing.Size(174, 20);
            this.txt_Gobierno.TabIndex = 7;
            // 
            // txt_Poblacion
            // 
            this.txt_Poblacion.Location = new System.Drawing.Point(303, 273);
            this.txt_Poblacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Poblacion.Name = "txt_Poblacion";
            this.txt_Poblacion.Size = new System.Drawing.Size(174, 20);
            this.txt_Poblacion.TabIndex = 8;
            // 
            // txt_Idioma
            // 
            this.txt_Idioma.Location = new System.Drawing.Point(303, 317);
            this.txt_Idioma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Idioma.Name = "txt_Idioma";
            this.txt_Idioma.Size = new System.Drawing.Size(174, 20);
            this.txt_Idioma.TabIndex = 9;
            // 
            // txt_Moneda
            // 
            this.txt_Moneda.Location = new System.Drawing.Point(303, 359);
            this.txt_Moneda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Moneda.Name = "txt_Moneda";
            this.txt_Moneda.Size = new System.Drawing.Size(174, 20);
            this.txt_Moneda.TabIndex = 10;
            // 
            // txt_Religion
            // 
            this.txt_Religion.Location = new System.Drawing.Point(303, 401);
            this.txt_Religion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Religion.Name = "txt_Religion";
            this.txt_Religion.Size = new System.Drawing.Size(174, 20);
            this.txt_Religion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Continente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Presidente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gobierno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Poblacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Idioma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 362);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Moneda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Religion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Religion);
            this.Controls.Add(this.txt_Moneda);
            this.Controls.Add(this.txt_Idioma);
            this.Controls.Add(this.txt_Poblacion);
            this.Controls.Add(this.txt_Gobierno);
            this.Controls.Add(this.txt_Presidente);
            this.Controls.Add(this.txt_Capital);
            this.Controls.Add(this.txt_Continente);
            this.Controls.Add(this.cbo_Paises);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ComboBox cbo_Paises;
        private System.Windows.Forms.TextBox txt_Continente;
        private System.Windows.Forms.TextBox txt_Capital;
        private System.Windows.Forms.TextBox txt_Presidente;
        private System.Windows.Forms.TextBox txt_Gobierno;
        private System.Windows.Forms.TextBox txt_Poblacion;
        private System.Windows.Forms.TextBox txt_Idioma;
        private System.Windows.Forms.TextBox txt_Moneda;
        private System.Windows.Forms.TextBox txt_Religion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

