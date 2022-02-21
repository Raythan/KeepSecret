using System;
using System.Linq;
using System.Windows.Forms;

namespace KS.Desktop
{
    public partial class frmMain : Form
    {
        private Configuracao configuracao = new();
        public frmMain()
        {
            InitializeComponent();
            configuracao.CarregarArquivoConfiguracao();
            AtualizarDropDownList();
        }
        private void AtualizarDropDownList()
        {
            if (configuracao.Parametros.Count > 0)
            {
                cboAplicacao.DataSource = new BindingSource(configuracao.Parametros, null);
                cboAplicacao.DisplayMember = "Key";
                cboAplicacao.ValueMember = "Value";
            }
            else
                cboAplicacao.DataSource = null;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (InsertInvalido())
            {
                MessageBox.Show("Chave já inserida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
                
            configuracao.Parametros.Add(txtNomeAplicacao.Text, new()
            { 
                Usuario = txtUsuarioAplicacao.Text,
                Senha = txtSenhaAplicacao.Text
            });

            configuracao.SalvarConfiguracao();
            AtualizarDropDownList();
            LimparTextField();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            configuracao.Parametros.Remove(cboAplicacao.Text);
            configuracao.SalvarConfiguracao();
            AtualizarDropDownList();
            LimparTextField();
        }

        private void LimparTextField()
        {
            txtNomeAplicacao.Text = "";
            txtUsuarioAplicacao.Text = "";
            txtSenhaAplicacao.Text = "";
        }

        private bool InsertInvalido()
        {
            return configuracao.Parametros.ContainsKey(txtNomeAplicacao.Text) ||
                string.IsNullOrEmpty(txtNomeAplicacao.Text) ||
                string.IsNullOrEmpty(txtUsuarioAplicacao.Text) ||
                string.IsNullOrEmpty(txtSenhaAplicacao.Text);
        }

        private void cboAplicacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            configuracao.Parametros.TryGetValue(cboAplicacao.Text, out Identificacao identificacao);
            if(identificacao != null && !string.IsNullOrEmpty(identificacao.Senha))
            {
                txtUsuarioAplicacao.Text = identificacao.Usuario;
                Clipboard.SetText(identificacao.Senha);
            }
        }

        private void chkHabilitaCampos_CheckedChanged(object sender, EventArgs e) => HabilitaCampos();

        public void HabilitaCampos()
        {
            txtNomeAplicacao.Enabled = !txtNomeAplicacao.Enabled;
            txtUsuarioAplicacao.Enabled = !txtUsuarioAplicacao.Enabled;
            txtSenhaAplicacao.Enabled = !txtSenhaAplicacao.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnAtualizar.Enabled = !btnAtualizar.Enabled;
            btnDeletar.Enabled = !btnDeletar.Enabled;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            configuracao.Parametros[cboAplicacao.Text] = new()
            {
                Usuario = txtUsuarioAplicacao.Text,
                Senha = txtSenhaAplicacao.Text
            };

            configuracao.SalvarConfiguracao();
            AtualizarDropDownList();
            LimparTextField();
        }
    }
}
