using CheckList_Digital.view;
using CheckList_Digital.view.Consulta;
using System;
using System.Windows.Forms;

namespace CheckList_Digital
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_CInspecao());
        }
    }
}
