
namespace Proyecto
{
    partial class FormVerEventos
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
            this.flpEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumEventos = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.flpEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpEventos
            // 
            this.flpEventos.AutoScroll = true;
            this.flpEventos.Controls.Add(this.vScrollBar2);
            this.flpEventos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEventos.Location = new System.Drawing.Point(32, 87);
            this.flpEventos.Name = "flpEventos";
            this.flpEventos.Size = new System.Drawing.Size(726, 402);
            this.flpEventos.TabIndex = 9;
            this.flpEventos.WrapContents = false;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Enabled = false;
            this.vScrollBar2.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(40, 41);
            this.vScrollBar2.TabIndex = 6;
            this.vScrollBar2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Eventos: ";
            // 
            // lblNumEventos
            // 
            this.lblNumEventos.AutoSize = true;
            this.lblNumEventos.Location = new System.Drawing.Point(220, 45);
            this.lblNumEventos.Name = "lblNumEventos";
            this.lblNumEventos.Size = new System.Drawing.Size(13, 13);
            this.lblNumEventos.TabIndex = 11;
            this.lblNumEventos.Text = "?";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(613, 42);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormVerEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblNumEventos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpEventos);
            this.Name = "FormVerEventos";
            this.Text = "FormVerGrupos";
            this.flpEventos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEventos;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumEventos;
        private System.Windows.Forms.Button btnActualizar;
    }
}