using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");