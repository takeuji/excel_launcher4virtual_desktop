using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;

namespace ExcelLoader
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            //App app = new App();
            //app.InitializeComponent();
            //app.Run();

            try
            {
                var commandLine = ConfigurationManager.AppSettings["Application"];
                if (!String.IsNullOrEmpty(commandLine))
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = commandLine;
                    proc.StartInfo.Arguments = " -x";
                    proc.Start();
                }
                System.Diagnostics.Debug.WriteLine("command line : " + commandLine);
            }
            catch
            {
            }
        }
    }
}
