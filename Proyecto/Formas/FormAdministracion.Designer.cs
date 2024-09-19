
namespace Proyecto
{
    partial class FormAdministracion
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
            this.btnBackPosts = new System.Windows.Forms.Button();
            this.btnBackUsuarios = new System.Windows.Forms.Button();
            this.btnBackEventos = new System.Windows.Forms.Button();
            this.btnBackGrupos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackPosts
            // 
            this.btnBackPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPosts.Location = new System.Drawing.Point(88, 67);
            this.btnBackPosts.Name = "btnBackPosts";
            this.btnBackPosts.Size = new System.Drawing.Size(289, 112);
            this.btnBackPosts.TabIndex = 0;
            this.btnBackPosts.Text = "BackOffice de posts";
            this.btnBackPosts.UseVisualStyleBackColor = true;
            this.btnBackPosts.Click += new System.EventHandler(this.btnBackPosts_Click);
            // 
            // btnBackUsuarios
            // 
            this.btnBackUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUsuarios.Location = new System.Drawing.Point(398, 67);
            this.btnBackUsuarios.Name = "btnBackUsuarios";
            this.btnBackUsuarios.Size = new System.Drawing.Size(289, 112);
            this.btnBackUsuarios.TabIndex = 1;
            this.btnBackUsuarios.Text = "BackOffice de usuarios";
            this.btnBackUsuarios.UseVisualStyleBackColor = true;
            this.btnBackUsuarios.Click += new System.EventHandler(this.btnBackUsuarios_Click);
            // 
            // btnBackEventos
            // 
            this.btnBackEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEventos.Location = new System.Drawing.Point(88, 207);
            this.btnBackEventos.Name = "btnBackEventos";
            this.btnBackEventos.Size = new System.Drawing.Size(289, 112);
            this.btnBackEventos.TabIndex = 2;
            this.btnBackEventos.Text = "BackOffice de eventos ";
            this.btnBackEventos.UseVisualStyleBackColor = true;
            this.btnBackEventos.Click += new System.EventHandler(this.btnBackEventos_Click);
            // 
            // btnBackGrupos
            // 
            this.btnBackGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackGrupos.Location = new System.Drawing.Point(398, 207);
            this.btnBackGrupos.Name = "btnBackGrupos";
            this.btnBackGrupos.Size = new System.Drawing.Size(289, 112);
            this.btnBackGrupos.TabIndex = 3;
            this.btnBackGrupos.Text = "BackOffice de grupos";
            this.btnBackGrupos.UseVisualStyleBackColor = true;
            this.btnBackGrupos.Click += new System.EventHandler(this.btnBackGrupos_Click);
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackGrupos);
            this.Controls.Add(this.btnBackEventos);
            this.Controls.Add(this.btnBackUsuarios);
            this.Controls.Add(this.btnBackPosts);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackPosts;
        private System.Windows.Forms.Button btnBackUsuarios;
        private System.Windows.Forms.Button btnBackEventos;
        private System.Windows.Forms.Button btnBackGrupos;
    }
}