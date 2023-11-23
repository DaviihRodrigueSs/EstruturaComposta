
using System.ComponentModel.Design;
using System.Globalization;

namespace EstruturaComposta
{
    class program
    {
        static void Main(string[] args)
        {

            int horas;

            Console.WriteLine("Quantas horas?  ");

            horas = int.Parse(Console.ReadLine());

            //objetivo perguntar ao usuario que horas são e definir se vai ser bom dia ou boa tarde.

            //Utilizando o if - se e else - se não, na estrutura composta.

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else

                if (horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");

            }







            Console.ReadLine();






        }
    }
}
