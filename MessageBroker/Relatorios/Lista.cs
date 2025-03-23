using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBroker.Relatorios
{
    public class Lista
    {
        public List<SolicitacaoRelatorio> Relatorio { get; set; }
    }

    public class SolicitacaoRelatorio
    { 
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public DateTime? ProcessedTime { get; set; }
    }
}
