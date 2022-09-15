int MaxSymbols = 3;
string[] GetShortSymbolsArray(string[] array)
{				
	string[] str = new string[array.Length];
	for (int i = 0; i < str.Length; i++)
			{
				if(array[i].Length <= MaxSymbols)
                str[i] = array [i];
			}
            return str;
}
	
void PrintArray(string[] array)
	{
		for (int i = 0; i < array.Length; i++)
		Console.WriteLine(array[i]+" ");
	    Console.WriteLine();
	}
string [] array = {"1234", "1567", "-2", "computer science"};
string [] str = GetShortSymbolsArray(array);
PrintArray(array);
PrintArray(str);

