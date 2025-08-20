namespace Projeto1
{
    partial class frmCadastroUsuario
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
            this.lbTituloUsuario = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.txtCadUsuario = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTituloUsuario
            // 
            this.lbTituloUsuario.AutoSize = true;
            this.lbTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloUsuario.Location = new System.Drawing.Point(295, 50);
            this.lbTituloUsuario.Name = "lbTituloUsuario";
            this.lbTituloUsuario.Size = new System.Drawing.Size(199, 29);
            this.lbTituloUsuario.TabIndex = 5;
            this.lbTituloUsuario.Text = "Cadastro Usuário";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.Location = new System.Drawing.Point(257, 200);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(80, 25);
            this.lblCadSenha.TabIndex = 4;
            this.lblCadSenha.Text = "Senha:";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUsuario.Location = new System.Drawing.Point(245, 153);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(92, 25);
            this.lblCadUsuario.TabIndex = 3;
            this.lblCadUsuario.Text = "Usuário:";
            // 
            // txtCadUsuario
            // 
            this.txtCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadUsuario.Location = new System.Drawing.Point(343, 154);
            this.txtCadUsuario.Name = "txtCadUsuario";
            this.txtCadUsuario.Size = new System.Drawing.Size(165, 26);
            this.txtCadUsuario.TabIndex = 0;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(343, 201);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.PasswordChar = '*';
            this.txtCadSenha.Size = new System.Drawing.Size(165, 26);
            this.txtCadSenha.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(300, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 75);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCadUsuario);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.lbTituloUsuario);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.TextBox txtCadUsuario;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}