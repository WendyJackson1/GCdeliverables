// See https://aka.ms/new-console-template for more information
//** create a program that simulates the host of a buffet
//** program will ask the user for a party size, 
//** ask for each party member’s drink order,
//** keep track of how many times each drink was ordered,
//** present a bill with the accurate total price sty the end.
//** the price for each person is the same. $9.99 per person
//** guests only pay extra for drinks this buffet only has two drinks!
//** You can choose two drinks and their prices. 
//** You 'll want to set up some variables to use throughout your program
//** such as number variables that keep track of how many of each drink is ordered,
//** and how much the drinks cost. 
//** (Hint: what number data type could be used to represent money? It's not an integer...)
//** Limit the party size to six people. 
//** If the user inputs a party size too large, simply provide a polite rejection message and end the program.
//** Otherwise, print out drink options for the user. 
//** Now, set up a loop that asks each person for which drink they'd like.
//** Keep track of how many of each drink is ordered because you'll need this number to calculate the bill.
//** After taking the orders, calculate the total and print out that value to the user.
Console.WriteLine("Howdy ya'll. Welcome to Biggies Unbleliveables Buffet, we just call it Bubs for short. Its All you can stuff in your face for $9.99! We do charge $2.00 extra for our tasty sweettea, but our water is free.");
Console.WriteLine("How many people in your group? Cause we ant got no room for more than 6 in a group.");
int groupSize = int.Parse(Console.ReadLine());



if (groupSize > 6)
{
    Console.WriteLine("sorry hun, but thats more than we can handle. You might wanna try down the street.");
    return;

}

Console.WriteLine($"A table for {groupSize}! Ya'll follow me and take a seat right here. How bout somethin to wet your whistle? We've got sweettea or water.");
int sweetteaCount = 0;
int waterCount = 0;


for (int i = 0; i < groupSize; i++)
{
    Console.WriteLine($"Alright, person {i + 1}, sweettea or water?");
    string drink = Console.ReadLine();
    if (drink != null && drink.Equals("sweettea", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("nice!");
        sweetteaCount++;
    }
    else if (drink != null && drink.Equals("water", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("sure!");
        waterCount++;
    }
    else
    {
        Console.WriteLine("sorry we dont have that! Guess you can have soemthin to drink after you leave.");
    }

}
Console.WriteLine($"Okay, so that's {sweetteaCount} sweetteas and {waterCount} waters. I'll be right back. Ya'll Feel free to grab some grub!");

decimal buffet = 9.99m;
decimal sweetteaPrice = 2.00m;
decimal waterPrice = 0.00m;
decimal totalTea = sweetteaPrice * sweetteaCount;
decimal totalWater = waterCount * waterPrice;
decimal totalbuffet = buffet * groupSize;
decimal totalBill = totalbuffet + totalTea + totalWater;

Console.WriteLine("Here's your bill!");

Console.WriteLine($"total sweettea = ${totalTea}");
Console.WriteLine($"total water = ${totalWater}");
Console.WriteLine($"total buffet = ${totalbuffet}");
Console.WriteLine($"total bill  = ${totalBill}");



