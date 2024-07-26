using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    public class WhereEOrderBy {
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

            Console.WriteLine("\nTodos os produtos:");
            foreach (var produto in listProdutos) {
                Console.WriteLine($"ID: {produto.Id} | Nome: {produto.Nome} | Valor: {produto.Valor} | Status: {produto.Status}| CategoriaI: {produto.CategoriaId}");
            }

            // 01 - Filtar produto por nome
            Console.WriteLine("\nFiltar produto por nome:");
            var RESP01 = Console.ReadLine();
            var result01 = from produto in listProdutos
                           where produto.Nome.ToLower() == RESP01.ToLower()
                           select produto;
            foreach (var resultf01 in result01) {
                Console.WriteLine($"ID: {resultf01.Id} | Nome: {resultf01.Nome} | Valor: {resultf01.Valor} | Status: {resultf01.Status}| CategoriaI: {resultf01.CategoriaId}");
            }

            // 02 - Filtar produto pela primeira letra
            Console.WriteLine("\nFiltar produto pela primeira letra:");
            var RESP02 = Console.ReadLine();
            var result02 = from produto in listProdutos
                           where produto.Nome.ToLower().Substring(0, 1) == RESP02.ToLower()
                           select produto;

            foreach (var resultf02 in result02) {
                Console.WriteLine($"ID: {resultf02.Id} | Nome: {resultf02.Nome} | Valor: {resultf02.Valor} | Status: {resultf02.Status}| CategoriaI: {resultf02.CategoriaId}");
            }

            // 03 - Filtar produto pela primeira letra e pelo status
            Console.WriteLine("\nProduto filtrado com status False: ");
            var result03 = from produto in listProdutos
                           where produto.Nome.ToLower().Substring(0, 1) == RESP02.ToLower() &&
                           produto.Status == false
                           select produto;
            foreach (var resultf03 in result03) {
                Console.WriteLine($"ID: {resultf03.Id} | Nome: {resultf03.Nome} | Valor: {resultf03.Valor} | Status: {resultf03.Status}| CategoriaI: {resultf03.CategoriaId}");
            }

            // 04 - Ordernar por ID (Ordem Crescente)
            Console.WriteLine("\nOrdernar por ID (Ordem Crescente)");

            var result04 = from produto in listProdutos
                           orderby produto.Id
                           select produto;

            foreach (var resultf04 in result04) {
                Console.WriteLine($"ID: {resultf04.Id} | Nome: {resultf04.Nome} | Valor: {resultf04.Valor} | Status: {resultf04.Status}| CategoriaI: {resultf04.CategoriaId}");
            }

            // 05 - Ordernar por ID (Ordem Decrescente)
            Console.WriteLine("\nOrdernar por ID (Ordem Decrescente)");
            var result05 = from produto in listProdutos
                           orderby produto.Id descending
                           select produto;

            foreach (var resultf05 in result05) {
                Console.WriteLine($"ID: {resultf05.Id} | Nome: {resultf05.Nome} | Valor: {resultf05.Valor} | Status: {resultf05.Status}| CategoriaI: {resultf05.CategoriaId}");
            }
        }
    }
}
