using PizzaAPI.Models;

namespace PizzaAPI.Data
{
    public class SampleData
    {
        public static List<Order> CreateSampleOrders()
        {
            List<Order> orders = new()
            {
                new Order()
                {
                    OrderId = new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624"),
                    OrderDate = DateOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderStartingTime = TimeOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderDeliveryTime = TimeOnly.FromDateTime(DateTime.Now).AddHours(1).ToString(),
                    OrderLocation = "SW 3, White Ave, Burnaby, BC V5G 3H2",
                    OrderPrice = 29.99M,
                    OrderStatus = "Complete",
                    OrderDetails = "Deliver at front door",
                },
                new Order()
                {
                    OrderId = new Guid("24a36310-6c27-424d-8eaf-238fabe3298a"),
                    OrderDate = DateOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderStartingTime = TimeOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderDeliveryTime = "",
                    OrderLocation = "7399 122 St, Surrey, BC V3W 5J2",
                    OrderPrice = 35.99M,
                    OrderStatus = "In Process",
                    OrderDetails = "Deliver at back door",
                },
                new Order()
                {
                    OrderId = new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a"),
                    OrderDate = DateOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderStartingTime = TimeOnly.FromDateTime(DateTime.Now).ToString(),
                    OrderDeliveryTime = TimeOnly.FromDateTime(DateTime.Now).AddHours(1).ToString(),
                    OrderLocation = "2100 Viceroy Pl, Richmond, BC V6V 1Y9",
                    OrderPrice = 25.99M,
                    OrderStatus = "Complete",
                    OrderDetails = "Deliver at side door",
                },
            };
            return orders;
        }

        public static List<Pizza> CreateSamplePizzas()
        {
            List<Pizza> pizzas = new()
            {
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.Pepperoni,
                    PizzaDescription = "Extra spicy",
                    OrderId = new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.Cheese,
                    PizzaDescription = "Normal Cheese Pizza",
                    OrderId = new Guid("d5473fbd-b5d2-427a-8561-0de46b84da4a")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.Veggie,
                    PizzaDescription = "No Pinapples",
                    OrderId = new Guid("24a36310-6c27-424d-8eaf-238fabe3298a")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.BBQChicken,
                    PizzaDescription = "Extra BBQ Sause",
                    OrderId = new Guid("24a36310-6c27-424d-8eaf-238fabe3298a")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.GlutenFree,
                    PizzaDescription = "No sauce",
                    OrderId = new Guid("24a36310-6c27-424d-8eaf-238fabe3298a")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.Cheese,
                    PizzaDescription = "Normal Cheese Pizza",
                    OrderId = new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624")
                },
                new Pizza()
                {
                    PizzaId = Guid.NewGuid(),
                    PizzaType = PizzaType.Cheese,
                    PizzaDescription = "Extra Cheese and Extra Sause",
                    OrderId = new Guid("1bb1c44f-87ef-46b6-8031-ca09cc419624")
                }

            };
            return pizzas;
        }
    }
}
