using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Вам представлена возможность ввести 3 слова. Мы начинаем.");
string[] stringArray = new string[3];
int sum = 0;
for(int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine("Введите текст:");
    stringArray[i] = Console.ReadLine();
    if(stringArray[i].Length <= 3){
        sum++;
    }
}
Console.WriteLine("Ваши варианты: ");
Console.WriteLine(String.Join("\n", stringArray));

string[] stringArray2 = new string[sum];
int x = 0;
for(int i = 0; i < stringArray.Length; i++)
{
if(stringArray[i].Length <= 3){
        stringArray2[x] = stringArray[i];
        x++;
    }
}
Console.WriteLine("Корректировка: ");
Console.WriteLine(String.Join("\n", stringArray2));