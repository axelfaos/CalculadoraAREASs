namespace CalculadoraAREAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            triangulo = new Button();
            circulo = new Button();
            cuadrado = new Button();
            rectangulo = new Button();
            trapecio = new Button();
            label1 = new Label();
            label2 = new Label();
            actualizar = new Button();
            SuspendLayout();
            // 
            // triangulo
            // 
            triangulo.BackColor = Color.Transparent;
            triangulo.BackgroundImage = (Image)resources.GetObject("triangulo.BackgroundImage");
            triangulo.BackgroundImageLayout = ImageLayout.Zoom;
            triangulo.FlatStyle = FlatStyle.Flat;
            triangulo.ForeColor = Color.Transparent;
            triangulo.Location = new Point(13, 257);
            triangulo.Name = "triangulo";
            triangulo.Size = new Size(109, 97);
            triangulo.TabIndex = 0;
            triangulo.UseVisualStyleBackColor = false;
            triangulo.Click += triangulo_Click;
            // 
            // circulo
            // 
            circulo.BackColor = Color.Transparent;
            circulo.BackgroundImage = (Image)resources.GetObject("circulo.BackgroundImage");
            circulo.BackgroundImageLayout = ImageLayout.Zoom;
            circulo.FlatStyle = FlatStyle.Flat;
            circulo.ForeColor = Color.Transparent;
            circulo.Location = new Point(164, 261);
            circulo.Name = "circulo";
            circulo.Size = new Size(97, 88);
            circulo.TabIndex = 1;
            circulo.UseVisualStyleBackColor = false;
            circulo.Click += circulo_Click;
            // 
            // cuadrado
            // 
            cuadrado.BackColor = SystemColors.ActiveCaption;
            cuadrado.FlatStyle = FlatStyle.Flat;
            cuadrado.ForeColor = Color.Transparent;
            cuadrado.Location = new Point(312, 264);
            cuadrado.Name = "cuadrado";
            cuadrado.Size = new Size(90, 82);
            cuadrado.TabIndex = 2;
            cuadrado.UseVisualStyleBackColor = false;
            cuadrado.Click += cuadrado_Click;
            // 
            // rectangulo
            // 
            rectangulo.BackColor = Color.FromArgb(255, 192, 128);
            rectangulo.FlatStyle = FlatStyle.Flat;
            rectangulo.ForeColor = Color.Transparent;
            rectangulo.Location = new Point(458, 277);
            rectangulo.Name = "rectangulo";
            rectangulo.Size = new Size(146, 66);
            rectangulo.TabIndex = 3;
            rectangulo.UseVisualStyleBackColor = false;
            rectangulo.Click += rectangulo_Click;
            // 
            // trapecio
            // 
            trapecio.BackColor = Color.Transparent;
            trapecio.BackgroundImage = (Image)resources.GetObject("trapecio.BackgroundImage");
            trapecio.BackgroundImageLayout = ImageLayout.Zoom;
            trapecio.FlatStyle = FlatStyle.Flat;
            trapecio.ForeColor = Color.Transparent;
            trapecio.Location = new Point(638, 264);
            trapecio.Name = "trapecio";
            trapecio.Size = new Size(150, 92);
            trapecio.TabIndex = 4;
            trapecio.UseVisualStyleBackColor = false;
            trapecio.Click += trapecio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 109);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 5;
            label1.Text = "Calculadora areas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 168);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 6;
            label2.Text = "Selecciona la figura";
            // 
            // actualizar
            // 
            actualizar.Location = new Point(25, 387);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(112, 34);
            actualizar.TabIndex = 7;
            actualizar.Text = "actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trapecio);
            Controls.Add(rectangulo);
            Controls.Add(cuadrado);
            Controls.Add(circulo);
            Controls.Add(triangulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button triangulo;
        private Button circulo;
        private Button cuadrado;
        private Button rectangulo;
        private Button trapecio;
        private Label label1;
        private Label label2;
        private Button actualizar;
    }
}
