// massid on vajalikud et salvestada teatud andmeid ühes kohas
//ühes massivis peab olema ainult ühte tüüpi andmed (nt stingid, numbrid või bool)
// [] tähendab kogumikku andmetes

//string[] fruit = {"apples", "bananas", "oranges"}

string[] fruit = new string[3]; // näitab et andmeid saab olla ainult 3, need indekseeritakse
fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";

Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array");

//for (int i = 0; i < fruitArrayLength; i++ )
//{
//    Console.WriteLine(fruit[i]);
//}

for (int i = 0; i < fruitArrayLength; i++) // Esimese tähe asendamine suure tähega
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit) // Foreaach ei lase muuta elementide sisu
{
    Console.WriteLine(element);
}
