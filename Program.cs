/* Задача:  Написать программу, которая из имеющегося массива строк формирует массив их строк, длинна которых меньше, 
либо равна 3 символа. Первоначальный массив можно ввести, либо задать на старте
*/


string getDataFronUser(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine()!;
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int Count3Simbol (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        count = count +1;      
    }
}
return count;
}

string [] Massive3Simbol (string [] array, int count)
{
    string[] newstr = new string [count];
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
            if (array[i].Length <= 3)
            {
                newstr [j] = array[i];  
                j=j+1;
            }
    }
    return newstr;
}

string str = getDataFronUser("напишите предложение для формирования массива:");
string[] array = str.Split(' ').ToArray();
PrintArray(array);
Console.WriteLine();

int count1 = Count3Simbol(array);


string[] newstr = Massive3Simbol(array,count1);
PrintArray(newstr);

