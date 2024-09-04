using native_aot.Models;

namespace native_aot.Repositories.Interfaces;

public interface IPeapleRepository
{
    void AddPeaple(Peaple Peaple);
    void UpdatePeaple(Guid Id, Peaple Peaple);
    void DeletePeaple(Guid Id); 
    IList<Peaple> GetAllPeaples();
    Peaple GetPeaple(Guid Id);
}
