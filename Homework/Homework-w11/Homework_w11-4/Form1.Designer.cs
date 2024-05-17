namespace Homework_w11_4
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
            btnStop = new Button();
            btnClear = new Button();
            btnStart = new Button();
            timer = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.Location = new Point(267, 296);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 34);
            btnStop.TabIndex = 0;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(385, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(267, 225);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(230, 65);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start!";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(357, 180);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(56, 25);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(159, 64);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(497, 31);
            txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblTimer);
            Controls.Add(btnStart);
            Controls.Add(btnClear);
            Controls.Add(btnStop);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStop;
        private Button btnClear;
        private Button btnStart;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private TextBox txtInput;
    }
}