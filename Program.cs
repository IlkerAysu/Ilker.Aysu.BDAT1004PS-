
//Question 1
object obj0 = Math.PI;
object obj1 = 5;
object obj2 = 5.0;
object obj3 = 5 > 1;
object obj4 = '5';
object obj5 = 5 * 2;   
object obj6 = '5' * 2;
object obj7 = '5' + '2';
object obj8 = 5 / 2;
object obj9 = 5 % 2;
object obj10 = 5 == 3;
object obj11 = Math.PI;
int[] numbers = { 5, 2, 1 };


  


Console.WriteLine(obj0.GetType() );
Console.WriteLine(obj1.GetType() );
Console.WriteLine(obj2.GetType());
Console.WriteLine(obj3.GetType());
Console.WriteLine(obj4.GetType());
Console.WriteLine(obj5.GetType());
Console.WriteLine(obj6.GetType());
Console.WriteLine(obj7.GetType());
Console.WriteLine(obj8.GetType());
Console.WriteLine(obj9.GetType());
Console.WriteLine(obj10.GetType());
Console.WriteLine(obj11.GetType());
Console.WriteLine(numbers.GetType());


//Question 2

    string s1 = "Supercalifragilisticexpialidocius";
    string s2 = "Honorificabilitudinitatibus";
    string s3 = "Bababadalgharaghtakamminarronnkonn";
    int charcounter = 0;
    int charcounter1 = 0;
    int charcounter2 = 0;
    

    string substring = "ice";

foreach (char item in s1)
    {
        charcounter++;
    }
    Console.WriteLine("Total char for " + s1 + " = " + charcounter);



Boolean contains = s1.Contains(substring);
Console.WriteLine("Does " + s1 +  "contains ice? " + " = " + contains);

foreach (char item in s2)
{
    charcounter1++;
}

Console.WriteLine("Total char for " + s2 + " = " + charcounter1);

foreach (char item in s3)
{
    charcounter2++;
}

Console.WriteLine("Total char for " + s3 + " = " + charcounter2);

if (charcounter > charcounter1)
{
    if (charcounter > charcounter2)
    {
        Console.WriteLine(s1 + " is the longest word with " + charcounter + " letters");
    }
    else
        Console.WriteLine(s3 + " is the longest word with " + charcounter2 + " letters");
}
else if (charcounter1 > charcounter2)
{
    Console.WriteLine(s2 + " is the longest word with " + charcounter1 + " letters");
}
else
    Console.WriteLine(s3 + " is the longest word with " + charcounter2 + " letters");


List<string> dictionary = new List<string>();
dictionary.Add("Berlioz");
dictionary.Add("Borodin");
dictionary.Add("Brian");
dictionary.Add("Buxtehude");
dictionary.Add("Bartok");
dictionary.Add("Bellini");
dictionary.Add("Bernstein");

dictionary.Sort();

Console.WriteLine(dictionary[0] + " comes first in the dictionary.");
Console.WriteLine(dictionary[6] + " comes last in the dictionary.");

// Question 4
//yeniden yazilacak
int[] arr1 = new int[] {
            25,
            47,
            42,
            56,
            32
         };
int[] arr2 = new int[5];
int[] arr3 = new int[5];
int i, j = 0, k = 0;
for (i = 0; i < 5; i++)
{
    if (arr1[i] % 2 == 0)
    {
        arr2[j] = arr1[i];
        j++;
    }
    else
    {
        arr3[k] = arr1[i];
        k++;
    }
}
Console.WriteLine("Even numbers...");
for (i = 0; i < j; i++)
{
    Console.WriteLine(arr2[i]);
}
Console.WriteLine("Odd numbers...");
for (i = 0; i < k; i++)
{
    Console.WriteLine(arr3[i]);
}


