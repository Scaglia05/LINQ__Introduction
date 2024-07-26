using LINQ.Models;

namespace LINQ {
    public class JoinEGroupBy {
        public static void Executar() {
            var produtos = new List<Produto>() {
                new Produto { Id = 1, CategoriaId = 1, Nome = "Geladeira", Status = false, Valor = 350 },
                new Produto { Id = 9, CategoriaId = 3, Nome = "Feijão", Status = true, Valor = 8 },
                new Produto { Id = 2, CategoriaId = 1, Nome = "Televisão", Status = false, Valor = 450 },
                new Produto { Id = 7, CategoriaId = 2, Nome = "Jaqueta", Status = true, Valor = 200 },
                new Produto { Id = 11, CategoriaId = 3, Nome = "Açúcar", Status = true, Valor = 3 },
                new Produto { Id = 3, CategoriaId = 1, Nome = "Notebook", Status = true, Valor = 1500 },
                new Produto { Id = 8, CategoriaId = 3, Nome = "Arroz", Status = true, Valor = 20 },
                new Produto { Id = 5, CategoriaId = 2, Nome = "Camiseta", Status = false, Valor = 50 },
                new Produto { Id = 10, CategoriaId = 3, Nome = "Macarrão", Status = true, Valor = 5 },
                new Produto { Id = 6, CategoriaId = 2, Nome = "Calça Jeans", Status = false, Valor = 120 },
                new Produto { Id = 4, CategoriaId = 1, Nome = "Smartphone", Status = true, Valor = 800 },
                new Produto { Id = 12, CategoriaId = 3, Nome = "Sal", Status = true, Valor = 1 },
            };

            var categorias = new List<Categoria>() {
                new Categoria { Id = 1, Nome = "Eletrônicos", Status = true },
                new Categoria { Id = 2, Nome = "Vestuários", Status = true },
                new Categoria { Id = 3, Nome = "Alimentos", Status = true }
            };

            // Grouping by CategoriaId
            Console.WriteLine("\nGroup by CategoriaId:");
            var produtosAgrupadosPorCategoria = from produto in produtos
                                                group produto by produto.CategoriaId into produtosAgrupados
                                                select produtosAgrupados;

            foreach (var grupo in produtosAgrupadosPorCategoria) {
                Console.WriteLine($"CategoriaId: {grupo.Key}");
                foreach (var produto in grupo) {
                    Console.WriteLine($"Nome: {produto.Nome} | CategoriaId: {produto.CategoriaId}");
                }
            }

            // Grouping by Status
            Console.WriteLine("\nGroup by Status:");
            var produtosAgrupadosPorStatus = from produto in produtos
                                             group produto by produto.Status into produtosAgrupados
                                             select produtosAgrupados;

            foreach (var grupo in produtosAgrupadosPorStatus) {
                Console.WriteLine($"Status: {grupo.Key}");
                foreach (var produto in grupo) {
                    Console.WriteLine($"Nome: {produto.Nome} | Status: {(produto.Status ? "Ativo" : "Inativo")}");
                }
            }

            // Joining produtos and categorias by CategoriaId
            Console.WriteLine("\nJoin produtos and categorias:");
            var produtosComCategoria = from produto in produtos
                                       join categoria in categorias
                                       on produto.CategoriaId equals categoria.Id
                                       select new {
                                           Produto = produto,
                                           Categoria = categoria
                                       };

            foreach (var item in produtosComCategoria) {
                Console.WriteLine($"Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome}");
            }
        }
    }
}
