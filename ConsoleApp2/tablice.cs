using System;
using System.Security.Cryptography;

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
		int dl = int.Parse(Console.ReadLine());
        int[] tab = new int[dl];
		for (int i = 0; i < dl; i++)
		{
			Console.WriteLine("Podaj kolejny element tablicy: ");
			tab[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine();
		return tab;
    }

	public void Wyswietl_Tablice(int[] tab)
	{
		Console.WriteLine(tab[i]);
		Console.WriteLine();
	}

    public void Sortowanie_Babelkowe(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = 0; j < tab.Length - 1; j++)
            {
                for (tab[j - 1] = tab[j];)
                {
                    int temp = tab[j - 1];
                    tab[j - 1] = tab[i];
                    tab[j] = temp;
                }
            }
        }
    }

}


