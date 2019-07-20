using Core;
using System;

namespace TresCamadas
{
    public sealed class UserInterface
    {
        public static void showMenu()
        {
            Console.Clear();
            Console.Write("==============================\n");
            Console.Write("   Digite uma opção abaixo:   \n");
            Console.Write("   1- Cadastrar novo usuário  \n");
            Console.Write("   0- Sair da aplicação       \n");
            Console.Write("==============================\n");
        }

        public static object menuInput(string input)
        {
            Console.Clear();
            switch (input)
            {
                //Cadastrar novo usuário
                case "1":
                    Console.Write("Insira um nome para o novo usuário: ");
                    string name = Console.ReadLine();
                    Console.Write("\nInsira um telefone para o novo usuário: ");
                    string phone = Console.ReadLine();
                    Console.Write("\nInsira um cpf para o novo usuário: ");
                    string cpf = Console.ReadLine();
                    Console.Write("\nInsira uma senha para o novo usuário: ");
                    string password = Console.ReadLine();
                    var user = new Usuario(name, phone, cpf, password);
                    Console.Clear();
                    Console.Write($"Usuario cadastrado com sucesso. \nCPF: {user.Cpf}\n");
                    return user;

                //Encerrar aplicação
                case "0":
                    Environment.Exit(0);
                    return null;

                //Input inválido
                default:
                    Console.Write("Opção inválida, tente novamente.");
                    return null;
            }
        }
    }
}
