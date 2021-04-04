using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsForLife.Creational
{
    public class Singleton
    {
        private IEnumerable<string> _items = new string[]
        {
            "item1", "item2", "item3"
        };
        private static readonly Singleton _instance;

        public static Singleton Instance => _instance ?? new Singleton();

        protected Singleton()
        {
        }

        public IEnumerable<string> GetItems() => _items;
        public IEnumerable<string> AddItems(IEnumerable<string> items) => _items = _items.Concat(items).ToArray();

    }
}
