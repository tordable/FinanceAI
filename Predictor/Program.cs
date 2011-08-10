using System;
using System.Windows.Forms;

namespace FinanceAI.Predictor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );

            // Main application form
            PredictorControl p = new PredictorControl( );
            MainForm mainForm = new MainForm( p );
            p.Form = mainForm;

            Application.Run( mainForm );
        }
    }
}
