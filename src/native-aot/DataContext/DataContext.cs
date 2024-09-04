using native_aot.Models;
using System.Collections.ObjectModel;

namespace native_aot.DataContext;

public class DataContext : IDataContext
{
    public IList<Peaple> Peaples { get; set; } = new List<Peaple> { new Peaple("Guilherme", "11972988514") };
}
