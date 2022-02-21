
namespace KS.Desktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboAplicacao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeAplicacao = new System.Windows.Forms.TextBox();
            this.txtSenhaAplicacao = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblAplicacao = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.chkHabilitaCampos = new System.Windows.Forms.CheckBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsuarioAplicacao = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboAplicacao
            // 
            this.cboAplicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAplicacao.FormattingEnabled = true;
            this.cboAplicacao.Location = new System.Drawing.Point(12, 12);
            this.cboAplicacao.Name = "cboAplicacao";
            this.cboAplicacao.Size = new System.Drawing.Size(497, 23);
            this.cboAplicacao.TabIndex = 0;
            this.cboAplicacao.SelectedIndexChanged += new System.EventHandler(this.cboAplicacao_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(12, 128);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeAplicacao
            // 
            this.txtNomeAplicacao.Enabled = false;
            this.txtNomeAplicacao.Location = new System.Drawing.Point(12, 41);
            this.txtNomeAplicacao.Name = "txtNomeAplicacao";
            this.txtNomeAplicacao.Size = new System.Drawing.Size(497, 23);
            this.txtNomeAplicacao.TabIndex = 2;
            // 
            // txtSenhaAplicacao
            // 
            this.txtSenhaAplicacao.Enabled = false;
            this.txtSenhaAplicacao.Location = new System.Drawing.Point(12, 99);
            this.txtSenhaAplicacao.Name = "txtSenhaAplicacao";
            this.txtSenhaAplicacao.Size = new System.Drawing.Size(497, 23);
            this.txtSenhaAplicacao.TabIndex = 4;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(278, 128);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(127, 40);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.AutoSize = true;
            this.lblAplicacao.Location = new System.Drawing.Point(515, 44);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(59, 15);
            this.lblAplicacao.TabIndex = 6;
            this.lblAplicacao.Text = "Aplicação";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(515, 102);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // chkHabilitaCampos
            // 
            this.chkHabilitaCampos.AutoSize = true;
            this.chkHabilitaCampos.Location = new System.Drawing.Point(515, 14);
            this.chkHabilitaCampos.Name = "chkHabilitaCampos";
            this.chkHabilitaCampos.Size = new System.Drawing.Size(114, 19);
            this.chkHabilitaCampos.TabIndex = 1;
            this.chkHabilitaCampos.Text = "Habilita Campos";
            this.chkHabilitaCampos.UseVisualStyleBackColor = true;
            this.chkHabilitaCampos.CheckedChanged += new System.EventHandler(this.chkHabilitaCampos_CheckedChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(515, 73);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Usuário";
            // 
            // txtUsuarioAplicacao
            // 
            this.txtUsuarioAplicacao.Enabled = false;
            this.txtUsuarioAplicacao.Location = new System.Drawing.Point(12, 70);
            this.txtUsuarioAplicacao.Name = "txtUsuarioAplicacao";
            this.txtUsuarioAplicacao.Size = new System.Drawing.Size(497, 23);
            this.txtUsuarioAplicacao.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(145, 128);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(127, 40);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 178);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsuarioAplicacao);
            this.Controls.Add(this.chkHabilitaCampos);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblAplicacao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtSenhaAplicacao);
            this.Controls.Add(this.txtNomeAplicacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboAplicacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAplicacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeAplicacao;
        private System.Windows.Forms.TextBox txtSenhaAplicacao;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblAplicacao;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.CheckBox chkHabilitaCampos;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsuarioAplicacao;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

