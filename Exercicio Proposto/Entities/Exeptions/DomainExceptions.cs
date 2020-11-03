using Exercicio_Proposto.Entities;
using System;

namespace Exercicio_Proposto.Entities.Exeptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}