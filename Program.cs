using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero:"21 2225-5525", modelo: "Iphone",ime: "23",memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Ba");


Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia("21 9205-2825", "Nokia", "3", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Ba");
