﻿using Comunikime.Models;

namespace Comunikime.ViewModels
{
    public class PedidoProdutoViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
