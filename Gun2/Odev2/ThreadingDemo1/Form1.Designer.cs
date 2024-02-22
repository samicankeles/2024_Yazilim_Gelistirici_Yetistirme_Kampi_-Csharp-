namespace ThreadingDemo1
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
            btn_Process1 = new Button();
            btn_Process2 = new Button();
            SuspendLayout();
            // 
            // btn_Process1
            // 
            btn_Process1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Process1.Location = new Point(124, 91);
            btn_Process1.Name = "btn_Process1";
            btn_Process1.Size = new Size(74, 34);
            btn_Process1.TabIndex = 0;
            btn_Process1.Text = "İşlem 1";
            btn_Process1.UseVisualStyleBackColor = true;
            btn_Process1.Click += btn_Process1_Click;
            // 
            // btn_Process2
            // 
            btn_Process2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Process2.Location = new Point(300, 91);
            btn_Process2.Name = "btn_Process2";
            btn_Process2.Size = new Size(74, 34);
            btn_Process2.TabIndex = 1;
            btn_Process2.Text = "İşlem 2";
            btn_Process2.UseVisualStyleBackColor = true;
            btn_Process2.Click += btn_Process2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Process2);
            Controls.Add(btn_Process1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Process1;
        private Button btn_Process2;
    }
}