using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("11 91234-1234", "5.4", "1234123412341234", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone("11 92345-6789", "15 Pro Max", "1234123412341234", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");