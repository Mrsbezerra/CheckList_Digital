﻿using System;
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
    public partial class FrmRelCargo : Form
    {
        public FrmRelCargo()
        {
            InitializeComponent();
        }

        private void FrmRelCargo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'checkListDBDataSet1.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            //this.cargoTableAdapter.Fill(this.checkListDBDataSet1.Cargo);

            this.reportViewer1.RefreshReport();
        }
    }
}