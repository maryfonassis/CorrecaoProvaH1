using CascaApi.Models;
using CascaApi.Repository.Interfaces;
namespace CascaApi.Repository
{
    public class EleitorRepository : IEleitorRepository
    {
        private readonly List<Eleitor> eleitores = new();
        public bool Adicionar(Eleitor eleitor)
        {
            if(BuscarPorCpf(eleitor.CPF) != null)
            {
                return false;
            }
            eleitores.Add(eleitor);
            return true;
        }

        public Eleitor? BuscarPorCpf(string cpf)
        {
            return eleitores.FirstOrDefault(e => e.CPF.Equals(cpf));
        }

        public List<Eleitor> Listar()
        {
            return eleitores;
        }
    }
}
