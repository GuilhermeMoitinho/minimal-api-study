using native_aot.Models.Abstractions;

namespace native_aot.Models;

public class Peaple(string name, string cpf) : Entity
{
    public string Name { get; set; } = name;
    public string Cpf { get; set; } = cpf;

    internal void update(string name, string cpf)
    {
        Name = name;
        Cpf = cpf;
    }
};
