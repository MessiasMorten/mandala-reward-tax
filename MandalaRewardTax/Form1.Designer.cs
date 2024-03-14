namespace MandalaRewardTax
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            progressBar = new ProgressBar();
            groupBox1 = new GroupBox();
            lb1 = new ListBox();
            ofd1 = new OpenFileDialog();
            button3 = new Button();
            button4 = new Button();
            sfd1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 149);
            button1.Name = "button1";
            button1.Size = new Size(205, 36);
            button1.TabIndex = 0;
            button1.Text = "Fetch reward values";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(735, 106);
            label1.TabIndex = 1;
            label1.Text = "This program reads a .csv file from the Mandala Exchange reports page and fetches the value of the reward for the relevant point in time for tax purposes.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(148, 107);
            button2.Name = "button2";
            button2.Size = new Size(205, 36);
            button2.TabIndex = 2;
            button2.Text = "Upload .csv";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 191);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(725, 29);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb1);
            groupBox1.Location = new Point(12, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 208);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log";
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.Location = new Point(6, 26);
            lb1.Name = "lb1";
            lb1.Size = new Size(713, 164);
            lb1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(359, 107);
            button3.Name = "button3";
            button3.Size = new Size(205, 36);
            button3.TabIndex = 5;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(359, 149);
            button4.Name = "button4";
            button4.Size = new Size(205, 36);
            button4.TabIndex = 6;
            button4.Text = "Save File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 446);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(progressBar);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "MandalaTaxRewards";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private ProgressBar progressBar;
        private GroupBox groupBox1;
        private ListBox lb1;
        private OpenFileDialog ofd1;
        private Button button3;
        private Button button4;
        private SaveFileDialog sfd1;
    }
}
