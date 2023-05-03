/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] array1 = new string[] { "Hello", "ips", "1567", "Hi", "Kazan", "a" };
string[] array2;

array2 = SortArrayMoreThree(array1);

string[] SortArrayMoreThree(string[] array)
{
	int countRightNumber = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			countRightNumber++;
		}
	}

	string[] newArray = new string[countRightNumber];

	int tempCounter = 0;

	for (int i = 0; i < array1.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			newArray[tempCounter] = array[i];
			tempCounter++;
		}
	}

	return newArray;
}