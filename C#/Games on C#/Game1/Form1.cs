namespace Game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravity = 10;
        int speed = 25;
        int score = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
            else if (e.KeyCode == Keys.Enter)
            {
                score = 0;
                timer2.Start();
            }
        }
        Random rnd = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipdown1.Left -= speed;
            pipTop1.Left -= speed;   

            IBLScore.Text = $"Score: {score}";

            if(pipdown1.Left < -50)
            {
                pipdown1.Left = rnd.Next(270, 1000);
                score++;
            }
            if (pipTop1.Left < -50)
            {
                pipTop1.Left = rnd.Next(270, 1000);
                score++;
            }
            if (bird.Bounds.IntersectsWith(pipdown1.Bounds) || bird.Bounds.IntersectsWith(pipTop1.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds)) {
                timer2.Stop();
                IBLScore.Text += " Game over";
            }
        }
    }
}