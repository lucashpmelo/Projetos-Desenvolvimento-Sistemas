﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class Fornecedor
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        public Fornecedor()
        {
            this.Id = null;
        }

        protected bool Equals(Fornecedor other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Fornecedor))
                return false;
            return Equals((Fornecedor)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
