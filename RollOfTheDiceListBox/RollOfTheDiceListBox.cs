namespace RollOfTheDiceListBox
{
    public partial class RollOfTheDiceListBox : Form
    {
        public string rollsOfDice { get; private set; }

        public RollOfTheDiceListBox()
        {
            InitializeComponent();
            SetDefaults();
            
        }




        private void SetDefaults()
        {
            ListBox.Items.Clear();
            ListBox.Items.Add("Roll of the dice, rolls a dice 1000 times,"
                + "and will show how many rolls per number.");
           
        }

        private void RollButton_Click(object sender, EventArgs e)
        {

            ListBox.Items.Clear();
            {
                Random random = new Random(); //makes a random number variable
                int[] dice = new int[13];
                string format = "|"; // to space out the numbers of rolls 
                ListBox.Items.Add("Roll of the dice, rolls a dice 1000 times,"
                    + " and will show how many rolls per number.");
                for (int i = 0; i < 1000; i++) // array to roll 1000 times 
                {
                    int n = random.Next(2, 12 + 1);
                    dice[n]++;
                }

                for (int i = 2; i <= 12; i++) // to show numbers 2-12 
                {
                    rollsOfDice += ($"{i}".PadRight(7) + format);
                }

                ListBox.Items.Add(rollsOfDice);
                ListBox.Items.Add("________________________________________________________________________________");
                rollsOfDice = "";

                for (int i = 2; i <= 12; i++) // to list how many times 
                {
                    rollsOfDice += ($"{dice[i]}".PadRight(7) + format);
                }
                ListBox.Items.Add(rollsOfDice);
                rollsOfDice = "";
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
