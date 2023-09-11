using System;
namespace StopWatch {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("Deseja fazer a contagem em: ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("[S] - Segundos");
            Console.WriteLine("[M] - Minuto");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("------------------------");

            string typeTime = Console.ReadLine();
            if(typeTime == "0") {
                Valeu();
            } // Sei que n precisava de chaves, mas fica mais organizado
            
            Console.Clear();

            Console.Write("Digite o tempo que deseja contar: ");
            int time = int.Parse(Console.ReadLine());
            int multiplier = 1;

            if(typeTime == "m") {
                multiplier = 60;
            } // Sei que n precisava de chaves, mas fica mais organizado

            PreStart(time * multiplier);
        }

        static void PreStart(int time) {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time) {
            int currentTime = 0;

            while(currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //1 segundo
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Console.WriteLine("Retornando ao menu...");
            Thread.Sleep(2500); //2.5 segundos
            Menu();
        }

        static void Valeu() {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Muito obrigado por utilizar meu sistema. Espero que tenha gostado e volte a usar!");
            Console.WriteLine("Abraço do Luckzin :)");
            Console.WriteLine("---------------------------------------------------------------------------------");
            System.Environment.Exit(0);
        }

    }
}