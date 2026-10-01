using CascaApi.Models;
namespace CascaApi.Repository.Interfaces
{
    public interface IEleitorRepository
    {
        List<Eleitor> Listar();
        bool Adicionar(Eleitor eleitor);
        Eleitor? BuscarPorCpf(string cpf);

    }
}
