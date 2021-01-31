using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace teesridimension
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 app = new Form1();
            app.Width = 800;
            app.Height = 600;
            app.InitializeGraphics();
            app.Show();
            while (app.Created)
            {
                app.Render();
                Application.DoEvents();
            }
            app.DisposeGraphics();
        }
    }
}
