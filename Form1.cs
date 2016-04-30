using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsТелеорганайзер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click_1(object sender, EventArgs e)
        { // добавление и хранение телепередач 
            Person new_person; // создание нового запроса к классу Person
            if (NameBox.Text == "") // проверка не пустое ли окно ввода имени телепередачи для 
          // добавления телепередач
            {
                MessageBox.Show("Введите название передачи");
            }
            if (AgeBox.Text != "") // окно времени телепередачи
            {
                if (ProfessionBox.Text != "") // окно жанра телепередачи
                {   
                    string age = AgeBox.Text; // разделение времени телепередачи на часы и минуты
                    age = age.Substring(0,2);
                    string age1 = AgeBox.Text;
                    age1 = age1.Substring(3,2);
                  // добавление телепередачи на хранение
                    new_person = new Person(NameBox.Text, Convert.ToInt32(age), Convert.ToInt32(age1), ProfessionBox.Text);  
                }
                else
                {
                    string age = AgeBox.Text;
                    age = age.Substring(0,2);
                    string age1 = AgeBox.Text;
                    age1 = age1.Substring(3,2);
                  // добавление телепередачи на хранение без жанра
                    new_person = new Person(NameBox.Text, Convert.ToInt32(age), Convert.ToInt32(age1)); 
                }
            }
            Else // если окно времени показа телепередачи пустое
            {
                if (ProfessionBox.Text != "")
                {  // добавление телепередачи на хранение без времени показа
                    new_person = new Person(NameBox.Text, 0, 0, ProfessionBox.Text); 
                }
                else
                {
                    new_person = new Person(NameBox.Text); // добавление только текста телепередачи
                }
            }
            string n = AgeBox.Text; // проверка времени показа телепередачи перед добавлением
            n = n.Substring(0, 2);
            string m = AgeBox.Text;
            m = m.Substring(3, 2);
            int a, b;
            a = Convert.ToInt32(n);
            b = Convert.ToInt32(m);
            if (a > 23 || b > 59) 
{ 
MessageBox.Show("Вы ввели неправильный формат часов или минут"); 
}
            NameBox.Clear(); // очистка окон ввода инфы о телепередаче
            ProfessionBox.Clear();
            AgeBox.Clear();
        }
        public void button2_Click(object sender, EventArgs e)
        {
        ResultBox.Text += new_person.GetInformation(); // вывод всех хранившихся телепередач
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ResultBox.Clear(); // очистка окна вывода инфы о телепередачах 
        }
    }
}
