using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebSite1
{
    /// <summary>
    /// Descrição resumida de Paginacao
    /// </summary>
    public abstract class Paginacao
    {

        protected int PaginaAtual { get; set; }

        protected Paginacao()
        {


            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}