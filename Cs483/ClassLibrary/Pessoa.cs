﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public byte TipoPessoa { get; set; }
    }
}
