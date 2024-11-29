using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Тут було порушено Single responsibility
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
    }

    class OrderOperations
    {
        public void CalculateTotalSum(Order order) {/*...*/}
        public void GetItems(Order order) {/*...*/}
        public void GetItemCount(Order order) {/*...*/}
        public void AddItem(Item item, Order order) {/*...*/}
        public void DeleteItem(Item item, Order order) {/*...*/}
    }

    class OrderManager
    {
        public void Load(Order order) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    class PrintManager
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
