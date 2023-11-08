namespace RotateMirrorIMgae
{
    public partial class Form1 : Form
    {
        Bitmap img;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img = new Bitmap(ofd.FileName);

            graphics = this.CreateGraphics(); // make the form like a canvas
            graphics.ScaleTransform(0.1F, 0.1F); // size of the canvas

            graphics.DrawImage(img, new Point(100, 100)); // position x ,y DrawLine()

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // rotate
        {
            img.RotateFlip(RotateFlipType.Rotate180FlipX);
            graphics.Clear(Color.White);

            graphics.DrawImage(img, new Point(100, 100));
        }

        private void button3_Click(object sender, EventArgs e) // mirror
        {
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            graphics.Clear(Color.White);
            graphics.DrawImage(img, new Point(100,100));
        }
    }
}