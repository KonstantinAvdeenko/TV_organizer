using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WindowsFormsТелеорганайзер
{
    class Person
    {
        string name, profession;
        int age, age1;
        public Person(string name) // для обращения к классу из модуля формы 
        {
            this.name = name; // добавление только имени телепередачи из модуля формы
        } 
        public Person(string name, int age, int age1) // добавление имени и времени показа
        {
            this.name = name;
            this.age = age;
            this.age1 = age1;
        } 
        public Person(string name,string profession) // добавление имени и жанра
        {
            this.name = name;
            this.profession = profession;
        }
         // добавление имени, времени и жанра
        public Person(string name, int age, int age1, string profession) 
        {
            this.name = name;
            this.age = age;
            this.age1 = age1;
            this.profession = profession;
        }
        public string GetInformation() // вывод всей хранящейся инфы 
        {
            string information;
               information = " \r\nНазвание передачи:  " + this.name + "; Время передачи:  " + this.age.ToString() + " : " + this.age1.ToString() + "; Жанр:  " + this.profession;
            return information; 
        }
    }
}
