using KingCompany.ResistenzaDiUnNumero;

do
{
    Console.WriteLine("Inserire numero per calcolarne la resistenza");
    Console.WriteLine(Helper.GetResistenza(int.Parse(Console.ReadLine())));

    Console.WriteLine("Inserire una resistenza per generare un numero che rispetti al resistenza indicata");
    Console.WriteLine(Helper.GetNumeroResistente(int.Parse(Console.ReadLine())));

    Console.WriteLine("Digirare A in maiuscolo per procedere con un altro calcolo di resistenza");
} while (Console.ReadLine() == "A");