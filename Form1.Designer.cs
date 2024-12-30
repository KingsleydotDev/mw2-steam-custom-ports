namespace MW2_port_forwarding_STEAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            customPort = new TextBox();
            label1 = new Label();
            gameStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            keepHookingCoD = new System.Windows.Forms.Timer(components);
            enablePortForwarding = new CheckBox();
            sendPortTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // customPort
            // 
            customPort.Location = new Point(126, 9);
            customPort.Name = "customPort";
            customPort.Size = new Size(100, 23);
            customPort.TabIndex = 0;
            customPort.Text = "28960";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Custom Port Value:";
            // 
            // gameStatus
            // 
            gameStatus.AutoSize = true;
            gameStatus.Location = new Point(170, 43);
            gameStatus.Name = "gameStatus";
            gameStatus.Size = new Size(136, 15);
            gameStatus.TabIndex = 2;
            gameStatus.Text = "GameStatus: Not Found.";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // keepHookingCoD
            // 
            keepHookingCoD.Tick += keepHookingCoD_Tick;
            // 
            // enablePortForwarding
            // 
            enablePortForwarding.AutoSize = true;
            enablePortForwarding.Location = new Point(232, 13);
            enablePortForwarding.Name = "enablePortForwarding";
            enablePortForwarding.Size = new Size(61, 19);
            enablePortForwarding.TabIndex = 3;
            enablePortForwarding.Text = "Enable";
            enablePortForwarding.UseVisualStyleBackColor = true;
            enablePortForwarding.CheckedChanged += enablePortForwarding_CheckedChanged;
            // 
            // sendPortTimer
            // 
            sendPortTimer.Tick += sendPortTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 67);
            Controls.Add(enablePortForwarding);
            Controls.Add(gameStatus);
            Controls.Add(label1);
            Controls.Add(customPort);
            Name = "Form1";
            Text = "MW2 Custom Port";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customPort;
        private Label label1;
        private Label gameStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer keepHookingCoD;
        private CheckBox enablePortForwarding;
        private System.Windows.Forms.Timer sendPortTimer;
    }
}
