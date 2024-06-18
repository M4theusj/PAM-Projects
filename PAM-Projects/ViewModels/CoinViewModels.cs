using PAM_Projects.Models;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PAM_Projects.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();
            Resultado = Escolha.ToLower() == coin.LadoSorteado.ToLower() ? "Você venceu" : "Você perdeu";
            Imagem = coin.LadoSorteado.ToLower() == "cara" ? "cara.png" : "coroa.png";
        }
    }
}
