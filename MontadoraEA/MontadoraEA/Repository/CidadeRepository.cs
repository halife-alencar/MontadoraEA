﻿using MontadoraEA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MontadoraEA.Repository
{
    public class CidadeRepository
    {
        private readonly Contexto db = new Contexto();

        public void Adicionar(Cidade cidade)
        {
            db.Cidade.Add(cidade);
            db.SaveChanges();
        }
    }
}