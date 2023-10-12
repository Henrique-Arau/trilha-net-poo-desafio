using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"50023877", modelo:"3310", imei:"1000202202", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Call of Duty");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"50023888", modelo:"ProMax", imei:"1000202604", memoria:64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("NuBank");