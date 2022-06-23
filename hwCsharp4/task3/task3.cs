//Задача 3: Напишите программу, которая задаёт массив из 8
//элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)

int[] initArray()
{
    int[] array = new int[8];
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(0, 10);
    }
	return array;
}

void printArray(int[] array) 
{
	for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}| ");
    }
	Console.WriteLine();
}

int [] firstArray = initArray();
int [] secondArray = initArray();
printArray(firstArray);
printArray(secondArray);
