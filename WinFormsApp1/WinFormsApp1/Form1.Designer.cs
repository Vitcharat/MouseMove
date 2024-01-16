namespace WinFormsApp1
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
            btnColor = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Font = new Font("TH SarabunPSK", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColor.Location = new Point(445, 43);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(111, 52);
            btnColor.TabIndex = 1;
            btnColor.Text = "เลือกสี";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH SarabunPSK", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 54);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.MouseMove += Form1_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH SarabunPSK", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(468, 122);
            label2.Name = "label2";
            label2.Size = new Size(46, 30);
            label2.TabIndex = 3;
            label2.Text = "ชื่อสี";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnColor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnColor;
        private Label label1;
        private Label label2;
    }
}
