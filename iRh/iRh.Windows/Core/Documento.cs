using System.Collections.Generic;

namespace iRh.Windows.Core
{
    public class Documento
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public List<Documento> ObterTodosOsDocumentos()
        {
            var listaDeDocumentos = new List<Documento>();
            //cadeia estados{}; << no portugol 

            listaDeDocumentos.Add(new Documento { Id = "1", Nome = "RG"});
            listaDeDocumentos.Add(new Documento { Id = "2", Nome = "Carteira Nacional de Habilitação"});
            listaDeDocumentos.Add(new Documento { Id = "3", Nome = "Pasaporte"});
            listaDeDocumentos.Add(new Documento { Id = "4", Nome = "Carteira de Trabalho"});
          
            return listaDeDocumentos;

        }
    }
}
