using ControleDeMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisiçao;
using ControleMedicamentos.ConsoleApp.ModuloRequisicao;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            TelaPaciente telaPaciente = new TelaPaciente();
            TelaFornecedor telaFornecedor = new TelaFornecedor();
            TelaMedicamento telaMedicamento = new TelaMedicamento();
            TelaRequisicao telaRequisicao = new TelaRequisicao();
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            TelaAquisicao telaAquisicao = new TelaAquisicao();

            RepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor();
            RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento();
            RepositorioRequisicao repositorioRequisicao = new RepositorioRequisicao();
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
            RepositorioAquisicao repositorioAquisicao = new RepositorioAquisicao();

            menu.telaPaciente = telaPaciente;
            menu.telaRemedio = telaMedicamento;
            menu.telaFornecedor = telaFornecedor;
            menu.telaFuncionario = telaFuncionario;
            menu.telaRequisicao = telaRequisicao;
            menu.telaAquisicao = telaAquisicao;

            telaPaciente.repositorioPaciente = repositorioPaciente;
            telaFornecedor.repositorioFornecedor = repositorioFornecedor;
            telaMedicamento.repositorioMedicamento = repositorioMedicamento;
            telaMedicamento.repositorioFornecedor = repositorioFornecedor;
            telaFuncionario.repositorioFuncionario = repositorioFuncionario;
            telaRequisicao.repositorioRequisicao = repositorioRequisicao;
            telaRequisicao.repositorioPaciente = repositorioPaciente;
            telaRequisicao.repositorioFuncionario = repositorioFuncionario;
            telaRequisicao.repositorioMedicamento = repositorioMedicamento;
            telaAquisicao.repositorioFuncionario = repositorioFuncionario;
            telaAquisicao.repositorioMedicamento = repositorioMedicamento;
            telaAquisicao.repositorioFornecedor = repositorioFornecedor;
            telaAquisicao.repositorioAquisicao = repositorioAquisicao;

            //CRIANDO FORNECEDORES
            Fornecedor fornecedor01 = new Fornecedor(0, "Eurofarma", "8854644");
            Fornecedor fornecedor02 = new Fornecedor(1, "Aché", "88545546");
            Fornecedor fornecedor03 = new Fornecedor(2, "LIBS", "886123423");
            Fornecedor fornecedor04 = new Fornecedor(3, "Mantecorp", "8831456547");
            repositorioFornecedor.Criar(fornecedor01);
            repositorioFornecedor.Criar(fornecedor02);
            repositorioFornecedor.Criar(fornecedor03);
            repositorioFornecedor.Criar(fornecedor04);

            //CRIANDO REMÉDIOS
            Medicamento medicamento01 = new Medicamento(0, "Paracetamol", 40, "Analgésico", 100, fornecedor01);
            Medicamento medicamento02 = new Medicamento(1, "atamol", 39, "Analgésico", 100, fornecedor02);
            Medicamento medicamento03 = new Medicamento(2, "cimegripe", 36, "Gripe", 100, fornecedor03);
            Medicamento medicamento04 = new Medicamento(3, "Buscopa", 6, "Analgésico", 100, fornecedor04);
            repositorioMedicamento.Criar(medicamento01);
            repositorioMedicamento.Criar(medicamento02);
            repositorioMedicamento.Criar(medicamento03);
            repositorioMedicamento.Criar(medicamento04);

            //CRIANDO FUNCIONARIOS
            Funcionario funcionario0 = new Funcionario(0, "Madara", "88234723", "415678567", "1298317289");
            Funcionario funcionario1 = new Funcionario(1, "Ragnar", "212567723", "62354234", "2354546283");
            Funcionario funcionario2 = new Funcionario(2, "Megumin", "32234723", "59879789", "1283712893");
            Funcionario funcionario3 = new Funcionario(3, "Escanor", "4123450543", "254724123", "812312623");
            repositorioFuncionario.Criar(funcionario0);
            repositorioFuncionario.Criar(funcionario1);
            repositorioFuncionario.Criar(funcionario2);
            repositorioFuncionario.Criar(funcionario3);

            //CRIAR PACIENTE
            Paciente paciente0 = new Paciente(0, "Kaisa", "829237", "9789789", "24938247", "1111111");
            Paciente paciente1 = new Paciente(1, "Neon", "21343424", "87235566", "68854654", "2223333");
            Paciente paciente2 = new Paciente(2, "Gandalf", "123213", "3333333", "77777", "4414444");
            Paciente paciente3 = new Paciente(3, "Leona", "23545345", "4444444", "888899", "12121211");
            repositorioPaciente.Criar(paciente0);
            repositorioPaciente.Criar(paciente1);
            repositorioPaciente.Criar(paciente2);
            repositorioPaciente.Criar(paciente3);

            //CRIAR REQUISIÇÕES
            Requisicao requisicao0 = new Requisicao(0, paciente0, medicamento01, funcionario0, "12/12/2000", 2);
            Requisicao requisicao1 = new Requisicao(1, paciente1, medicamento02, funcionario1, "12/12/2000", 3);
            Requisicao requisicao2 = new Requisicao(2, paciente2, medicamento03, funcionario2, "12/12/2000", 1);
            Requisicao requisicao3 = new Requisicao(3, paciente3, medicamento04, funcionario3, "12/12/2000", 4);
            repositorioRequisicao.Criar(requisicao0);
            repositorioRequisicao.Criar(requisicao1);
            repositorioRequisicao.Criar(requisicao2);
            repositorioRequisicao.Criar(requisicao3);

            //CRIAR AQISIÇÕES
            Aquisicao aquisicao0 = new Aquisicao(0, fornecedor01, medicamento01, funcionario0, "05/04/2023", 10);
            Aquisicao aquisicao1 = new Aquisicao(1, fornecedor02, medicamento02, funcionario1, "05/04/2023", 5);
            Aquisicao aquisicao2 = new Aquisicao(2, fornecedor03, medicamento03, funcionario2, "05/04/2023", 15);
            Aquisicao aquisicao3 = new Aquisicao(3, fornecedor04, medicamento04, funcionario3, "05/04/2023", 12);
            repositorioAquisicao.Criar(aquisicao0);
            repositorioAquisicao.Criar(aquisicao1);
            repositorioAquisicao.Criar(aquisicao2);
            repositorioAquisicao.Criar(aquisicao3);

            menu.ExecutarMenuPrincipal();
        }
    }
}