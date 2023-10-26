namespace Lab6
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
            this.button1 = new System.Windows.Forms.Button();
            this.СТУДЕНТЫ = new System.Windows.Forms.Button();
            this.ОБУЧЕНИЕ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "СПЕЦИАЛЬНОСТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // СТУДЕНТЫ
            // 
            this.СТУДЕНТЫ.Location = new System.Drawing.Point(242, 70);
            this.СТУДЕНТЫ.Name = "СТУДЕНТЫ";
            this.СТУДЕНТЫ.Size = new System.Drawing.Size(137, 87);
            this.СТУДЕНТЫ.TabIndex = 1;
            this.СТУДЕНТЫ.Text = "СТУДЕНТЫ";
            this.СТУДЕНТЫ.UseVisualStyleBackColor = true;
            this.СТУДЕНТЫ.Click += new System.EventHandler(this.СТУДЕНТЫ_Click);
            // 
            // ОБУЧЕНИЕ
            // 
            this.ОБУЧЕНИЕ.Location = new System.Drawing.Point(163, 190);
            this.ОБУЧЕНИЕ.Name = "ОБУЧЕНИЕ";
            this.ОБУЧЕНИЕ.Size = new System.Drawing.Size(141, 95);
            this.ОБУЧЕНИЕ.TabIndex = 2;
            this.ОБУЧЕНИЕ.Text = "ОБУЧЕНИЕ";
            this.ОБУЧЕНИЕ.UseVisualStyleBackColor = true;
            this.ОБУЧЕНИЕ.Click += new System.EventHandler(this.ОБУЧЕНИЕ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 329);
            this.Controls.Add(this.ОБУЧЕНИЕ);
            this.Controls.Add(this.СТУДЕНТЫ);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Коммерческое обучение в вузе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button СТУДЕНТЫ;
        private System.Windows.Forms.Button ОБУЧЕНИЕ;
    }
}

