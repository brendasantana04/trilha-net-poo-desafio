using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


//realizando testes com nokia
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "333", modelo: "final" , imei: "87886752" , memoria: 124);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pou");

Console.Write("\n");

//realizando testes com iphone
Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "444", modelo: "beta" , imei: "990898877" , memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");
