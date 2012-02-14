//TODO: 
//main list
//add more error handling!
//try to hide title bar or at least the minimize and maximize buttons
//send error log to a server to detect the status of the program. Send computer ID too.
//remove minimize/maxmize buttons
//re-center window for non full screen games
//Kunal says Syed should get a demoscene program to show trippy graphics, keygen style, when you launch trollkit
//use and pull to original Trollkit github repository
//delete files upon uninstall - delete data and startup shortcut, a pain with ClickOnce
//test full screen/hide mouse/etc in a non ClickOnce application to determine if the problem is related to priveleges
//clickonce elevated privelege using app.manifest and publish manifest?
//use windows installer, write auto-update code, move everything to program files folder
//autostart with last played game settings vs current settings
//if arcade mode, do not auto update
//drag and drop - controls
//add file dialog for JoyToKey

//later:
//use standard XML parsing code, likely XPATH, not the AMS.Profile library, http://www.codeproject.com/Articles/9494/Manipulate-XML-data-with-XPath-and-XmlDocument-C
//orrrr use LINQ to XML!
//add download game functionality - seperate form
//add game configurations to automatically set settings (full screen, hide mouse) for each game?

//much later:
//certificate

//not code related
//test on the next exhibition
//find other volunteers or friendly open source game programmers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trollkit {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            //start the GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserGUI());
        }
    }
}
