using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly Filmes_Context _context;

        public FilmeRepository(Filmes_Context context) 
        {
            
            _context = context;
        
        }

        public Filmes BuscarPorId (Guid id)
        {
            try
            {
                Filmes filmeBuscando = _context.Filme.Find(id)!;

                return filmeBuscando;
            }
            catch (Exception) 
            {
                throw;
            }

        public void Cadastrar(Filmes novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            } 
        }

        public void Deleta(Guid id, Filmes filme)
        {
            try
            {
                Filmes filmeBuscado = _context.Filme.Find(id)!;
                if (filmeBuscado != null)
                {
                    _context.Filme.Remove(filmeBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Atualizar(Guid id, Filmes filmes)
        {
            try
            {
                Filmes filmeBuscado = _context.Filme.Find(id)!;


                if (filmeBuscado != null)
                {
                    filmeBuscado.Titulo = filmes.Titulo;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Filmes> Listar()
        {
            try
            {
                List<Filmes> listaDeFilmes = _context.Filme
                    .Include(g => g.Genero)

                    .Select(f => new Filmes
                    {
                        IdFilme = f.IdFilme,
                        Titulo = f.Titulo,
                        Genero = new Genero
                        {
                            IdGenero = f.IdGenero,
                            Nome = f.Genero!.Nome
                        }
                    })      
                    .ToList();
                return listaDeFilmes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void IFilmeRepository.BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Filmes> ListarPorId(Guid idGenero)
        {
            throw new NotImplementedException();
        }
    }
}
