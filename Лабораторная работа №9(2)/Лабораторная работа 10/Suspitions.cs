using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_10
{
    class Suspitions: IDetect, IVisual
    {
        private string FIO, Motiv;
        private int Kolul;
        public Suspitions(string pFIO, string pMotiv, int pKolul)
        {
            FIO = pFIO;
            Motiv = pMotiv;
            Kolul = pKolul;
        }
        public void UlPlus(int pUl)
        {
            Kolul += pUl;
        }
        public void UlMinus (int pUl)
        {
            Kolul += pUl;
        }
        public string Name
        {
            get
            {
                return FIO + "\n Мотив: " + Motiv + "\n Количество улик: " + Kolul.ToString();
            }
            set
            {
                FIO = value;
            }
        }
        public void DrowEmblema()
        {
            Console.WriteLine
                (
                "******  *    \n" +
                "*       *    \n" +
                "*       *    \n" +
                "******  *****\n" +
                "     *  *   *\n" +
                "     *  *   *\n" +
                "******  *   *\n"
                );
            Console.WriteLine(Name);
        }
    }
    class Incendent : IDetect, IVisual
    {
        string Place;
        DateTime Time;
        int KolWitness;
        public Incendent (string pPlace, DateTime pTime, int pKolWitness )
        {
            Place = pPlace;
            Time = pTime;
            KolWitness = pKolWitness;
        }
        public void UlPlus(int pUl)
        {
            KolWitness += pUl;
        }
        public void UlMinus(int pUl)
        {
            KolWitness += pUl;
        }
        public string Name
        {
            get
            {
                return "Место проишествия: " + Place + "\n Время: " + Time + "\n Количество свидетелей: " + KolWitness.ToString();
            }
            set
            {
                Place = value;
            }
        }
        public void DrowEmblema()
        {
            Console.WriteLine
                (
                "******  *    \n" +
                "*       *    \n" +
                "*       *    \n" +
                "******  *****\n" +
                "*       *   *\n" +
                "*       *   *\n" +
                "******  *   *\n"
                );
            Console.WriteLine(Name);
        }
    }

    public interface IDetect
    {
        void UlPlus(int pUl);
        void UlMinus(int pUl);
    }
    public interface IVisual
    {
        string Name { get; set; }
        void DrowEmblema();
    }

}

