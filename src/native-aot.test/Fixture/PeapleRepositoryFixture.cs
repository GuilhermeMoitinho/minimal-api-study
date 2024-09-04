using Moq;
using native_aot.Models;
using native_aot.Repositories.Interfaces;
using AutoFixture;

namespace native_aot.test.FixtureMoq;

public class PeapleRepositoryFixture
{
    public Mock<IPeapleRepository> PeapleRepositoryMock { get; }
    public IFixture Fixture { get; }

    public PeapleRepositoryFixture()
    {
        PeapleRepositoryMock = new Mock<IPeapleRepository>();
        Fixture = new Fixture();
    }

    public void SetupGetAllPeaples(IList<Peaple> peaples)
    {
        PeapleRepositoryMock.Setup(repo => repo.GetAllPeaples()).Returns(peaples);
    }

    public void SetupGetPeaple(Guid id, Peaple peaple)
    {
        PeapleRepositoryMock.Setup(repo => repo.GetPeaple(id)).Returns(peaple);
    }

    public void SetupAddPeaple(Peaple peaple)
    {
        PeapleRepositoryMock.Setup(repo => repo.AddPeaple(peaple)).Verifiable();
    }

    public void SetupUpdatePeaple(Guid id, Peaple peaple)
    {
        PeapleRepositoryMock.Setup(repo => repo.UpdatePeaple(id, peaple)).Verifiable(); 
    }

    public void SetupDeletePeaple(Guid id)
    {
        PeapleRepositoryMock.Setup(repo => repo.DeletePeaple(id)).Verifiable();
    }
}
