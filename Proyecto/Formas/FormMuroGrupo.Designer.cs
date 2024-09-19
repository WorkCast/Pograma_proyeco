
namespace Proyecto
{
    partial class FormMuroGrupo
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
            this.lblNombreG = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.btnAdministrarGrup = new System.Windows.Forms.Button();
            this.btnEtiquetas = new System.Windows.Forms.Button();
            this.flpPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerEventosG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.flpPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreG
            // 
            this.lblNombreG.AutoSize = true;
            this.lblNombreG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreG.Location = new System.Drawing.Point(46, 34);
            this.lblNombreG.Name = "lblNombreG";
            this.lblNombreG.Size = new System.Drawing.Size(151, 20);
            this.lblNombreG.TabIndex = 0;
            this.lblNombreG.Text = "Nombre del grupo";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(587, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(162, 102);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 1;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(587, 340);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(162, 23);
            this.btnCrearEvento.TabIndex = 3;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.CrearEvento_Click);
            // 
            // btnAdministrarGrup
            // 
            this.btnAdministrarGrup.Location = new System.Drawing.Point(587, 393);
            this.btnAdministrarGrup.Name = "btnAdministrarGrup";
            this.btnAdministrarGrup.Size = new System.Drawing.Size(162, 23);
            this.btnAdministrarGrup.TabIndex = 4;
            this.btnAdministrarGrup.Text = "Administrar Grupo";
            this.btnAdministrarGrup.UseVisualStyleBackColor = true;
            this.btnAdministrarGrup.Click += new System.EventHandler(this.btnAdministrarGrup_Click);
            // 
            // btnEtiquetas
            // 
            this.btnEtiquetas.Location = new System.Drawing.Point(587, 192);
            this.btnEtiquetas.Name = "btnEtiquetas";
            this.btnEtiquetas.Size = new System.Drawing.Size(162, 23);
            this.btnEtiquetas.TabIndex = 5;
            this.btnEtiquetas.Text = "Etiquetas De Interes";
            this.btnEtiquetas.UseVisualStyleBackColor = true;
            this.btnEtiquetas.Click += new System.EventHandler(this.btnEtiquetas_Click);
            // 
            // flpPosts
            // 
            this.flpPosts.AutoScroll = true;
            this.flpPosts.Controls.Add(this.vScrollBar2);
            this.flpPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPosts.Location = new System.Drawing.Point(26, 74);
            this.flpPosts.Name = "flpPosts";
            this.flpPosts.Size = new System.Drawing.Size(478, 402);
            this.flpPosts.TabIndex = 8;
            this.flpPosts.WrapContents = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Postear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(587, 288);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerEventosG
            // 
            this.btnVerEventosG.Location = new System.Drawing.Point(587, 147);
            this.btnVerEventosG.Name = "btnVerEventosG";
            this.btnVerEventosG.Size = new System.Drawing.Size(162, 23);
            this.btnVerEventosG.TabIndex = 11;
            this.btnVerEventosG.Text = "Ver Eventos";
            this.btnVerEventosG.UseVisualStyleBackColor = true;
            this.btnVerEventosG.Click += new System.EventHandler(this.btnVerEventosG_Click);
            // 
            // FormMuroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(761, 503);
            this.Controls.Add(this.btnVerEventosG);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpPosts);
            this.Controls.Add(this.btnEtiquetas);
            this.Controls.Add(this.btnAdministrarGrup);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.lblNombreG);
            this.Name = "FormMuroGrupo";
            this.Text = "MuroGrupo";
            this.Load += new System.EventHandler(this.FormMuroGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.flpPosts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreG;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnCrearEvento;
        private System.Windows.Forms.Button btnAdministrarGrup;
        private System.Windows.Forms.Button btnEtiquetas;
        private System.Windows.Forms.FlowLayoutPanel flpPosts;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerEventosG;
    }
}