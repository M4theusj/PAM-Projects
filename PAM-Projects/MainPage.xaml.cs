namespace PAM_Projects
{
    public partial class MainPage : ContentPage
    {
        Random rand = new Random();
        int randomNumber;
        bool CheckColor = false;

        public MainPage()
        {
            InitializeComponent();
            DicePicker.SelectedIndex = 0;
        }

        private int NumeroLados()
        {
            switch (DicePicker.SelectedIndex)
            {
                case 0: return 4;
                case 1: return 6;
                case 2: return 10;
                case 3: return 20;
                case 4: return 100;
                default: return 4;
            }
        }

        private async void DiceRollButton_Clicked(object sender, EventArgs e)
        {
            int PreviousDiceRoll = 0;
            DiceRollButton.IsEnabled = false;
            int lados = NumeroLados();

            for (int i = 0; i < 3; i++)
            {
                int newRandomNumber;
                do
                {
                    newRandomNumber = rand.Next(1, lados + 1);
                } while (newRandomNumber == PreviousDiceRoll);

                randomNumber = newRandomNumber;
                PreviousDiceRoll = randomNumber;
                DiceResult.Text = randomNumber.ToString();

                await Task.Delay(500);
            }

            DiceRollButton.IsEnabled = true;
        }


        private void ChangeThemeColor_Clicked(object sender, EventArgs e)
        {
            CheckColor = !CheckColor;

            if (CheckColor)
            {
                BackgroundColor = Color.FromArgb("282525");
                InitialLabel.TextColor = Color.FromRgb(255, 255, 255);
                DiceResult.TextColor = Color.FromRgb(255, 255, 255);
                DicePicker.TitleColor = Color.FromRgb(255, 255, 255);
                ChangeThemeColor.Source = "sun.png";
                CheckColor = true;
            }
            else
            {
                BackgroundColor = Color.FromArgb("FFFFFF");
                InitialLabel.TextColor = Color.FromRgb(0, 0, 0);
                DiceResult.TextColor = Color.FromRgb(0, 0, 0);
                DicePicker.TitleColor = Color.FromRgb(0, 0, 0);
                ChangeThemeColor.Source = "moon.png";
                CheckColor = false;
            }
        }
    }

}
