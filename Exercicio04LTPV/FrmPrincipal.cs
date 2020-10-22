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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        void ExibirFormulario(Form frm, bool AbrirNovamente)
        {
            FormCollection fc = Application.OpenForms;
            
            if (!AbrirNovamente)
            {
                foreach (Form item in fc)
                {
                    if (item.Name == frm.Name)
                    {
                        MessageBox.Show(this, "Este Formulário já está aberto!", "Alerta", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            frm.MdiParent = this;
            frm.Show();
                
        }
        private void cadastraAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frm = new FrmCadastroAluno();
            ExibirFormulario(frm, true);
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditorTexto frm = new FrmEditorTexto();
            ExibirFormulario(frm, false);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
