using CodeSkill.Usage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkillTests.Usage
{
    [TestClass()]
    public class InterfaceCallBackTest
    {
        [TestMethod()]
        public void CallBackTest()
        {
            
            //Person person = new Person();
            //Swim swim = new Swim(person);
            //person.Learn(swim);
            //person.DoWork();


            Person person = new Person(new Swim());
            Swim swim = new Swim(person);
            person.Learn(swim);
            person.DoWork();
            // Assert.AreEqual(person, swim.person);
        }
    }
}
