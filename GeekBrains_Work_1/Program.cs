//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

//вывод массива
void printArrey(string[] col)
{
    int count = col.Length;
    for (int i=0; i < count; i++)
    {
        Console.WriteLine(col[i]);
    }
}


int maxSizeString = 3;
int sizeArreyStart = 4;

string[] arreyStart = { "1234", "1567", "-2", "computer science" };

int indexArreyEnd = 0;

Console.WriteLine("Исходный массив:");
printArrey(arreyStart);
Console.WriteLine();

string[] arreyModifind = new string[sizeArreyStart];
for (int i = 0; i < sizeArreyStart; i++)
{
    int lenght = arreyStart[i].Length;
    if (lenght <= maxSizeString)
    {
        arreyModifind[indexArreyEnd] = arreyStart[i];
        indexArreyEnd++;
    }
}

string[] arreyFinish = new string[indexArreyEnd];
for (int i = 0; i < indexArreyEnd; i++) arreyFinish[i]=arreyModifind[i];

Console.WriteLine("Новый массив:");
printArrey(arreyFinish);


