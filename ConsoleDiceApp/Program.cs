// See https://aka.ms/new-console-template for more information
using ConsoleDiceApp;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

Die Die1 = new Die("Die1");
Die Die2 = new Die("Die2");


//instantiate the dicetotal classes
// also append them into a list
//create a list of dicetotal objects
List<diceTotal> diceTotalList = new List<diceTotal>();


diceTotal total2 = new diceTotal(2);
diceTotal total3 = new diceTotal(3);
diceTotal total4 = new diceTotal(4);
diceTotal total5 = new diceTotal(5);
diceTotal total6 = new diceTotal(6);
diceTotal total7 = new diceTotal(7);
diceTotal total8 = new diceTotal(8);
diceTotal total9 = new diceTotal(9);
diceTotal total10 = new diceTotal(10);
diceTotal total11 = new diceTotal(11);
diceTotal total12 = new diceTotal(12);


//add all those objects to my list
diceTotalList.Add(total2);
diceTotalList.Add(total3);
diceTotalList.Add(total4);
diceTotalList.Add(total5);
diceTotalList.Add(total6);
diceTotalList.Add(total7);
diceTotalList.Add(total8);
diceTotalList.Add(total9);
diceTotalList.Add(total10);
diceTotalList.Add(total11);
diceTotalList.Add(total12);




//get the user's name
Console.WriteLine("What is your name?");
string userName = System.Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");

Console.WriteLine("How many times do you want the roll the dice?");
string rollcountstring = System.Console.ReadLine();

//create the index integer
int index = 0;


if (int.TryParse(rollcountstring, out int rollCount))
{

    for (int i = 0; i < rollCount; i++)
    {
        // Roll the dice here
        Die1.rollDie();
        Die2.rollDie();
        int total = Die1.getNum() + Die2.getNum();
        //System.Console.WriteLine(total);
        //get the position if the object we are going to change
        index = total - 2;

        diceTotalList[index].AddToTotal();
    }

    //after rolling the dice all the times, we then get ready to display output.
    System.Console.WriteLine("The stars will show the percent of rolls that fell on each number: ");

    for (int j = 0; j < diceTotalList.Count; j++)
    {
        diceTotalList[j].calculateStars(rollCount);
    }




}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}







