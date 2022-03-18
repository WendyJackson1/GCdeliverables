// See https://aka.ms/new-console-template for more information
// ** how many people
// ** how much bread , peanut Butter, jelly needed
// ** each sandwich = 1 person =
// ** 2 slices of bread, 2 table spoons of peanut butter, 4 teaspoons of jelly
// ** 1 loaf = 28 slices
// ** 1 jar peanut butter = 32 tablespoons
// ** 1 jar jelly = 48 teaspoons
// ** calculate the amount of ingreadients needed
// ** print results into console

//** how many people are we making sandwiches for? print result, parse and store result in number varable
//** calculate needed ingredents prin into console
//** round all number up to pack size of ingredents and print out all three totals
//** ask if user would like to start over or no(print Goodbye)

bool isMakingSandwich = true;
do
{

    Console.WriteLine("How many people are we making PB and J sandwiches for?");
    decimal people = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"{people} people to feed");

    Console.WriteLine("You will need:");

    decimal breadSlices = people * 2;
    Console.WriteLine($"{breadSlices} slices of bread");

    decimal spoonsOfPeanutButter = people * 2;
    Console.WriteLine($"{spoonsOfPeanutButter} tablespoons of peanut butter");

    decimal SpoonsOfJelly = people * 4;
    Console.WriteLine($"{SpoonsOfJelly} teaspoons of jelly");

    Console.WriteLine("which is ...");

    decimal loafs = Math.Ceiling(breadSlices / 28);
    Console.WriteLine($"{loafs} Loafs of bread");

    decimal peanutButterJars = Math.Ceiling(spoonsOfPeanutButter / 32);
    Console.WriteLine($"{peanutButterJars} Jars of peanut butter");

    decimal jellyJars = Math.Ceiling(SpoonsOfJelly / 48);
    Console.WriteLine($"{jellyJars} Jars of jelly");

    Console.WriteLine("Would you like to restart ? Enter yes or y to continue, or enter any other key to exit.");

    var userChoice = Console.ReadKey().Key; 

    if (userChoice != ConsoleKey.Y)
    {
        Console.WriteLine("GoodBye!");
        isMakingSandwich = false;
    }

} while (isMakingSandwich);
