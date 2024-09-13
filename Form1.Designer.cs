namespace Evaluacion
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.lbLargos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Nombre del Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Todos los estudiantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estudiantes de nombres largos";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(318, 63);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(258, 29);
            this.tbNombre.TabIndex = 4;
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.Location = new System.Drawing.Point(40, 174);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(280, 95);
            this.lbAll.TabIndex = 5;
            // 
            // lbLargos
            // 
            this.lbLargos.FormattingEnabled = true;
            this.lbLargos.Location = new System.Drawing.Point(432, 174);
            this.lbLargos.Name = "lbLargos";
            this.lbLargos.Size = new System.Drawing.Size(266, 95);
            this.lbLargos.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLargos);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.tbNombre);
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
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.ListBox lbLargos;
        private System.Windows.Forms.Button button1;
    }
}

