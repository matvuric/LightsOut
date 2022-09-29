namespace Safe
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int size;
        private int steps;
        private int lightsQuantity;
        
        // Array of buttons
        private Button[,] lights;
        internal MessageBoxButtons MB_OK { get; private set; }
        public Form()
        {
            InitializeComponent();
        }

        private void Setup()
        {
            lights = new Button[size, size];
            // Loop through all lights to generate the buttons on form
            for (int i = 0; i < lights.GetLength(1); i++)
            {
                for (int j = 0; j < lights.GetLength(0); j++)
                {
                    lights[i, j] = new Button();
                    lights[i, j].Size = new Size(40, 40);
                    // Name of button object is index in 3D array
                    lights[i, j].Name = i.ToString() + ' ' + j.ToString();
                    lights[i, j].Click += LightClick!;
                    lights[i, j].Location = new Point(10 + (j * 50), 10 + (i * 50));
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
        }

        private void LightClick(object sender, EventArgs e)
        {
            Button b = (Button)sender; //Clicked object is a Button
            // Get the index of the button clicked
            string[] arr = b.Name.Split(' ');
            int i = int.Parse(arr[0]);
            int j = int.Parse(arr[1]);
            StepQuantity.Text = Convert.ToString(++steps);

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
            // Check if all lights are off
            if (lightsQuantity == 0)
            {
                // Display message to user
                MessageBox.Show("Game Completed!",
                    "Congratulations!",
                     MB_OK);
                // Close Application
                Application.Exit();
            }
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            size = (int)ComboBox.SelectedItem;
            ComboBox.Visible = false;
            GridLabel.Visible = false;
            SubmitBtn.Visible = false;
            // Turn on a random number of lights to start game
            Setup();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            size = (int)ComboBox.SelectedItem;
            ComboBox.Visible = false;
            GridLabel.Visible = false;
            SubmitBtn.Visible = false;
            // Turn on a random number of lights to start game
            Setup();
        }

    }
}