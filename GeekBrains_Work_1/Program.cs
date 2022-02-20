//## Итоговая проверочная работа.
//
//Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.
//
//Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
//
//**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
//**Примеры**:
//
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//
//["1234", "1567", "-2", "computer science"] -> ["-2"]
//
//["Russia", "Denmark", "Kazan"] -> []


//вывод массива в виде списка
void printArreyString(string[] col)
{
    int count = col.Length;
    for (int i=0; i < count; i++)
    {
        Console.WriteLine(col[i]);
    }
}

////вывод массива по т.з.
void printArrey(string[] col)
{
    int count = col.Length;
    Console.Write("[");
    Console.Write(col[0]);
    if (count > 0)
    {
 
        for (int i=1; i < count; i++)
        {
            Console.Write(", ");
            Console.Write(col[i]);
            
        }
    Console.Write("]");
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


