
namespace Proyecto
{
    partial class FormVerGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumGrupos = new System.Windows.Forms.Label();
            this.CrearGrupo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.flpGrupos = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de grupos: ";
            // 
            // lblNumGrupos
            // 
            this.lblNumGrupos.AutoSize = true;
            this.lblNumGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGrupos.Location = new System.Drawing.Point(190, 22);
            this.lblNumGrupos.Name = "lblNumGrupos";
            this.lblNumGrupos.Size = new System.Drawing.Size(18, 20);
            this.lblNumGrupos.TabIndex = 1;
            this.lblNumGrupos.Text = "0";
            // 
            // CrearGrupo
            // 
            this.CrearGrupo.Location = new System.Drawing.Point(857, 22);
            this.CrearGrupo.Name = "CrearGrupo";
            this.CrearGrupo.Size = new System.Drawing.Size(120, 42);
            this.CrearGrupo.TabIndex = 4;
            this.CrearGrupo.Text = "Crear Grupo";
            this.CrearGrupo.UseVisualStyleBackColor = true;
            this.CrearGrupo.Click += new System.EventHandler(this.CrearGrupo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(857, 90);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 43);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Enabled = false;
            this.vScrollBar2.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(40, 41);
            this.vScrollBar2.TabIndex = 6;
            this.vScrollBar2.Visible = false;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // flpGrupos
            // 
            this.flpGrupos.AutoScroll = true;
            this.flpGrupos.Controls.Add(this.vScrollBar2);
            this.flpGrupos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGrupos.Location = new System.Drawing.Point(16, 80);
            this.flpGrupos.Name = "flpGrupos";
            this.flpGrupos.Size = new System.Drawing.Size(790, 402);
            this.flpGrupos.TabIndex = 7;
            this.flpGrupos.WrapContents = false;
            this.flpGrupos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // FormVerGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(989, 511);
            this.Controls.Add(this.flpGrupos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.CrearGrupo);
            this.Controls.Add(this.lblNumGrupos);
            this.Controls.Add(this.label1);
            this.Name = "FormVerGrupo";
            this.Text = "VerGrupo";
            this.flpGrupos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumGrupos;
        private System.Windows.Forms.Button CrearGrupo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.FlowLayoutPanel flpGrupos;
    }
}