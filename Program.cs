using DesafioPOO.Models;

// Realiza os testes com as classes Nokia e iPhone
Console.WriteLine("Smartphone Nokia \n");
Smartphone nokia = new Nokia(numero: "24 9999-4000", modelo: "Nokia T20", imei: "22222222", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone \n");
Smartphone iphone = new Iphone(numero: "24 8888-4000", modelo: "Iphone 15", imei: "33333333", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");