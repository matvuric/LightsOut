namespace Safe
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int gridSize;
        private int steps;
        private int lightsQuantity;

        private readonly Random rand = new();

        private int[]? rowsSum;
        private int[]? colsSum;

        private Button[,]? lights;

        public Form()
        {
            InitializeComponent();
        }

        private void Setup()
        {
            lights = new Button[gridSize, gridSize];
            rowsSum = new int[gridSize];
            colsSum = new int[gridSize];

            if (gridSize % 2 == 0)
            {
                /*
                Grids with an even size always have a solution,
                so they are set completely randomly

                Сетки с четным размером всегда имеют решение,
                поэтому они задаются совершенно случайным образом
                */

                for (int i = 0; i < gridSize; i++)
                {
                    GenerateRandomRow(i);
                }
            }
            else
            {
                /*
                Grids with an odd size have a solution only when
                the number of 1 or 0 (lights or empties) modulo 2
                in all rows and columns of the grid are equal

                Сетки с нечетным размером имеют решение, только тогда, 
                когда количество 1 или 0 (светильников или пустот) по 
                модулю 2 во всех строках и столбцах сетки равны
                */

                for (int i = 0; i < gridSize; i++)
                {
                    if (i == 0)
                    {
                        GenerateRandomRow(i);
                    }
                    else if (i != gridSize - 1)
                    {
                        int lightsInRow;

                        if (rowsSum[0] % 2 == 0)
                        {
                            lightsInRow = GenerateRandomOddNum(0);
                        }
                        else
                        {
                            lightsInRow = GenerateRandomOddNum(1);
                        }

                        GenerateRowWithSpecifiedQuantity(i, lightsInRow);
                    }
                    else
                    {
                        GenerateLastRow(i);
                    }
                }
            }

            // Check if empty or full

            if (lightsQuantity == 0 || lightsQuantity == gridSize * gridSize)
            {
                restartBtn_Click(null, null);
            }
        }

        #region Generate Rows
        private void GenerateRandomRow(int i)
        {
            for (int j = 0; j < gridSize; j++)
            {
                InitializeBtn(i, j);

                if (rand.Next(2) == 1)
                {
                    Light(i, j);
                }
                else
                {
                    FadeOut(i, j);
                }

                Controls.Add(lights![i, j]);
            }
        }

        private void GenerateRowWithSpecifiedQuantity(int i, int quantity)
        {
            for (int j = 0; j < gridSize; j++)
            {
                InitializeBtn(i, j);

                if (gridSize - j - 1 >= quantity)
                {
                    if (quantity > 0 && rand.Next(2) == 1)
                    {
                        Light(i, j);
                        quantity--;
                    }
                    else
                    {
                        FadeOut(i, j);
                    }
                }
                else
                {
                    Light(i, j);
                    quantity--;
                }

                Controls.Add(lights![i, j]);
            }
        }

        private void GenerateLastRow(int i)
        {
            for (int j = 0; j < gridSize; j++)
            {
                InitializeBtn(i, j);

                if (colsSum![j] % 2 != rowsSum![0])
                {
                    Light(i, j);
                }
                else
                {
                    FadeOut(i, j);
                }

                Controls.Add(lights![i, j]);
            }
        }

        #endregion

        private void InitializeBtn(int i, int j)
        {
            lights![i, j] = new Button
            {
                Size = new Size(40, 40),
                Name = i.ToString() + ' ' + j.ToString(),
                FlatStyle = FlatStyle.Flat

            };

            if (gridSize < 13)
            {
                lights![i, j].Location = new Point(Width / 2 - gridSize / 2 * 50 + (j * 50),
                                                   Height / 2 - gridSize / 2 * 50 + (i * 50));
            }
            else
            {
                lights![i, j].Location = new Point(40 + (j * 50), 40 + (i * 50));
            }

            lights[i, j].Click += LightClick!;
        }

        private void Light(int i, int j)
        {
            lights![i, j].BackColor = Color.LightCoral;
            lightsQuantity++;
            rowsSum![i] ^= 1;
            colsSum![j] ^= 1;
        }

        private void FadeOut(int i, int j)
        {
            lights![i, j].BackColor = Color.Turquoise;
        }

        private int GenerateRandomOddNum(int odd)
        {
            int num;

            do
            {
                num = rand.Next(gridSize + 1);
            }
            while (num % 2 != odd);

            return num;
        }

        private void LightClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] arr = btn.Name.Split(' ');
            int i = int.Parse(arr[0]);
            int j = int.Parse(arr[1]);

            ChangeStep(++steps);
            InvertHandler(i, j);

            // Check end

            if (lightsQuantity == 0 || lightsQuantity == gridSize * gridSize)
            {
                menuBtn_Click(null, null);
            }
        }

        private void InvertHandler(int i, int j)
        {
            InvertButton(lights![i, j]);

            for (int k = 0; k < gridSize; k++)
            {
                InvertButton(lights[i, k]);
                InvertButton(lights[k, j]);
            }
        }

        private void InvertButton(object sender)
        {
            Button b = (Button)sender;

            if (b.BackColor == Color.LightCoral)
            {
                b.BackColor = Color.Turquoise;
                lightsQuantity--;
            }
            else
            {
                b.BackColor = Color.LightCoral;
                lightsQuantity++;
            }
        }

        private void ChangeStep(int step)
        {
            steps = step;
            stepQuantity.Text = Convert.ToString(steps);
        }

        private void ResetGrid()
        {
            lightsQuantity = 0;
            ChangeStep(0);

            foreach (Button btn in lights!)
            {
                Controls.Remove(btn);
            }
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

        #region MouseHandler

        private void submitBtn_Click(object sender, EventArgs e)
        {
            gridSize = (int)comboBox.SelectedItem;
            SetVisibility(false);
            Setup();
        }

        private void restartBtn_Click(object? sender, EventArgs? e)
        {
            ResetGrid();
            Setup();
        }

        private void menuBtn_Click(object? sender, EventArgs? e)
        {
            ResetGrid();
            SetVisibility(true);
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

        #endregion
    }
}