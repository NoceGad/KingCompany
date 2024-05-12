using KingCompany.FrequenzaDiUnNumero;

//int[] vector = { 55, 42, 88, 42, 88, 42};
//int[] vector = { 1, 52, 52, 1, 56, 1, 54, 54, 1, 54 };
//int[] vector = { 52, 52, 52, 56, 54, 54, 54 };

int[] vector = { 1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54 };

Console.WriteLine(Helper.GetMaxFrequente(vector));
Helper.PrintArray(Helper.GetMaxFrequenti(vector,2));