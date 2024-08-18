namespace EjemploUno
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            L_y1 = new Label();
            L_y = new Label();
            L_x1 = new Label();
            L_x = new Label();
            C_tamanio = new ComboBox();
            B_guardar = new Button();
            B_circulo = new Button();
            B_color = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            edicionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            B_borrar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Location = new Point(12, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(648, 335);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(L_y1);
            groupBox1.Controls.Add(L_y);
            groupBox1.Controls.Add(L_x1);
            groupBox1.Controls.Add(L_x);
            groupBox1.Location = new Point(26, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // L_y1
            // 
            L_y1.AutoSize = true;
            L_y1.Location = new Point(202, 77);
            L_y1.Name = "L_y1";
            L_y1.Size = new Size(25, 20);
            L_y1.TabIndex = 3;
            L_y1.Text = "Y1";
            // 
            // L_y
            // 
            L_y.AutoSize = true;
            L_y.Location = new Point(69, 77);
            L_y.Name = "L_y";
            L_y.Size = new Size(17, 20);
            L_y.TabIndex = 2;
            L_y.Text = "Y";
            // 
            // L_x1
            // 
            L_x1.AutoSize = true;
            L_x1.Location = new Point(202, 43);
            L_x1.Name = "L_x1";
            L_x1.Size = new Size(26, 20);
            L_x1.TabIndex = 1;
            L_x1.Text = "X1";
            // 
            // L_x
            // 
            L_x.AutoSize = true;
            L_x.Location = new Point(65, 43);
            L_x.Name = "L_x";
            L_x.Size = new Size(18, 20);
            L_x.TabIndex = 0;
            L_x.Text = "X";
            // 
            // C_tamanio
            // 
            C_tamanio.BackColor = SystemColors.ControlLightLight;
            C_tamanio.FormattingEnabled = true;
            C_tamanio.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            C_tamanio.Location = new Point(681, 95);
            C_tamanio.Name = "C_tamanio";
            C_tamanio.Size = new Size(151, 28);
            C_tamanio.TabIndex = 2;
            C_tamanio.SelectedIndexChanged += C_tamanio_SelectedIndexChanged;
            // 
            // B_guardar
            // 
            B_guardar.Location = new Point(681, 49);
            B_guardar.Name = "B_guardar";
            B_guardar.Size = new Size(94, 29);
            B_guardar.TabIndex = 3;
            B_guardar.Text = "Guardar";
            B_guardar.UseVisualStyleBackColor = true;
            // 
            // B_circulo
            // 
            B_circulo.Location = new Point(681, 151);
            B_circulo.Name = "B_circulo";
            B_circulo.Size = new Size(94, 29);
            B_circulo.TabIndex = 4;
            B_circulo.Text = "Circulo";
            B_circulo.UseVisualStyleBackColor = true;
            B_circulo.Click += B_circulo_Click;
            // 
            // B_color
            // 
            B_color.Location = new Point(421, 429);
            B_color.Name = "B_color";
            B_color.Size = new Size(94, 29);
            B_color.TabIndex = 5;
            B_color.Text = "Color";
            B_color.UseVisualStyleBackColor = true;
            B_color.Click += B_color_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, edicionToolStripMenuItem, ayudaToolStripMenuItem, acercaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(844, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, nuevoToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripMenuItem1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(187, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(187, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(184, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(187, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // edicionToolStripMenuItem
            // 
            edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            edicionToolStripMenuItem.Size = new Size(72, 24);
            edicionToolStripMenuItem.Text = "Edicion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaToolStripMenuItem
            // 
            acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            acercaToolStripMenuItem.Size = new Size(68, 24);
            acercaToolStripMenuItem.Text = "Acerca";
            // 
            // B_borrar
            // 
            B_borrar.Location = new Point(685, 432);
            B_borrar.Name = "B_borrar";
            B_borrar.Size = new Size(94, 29);
            B_borrar.TabIndex = 7;
            B_borrar.Text = "Borrar";
            B_borrar.UseVisualStyleBackColor = true;
            B_borrar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(681, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Triangulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(681, 242);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Rectangulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(844, 514);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(B_borrar);
            Controls.Add(B_color);
            Controls.Add(B_circulo);
            Controls.Add(B_guardar);
            Controls.Add(C_tamanio);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ComboBox C_tamanio;
        private Label L_y1;
        private Label L_y;
        private Label L_x1;
        private Label L_x;
        private Button B_guardar;
        private Button B_circulo;
        private Button B_color;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem edicionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Button B_borrar;
        private Button button1;
        private Button button2;
    }
}
