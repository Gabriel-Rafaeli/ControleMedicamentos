﻿using ControleMedicamentos.ConsoleApp.Compartilhados;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;

namespace ControleDeMedicamentos.ConsoleApp.ModuloAquisicao
{
    public class Aquisicao : Entidade
    {
        public Fornecedor Fornecedor;
        public Medicamento Medicamento;
        public Funcionario Funcionario;
        public string Data;
        public int QuantidadeMedicamento;

        public Aquisicao(int id, Fornecedor fornecedor, Medicamento medicamento, Funcionario funcionario, string data, int quantidadeRemedio)
        {
            Id = id;
            Fornecedor = fornecedor;
            Medicamento = medicamento;
            Funcionario = funcionario;
            Data = data;
            QuantidadeMedicamento = quantidadeRemedio;
        }

        public override void Atualizar(Entidade registroAtualizado)
        {
            Aquisicao aquisicao = (Aquisicao)registroAtualizado;

            Fornecedor = aquisicao.Fornecedor;
            Medicamento = aquisicao.Medicamento;
            Funcionario = aquisicao.Funcionario;
            Data = aquisicao.Data;
            QuantidadeMedicamento = aquisicao.QuantidadeMedicamento;
        }
    }
}
