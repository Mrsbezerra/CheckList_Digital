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
    public partial class FrmRelSexo : Form
    {
        public FrmRelSexo()
        {
            InitializeComponent();
        }

        private void FrmRelSexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet.Sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.checkListDBDataSet.Sexo);

            this.reportViewer1.RefreshReport();
        }

        private void FrmRelSexo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
