using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public sealed class Controles
    {
        private static Controles instance = null;
        private static readonly object padlock = new object();

        Controles()
        {
        }

        public static Controles Singleton
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Controles();
                        }
                    }
                }
             return instance;
            }
        }

        public void showMenu()
        {
            Console.Clear();
            Console.Write("==============================\n");
            Console.Write("   Digite uma opção abaixo:   \n");
            Console.Write("   1- Cadastrar novo usuário  \n");
            Console.Write("   0- Sair da aplicação       \n");
            Console.Write("==============================\n");
        }

        public object menuInput(string input)
        {
            Console.Clear();
            switch (input){
                //Cadastrar novo usuário
                case "1":
                    Console.Write("Insira um nome para o novo usuário: ");
                    string name = Console.ReadLine();
                    Console.Write("\nInsira um telefone para o novo usuário: ");
                    string phone = Console.ReadLine();
                    Console.Write("\nInsira um cpf para o novo usuário: ");
                    string cpf = Console.ReadLine();
                    Usuario user = new Usuario(name, phone, cpf);
                    Console.Clear();
                    Console.Write("Usuario cadastrado com sucesso. \nCPF: "+user.getCpf()+"\n");
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
