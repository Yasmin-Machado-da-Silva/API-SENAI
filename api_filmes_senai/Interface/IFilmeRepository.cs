using api_filmes_senai.Domains;

namespace api_filmes_senai.Interface
{
    public interface IFilmeRepository
    {
        void Cadastrar (Filmes novoFilme);

        List<Filmes> Listar();

        void Deleta(Guid id, Filmes filme);

       

    }
}
