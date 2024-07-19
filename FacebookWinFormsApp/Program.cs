using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // $G$ RUL-003 (-10) Redundant files in assignment folder.
        // $G$ THE-001 (-12) your grade on diagrams document - 88. please see comments inside the document. 40% of your grade).
        // $G$ THE-001 (-10) General impression: there is no seperation of Logic and UI. There is no 
        // logical seperation of classes and delegation of responsibilites in your project.

        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
