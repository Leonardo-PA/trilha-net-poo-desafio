using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
public class Program
{
    public static void Main(string [] arg)
    {
        //Objeto Nokia
        Nokia nokia = new Nokia ("12345", "Nokia 123", "123456789IMEI", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");


        //Objeto Iphone
        Iphone iphone = new Iphone("67890", "Iphone XV", "1234567890IMEI", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");

    }
}
