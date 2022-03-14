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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ingresarPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarPropietariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMostrar.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMostrar.ForeColor = System.Drawing.Color.White;
            this.buttonMostrar.Location = new System.Drawing.Point(12, 166);
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
            this.buttonOrdenar.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonOrdenar.ForeColor = System.Drawing.Color.White;
            this.buttonOrdenar.Location = new System.Drawing.Point(171, 165);
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
            this.buttonMayorMenor.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMayorMenor.ForeColor = System.Drawing.Color.White;
            this.buttonMayorMenor.Location = new System.Drawing.Point(328, 165);
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
            this.labelMayor1.Location = new System.Drawing.Point(572, 82);
            this.labelMayor1.Name = "labelMayor1";
            this.labelMayor1.Size = new System.Drawing.Size(11, 15);
            this.labelMayor1.TabIndex = 4;
            this.labelMayor1.Text = ".";
            // 
            // labelMenor1
            // 
            this.labelMenor1.AutoSize = true;
            this.labelMenor1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelMenor1.Location = new System.Drawing.Point(572, 142);
            this.labelMenor1.Name = "labelMenor1";
            this.labelMenor1.Size = new System.Drawing.Size(11, 15);
            this.labelMenor1.TabIndex = 5;
            this.labelMenor1.Text = ".";
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelPropietario.Location = new System.Drawing.Point(572, 37);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(11, 15);
            this.labelPropietario.TabIndex = 6;
            this.labelPropietario.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(470, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mayor Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(519, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mayor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(519, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menor:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPropietariosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 26);
            // 
            // ingresarPropietariosToolStripMenuItem
            // 
            this.ingresarPropietariosToolStripMenuItem.Name = "ingresarPropietariosToolStripMenuItem";
            this.ingresarPropietariosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarPropietariosToolStripMenuItem.Text = "Ingresar Propietarios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPropietariosToolStripMenuItem1,
            this.ingresarPropiedadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarPropietariosToolStripMenuItem1
            // 
            this.ingresarPropietariosToolStripMenuItem1.Name = "ingresarPropietariosToolStripMenuItem1";
            this.ingresarPropietariosToolStripMenuItem1.Size = new System.Drawing.Size(127, 20);
            this.ingresarPropietariosToolStripMenuItem1.Text = "Ingresar Propietarios";
            this.ingresarPropietariosToolStripMenuItem1.Click += new System.EventHandler(this.ingresarPropietariosToolStripMenuItem1_Click);
            // 
            // ingresarPropiedadesToolStripMenuItem
            // 
            this.ingresarPropiedadesToolStripMenuItem.Name = "ingresarPropiedadesToolStripMenuItem";
            this.ingresarPropiedadesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.ingresarPropiedadesToolStripMenuItem.Text = "Ingresar Propiedades";
            this.ingresarPropiedadesToolStripMenuItem.Click += new System.EventHandler(this.ingresarPropiedadesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 232);
            this.Controls.Add(this.menuStrip1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Repaso #3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarPropietariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarPropietariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarPropiedadesToolStripMenuItem;
    }
}

