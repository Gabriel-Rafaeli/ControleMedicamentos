﻿using ControleDeMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisiçao;

namespace ControleMedicamentos.ConsoleApp
{
    public class Menu
    {
        public TelaPaciente telaPaciente = null;
        public TelaMedicamento telaRemedio = null;
        public TelaFornecedor telaFornecedor = null;
        public TelaFuncionario telaFuncionario = null;
        public TelaRequisicao telaRequisicao = null;
        public TelaAquisicao telaAquisicao = null;

        public void ExecutarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("(1) Gerenciar Pacientes");
                Console.WriteLine("(2) Gerenciar Remedios");
                Console.WriteLine("(3) Gerenciar Fornecedor");
                Console.WriteLine("(4) Gerenciar Funcionario");
                Console.WriteLine("(5) Gerenciar Requisições");
                Console.WriteLine("(6) Gerenciar Aquisições");
                Console.WriteLine("(7) Listar Remédios em Falta");
                Console.WriteLine("(S) Sair");
                Console.WriteLine("-------------------------------------");

                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1": MenuPaciente(); break;
                    case "2": MenuRemedio(); break;
                    case "3": MenuFornecedor(); break;
                    case "4": MenuFuncionario(); break;
                    case "5": MenuRequisicao(); break;
                    case "6": MenuAquisicao(); break;
                    case "7": telaRemedio.ListarRemédiosEmFalta(); break;
                    case "S": Finalizar(); return;
                }
            }
        }

        public void MenuPaciente()
        {
            while (true)
            {
                string opcao = telaPaciente.ApresentarMenu();
                telaPaciente.SelecionarOpcao(opcao);
                break;
            }
        }

        public void MenuRemedio()
        {
            while (true)
            {
                string opcao = telaRemedio.ApresentarMenu();
                telaRemedio.SelecionarOpcao(opcao);
                break;
            }
        }

        public void MenuFornecedor()
        {
            while (true)
            {
                string opcao = telaFornecedor.ApresentarMenu();
                telaFornecedor.SelecionarOpcao(opcao);
                break;
            }
        }

        public void MenuFuncionario()
        {
            while (true)
            {
                string opcao = telaFuncionario.ApresentarMenu();
                telaFuncionario.SelecionarOpcao(opcao);
                break;
            }
        }

        public void MenuRequisicao()
        {
            while (true)
            {
                string opcao = telaRequisicao.ApresentarMenu();
                telaRequisicao.SelecionarOpcao(opcao);
                break;
            }
        }

        public void MenuAquisicao()
        {
            while (true)
            {
                string opcao = telaAquisicao.ApresentarMenu();
                telaAquisicao.SelecionarOpcao(opcao);
                break;
            }
        }

        public static void VoltarAoMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|Voltando...|");
            Console.ResetColor();
        }

        private static void Finalizar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|Encerrando o PROGRAMA...|");
            Console.ResetColor();
            return;
        }
    }
}
    

