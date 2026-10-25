using fortumakov.Bankaccount;
using System;
using fortumakov.TypeforBankAccount;

namespace fortumakov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1 задание

            Console.WriteLine("Введите номер счета:");
            bool isNumberBankAccount1 = int.TryParse(Console.ReadLine(), out int numberBankAccount1);

            Console.WriteLine("Введите цифру, которая относится к нужному вам типу счета(0 - текущий, 1 - сберегательный):");
            bool isTypeForBA1 = int.TryParse(Console.ReadLine(), out int typeForBA1); 

            Console.WriteLine("Введите баланс счета:");
            bool isBalance1 = decimal.TryParse(Console.ReadLine(),out decimal balance1);

            BankAccount1 bankAccount1;
            if ((typeForBA1 == 0 || typeForBA1 == 1) && isBalance1 && isNumberBankAccount1 && isTypeForBA1)
            {
                bankAccount1 = new BankAccount1(numberBankAccount1, balance1, (TypeForBankAccount)typeForBA1);

                bankAccount1.PrintInfo();
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }

            //2 задание

            BankAccount23 bankAccount23 = new BankAccount23();
            bool isInput = true;
            while(isInput)
            {
                Console.WriteLine("Введите цифру, которая относится к нужному вам типу счета(0 - текущий, 1 - сберегательный):");
                bool isTypeForBA2 = int.TryParse(Console.ReadLine(), out int typeForBA2);

                Console.WriteLine("Введите баланс счета:");
                bool isBalance2 = decimal.TryParse(Console.ReadLine(), out decimal balance2);

                if ((typeForBA2 == 0 || typeForBA2 == 1) && isBalance2 && isTypeForBA2)
                {
                   bankAccount23 = new BankAccount23(balance2, (TypeForBankAccount)typeForBA2);

                    bankAccount23.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные");
                }
                Console.WriteLine("Нажмите enter, чтобы выйти, или любую другую клавишу, чтобы продолжить");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    isInput = false;
                }
            }

            //3 задание

            Console.WriteLine("Введите сумму которую хотите положить на счет, созданный выше:");
            bool isAmountDeposit = decimal.TryParse(Console.ReadLine(), out decimal amountDeposit);

            bankAccount23.BankAccountTopUp(amountDeposit);

            Console.WriteLine("Введите сумму, которую хотите снять с этого счета:");
            bool isAmountWithdrawal = decimal.TryParse(Console.ReadLine(),out decimal amountWithdrawal);

            bankAccount23.Withdrawal(amountWithdrawal);
        }
    }
}
