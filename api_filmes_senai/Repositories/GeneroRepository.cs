using api_filmes_senai.Domains;
using api_filmes_senai.Interface;
using api_filmes_senai.Context;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// classe que vai implementar a interface IGeneroRepository ou seja vamos implementar os metodos, toda a logica dos metodos.
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// variavel privada e somente leitura que "guarda" os dados do contexto
        private readonly Filmes_Context _context;
        /// <summary>
        /// construtor de repositorio
        /// aqui, toda vez que o construtor for chanmado, os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto">dados do contexto</param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;

        }
        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo genero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);

                //Apos o cadastro salva as alteracoes(BD)
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {

            try
            {
                List<Genero> ListaGeneros = _context.Genero.ToList();

                return ListaGeneros;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
