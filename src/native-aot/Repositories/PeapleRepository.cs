using native_aot.DataContext;
using native_aot.Models;
using native_aot.Repositories.Interfaces;

namespace native_aot.Repositories;

public class PeapleRepository(IDataContext DataContext) : IPeapleRepository
{
    public void AddPeaple(Peaple Peaple)
      => DataContext.Peaples.Add(Peaple);    

    public void DeletePeaple(Guid Id)
      => DataContext.Peaples.Remove(DataContext.Peaples.FirstOrDefault(x => x.Id == Id)); 

    public IList<Peaple> GetAllPeaples()
      => DataContext.Peaples.ToList();

    public Peaple GetPeaple(Guid Id)
      => DataContext.Peaples.FirstOrDefault(x => x.Id == Id);

    public void UpdatePeaple(Guid Id, Peaple Peaple)
      => DataContext.Peaples.FirstOrDefault(x => x.Id == Id).update(Peaple.Name, Peaple.Cpf);
}
