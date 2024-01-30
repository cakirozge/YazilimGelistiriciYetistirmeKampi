namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8,8];
            int top = 0;
            int left =0;

            for (int i = 0; i < button.GetUpperBound(0); i++) //0. boyutun 
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i,j].Height = 50;
                    button[i, j].Left = left;
                    left += 50;
                    button[i, j].Top = top;
                    //button[i, j].Text = "My button";
                    this.Controls.Add(button[i,j]);

                    if ((i+j)%2==0)
                    {
                        button[i, j].BackColor = Color.BlueViolet;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }

                }
                top += 50;
                left = 0; //sola geçmek için 
            }


           


        }
    }
}