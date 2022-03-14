namespace Repaso3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonMayorMenor = new System.Windows.Forms.Button();
            this.labelMayor1 = new System.Windows.Forms.Label();
            this.labelMenor1 = new System.Windows.Forms.Label();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMostrar.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.White;
            this.buttonMostrar.Location = new System.Drawing.Point(22, 151);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(126, 45);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar Resumen";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonOrdenar.Enabled = false;
            this.buttonOrdenar.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonOrdenar.ForeColor = System.Drawing.Color.White;
            this.buttonOrdenar.Location = new System.Drawing.Point(181, 150);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(126, 46);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonMayorMenor
            // 
            this.buttonMayorMenor.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMayorMenor.Enabled = false;
            this.buttonMayorMenor.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMayorMenor.ForeColor = System.Drawing.Color.White;
            this.buttonMayorMenor.Location = new System.Drawing.Point(338, 150);
            this.buttonMayorMenor.Name = "buttonMayorMenor";
            this.buttonMayorMenor.Size = new System.Drawing.Size(126, 42);
            this.buttonMayorMenor.TabIndex = 3;
            this.buttonMayorMenor.Text = "Mostrar Mayor y Menor";
            this.buttonMayorMenor.UseVisualStyleBackColor = false;
            this.buttonMayorMenor.Click += new System.EventHandler(this.buttonMayorMenor_Click);
            // 
            // labelMayor1
            // 
            this.labelMayor1.AutoSize = true;
            this.labelMayor1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelMayor1.Location = new System.Drawing.Point(582, 67);
            this.labelMayor1.Name = "labelMayor1";
            this.labelMayor1.Size = new System.Drawing.Size(11, 15);
            this.labelMayor1.TabIndex = 4;
            this.labelMayor1.Text = ".";
            // 
            // labelMenor1
            // 
            this.labelMenor1.AutoSize = true;
            this.labelMenor1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelMenor1.Location = new System.Drawing.Point(582, 127);
            this.labelMenor1.Name = "labelMenor1";
            this.labelMenor1.Size = new System.Drawing.Size(11, 15);
            this.labelMenor1.TabIndex = 5;
            this.labelMenor1.Text = ".";
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelPropietario.Location = new System.Drawing.Point(582, 22);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(11, 15);
            this.labelPropietario.TabIndex = 6;
            this.labelPropietario.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(480, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mayor Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(529, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mayor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(529, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.labelMenor1);
            this.Controls.Add(this.labelMayor1);
            this.Controls.Add(this.buttonMayorMenor);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Repaso #3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonMayorMenor;
        private System.Windows.Forms.Label labelMayor1;
        private System.Windows.Forms.Label labelMenor1;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

