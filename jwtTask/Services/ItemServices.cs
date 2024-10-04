using jwtTask.Models;

namespace jwtTask.Services
{
    public interface IItem
    {
        void CreateItem(Items item);
        void DeleteItem(int id);

        List<Items> GetItems();

        //Items GetItemById(int id);
    }
    public class ItemServices:IItem
    {
        static List<Items> items = new List<Items>();

        public void CreateItem(Items item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
        }
        public List<Items> GetItems()
        {
            return items;
        }
        public void DeleteItem(int id)
        {
            var i=items.FirstOrDefault(x => x.Id == id);
            items.Remove(i);
        }
    }
}

