using System;

namespace fordina.maternityHospital
{
    public class Patient : PersonAbstract
    {
        //Свойства
        public int WardNumber {  get; set; }
        public string HealthStatus{  get; set; }
        public bool IsBearth {  get; private set; }
        public DateTime AdmissionDate { get; set; }

        //Конструкторы
        public Patient(string name, byte age, int passportNumber) : base(name, "", age, "Женский", passportNumber)
        {
            WardNumber = 101;
            HealthStatus = "Стабильное";
            IsBearth = false;
            AdmissionDate = DateTime.Now;
        }

        public Patient(string name, string email, byte age, int passportNumber, int wardNumber, string healthStatus, bool isBearth,  DateTime admissionDate) : base(name, email, age, "Женский", passportNumber)
        {
            WardNumber = wardNumber;
            HealthStatus= healthStatus;
            IsBearth= isBearth;
            AdmissionDate = admissionDate;
        }

        //Методы
        public override string GetRoLe()
        {
            return $"Пациентка из {WardNumber} палаты";
        }

        public void GiveBirth()
        {
            IsBearth = true;
            HealthStatus = "Восстановление после родов";
        }

        public void CallNurse()
        {
            Console.WriteLine($"Пациентка {Name} из {WardNumber} вызвала медсестру");
        }

        public void TakeMedicine(string medicineName)
        {
            Console.WriteLine($"Пациентка {Name} приняла лекарство {medicineName}");
        }

        public void UpdateHealchStatus(string newStatus)
        {
            HealthStatus = newStatus;
            Console.WriteLine($"Состояние здоровья пациентки {Name} обновлено: {HealthStatus}");
        }
    }
}
