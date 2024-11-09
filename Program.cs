using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 16);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("987654321", "iPhone X", "222222222222222", 64);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
