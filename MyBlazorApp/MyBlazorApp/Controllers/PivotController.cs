using MyBlazorApp.Data;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Blazor.Data;
using System.Linq.Dynamic.Core;

namespace MyBlazorApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PivotController : ControllerBase
    {
        public OrderDataAccessLayer OrderService = new OrderDataAccessLayer();
        // GET: api/Default
        [HttpGet]
        public object Get()
        {
            IQueryable<Order> data = OrderService.GetAllOrders().AsQueryable();
            return new { Items = data, Count = data.Count() };
        }

        // The modified orders can be obtained from the EditCompleted event via HttpClient and used to update specified records in the SQL database.
        [HttpPost]
        [Route("Update")]
        public void Update([FromBody] Dictionary<int, Order> modifiedData)
        {
            if (modifiedData != null)
            {
                foreach (int index in modifiedData.Keys)
                {
                    OrderService.UpdateOrder(modifiedData[index]);
                }
            }
        }

        // The newly added orders can be obtained from the EditCompleted event via HttpClient and used to add specified records to the SQL database.
        [HttpPost]
        [Route("Add")]
        public void Add([FromBody] Dictionary<int, Order> addedData)
        {
            if (addedData != null)
            {
                foreach (int index in addedData.Keys)
                {
                    OrderService.AddOrder(addedData[index]);
                }
            }
        }

        // The newly added orders can be obtained from the EditCompleted event via HttpClient and used to delete specified records in the SQL database.
        [HttpPost]
        [Route("Delete")]
        public void Delete([FromBody] Dictionary<int, Order> removedData)
        {
            if (removedData != null)
            {
                foreach (int index in removedData.Keys)
                {
                    OrderService.DeleteOrder(index);
                }
            }
        }
    }
}
