namespace JuegoRPG_trabajo
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
            textboxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textboxAtaque = new TextBox();
            label3 = new Label();
            textboxVida = new TextBox();
            button1 = new Button();
            nombreguerrero = new Label();
            ataqueguerrero = new Label();
            vidaguerrero = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            nombre_enemigo = new Label();
            ataque_enemigo = new Label();
            vida_enemigo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label6 = new Label();
            pocionesvida = new Label();
            label7 = new Label();
            pocionesveneno = new Label();
            button9 = new Button();
            label8 = new Label();
            cantidaddinero = new Label();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(145, 357);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(125, 27);
            textboxNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 360);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 411);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "ataque";
            // 
            // textboxAtaque
            // 
            textboxAtaque.Location = new Point(145, 408);
            textboxAtaque.Name = "textboxAtaque";
            textboxAtaque.Size = new Size(125, 27);
            textboxAtaque.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 458);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "vida";
            // 
            // textboxVida
            // 
            textboxVida.Location = new Point(145, 455);
            textboxVida.Name = "textboxVida";
            textboxVida.Size = new Size(125, 27);
            textboxVida.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(96, 519);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 6;
            button1.Text = "crear personaje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttoncrearpersonaje;
            // 
            // nombreguerrero
            // 
            nombreguerrero.AutoSize = true;
            nombreguerrero.Location = new Point(38, 80);
            nombreguerrero.Name = "nombreguerrero";
            nombreguerrero.Size = new Size(15, 20);
            nombreguerrero.TabIndex = 7;
            nombreguerrero.Text = "-";
            // 
            // ataqueguerrero
            // 
            ataqueguerrero.AutoSize = true;
            ataqueguerrero.Location = new Point(38, 128);
            ataqueguerrero.Name = "ataqueguerrero";
            ataqueguerrero.Size = new Size(15, 20);
            ataqueguerrero.TabIndex = 8;
            ataqueguerrero.Text = "-";
            // 
            // vidaguerrero
            // 
            vidaguerrero.AutoSize = true;
            vidaguerrero.Location = new Point(38, 175);
            vidaguerrero.Name = "vidaguerrero";
            vidaguerrero.Size = new Size(15, 20);
            vidaguerrero.TabIndex = 9;
            vidaguerrero.Text = "-";
            // 
            // button2
            // 
            button2.Location = new Point(565, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "orco";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_orco;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 306);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 11;
            label4.Text = "Crear Personaje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 306);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 12;
            label5.Text = "seleccionar enemigo";
            // 
            // button3
            // 
            button3.Location = new Point(565, 402);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "goblin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_goblin;
            // 
            // button4
            // 
            button4.Location = new Point(565, 458);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "asesino";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_asesino;
            // 
            // nombre_enemigo
            // 
            nombre_enemigo.AutoSize = true;
            nombre_enemigo.Location = new Point(476, 80);
            nombre_enemigo.Name = "nombre_enemigo";
            nombre_enemigo.Size = new Size(15, 20);
            nombre_enemigo.TabIndex = 15;
            nombre_enemigo.Text = "-";
            // 
            // ataque_enemigo
            // 
            ataque_enemigo.AutoSize = true;
            ataque_enemigo.Location = new Point(476, 128);
            ataque_enemigo.Name = "ataque_enemigo";
            ataque_enemigo.Size = new Size(15, 20);
            ataque_enemigo.TabIndex = 16;
            ataque_enemigo.Text = "-";
            // 
            // vida_enemigo
            // 
            vida_enemigo.AutoSize = true;
            vida_enemigo.Location = new Point(476, 172);
            vida_enemigo.Name = "vida_enemigo";
            vida_enemigo.Size = new Size(15, 20);
            vida_enemigo.TabIndex = 17;
            vida_enemigo.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(123, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(575, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(123, 224);
            button5.Name = "button5";
            button5.Size = new Size(111, 29);
            button5.TabIndex = 20;
            button5.Text = "atacar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_atacar_guerrero;
            // 
            // button6
            // 
            button6.Location = new Point(589, 224);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 21;
            button6.Text = "atacar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_atacar_enemigo;
            // 
            // button7
            // 
            button7.Location = new Point(377, 270);
            button7.Name = "button7";
            button7.Size = new Size(94, 56);
            button7.TabIndex = 22;
            button7.Text = "mejorar guerrero";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_mejorarguerrero;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(240, 91);
            button8.Name = "button8";
            button8.Size = new Size(68, 46);
            button8.TabIndex = 23;
            button8.Text = "posion de vida";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_pocion_vida;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 19);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 24;
            label6.Text = "posiones de vida:";
            // 
            // pocionesvida
            // 
            pocionesvida.AutoSize = true;
            pocionesvida.Location = new Point(238, 19);
            pocionesvida.Name = "pocionesvida";
            pocionesvida.Size = new Size(17, 20);
            pocionesvida.TabIndex = 25;
            pocionesvida.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 39);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 26;
            label7.Text = "pociones de veneno:";
            // 
            // pocionesveneno
            // 
            pocionesveneno.AutoSize = true;
            pocionesveneno.Location = new Point(261, 39);
            pocionesveneno.Name = "pocionesveneno";
            pocionesveneno.Size = new Size(17, 20);
            pocionesveneno.TabIndex = 27;
            pocionesveneno.Text = "0";
            // 
            // button9
            // 
            button9.Location = new Point(240, 143);
            button9.Name = "button9";
            button9.Size = new Size(88, 56);
            button9.TabIndex = 28;
            button9.Text = "posion de veneno";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_pocion_veneno;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 361);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 29;
            label8.Text = "dinero";
            // 
            // cantidaddinero
            // 
            cantidaddinero.AutoSize = true;
            cantidaddinero.Location = new Point(350, 383);
            cantidaddinero.Name = "cantidaddinero";
            cantidaddinero.Size = new Size(17, 20);
            cantidaddinero.TabIndex = 30;
            cantidaddinero.Text = "0";
            // 
            // button10
            // 
            button10.Location = new Point(397, 360);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 31;
            button10.Text = "tienda";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_tienda;
            // 
            // button11
            // 
            button11.Location = new Point(575, 45);
            button11.Name = "button11";
            button11.Size = new Size(125, 29);
            button11.TabIndex = 32;
            button11.Text = "recompensa";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_recompensa;
            // 
            // button12
            // 
            button12.Location = new Point(350, 458);
            button12.Name = "button12";
            button12.Size = new Size(127, 29);
            button12.TabIndex = 33;
            button12.Text = "Guardar Partida";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_guardar;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(cantidaddinero);
            Controls.Add(label8);
            Controls.Add(button9);
            Controls.Add(pocionesveneno);
            Controls.Add(label7);
            Controls.Add(pocionesvida);
            Controls.Add(label6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(vida_enemigo);
            Controls.Add(ataque_enemigo);
            Controls.Add(nombre_enemigo);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(vidaguerrero);
            Controls.Add(ataqueguerrero);
            Controls.Add(nombreguerrero);
            Controls.Add(button1);
            Controls.Add(textboxVida);
            Controls.Add(label3);
            Controls.Add(textboxAtaque);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textboxNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxNombre;
        private Label label1;
        private Label label2;
        private TextBox textboxAtaque;
        private Label label3;
        private TextBox textboxVida;
        private Button button1;
        private Label nombreguerrero;
        private Label ataqueguerrero;
        private Label vidaguerrero;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label nombre_enemigo;
        private Label ataque_enemigo;
        private Label vida_enemigo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label6;
        private Label pocionesvida;
        private Label label7;
        private Label pocionesveneno;
        private Button button9;
        private Label label8;
        private Label cantidaddinero;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}
