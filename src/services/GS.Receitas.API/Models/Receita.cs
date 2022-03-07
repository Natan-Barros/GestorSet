using GS.Core.DomainObjects;

namespace GS.Receitas.API.Models
{
    public class Receita : Entity, IAgregateRoot
    {
        public int Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }


        protected Receita()
        {

        }

        public Receita(Guid id, int descricao, decimal valor, DateTime data)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }
    }
}
