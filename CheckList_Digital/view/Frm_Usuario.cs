using CheckList_Digital.conexao;
using CheckList_Digital.controler;
using CheckList_Digital.model;
using CheckList_Digital.view.frm_relatorio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CheckList_Digital.view
{
    public partial class Frm_Usuario : Form
    {
        DataTable tabelaUsuario;

        private Boolean novo = true;
        private SqlConnection con;
        private SqlCommand cmd;
        private string ConnectionString;
        private int posicao;
        DataRow[] linhaAtual;


        public Frm_Usuario()
        {
            InitializeComponent();
            DesabilitaTexts();
            LimparCampos();
            LblTotal_Registros2.Text = usuarioTableAdapter.TotalUsuarios().ToString();
        }

        private void AtivarTexts()
        {
            TxtNome_Usuario.Enabled = true;
            TxtLogin.Enabled = true;
            TxtSenha.Enabled = true;
            TxtEmail.Enabled = true;
            CmbSexo.Enabled = true;
            CmbCargo.Enabled = true;
            CmbTipoUsuario.Enabled = true;
        }

        private void DesabilitaTexts()
        {
            TxtNome_Usuario.Enabled = false;
            TxtLogin.Enabled = false;
            TxtSenha.Enabled = false;
            TxtEmail.Enabled = false;
            CmbSexo.Enabled = false;
            CmbCargo.Enabled = false;
            CmbTipoUsuario.Enabled = false;
           
        }

        private void LimparCampos()
        {
         
        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            usuarioBindingSource.AddNew();
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            usuarioTableAdapter.Update(checkListDBDataSet.Usuario);
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MoveFirst();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MovePrevious();
        }

        private void AtualizarTextBoxComLinhaSelecionada()
        {
           
        }

        private void DgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MoveNext();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MoveLast();
        }

        private void AtualizarTotalRegistrosVisiveis()
        {
            
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Usuario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Tipo_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_UsuarioTableAdapter.Fill(this.checkListDBDataSet.Tipo_Usuario);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.checkListDBDataSet.Cargo);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.checkListDBDataSet.Sexo);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.checkListDBDataSet.Usuario);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.checkListDBDataSet.Sexo);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Tipo_Usuario'. Você pode movê-la ou removê-la conforme necessário.
           
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.checkListDBDataSet.Usuario);

        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.checkListDBDataSet);

        }

        private void TsbExcluir_Click_1(object sender, EventArgs e)
        {
            usuarioBindingSource.RemoveCurrent();

            usuarioBindingSource.EndEdit();
            usuarioTableAdapter.Update(checkListDBDataSet.Usuario);
        }
    }
}
