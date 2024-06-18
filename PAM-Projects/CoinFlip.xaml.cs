namespace PAM_Projects;

public partial class CoinFlip : ContentPage
{
	public CoinFlip()
	{
		InitializeComponent();
        CoinPicker.SelectedIndex = 0;
    }

    private void CoinButton_Clicked(object sender, EventArgs e)
    {

        Random random = new Random();
        int CoinResult = random.Next(0, 2);

        if (CoinResult == CoinPicker.SelectedIndex)
        {
            CoinImage.Source = CoinPicker.SelectedItem + ".png";
            CoinResultLabel.Text = "Parabéns você acertou!";
        }
        else if (CoinResult != CoinPicker.SelectedIndex)
        {
            if (CoinResult == 0)
            {
                CoinImage.Source = "cara.png";
            }
            else
            {
                CoinImage.Source = "coroa.png";
            }
            CoinResultLabel.Text = "Você errou!";
        }


    }
}