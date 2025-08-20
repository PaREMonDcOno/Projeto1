using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario CU = new frmCadastroUsuario();
            this.Hide();
            CU.Show();
        }
    }
}
