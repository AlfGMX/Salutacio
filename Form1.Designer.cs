namespace Salutació
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
            SayHelloButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SayHelloButton
            // 
            SayHelloButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SayHelloButton.Location = new Point(54, 49);
            SayHelloButton.Name = "SayHelloButton";
            SayHelloButton.Size = new Size(358, 117);
            SayHelloButton.TabIndex = 0;
            SayHelloButton.Text = "Fes clic aqui per dir hola";
            SayHelloButton.UseVisualStyleBackColor = true;
            SayHelloButton.Click += SayHelloButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(54, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 80);
            textBox1.TabIndex = 1;
            textBox1.Text = "Hola a tots!";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 342);
            Controls.Add(textBox1);
            Controls.Add(SayHelloButton);
            Name = "Form1";
            Text = "Digues hola";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SayHelloButton;
        private TextBox textBox1;
    }
}
