namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //*IMPLEMENTADO*
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

    public override void InstalarAplicativo(string nomeApp)
        {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //*IMPLEMENTADO*
        Console.WriteLine($"Instalando {nomeApp} no Nokia!");
        }
    }
}