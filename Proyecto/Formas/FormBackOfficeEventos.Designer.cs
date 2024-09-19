
namespace Proyecto
{
    partial class FormBackOfficeEventos
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
            this.listEventos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.lblIdEvento = new System.Windows.Forms.Label();
            this.btnCrearEvento = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.btnBorrarEve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEventos
            // 
            this.listEventos.FormattingEnabled = true;
            this.listEventos.HorizontalScrollbar = true;
            this.listEventos.Location = new System.Drawing.Point(656, 38);
            this.listEventos.Name = "listEventos";
            this.listEventos.ScrollAlwaysVisible = true;
            this.listEventos.Size = new System.Drawing.Size(765, 511);
            this.listEventos.TabIndex = 51;
            this.listEventos.SelectedIndexChanged += new System.EventHandler(this.listEventos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "id de evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "id grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Lugar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha y hora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "nombre";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(97, 166);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnCargarFoto.TabIndex = 59;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBoxFoto.Location = new System.Drawing.Point(45, 22);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(176, 138);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 58;
            this.pictureBoxFoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxFoto);
            this.panel2.Controls.Add(this.btnCargarFoto);
            this.panel2.Location = new System.Drawing.Point(372, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 200);
            this.panel2.TabIndex = 60;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(111, 239);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(237, 20);
            this.txtFechaHora.TabIndex = 66;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 309);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(620, 100);
            this.txtDescripcion.TabIndex = 65;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(111, 140);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(237, 20);
            this.txtLugar.TabIndex = 63;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(111, 191);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(237, 20);
            this.txtNombreE.TabIndex = 61;
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(111, 94);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(237, 20);
            this.txtIdGrupo.TabIndex = 67;
            // 
            // lblIdEvento
            // 
            this.lblIdEvento.AutoSize = true;
            this.lblIdEvento.Location = new System.Drawing.Point(108, 46);
            this.lblIdEvento.Name = "lblIdEvento";
            this.lblIdEvento.Size = new System.Drawing.Size(13, 13);
            this.lblIdEvento.TabIndex = 68;
            this.lblIdEvento.Text = "?";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.Location = new System.Drawing.Point(15, 435);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(106, 23);
            this.btnCrearEvento.TabIndex = 69;
            this.btnCrearEvento.Text = "Crear evento";
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(148, 435);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 23);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar evento";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(387, 46);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(13, 13);
            this.lblP.TabIndex = 71;
            this.lblP.Text = "?";
            // 
            // btnBorrarEve
            // 
            this.btnBorrarEve.Location = new System.Drawing.Point(283, 435);
            this.btnBorrarEve.Name = "btnBorrarEve";
            this.btnBorrarEve.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarEve.TabIndex = 72;
            this.btnBorrarEve.Text = "Borrar evento";
            this.btnBorrarEve.UseVisualStyleBackColor = true;
            this.btnBorrarEve.Click += new System.EventHandler(this.btnBorrarEve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "Actualizar eventos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "idEvento - idGrupo - nombre - descripcion - lugar - fechaEvento - dirImagen - int" +
    "ereses";
            // 
            // FormBackOfficeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrarEve);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.lblIdEvento);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEventos);
            this.Name = "FormBackOfficeEventos";
            this.Text = "FormBackOfficeEventos";
            this.Load += new System.EventHandler(this.FormBackOfficeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFechaHora;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.Label lblIdEvento;
        private System.Windows.Forms.Button btnCrearEvento;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnBorrarEve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}