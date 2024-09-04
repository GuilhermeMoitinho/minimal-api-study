namespace native_aot.Models.Abstractions;

public class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();   
    public DateTime Created { get; set; } = DateTime.Now;   
    public DateTime Updated { get; set; } = DateTime.Now;
}
