using System;

public class Tablice
{
	public int = 20
	public void Powitanie()
	{
		Console.WriteLine("Witaj w pliku tablice!");
	}

	public int[] Stworz_Tablice()
	{		
		Console.Write("Podaj długość tablicy: ")
		int dlugosc = int.Parse(Console.ReadLine());
        int[] tablica = new int[dlugosc];
		for (int i = 0; i < dlugosc; i++)
		{
			Console.WriteLine("Podaj kolejny element tablicy: ");
			tablica[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine();
		return tablica;
    }

	public void Wyswietl_Tablice(int[] tablica)
	{
		Console.WriteLine(tablica[i]);
		Console.WriteLine();
	}
}
