//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами/
Console.Write("Введите текст на латинице и/или символы через запятую: ");
var size = Console.ReadLine().Split(", ");
string[] array = size;
var text = new string[array.Length];
var count = 0;
foreach (var element in array)
{
	if (element.Length <= 3)
	{
		text[count] = element;
		count++;
	}

}
Console.WriteLine(string.Join(Environment.NewLine, text, 0, count));