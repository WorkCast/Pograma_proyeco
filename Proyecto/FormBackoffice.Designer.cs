
namespace Proyecto
{
    partial class FormBackoffice
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
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            this.textBoxLikes = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonDeletePost = new System.Windows.Forms.Button();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.buttonDeleteComment = new System.Windows.Forms.Button();
            this.buttonUpdateLikes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.btnAutoActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(488, 35);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(288, 173);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(488, 231);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(288, 173);
            this.listBoxComments.TabIndex = 1;
            this.listBoxComments.SelectedIndexChanged += new System.EventHandler(this.listBoxComments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "texto del post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "likes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "comentarios";
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.Location = new System.Drawing.Point(147, 62);
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.Size = new System.Drawing.Size(156, 20);
            this.textBoxPostText.TabIndex = 5;
            this.textBoxPostText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLikes
            // 
            this.textBoxLikes.Location = new System.Drawing.Point(147, 124);
            this.textBoxLikes.Name = "textBoxLikes";
            this.textBoxLikes.Size = new System.Drawing.Size(156, 20);
            this.textBoxLikes.TabIndex = 6;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(147, 249);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(156, 20);
            this.textBoxComment.TabIndex = 7;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.Location = new System.Drawing.Point(15, 312);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(103, 23);
            this.buttonDeletePost.TabIndex = 8;
            this.buttonDeletePost.Text = "Borrar post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(179, 312);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(103, 23);
            this.buttonUpdateText.TabIndex = 9;
            this.buttonUpdateText.Text = "cambiar texto";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(346, 312);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(103, 23);
            this.buttonAddComment.TabIndex = 10;
            this.buttonAddComment.Text = "Añadir comentario";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // buttonDeleteComment
            // 
            this.buttonDeleteComment.Location = new System.Drawing.Point(15, 353);
            this.buttonDeleteComment.Name = "buttonDeleteComment";
            this.buttonDeleteComment.Size = new System.Drawing.Size(103, 23);
            this.buttonDeleteComment.TabIndex = 11;
            this.buttonDeleteComment.Text = "Borrar comentario";
            this.buttonDeleteComment.UseVisualStyleBackColor = true;
            this.buttonDeleteComment.Click += new System.EventHandler(this.buttonDeleteComment_Click);
            // 
            // buttonUpdateLikes
            // 
            this.buttonUpdateLikes.Location = new System.Drawing.Point(179, 353);
            this.buttonUpdateLikes.Name = "buttonUpdateLikes";
            this.buttonUpdateLikes.Size = new System.Drawing.Size(103, 23);
            this.buttonUpdateLikes.TabIndex = 12;
            this.buttonUpdateLikes.Text = "actualizar likes";
            this.buttonUpdateLikes.UseVisualStyleBackColor = true;
            this.buttonUpdateLikes.Click += new System.EventHandler(this.buttonUpdateLikes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(144, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(98, 13);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Seleccione un post";
            // 
            // btnAutoActualizar
            // 
            this.btnAutoActualizar.Location = new System.Drawing.Point(346, 353);
            this.btnAutoActualizar.Name = "btnAutoActualizar";
            this.btnAutoActualizar.Size = new System.Drawing.Size(103, 23);
            this.btnAutoActualizar.TabIndex = 15;
            this.btnAutoActualizar.Text = "Auto actualizar";
            this.btnAutoActualizar.UseVisualStyleBackColor = true;
            this.btnAutoActualizar.Click += new System.EventHandler(this.btnAutoActualizar_Click);
            // 
            // FormBackoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoActualizar);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdateLikes);
            this.Controls.Add(this.buttonDeleteComment);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.buttonDeletePost);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxLikes);
            this.Controls.Add(this.textBoxPostText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.listBoxPosts);
            this.Name = "FormBackoffice";
            this.Text = "FormBackoffice";
            this.Load += new System.EventHandler(this.FormBackoffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPostText;
        private System.Windows.Forms.TextBox textBoxLikes;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.Button buttonUpdateText;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Button buttonDeleteComment;
        private System.Windows.Forms.Button buttonUpdateLikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnAutoActualizar;
    }
}