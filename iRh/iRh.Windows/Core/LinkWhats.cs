using System;
using System.Net.Http;

namespace iRh.Windows.Core
{
    public class LinkWhats : ObterPorWhats
    {
        public void SendMessage(String message, String to)
        {
            StarBrowser(TypeDrive.Google.Chorme);
            Navegate("https://wa.me/5527997249172");

            WaitForLoad();
        }

    }
}
