using System;

namespace verificador
{
    class Program
    {
        static void Main(string[] args)
        {
           // CPF verificator 

           int temporary = 0;
           int temporary2 = 0;
           string cpf;
           string test1 = ""; 
           string test2 = "";
           
           int [] multiplier1 = new int[9] {10,9,8,7,6,5,4,3,2};
           int [] multiplier2 = new int[10] {11,10,9,8,7,6,5,4,3,2};
           int sum;
           int remainder;
           int[] cpftemporary = new int[11];

          
           Console.WriteLine("Type your CPF (only numbers):");
           cpf = Console.ReadLine();

            if (cpf.Length == 11)
            {
            
            cpftemporary[0] = Convert.ToInt32(cpf.Substring(0, 1));
            cpftemporary[1] = Convert.ToInt32(cpf.Substring(1, 1));
            cpftemporary[2] = Convert.ToInt32(cpf.Substring(2, 1));
            cpftemporary[3] = Convert.ToInt32(cpf.Substring(3, 1));
            cpftemporary[4] = Convert.ToInt32(cpf.Substring(4, 1));
            cpftemporary[5] = Convert.ToInt32(cpf.Substring(5, 1));
            cpftemporary[6] = Convert.ToInt32(cpf.Substring(6, 1));
            cpftemporary[7] = Convert.ToInt32(cpf.Substring(7, 1));
            cpftemporary[8] = Convert.ToInt32(cpf.Substring(8, 1));
            cpftemporary[9] = Convert.ToInt32(cpf.Substring(9, 1));
            cpftemporary[10] = Convert.ToInt32(cpf.Substring(10, 1));
           
           for (int i = 0; i < 9; i++)
           {
            sum = cpftemporary[i] * multiplier1[i];
            temporary += sum;
           }

            remainder = temporary % 11;

            if (remainder < 2)
            {
                if (cpftemporary[9] == 0)
                {
                    test1 = "ok";
                }
                
            }
            else if (remainder > 2 & remainder < 10 & cpftemporary[9] == 11 - remainder)
            {
                test1 = "ok";
            }
            else
            {
                test1 = "false";
            }

            
            if (test1 == "ok")
            {
                for (int i = 0; i < 10; i++)
                {
                sum = cpftemporary[i] * multiplier2[i];
                temporary2 += sum;
                }

                remainder = temporary2 % 11;

                if (remainder < 2 && cpftemporary[10] == 0)
                {
                    test2 = "valid";
                }
                else if (remainder > 2 & remainder < 10 & cpftemporary[10] == 11 - remainder)
                {
                    test2 = "valid";
                }
                else
                {
                    test2 = "invalid";
                }
            }

            if (test1 == "ok" & test2 == "valid")
            {
                Console.WriteLine("O CPF {0} é valid", cpf);
                
            } else
            {
                Console.WriteLine("O CPF {0} é invalid", cpf);
            }
          }
          
          if (cpf.Length != 11)
          {
            Console.WriteLine("Invalid");  
          }
          
        }
    }
}
