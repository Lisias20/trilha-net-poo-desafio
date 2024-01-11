using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "81-981105148", Modelo: "Nokia G11plus", IMEI: "IMEI98723234", Memoria: 256);
Smartphone iphone = new Iphone(numero: "81-982048253", Modelo: "Iphone 15 PRO max", IMEI: "IMEI982736173", Memoria: 580);



Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");
Console.WriteLine("Celular: Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("\n");
Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");


Console.WriteLine("Celular: Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("\n");
Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");


