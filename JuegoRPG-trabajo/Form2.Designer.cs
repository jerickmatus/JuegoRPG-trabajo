namespace JuegoRPG_trabajo
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Tienda";
            // 
            // button1
            // 
            button1.Location = new Point(102, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_comprarvida;
            // 
            // button2
            // 
            button2.Location = new Point(585, 324);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "comprar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_comprarveneno;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 100);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Pociones de vida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 89);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 4;
            label3.Text = "Pociones de veneno";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pociondevida;
            pictureBox1.Location = new Point(69, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pociondeveneno;
            pictureBox2.Location = new Point(554, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_cerrartienda;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}