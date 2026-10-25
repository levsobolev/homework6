using fortumakov.TypeforBankAccount;
using System;
namespace fortumakov.Bankaccount
{
    public class BankAccount1
    {
        private int _numberBankAccount;
        private decimal _balance;
        private TypeForBankAccount _typeforBankAccount;

        //Методы для доступа к данным
        public decimal GetBalance() 
        { 
            return _balance; 
        }
        public void SetBalance(decimal value)
        {
            _balance = value;
        }

        public TypeForBankAccount GetTypeForBankAccount() 
        { 
            return _typeforBankAccount;
        }
        public void SetTypeForBankAccount(TypeForBankAccount value)
        {
            _typeforBankAccount = value;
        }

        public int GetNumberBankAccount() 
        { 
            return _numberBankAccount;
        } 
        public void SetNumberBankAccount(int value)
        {
            _numberBankAccount = value;
        }
        
        //Пустой конструктор
        public BankAccount1() { }
        
        //Конструктор со всеми полями
        public BankAccount1(int numberBankAccount, decimal balance, TypeForBankAccount typeforBankAccount)
        {
            _numberBankAccount = numberBankAccount;
            _balance = balance;
            _typeforBankAccount = typeforBankAccount;
        }

        //Печать информации об аккаунте
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {_numberBankAccount}\nТип счета - {_typeforBankAccount}\nБаланс - {_balance}");
        }
    }
}

