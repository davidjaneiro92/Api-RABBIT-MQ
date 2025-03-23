using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBroker.Relatorios
{
    public sealed record RelatorioSolicitadoEvent(Guid Id, string Nome);
}
