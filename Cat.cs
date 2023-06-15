using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Cat
    {
        private string name;
        private double weight;
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                } else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 1)
                    weight = value;
                else
                    Console.WriteLine($"Вес не может быть меньше 1 кг");
            }
        }
        public void SetCatName (string CatName)
        {
            bool OnlyLetters = true;

            foreach (var ch in CatName)
            {
                if (!char.IsLetter(ch))
                {
                    OnlyLetters = false;
                }
            }

            if (OnlyLetters)
                name = CatName;
            else
                Console.WriteLine($"{CatName} - неправильное имя!!!");
        }

        public Cat (string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }
       
        public void Meow ()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }
        public void Info ()
        {
            if (weight <= 0)
                Console.WriteLine("Вы ввели неправильный вес кота");
            else if (name.Length == 0)
                Console.WriteLine("Вы неправильно ввели имя кота");
            else
                Console.WriteLine($"Кот {name}: {weight} кг");
        }
    }
}

