using System;
using System.ComponentModel;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool app = true;
            while (app)
            {
                Console.WriteLine("\n\ndigite a regra de negócios que você quer acionar: Regra1 ou Regra2. Para encerrar a aplicação digite 'FECHAR'");
                string regra = Console.ReadLine();


                if (regra.ToLower().Equals("fechar"))
                {
                    app = false;
                }
                else
                {
                    //pulo do gato
                    dynamic obj = Roteador.GetObject(regra);
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
                    {
                        string name = descriptor.Name;
                        object value = descriptor.GetValue(obj);
                        if (obj.GetType().ToString().ToLower()!="system.string")
                        {
                            Console.WriteLine("{0}={1}", name, value);
                        }
                        else
                        {
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    if (regra.ToLower().Equals("regra1"))
                    {
                        obj.CalculoRegra1();
                    }else if (regra.ToLower().Split('-').Equals("catalog"))
                    {
                        
                    }
                }
            }
        }
    }
}
