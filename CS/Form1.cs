using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;


namespace SplashScreen_ProcessCommand {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnShowSplashScreen_Click(object sender, EventArgs e) {
            // Open a Splash Screen
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true, false);
            
            // The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.
            for (int i = 1; i <= 100; i++) {
                SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, i);
                //To process commands, override the SplashScreen.ProcessCommand method.
                Thread.Sleep(25);
            }
            
            // Close the Splash Screen.
            SplashScreenManager.CloseForm(false);
        }
    }
}
