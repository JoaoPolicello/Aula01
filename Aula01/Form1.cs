namespace Aula01
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNome.Text;

            MessageBox.Show($"Bem vindo ao c# {nomeUsuario}", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lblMensagem.Text = $"Bem-vindo ao c# {nomeUsuario}";
        }
    }
}