using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    public class Dog
    {
       private int _age;
       //private string _name;
        //private string _breed;
        //vishe polya 
        public Dog(int age,string name, string breed) //nazvanie ageOfDog
        {
            Age = age;
            Name = name;
            Breed = breed;
        }
        

        public Dog(int age)   //esli u nas 1 zayavleno i mi vvedem 1 age to on obratitsya suda
        {
            _age = age;
        }
        //Vishe konstructori
        public int Age  //NAzv:AgeOfDog
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }

            }

        }
        //svoistvo porodi (dlya chteniya)
        //public string Breed
        //{
        //    get { return _breed; }
        //    private set { _breed = value; }
        //}
        public string Breed
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            set;
        }
        //vishe svoistva
        public void Bark()  //Nazv BarkOfDog pascale case:BarkOfDog camel case:barkOfDog
        {
            Console.WriteLine("Woof-woof-woof");
        }
        public bool CanTakePartInCompetition()
        {
            //if (_age <2)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return !(_age < 2);
        }
        //metodi vishe (public,private)
    }
    /* public internal protected private : 4 identificatora dostupa, oni ogranich dostup k nashim polyam
     privat - ne pozvol isp peremennyu vne klasssa
    internal - daet vozm isp pole tol'ko vnutri internalp*/
}
//polya delaem privatnimy i zadaem svoistva chtobi ih usat'
