// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections;


class program
{
    static void Main(string[] args)
    {

       double sonuc = metod.Ortalama(5, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21);
    Console.WriteLine(sonuc);

    }
    

    





}



class metod
{
    

    public static double Ortalama(params double[] degerler)
    {
        double sonuc = 0;
        for (int i = 0; i < degerler.Length; i++)
        {
            sonuc += degerler[i];
            sonuc = sonuc / degerler.Length;
        }

        return sonuc;

    }

}


