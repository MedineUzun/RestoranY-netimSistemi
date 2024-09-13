namespace YazLab1_3
{
    partial class GarsonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            deneme = new RichTextBox();
            deneme1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(530, 52);
            button1.Name = "button1";
            button1.Size = new Size(178, 71);
            button1.TabIndex = 0;
            button1.Text = "müşterileri göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deneme
            // 
            deneme.Location = new Point(12, 52);
            deneme.Name = "deneme";
            deneme.Size = new Size(494, 246);
            deneme.TabIndex = 1;
            deneme.Text = "";
            // 
            // deneme1
            // 
            deneme1.Location = new Point(12, 324);
            deneme1.Name = "deneme1";
            deneme1.Size = new Size(494, 246);
            deneme1.TabIndex = 2;
            deneme1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(530, 324);
            button2.Name = "button2";
            button2.Size = new Size(178, 71);
            button2.TabIndex = 3;
            button2.Text = "müşterileri göster";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(530, 227);
            button3.Name = "button3";
            button3.Size = new Size(178, 71);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(530, 499);
            button4.Name = "button4";
            button4.Size = new Size(178, 71);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // GarsonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1023, 609);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(deneme1);
            Controls.Add(deneme);
            Controls.Add(button1);
            Name = "GarsonForm";
            Text = "GarsonForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox deneme;
        private RichTextBox deneme1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}