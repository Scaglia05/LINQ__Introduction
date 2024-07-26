using System;
using System.Collections.Generic;

namespace LINQ.Gerenciador {
    internal class Program {
        public static void Main(string[] args) {
            var central = new Central(new Dictionary<string, Action>() {
                {"LINQ", LINQ.Executar},
                {"Select", Select.Executar},
                {"Where e OrderBy", WhereEOrderBy.Executar},
                {"Join e GroupBy", JoinEGroupBy.Executar},
                {"First e FirstOrDefault", FirstEFirstOrDefault.Executar},
                {"Last e LastOrDefault", LastELastOrDefault.Executar},
                {"Single e SingleOrDefault", SingleESingleOrDefault.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
