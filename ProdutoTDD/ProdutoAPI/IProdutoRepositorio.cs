﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoAPI
{
    public interface IProdutoRepositorio
    {
        void ler();
        void Adicionar(Produto P);
    }
}
