namespace PAM_Projects.Models
{
    internal class Coin
    {
        public string LadoSorteado { get; set; }

        public Coin() { }

        public void Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "cara" : "coroa";
        }
    }
}
