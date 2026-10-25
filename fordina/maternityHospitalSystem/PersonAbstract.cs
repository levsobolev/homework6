using System;

namespace fordina.maternityHospital
{
    public abstract class PersonAbstract
    {
        //Приватные поля
        private string _name;
        private string _email;
        private byte _age;
        private string _gender;
        private int _passportNumber;

        //Свойства
        public string Name { get { return _name; } set { _name = value; } }
        public int PassportNumber { get { return _passportNumber; } }
        public byte Age { get { return _age; } set { _age = value; } }
        public string Gender { get { return _gender; } }

        //Методы доступа
        public string GetEmail() 
        { 
            return _email; 
        }
        public void SetEmail(string value)
        {
            _email = value;
        }

        //Конструктор
        public PersonAbstract(string name, string email, byte age,  string gender, int passportNumber)
        {
            _name = name;
            _email = email;
            _age = age;
            _gender = gender;
            _passportNumber = passportNumber;
        }

        //Методы 
        public void PrintInfo()
        {
            Console.WriteLine($"Имя - {_name}\nВозраст - {_age}\nПол - {_gender}\nПочта - {_email}\nНомер паспорта - {_passportNumber}");
        }
        public void Greeting()
        {
            Console.WriteLine($"{_name} говорит: Здравствуйте!");
        }
        public void Walk()
        {
            Console.WriteLine($"{_name} гуляет по коридору больницы");
        }
        public void Sleep()
        {
            Console.WriteLine($"{_name} отдыхает");
        }
        public abstract string GetRoLe(); 
    }
}
