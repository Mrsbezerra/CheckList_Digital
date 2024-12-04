using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList_Digital.view.Frm_Relatorio
{
    public partial class FrmRelSetor : Form
    {
        public FrmRelSetor()
        {
            InitializeComponent();
        }

        private void FrmRelSetor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.checkListDBDataSet.Setor);
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            //this.cargoTableAdapter.Fill(this.checkListDBDataSet.Setor);

            this.reportViewer1.RefreshReport();
        }
    }
}
