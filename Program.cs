using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//*TESTE REALIZADO
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("888359486","Nokia G21","67831569843",128);
nokia.Ligar();
nokia.InstalarAplicativo("DIO.NetApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("777359486","Iphone 11","375498653215",64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO.NetApp");



