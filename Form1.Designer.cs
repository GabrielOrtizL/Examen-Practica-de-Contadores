namespace Examen_Practica_de_Contadores
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.buttonsumar = new System.Windows.Forms.Button();
            this.buttonrestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.Location = new System.Drawing.Point(10, 22);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox.Size = new System.Drawing.Size(287, 42);
            this.txtbox.TabIndex = 0;
            this.txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonsumar
            // 
            this.buttonsumar.BackColor = System.Drawing.Color.Lime;
            this.buttonsumar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsumar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonsumar.Location = new System.Drawing.Point(34, 110);
            this.buttonsumar.Name = "buttonsumar";
            this.buttonsumar.Size = new System.Drawing.Size(75, 33);
            this.buttonsumar.TabIndex = 1;
            this.buttonsumar.Text = "Sumar";
            this.buttonsumar.UseVisualStyleBackColor = false;
            this.buttonsumar.Click += new System.EventHandler(this.buttonsumar_Click);
            // 
            // buttonrestar
            // 
            this.buttonrestar.BackColor = System.Drawing.Color.Red;
            this.buttonrestar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrestar.Location = new System.Drawing.Point(176, 110);
            this.buttonrestar.Name = "buttonrestar";
            this.buttonrestar.Size = new System.Drawing.Size(75, 33);
            this.buttonrestar.TabIndex = 2;
            this.buttonrestar.Text = "Restar";
            this.buttonrestar.UseVisualStyleBackColor = false;
            this.buttonrestar.Click += new System.EventHandler(this.buttonrestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.buttonrestar);
            this.Controls.Add(this.buttonsumar);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Examen Gabriel Ortiz Lopez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button buttonsumar;
        private System.Windows.Forms.Button buttonrestar;
    }
}

