namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string ime, int memoria) : base(numero, modelo, ime, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no iphone");
        } 
    
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}