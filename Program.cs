using DesafioPOO.Models;
Smartphone nokia = new Nokia("8199999999", "111111111111", "Nokia", 128);
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
// Realizado!
Smartphone iphone = new Iphone("818888888", "2222222222222", "Iphone", 512);
Console.WriteLine("Smartphone Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");