using System;
using System.Windows.Forms;

namespace AssemblySign
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, args) => MessageBox.Show(args.Exception.Message);
            Application.Run(new MainForm());
        }
    }
}
