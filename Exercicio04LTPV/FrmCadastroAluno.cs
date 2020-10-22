using Exercicio04.LTPV.Data.Interfaces;
using Exercicio04.LTPV.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04LTPV
{
    public partial class FrmCadastroAluno : Form
    {
        private IAlunoRepositorio _repositorio;
        public FrmCadastroAluno()
        {
            InitializeComponent();
            _repositorio = Program.container.GetInstance<IAlunoRepositorio>();

            var registros = _repositorio.ObterTodos();
            dataGridView1.DataSource = registros;
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
