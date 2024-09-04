using AutoFixture;
using native_aot.Models;
using Shouldly;
using native_aot.test.FixtureMoq;
using Moq;

namespace native_aot.test.Service;

public class PeapleRepositoryTest(PeapleRepositoryFixture Fixture) : IClassFixture<PeapleRepositoryFixture>
{
    [Fact]
    public void return_list_of_peaples()
    {
        // Arrange
        var peaples = Fixture.Fixture.CreateMany<Peaple>(5).ToList();
        Fixture.SetupGetAllPeaples(peaples);

        // Act
        var result = Fixture.PeapleRepositoryMock.Object.GetAllPeaples();

        // Assert
        result.ShouldBeOfType<List<Peaple>>();
        result.ShouldNotBeEmpty();
    }

    [Fact]
    public void return_peaple_By_Id()
    {
        // Arrange
        var peaple = Fixture.Fixture.Create<Peaple>();
        Fixture.SetupGetPeaple(peaple.Id, peaple);

        // Act
        var result = Fixture.PeapleRepositoryMock.Object.GetPeaple(peaple.Id);

        // Assert
        result.ShouldBeOfType<Peaple>();
        result.ShouldBe(peaple);
    }

    [Fact]
    public void add_peaple()
    {
        // Arrange
        var peaple = Fixture.Fixture.Create<Peaple>();
        Fixture.SetupAddPeaple(peaple);

        // Act
        Fixture.PeapleRepositoryMock.Object.AddPeaple(peaple);

        // Assert
        Fixture.PeapleRepositoryMock.Verify(repo => repo.AddPeaple(peaple), Times.Once);
    }

    [Fact]
    public void update_peaple()
    {
        // Arrange
        var peaple = Fixture.Fixture.Create<Peaple>();
        Fixture.SetupUpdatePeaple(peaple.Id, peaple);

        // Act
        Fixture.PeapleRepositoryMock.Object.UpdatePeaple(peaple.Id, peaple);

        // Assert
        Fixture.PeapleRepositoryMock.Verify(repo => repo.UpdatePeaple(peaple.Id, peaple), Times.Once);
    }

    [Fact]
    public void delete_peaple()
    {
        // Arrange
        var peaple = Fixture.Fixture.Create<Peaple>();
        Fixture.SetupDeletePeaple(peaple.Id);

        // Act
        Fixture.PeapleRepositoryMock.Object.DeletePeaple(peaple.Id);

        // Assert
        Fixture.PeapleRepositoryMock.Verify(repo => repo.DeletePeaple(peaple.Id), Times.Once);
    }
}
