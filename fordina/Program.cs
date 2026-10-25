using fordina.building;
using fordina.maternityHospitalSystem;
using System;
using fordina.maternityHospital;

namespace fordina
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Задание со зданием
            Console.WriteLine("Реализовать класс для описания здания (уникальный номер здания,\r\n" +
                "высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,\r\n" +
                "предусмотреть методы для заполнения полей и получения значений полей для печати.\r\n" +
                "Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества\r\n" +
                "квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания\r\n" +
                "генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы\r\n" +
                "хранило последний использованный номер здания, и предусмотреть метод, который\r\nувеличивал бы значение этого поля.");

            Building building = new Building(240, 60, 1800, 30);
            Console.WriteLine($"Количество квартир в подъезде: {building.NumberOfApartmentOnEntranc()}\nКоличество квартир" +
                $" на этаже: {building.NumberOfApartmentOnFloor()}\nВысота одного этажа: {building.FloorHeight()}\nКоличество квартир" +
                $" в подъезде на одном этаже: {building.NumberOfApartmentOnEntrancOneFloor()}");
            //Задание с роддомом
            Console.WriteLine("Написать программу, содержащую решение следующих задач:\r\n" +
                "Вы получили тему, по которой должны составить классы.\r\n" +
                "Цель задания: Написать программу, в которой реализованы все принципы ООП. Для этого\r\n" +
                "необходимо реализовать не менее 4 классов:\r\n● Один должен быть абстрактным\r\n" +
                "● Должно быть не менее 2 наследников\r\n" +
                "● Не менее 5 методов в каждом классе (необходимо показать свойство на чтение\r\n" +
                "и на чтение-запись)\r\n" +
                "● Не менее 4 свойств\r\n" +
                "● Должно быть не менее 2 конструкторов в классах наследниках\r\n" +
                "\r\nВ Main создать объекты классов, показать работу методов. В программе для ваших объектов\r\n" +
                "используйте какие-то данные, который необходимо читать с файла/введены с\r\n" +
                "клавиатуры/прописано в коде. Например, класс человек, создаете экземпляры для человека,\r\n" +
                "а имена, фамилии читаете с файла/вводите с клавиатуры/заранее прописано в коде .\r\n" +
                "Необходимо быть готовым к тому, что каждый принцип нужно объяснять. Ваша программа\r\n" +
                "должна объяснять человеку то, о чем у вас тема и показать основные моменты вашей темы,\r\nто, что считаете важным.");

            //Создание роддома
            MaternityHospital maternityHospital = new MaternityHospital("Первая областная", "ул. Пушкина, д.Калатушкина 1", 40);

            //Создание людей
            Doctor doctor1 = new Doctor("Антон", 30, 444444, "Гинеколог");
            Doctor doctor2 = new Doctor("Лиза", "reteet@gmail.com", 27, 423143, "Женский", "Акушер", 4, 60, false);
            Patient patient1 = new Patient("Маша", 22, 443434);
            Patient patient2 = new Patient("Даша", "dhdhd@gmail.com", 20, 434343, 213, "Осложнения", false, DateTime.Now);

            //Наем врачей
            maternityHospital.AddDoctor(doctor1);
            maternityHospital.AddDoctor(doctor2);

            //Добавление пациентов
            maternityHospital.AddPatient(patient1);
            maternityHospital.AddPatient(patient2);

            //Методы абстрактного класса
            doctor1.PrintInfo();
            doctor2.Greeting();
            patient1.Walk();
            patient2.Sleep();

            //Методы пациента
            patient1.CallNurse();
            patient2.TakeMedicine("Нурофен");
            patient1.UpdateHealchStatus("Стабильное");
            patient2.GiveBirth();

            //Методы доктора
            doctor1.Examination(patient2);
            doctor2.DeliveredBaby(patient2);
            doctor1.StatusDuty(true);
            doctor2.Report();

            //Методы роддома
            maternityHospital.RemoveDoctor(doctor1);
            maternityHospital.DischargePatient(patient2);
            maternityHospital.PrintInfoHospital();
            maternityHospital.ArrayPeople();
        }
    }
}
