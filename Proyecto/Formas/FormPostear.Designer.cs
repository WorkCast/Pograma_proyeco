
namespace Proyecto
{
    partial class FormPostear
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxImagen = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLlamarBackofice = new System.Windows.Forms.Button();
            this.Prueba = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 148);
            this.textBox1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxImagen);
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.btnLlamarBackofice);
            this.panel3.Controls.Add(this.Prueba);
            this.panel3.Location = new System.Drawing.Point(623, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 148);
            this.panel3.TabIndex = 10;
            // 
            // cbxImagen
            // 
            this.cbxImagen.AutoSize = true;
            this.cbxImagen.Location = new System.Drawing.Point(17, 69);
            this.cbxImagen.Name = "cbxImagen";
            this.cbxImagen.Size = new System.Drawing.Size(99, 17);
            this.cbxImagen.TabIndex = 3;
            this.cbxImagen.Text = "agregar imagen";
            this.cbxImagen.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(17, 9);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 40);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Que es lo que te gustaria decir?";
            // 
            // btnLlamarBackofice
            // 
            this.btnLlamarBackofice.Location = new System.Drawing.Point(26, 92);
            this.btnLlamarBackofice.Name = "btnLlamarBackofice";
            this.btnLlamarBackofice.Size = new System.Drawing.Size(75, 23);
            this.btnLlamarBackofice.TabIndex = 12;
            this.btnLlamarBackofice.Text = "Backoffice";
            this.btnLlamarBackofice.UseVisualStyleBackColor = true;
            this.btnLlamarBackofice.Click += new System.EventHandler(this.btnLlamarBackofice_Click);
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(26, 121);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 11;
            this.Prueba.Text = "Cargar datos";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click_1);
            // 
            // FormPostear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Name = "FormPostear";
            this.Text = "FormPostear";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbxImagen;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLlamarBackofice;
        private System.Windows.Forms.Button Prueba;
    }
}