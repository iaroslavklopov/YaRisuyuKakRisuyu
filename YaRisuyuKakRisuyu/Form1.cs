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
            //�������� ���� "myPen" ������� ����� Black
            //�������� � 1 �������:
            Pen myPen = new Pen(Color.Black, 1);
            SolidBrush solidBrushR = new SolidBrush(Color.Red);
            SolidBrush solidBrushG = new SolidBrush(Color.Green);
            SolidBrush solidBrushB = new SolidBrush(Color.Blue);
            //��������� ������ "g" ������ Graphics � �������������
            //��� ����������� ��������� �� pictureBox1:
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            //������ �������������:
            g.FillRectangle(solidBrushB, 100, 650, 1500, 250);
            g.FillRectangle(solidBrushG, 500, 400, 750, 250);
            g.FillRectangle(solidBrushR, 750, 150, 250, 250);
        }
    }
}