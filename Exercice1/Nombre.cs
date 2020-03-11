using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    class Nombre
    {
        public int content;
        public void convertToChaine()
        {
          Convert.ToString(content);
        }
        public void ConvertToDouble()
        {
            Console.WriteLine();
        }
        public void ConvertToFloat()
        {
            Console.WriteLine();
        }
        public void ConvertToCar()
        {
            Console.WriteLine();
        }
       
    }

    class Valeur
    {
        public String content;
        public void ConvertToInteger()
        {
            if ()
            {

            }
        }
        public void Capitalize()
        {
            content.Substring(0, 1).ToUpper();
        }
        public void Minimize()
        {
            content.ToLower();
        }
        public void RevokeOnStart(int number)
        {
            if (number < content.Length)
            {
                content.Remove(0, number);
            }
            else
            {
                Console.WriteLine("Message d'Erreur");
            }
        }

        public void RevokeOnEnd(int number)
        {
            if (number < content.Length)
            {
                content.Remove(-1, number);
            }
            else
            {
                Console.WriteLine("Message d'Erreur");
            }
        }
        public void Remoke(int a, int b)
        {
            content.Remove(a, b);
        }
        public void Contat()
        {
            List<String> vs = new List<String>();
            Console.WriteLine("entrer un String");
            var allo = Console.ReadLine();
            vs.Add(allo);
            var nbr = "";
            foreach (var item in vs)
            {
                nbr += item;             
            }
        }
    }
    
}
