using System;

namespace iRh.Windows.Core
{
    public class LinkWhats ObterPorWhats(string whats)
    {
        var linkDoWhats = new LinkWhats();

        //Instancia HTTP que permite obter informações da Internet através de uma URL
        var http = new cadastro.HttpClienteWhats();

        var url = new Uri("https://wa.me/5527998006968" + whats);
        var result = http.GetAsync(url).GetAwaiter().GetResult();

        //Converte o resultado obtido em uma string
        var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

              
            return linkDoWhats;
    }
}
