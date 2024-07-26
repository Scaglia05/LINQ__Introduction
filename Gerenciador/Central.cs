using System;
using System.Collections.Generic;

namespace LINQ.Gerenciador {
    public class Central {
        private Dictionary<string, Action> _acoes;

        public Central(Dictionary<string, Action> acoes) {
            _acoes = acoes;
        }

        public void SelecionarEExecutar() {
            while (true) {
                Console.WriteLine("\nEscolha uma ação:");
                int i = 1;
                foreach (var acao in _acoes) {
                    Console.WriteLine($"{i}. {acao.Key}");
                    i++;
                }

                if (int.TryParse(Console.ReadLine(), out int escolha) && escolha > 0 && escolha <= _acoes.Count) {
                    var acao = _acoes.Values.ElementAt(escolha - 1);
                    acao();
                } else {
                    Console.WriteLine("Escolha inválida.");
                }
            }
        }
    }
}
