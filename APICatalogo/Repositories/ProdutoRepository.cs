using APICatalogo.Context;
using APICatalogo.Models;

namespace APICatalogo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Produto GetProduto(int id)
        {
           var produtos = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

            if (produtos is null)
                throw new InvalidOperationException("Produto Não Encontrado!!!");
            return produtos;
        }

        public IQueryable<Produto> GetProdutos()
        {
            return _context.Produtos;
        }

        public Produto Create(Produto produto)
        {
            if (produto is null)
                throw new InvalidOperationException("Produto Não Encontrado!!!");

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;

        }

        public bool Delete(int id)
        {
            var produto = _context.Produtos.Find(id);

            if(produto is not null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(Produto produto)
        {
            if (produto is null)
                throw new InvalidOperationException("Produto Não Encontrado!!!");

            if (_context.Produtos.Any(p => p.ProdutoId == produto.ProdutoId))
            {
                _context.Produtos.Update(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
