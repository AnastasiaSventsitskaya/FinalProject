// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = new string [4] {"Hello", "2", "world", ":-)"};

int GetResultElementsCount(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter++;
        }
    }
return counter;
}

string[] FillResultArray (int counter, string[] array)
{   
    string[] resultArray = new string[counter]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

int counter = GetResultElementsCount(array);
string [] resultArray = FillResultArray(counter, array);
Console.WriteLine(String.Join(" ", resultArray));

// Или
// Console.WriteLine(String.Join(" ", array.Where(x => x.Length <= 3)));