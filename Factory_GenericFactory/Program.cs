using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory_GenericFactory1;
using Factory_GenericFactory2;
using Factory_GenericFactory3;
using Factory_GenericFactory4;


namespace Factory_GenericFactory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FactorySample1());
            //Application.Run(new GenericFactory());
            //Application.Run(new FactoryMethodPattern_Sample1());
            Application.Run(new AnotherGenericFactory());
        }
    }
}
