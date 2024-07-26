using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    public class Select {
        public static void Executar() {

            var listProdutos = new List<Produto>() {
                new Produto { Id = 1, CategoriaId = 1, Nome = "Geladeira", Status = true, Valor = 350 },
                new Produto { Id = 9, CategoriaId = 3, Nome = "Feijão", Status = false, Valor = 8 },
                new Produto { Id = 2, CategoriaId = 1, Nome = "Televisão", Status = true, Valor = 450 },
                new Produto { Id = 7, CategoriaId = 2, Nome = "Jaqueta", Status = true, Valor = 200 },
                new Produto { Id = 11, CategoriaId = 3, Nome = "Açúcar", Status = true, Valor = 3 },
                new Produto { Id = 3, CategoriaId = 1, Nome = "Notebook", Status = true, Valor = 1500 },
                new Produto { Id = 8, CategoriaId = 3, Nome = "Arroz", Status = false, Valor = 20 },
                new Produto { Id = 5, CategoriaId = 2, Nome = "Camiseta", Status = true, Valor = 50 },
                new Produto { Id = 10, CategoriaId = 3, Nome = "Macarrão", Status = true, Valor = 5 },
                new Produto { Id = 6, CategoriaId = 2, Nome = "Calça Jeans", Status = true, Valor = 120 },
                new Produto { Id = 4, CategoriaId = 1, Nome = "Smartphone", Status = true, Valor = 800 },
                new Produto { Id = 12, CategoriaId = 3, Nome = "Sal", Status = false, Valor = 1 },
            };

            var listCategorias = new List<Categoria>() {
                new Categoria { Id = 1, Nome = "Eletrônicos", Status = true },
                new Categoria { Id = 2, Nome = "Vestuários", Status = true },
                new Categoria { Id = 3, Nome = "Alimentos", Status = true }
            };

            var result = from prod in listProdutos
                         select new ProdutoDto {
                             Nome = prod.Nome,
                             Status = prod.Status,
                             Valor = prod.Valor
                         };

            foreach (var item in result) {
                Console.WriteLine($"Nome: {item.Nome} | Status: {item.Status} | Valor: {item.Valor}");
            }
        }
    }
}
