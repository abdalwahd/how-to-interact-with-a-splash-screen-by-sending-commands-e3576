namespace SplashScreen_ProcessCommand {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            this.btnShowSplashScreen = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnShowSplashScreen
            // 
            this.btnShowSplashScreen.Location = new System.Drawing.Point(22, 12);
            this.btnShowSplashScreen.Name = "btnShowSplashScreen";
            this.btnShowSplashScreen.Size = new System.Drawing.Size(145, 32);
            this.btnShowSplashScreen.TabIndex = 0;
            this.btnShowSplashScreen.Text = "Show Splash Screen";
            this.btnShowSplashScreen.Click += new System.EventHandler(this.btnShowSplashScreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.btnShowSplashScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShowSplashScreen;
    }
}

