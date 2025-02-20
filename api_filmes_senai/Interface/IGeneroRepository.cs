using api_filmes_senai.Domains;
namespace api_filmes_senai.Interface
{

    /// <summary>
    /// Interface para genero : Contrato
    /// Toda classe que herdar(Implementar) essa interface, 
    /// devera implementar todos os metodos definidos aqui dentro
    /// </summary>
   
    public interface IGeneroRepository
    {
                //CRUD: Metodos
        //C : Create : Cadastrar um novo Objeto
        //R : Read : Read : Listar todos os objetos
        //U : Update : Alterar um objeto
        //D : Delete : Deleto ou excluo um objeto

        //Metodo = TipoDeRetorno NomeDoMetodo(Argumentos)

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();

        void Atualizar(Guid id, Genero genero);

        void Deletar(Guid id);

        Genero BuscarPorId(Guid id);
    }
}
