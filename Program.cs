using DesafioPOO.Models;

Console.WriteLine("Iniciando Testes NOKIA!\n");
Nokia nokia = new Nokia("123456789", "Modelo do Nokia", "Imei do Nokia", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("App no Nokia");

Console.WriteLine("\n\nIniciando Testes IPHONE!\n");
Iphone iphone = new Iphone("987654321", "Modelo do Iphone", "Imei do Iphone", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("App no Iphone");
