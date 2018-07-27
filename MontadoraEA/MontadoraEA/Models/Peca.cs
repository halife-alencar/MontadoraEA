﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MontadoraEA.Models
{
    public class Peca
    {
        public Peca()
        {
            Fornecedor = new Fornecedor();
        }

        [Key]
        public int PecaId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFabricacao { get; set; }

        [DisplayName("Descrição")]
        [StringLength(50, ErrorMessage = "O tamanho máximo são 50 caracteres.")]
        [Required]
        public string Descricao { get; set; }

        [DisplayName("Número de Série")]
        [StringLength(30, ErrorMessage = "O tamanho máximo são 30 caracteres.")]
        [Required]
        public string NumeroSerie { get; set; }        

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double Valor { get; set; }
                
        public Fornecedor Fornecedor { get; set; }
    }
}