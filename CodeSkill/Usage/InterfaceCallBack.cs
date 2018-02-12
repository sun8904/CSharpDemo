using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage
{
    public interface ISkill
    {
        void Common();
    }
    public class Swim : ISkill
    {
        public Person person;
        public Swim()
        {

        }
        public Swim(Person person)
        {
            this.person = person;
        }
        public void Common()
        {            
            Console.WriteLine("i need to swim 1km");
            person.CallBack();
        }
    }
    public class Person
    {
        public ISkill skill;
        public bool getSkill { get; set; } = false;
        public Person()
        {
        }
        public Person(ISkill s)
        {
            skill = s;
            
        }

        public void DoWork()
        {
            if (getSkill)
            {
                skill.Common();
            }

        }

        public void Learn()
        {
            //skill = s;
            getSkill = true;
        }

        public void Learn(ISkill s)
        {
            skill = s;
            getSkill = true;
        }

        internal void CallBack()
        {
            Console.WriteLine($"finish my today's swim excercise");
        }
    }
}
