namespace DesafioPOO.Models
{
    public class Iphone
    public class Iphone : Smartphone
    {
        public Iphone(string numero,string modelo,string imei,int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando {nomeApp} no celular iphone");
        }
    }
}
10 changes: 9 additions & 1 deletion 10
Models/Nokia.cs
