// Microservice boundary sample: one service, one responsibility, own data model.
public interface IOrderService { Task<OrderDto> GetAsync(int id); }
public class OrderService : IOrderService
{
    public Task<OrderDto> GetAsync(int id) => Task.FromResult(new OrderDto(id, "Paid"));
}
public record OrderDto(int Id, string Status);
