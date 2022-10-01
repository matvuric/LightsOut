namespace Safe
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int size;
        private int steps;
        private int lightsQuantity;

        private int[,] colors = new int[,] { { 1, 1, 0, 1, 0 }, { 0, 1, 1, 0, 1 }, { 1, 0, 1, 1, 0 }, { 1, 0, 1, 1, 0 }, { 0, 1, 0, 0, 0 } };
        private Button[,] lights;

        public Form()
        {
            InitializeComponent();
        }

        private void Setup()
        {
            lights = new Button[size, size];
            int lightsQuantityInRow = 0;
            int lightsQuantityInColumn = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    lights[i, j] = new Button
                    {
                        Size = new Size(40, 40),
                        Name = i.ToString() + ' ' + j.ToString(),
                        Location = new Point(10 + (j * 50), 10 + (i * 50))
                    };
                    lights[i, j].Click += LightClick!;


                    /*if (colors[i, j] == 1)
                    {
                        lights[i, j].BackColor = Color.Yellow;
                        lightsQuantity++;
                    }
                    else
                    {
                        lights[i, j].BackColor = Color.Black;
                    }*/

                    Random rand = new();
                    if (rand.Next(0, 2) == 0)
                    {
                        lights[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        lights[i, j].BackColor = Color.Yellow;
                        lightsQuantity++;
                    }

                    Controls.Add(lights[i, j]);
                }
            }

            if (lightsQuantity == 0)
            {
                lights[0, 0].BackColor = Color.Yellow;
                lightsQuantity++;
            }

            if (size % 2 == 1)
            {
                TestSetup();
            }
        }

        private void TestSetup()
        {
            int[] rowsSum = new int[size];
            int[] colsSum = new int[size];


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (lights[i, j].BackColor == Color.Yellow)
                    {
                        rowsSum[i] ^= 1;
                    };
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (lights[j, i].BackColor == Color.Yellow)
                    {
                        colsSum[i] ^= 1;
                    };
                }
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (rowsSum[0] != rowsSum[i] || rowsSum[0] != colsSum[i])
                {
                    sum++;
                }
            }

            if (sum != 0)
            {
                restartBtn_Click(null, null);
            }
        }

        private void LightClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string[] arr = btn.Name.Split(' ');
            int i = int.Parse(arr[0]);
            int j = int.Parse(arr[1]);
            ChangeStep(++steps);

            // Invert button clicked
            InvertHandler(i, j);

            // Check if game has ended
            CheckEnd();
        }

        private void InvertHandler(int i, int j)
        {
            InvertButton(lights[i, j]);
            for (int k = 0; k < lights.GetLength(0); k++)
            {
                InvertButton(lights[i, k]);
                InvertButton(lights[k, j]);
            }
        }

        private void InvertButton(object sender)
        {
            Button b = (Button)sender; //Clicked object is a Button

            if (b.BackColor == Color.Yellow)
            {
                b.BackColor = Color.Black;
                lightsQuantity--;
            }
            else
            {
                b.BackColor = Color.Yellow;
                lightsQuantity++;
            }
        }

        private void CheckEnd()
        {
            if (lightsQuantity == 0 || lightsQuantity == size * size)
            {
                menuBtn_Click(null, null);
            }
        }

        private void Reset()
        {
            lightsQuantity = 0;
            steps = 0;
            ChangeStep(0);

            foreach (Button btn in lights)
            {
                Controls.Remove(btn);
            }
        }

        private void ChangeStep(int step)
        {
            steps = step;
            stepQuantity.Text = Convert.ToString(steps);
        }

        private void SetVisibility(bool v)
        {
            comboBox.Visible = v;
            gridLabel.Visible = v;
            submitBtn.Visible = v;
            stepLabel.Visible = !v;
            stepQuantity.Visible = !v;
            restartBtn.Visible = !v;
            menuBtn.Visible = !v;
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.ForeColor = Color.LightCoral;
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.ForeColor = Color.Turquoise;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            size = (int)comboBox.SelectedItem;
            SetVisibility(false);
            // Turn on a random number of lights to start game
            Setup();
        }

        private void restartBtn_Click(object? sender, EventArgs? e)
        {
            Reset();
            Setup();
        }

        private void menuBtn_Click(object? sender, EventArgs? e)
        {
            Reset();
            SetVisibility(true);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}