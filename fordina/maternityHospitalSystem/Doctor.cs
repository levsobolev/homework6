using System;

namespace fordina.maternityHospital
{
    public class Doctor : PersonAbstract
    {
        //Свойства
        public string Specialisation { get; set; }
        public byte Experience { get; set; }
        public int NumberChilbirth { get; private set; } 
        public bool IsOnDuty { get; set; }
        public int NumberChilbirthPerShift { get; private set; } = 0;

        //Конструкторы
        public Doctor(string name, byte age, int passportNumber, string specialisation) : base(name, "", age, "Мужской", passportNumber)
        {
            Specialisation = specialisation;
            Experience = 0;
            NumberChilbirth = 0;
            IsOnDuty = true;
        }

        public Doctor(string name, string email, byte age, int passportNumber, string gender, string specialisation, byte experience, int numberChilbirth, bool isOnDuty) : base(name, email, age, gender, passportNumber)
        {
            Specialisation = specialisation;
            Experience = experience;
            NumberChilbirth = numberChilbirth;
            IsOnDuty = isOnDuty;
        }

        //Методы
        public override string GetRoLe()
        {
            return $"Врач {Specialisation}";
        }

        public void Examination(Patient patient)
        {
            Console.WriteLine($"Доктор {Name} осматривает пациентку {patient.Name}. Состояние здоровья: {patient.HealthStatus}");
        }

        public void DeliveredBaby(Patient patient)
        {
            if (!patient.IsBearth)
            {
                Console.WriteLine($"Доктор {Name} принял роды у пациентки {patient.Name}");
                patient.GiveBirth();
                NumberChilbirth++;
                NumberChilbirthPerShift++;
            }
            else
            {
                Console.WriteLine($"Пациентка {patient.Name} уже родила.");
            }
        }

        public void StatusDuty(bool status)
        {
            IsOnDuty = status;
            Console.WriteLine($"Статус дежурства врача {Name} изменен на {(IsOnDuty ? "На дежурстве" : "Отдыхает")}");
        }

        public void Report()
        {
            Console.WriteLine($"Доктор {Name} заполнил отчет за смену. Принято родов за смену: {NumberChilbirthPerShift}");
            NumberChilbirthPerShift = 0;
        }
    }
}
