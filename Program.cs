﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero:"40028922", modelo:"pro", imei:"1000101101", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Candy Crush Saga");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"90906060", modelo:"proMax", imei:"0110110110", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Royale"); 
