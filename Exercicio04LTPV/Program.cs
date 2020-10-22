using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio04.LTPV.Data.Interfaces;
using Exercicio04.LTPV.Data.Repositorios;
using SimpleInjector;

namespace Exercicio04LTPV
{
    static class Program
    {
        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();
            container.Register<IAlunoRepositorio, AlunoRepositorio>();
            container.Verify();
        }
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new FrmPrincipal());
        }
    }
}
