
using Loja.Business.Notificacoes;
using System.Collections.Generic;

namespace Loja.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);
    }
}
