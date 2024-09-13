namespace YazLab1_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            label1 = new Label();
            buttongarson = new Button();
            buttonasci = new Button();
            buttonkasa = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(331, 42);
            label1.Name = "label1";
            label1.Size = new Size(329, 49);
            label1.TabIndex = 2;
            label1.Text = "HOŞ GELDİNİZ :)";
            // 
            // buttongarson
            // 
            buttongarson.BackColor = Color.Bisque;
            buttongarson.ForeColor = Color.FromArgb(64, 0, 0);
            buttongarson.Location = new Point(188, 268);
            buttongarson.Name = "buttongarson";
            buttongarson.Size = new Size(150, 50);
            buttongarson.TabIndex = 4;
            buttongarson.Text = "GARSON";
            buttongarson.UseVisualStyleBackColor = false;
            buttongarson.Click += buttongarson_Click;
            // 
            // buttonasci
            // 
            buttonasci.BackColor = Color.Bisque;
            buttonasci.ForeColor = Color.FromArgb(64, 0, 0);
            buttonasci.Location = new Point(427, 268);
            buttonasci.Name = "buttonasci";
            buttonasci.Size = new Size(150, 50);
            buttonasci.TabIndex = 5;
            buttonasci.Text = "AŞÇI";
            buttonasci.UseVisualStyleBackColor = false;
            buttonasci.Click += buttonasci_Click;
            // 
            // buttonkasa
            // 
            buttonkasa.BackColor = Color.Bisque;
            buttonkasa.ForeColor = Color.FromArgb(64, 0, 0);
            buttonkasa.Location = new Point(662, 268);
            buttonkasa.Name = "buttonkasa";
            buttonkasa.Size = new Size(150, 50);
            buttonkasa.TabIndex = 6;
            buttonkasa.Text = "KASA";
            buttonkasa.UseVisualStyleBackColor = false;
            buttonkasa.Click += buttonkasa_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Location = new Point(331, 440);
            button1.Name = "button1";
            button1.Size = new Size(329, 60);
            button1.TabIndex = 7;
            button1.Text = "ÇALIŞTIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1023, 609);
            Controls.Add(button1);
            Controls.Add(buttonkasa);
            Controls.Add(buttonasci);
            Controls.Add(buttongarson);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttongarson;
        private Button buttonasci;
        private Button buttonkasa;
        private Button button1;
    }
}