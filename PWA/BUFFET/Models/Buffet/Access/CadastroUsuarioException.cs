using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BUFFET.Models.Buffet.Access
{
    public class CadastroUsuarioException : Exception
    {
        public CadastroUsuarioException(IEnumerable<IdentityError> erros)
        {
            Erros = erros;
        }

        public IEnumerable<IdentityError> Erros { get; set; }
    }
}