using CascaApi.Models;

namespace CascaApi.Repository.Interfaces
{
    public interface IJustificativaRepository
    {
        List<Justificativa> Listar();
        void Adicionar(Justificativa justificativa);
    }
}
