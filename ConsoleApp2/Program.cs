﻿class Program
{
    static void Main(string[] args)
    {
        Tablice tablice = new Tablice();

        tablice.Powitanie();   

        int[] tab = tablice.Stworz_Tablice();

        Console.Clear();
        tablice.Wyswietl_Tablice(tab);
        tablice.Sortowanie_Babelkowe(tab);
        tablice.Wyswietl_Tablice(tab);
    }
}