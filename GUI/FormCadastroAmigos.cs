using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public partial class FormCadastroAmigos : Form
    {
        public FormCadastroAmigos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Amigo amig = new Amigo();
            amig.Nome = textBoxAmigo.Text;
            amig.DataNascimento = dateTimePickerAmigo.Value;
            amig.Email = textBoxEmail.Text;

            if (ControllerAmigo.GravarAmigo(amig))
            {
                MessageBox.Show("Amigo Salvo com Sucesso!");
                atualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar Funcionário");
            }
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAmigo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
