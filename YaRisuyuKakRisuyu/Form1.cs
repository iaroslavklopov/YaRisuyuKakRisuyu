namespace YaRisuyuKakRisuyu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выбираем перо "myPen" черного цвета Black
            //толщиной в 1 пиксель:
            Pen myPen = new Pen(Color.Black, 1);
            SolidBrush solidBrushR = new SolidBrush(Color.Red);
            SolidBrush solidBrushG = new SolidBrush(Color.Green);
            SolidBrush solidBrushB = new SolidBrush(Color.Blue);
            //Объявляем объект "g" класса Graphics и предоставляем
            //ему возможность рисования на pictureBox1:
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            //Рисуем прямоугольник:
            g.FillRectangle(solidBrushB, 100, 650, 1500, 250);
            g.FillRectangle(solidBrushG, 500, 400, 750, 250);
            g.FillRectangle(solidBrushR, 750, 150, 250, 250);
        }
    }
}