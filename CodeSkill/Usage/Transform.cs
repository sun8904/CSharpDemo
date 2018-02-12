using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    internal class Transform
    {
        public static void Test()
        {
            var animal = new AnimalAge(2000);
            Console.WriteLine(animal);
            animal = 2000;
            Console.WriteLine(animal);
            int age = (int)animal;
            Console.WriteLine(age);
        }
    }

    internal class AnimalAge
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public AnimalAge()
        {
        }

        public AnimalAge(int age)
        {
            this.age = age;
        }

        public static implicit operator AnimalAge(int year)
        {
            return new AnimalAge(year > 1980 ? (year - 1980) : -1);
        }

        public static explicit operator int(AnimalAge animal)
        {
            if (animal != null)
                return animal.age;
            else return -1;
        }

        public static implicit operator String(AnimalAge animal)
        {
            return $"i'm {animal.age}";
        }

        public override string ToString()
        {
            return $"ToString i'm {age}";
        }
    }
}