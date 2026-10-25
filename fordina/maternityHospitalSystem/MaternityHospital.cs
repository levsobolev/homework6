using System;
using System.Collections.Generic;
using fordina.maternityHospital;

namespace fordina.maternityHospitalSystem
{
    internal class MaternityHospital
    {
        //Свойства
        public string HospitalName { get; set; }
        public string Address {  get; set; }
        public int Capacity {  get; }

        //Метод доступа для текущей занятости
        public int CurrentOccupancy()
        {
            return Patients.Count;
        }

        //Списки врачей и пациентов
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public List<Patient> Patients { get; } = new List<Patient>();

        //Конструктор
        public MaternityHospital(string hospitalName, string address, int capacity)
        {
            HospitalName = hospitalName;
            Address = address;
            Capacity = capacity;
        }

       //Методы
       public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"В штаб роддома {HospitalName} принят врач {doctor.Name}");
        }

        public void RemoveDoctor(Doctor doctor)
        {
            if (Doctors.Remove(doctor))
            {
                Console.WriteLine($"Доктор {doctor.Name} уволен из штаба роддома {HospitalName}");
            }
            else
            {
                Console.WriteLine("Такого врача нету в штабе роддома");
            }
        }

        public void AddPatient(Patient patient)
        {
            if (CurrentOccupancy() < Capacity)
            {
                Patients.Add(patient);
                Console.WriteLine($"Пациентка {patient.Name} успешно госпитализирована в палату {patient.WardNumber}");
            }
            else
            {
                Console.WriteLine("Нет свободных мест в роддоме!");
            }
        }

        public void DischargePatient(Patient patient)
        {
            if (Patients.Remove(patient))
            {
                Console.WriteLine($"Пациентка {patient.Name} выписана из роддома. Состояние на момент выписки: {(patient.IsBearth ? "Родила" : "Выписана до родов")}");
                Patients.Remove(patient);
            }
            else
            {
                Console.WriteLine("Такого пациента нет в роддоме!");
            }
        }

        public void PrintInfoHospital()
        {
            Console.WriteLine($"Отчет роддома {HospitalName}\nАдрес: {Address}\nВместимость: {CurrentOccupancy()} / {Capacity}\nВрачей в штабе: {Doctors.Count}");
        }

        public void ArrayPeople()
        {
            Console.WriteLine("Список людей в роддоме:");
            foreach (Doctor doctor in Doctors)
            {
                Console.WriteLine($"{doctor.GetRoLe()} {doctor.Name}, опыт: {doctor.Experience}.");
            }

            foreach (Patient patient in Patients)
            {
                Console.WriteLine($"{patient.GetRoLe()} {patient.Name}, статус родов: {(patient.IsBearth ? "Родила" : "Ожидает")}.");
            }
        }
    }
}
