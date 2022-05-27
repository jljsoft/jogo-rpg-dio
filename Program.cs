// See https://aka.ms/new-console-template for more information
using jogo_rpg.src.Model;

Knight hero = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
Console.WriteLine(hero.Attack());
Console.WriteLine(wizard.Attack());
