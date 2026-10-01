using CascaApi.Models;
using CascaApi.Repository.Interfaces;

namespace CascaApi.Repository
{
    public class JustificativaRepository : IJustificativaRepository
    {
        private readonly List<Justificativa> justificativas = new();
        public void Adicionar(Justificativa justificativa)
        {
            justificativas.Add(justificativa);
        }


        public List<Justificativa> Listar()
        {
            return justificativas ;

        }
    }
}
