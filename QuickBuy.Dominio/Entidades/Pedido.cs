﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMenagensValidacao();

            if (ItensPedidos.Any())
                AdicionarCritica("Crítica - Pedido não po   de ficar sem Item de Pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido ");
        }
    }
}
