//Zadanie:
//Przygotuj program, który policzy ilość wystąpięń danej cyfry w podanej przez użytkownika liczbie.
//Wynik wydrukuj w konsoli.

Console.WriteLine("\nPodaj liczbę: ");
var randomNumber = Console.ReadLine();

Console.WriteLine($"\nWynik dla analizowanej liczby {randomNumber} to:");

//string numberInString = randomNumber.ToString();
char[] lettersOfNumber = randomNumber.ToArray();

List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach (var number in numbers)
{
    var count = 0;
    foreach(var n in lettersOfNumber)
    {
        if (number == n)
            count++;
    }
    Console.WriteLine($"\n {number} => {count}");
}





//Przemyślenia:


//for (var i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i + " => " + lettersOfNumber[0]);
//}


//foreach (char x in lettersOfNumber )
//{
//    Console.WriteLine(x);
//}



