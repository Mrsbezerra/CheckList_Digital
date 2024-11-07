using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.view.frm_relatorio
{
    public partial class FrmRelTipoUsuario : Form
    {
        public FrmRelTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmRelTipoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet2.Tipo_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.tipo_UsuarioTableAdapter.Fill(this.checkListDBDataSet2.Tipo_Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
