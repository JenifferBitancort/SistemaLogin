using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17___Sistema_de_Login
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonEntrar_Click_1(object sender, EventArgs e)
        {
            string nome = textUsuario.Text;
            string senha = textBoxSenha.Text;

            //Verifica se o usuário logado é valido
            if (CadastroUsuarios.Login(nome, senha))
            {

                Close();
            }
            else
            {
                MessageBox.Show("Acesso negado");
                textUsuario.Text = "";
                textBoxSenha.Text = "";
                textUsuario.Focus();
                Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

 
    }
}
