namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria, string modelo, string imei) : base(numero, memoria, modelo, imei)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}