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
    public partial class CadastroUsuario : Form
    {
        public bool ValidarEstadoDoForm { get; set; }
        public bool FormJaCarregado = false;

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void LoadCadastroUsuario(object sender, EventArgs e)
        {
            this.ValidarEstadoDoForm = true;

            //Código abaixo elimina a ocorrencia de duas telas de cadastro de usuário
            if (!FormJaCarregado)
            {
                FormJaCarregado = true;
            }
            else
            {
                this.Hide();
            }
        }

        private void CloseCadastroUsuario(object sender, FormClosedEventArgs e)
        {
            this.ValidarEstadoDoForm = false;
        }
    }
}
