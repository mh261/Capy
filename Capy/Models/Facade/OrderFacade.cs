namespace Capy.Models.Facade
{
    public class OrderFacade
    {
        public List<Order> getByUserId(int userId)
        {
            List<Order> orders = new List<Order>();

            // get all orders of a user from DB

            return orders;
        }

        public Order getById(int id)
        {
            Order order = new Order();

            // get a single order from DB

            return order;
        }

        public void create(Order order)
        {
            // create order in DB
        }

        public void update(Order order)
        {
            // update order in DB
        }

        public void delete(int id) {
            // delete order from DB
        }
    }
}
