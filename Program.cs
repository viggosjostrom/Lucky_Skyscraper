var number = 1;

Console.WriteLine("Please enter a floor number");
number = Convert.ToInt32(Console.ReadLine());

//DEL 1

var testOne = number % 10;
var testTwo = number % 100;

if (testOne == 4 || testTwo == 13)
{
    number++;
}

Console.WriteLine("Floor:" + number);


//DEL 2

/*
if (number % 10 == 4 || number % 100 == 13)
{
    Console.WriteLine("kan ej omvandla till riktigt våningsnummer");
}

else if ( number % 10 == 5 || number % 100 == 14)
{
    number--;
    Console.WriteLine("Floor:" + number);
}

else
{
    Console.WriteLine("Floor:" + number);
}
*/

