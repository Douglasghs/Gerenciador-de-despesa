using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Despesas
{
    public partial class Login : Form
    {
        CadastroUsuario forme_CadastroUsuario = new CadastroUsuario();

        public Login()
        {
            InitializeComponent();
        }

        private void button_NOVO_USUARIO_Click(object sender, EventArgs e)
        {
            forme_CadastroUsuario.Show();

            //if (forme_CadastroUsuario.ValidarEstadoDoForm)
            //{
            //    this.Hide();
            //}
        }
    }
}
