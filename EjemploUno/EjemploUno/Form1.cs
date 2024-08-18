namespace EjemploUno
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen punto = new Pen(Color.Pink, 1);
        Pen borrar = new Pen(Color.White, 1);
        Point pini = new Point(10, 10);
        Point pfin = new Point(100, 100);
        Color color;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            L_x.Text = "X: " + Convert.ToString(e.X);
            L_y.Text = "Y: " + Convert.ToString(e.Y);
            if (e.Button == MouseButtons.Left)
            //if(bandera)
            {
                pfin = e.Location;
                g.DrawLine(punto, pini, pfin);
                pini = pfin; //el punto inicial se convierte en el punto final
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            L_x1.Text = "X1: " + Convert.ToString(e.X);
            L_y1.Text = "Y1: " + Convert.ToString(e.Y);
            pini = e.Location; //quita el error de la linea inicial
        }

        private void B_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            punto.Color = colorDialog1.Color;
        }

        private void C_tamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            punto.Width = int.Parse(C_tamanio.SelectedItem.ToString());
        }

        private void B_circulo_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(punto, 100, 100, 150, 150);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            g.DrawRectangles(punto, 50,50,50,50);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
