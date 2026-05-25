using Abc.Data;
using Abc.Tests.Aids;
using Microsoft.Testing.Platform.Extensions.Messages;

namespace Abc.Tests.Data
{
    [TestClass] 
    public sealed class MovieTests : BaseTests<Movie>
    {
        [TestMethod] public void IdTest() => IsProperty<int>(nameof(Movie.Id));
        [TestMethod] public void TitleTest() => Assert.Inconclusive();
        [TestMethod] public void ReleaseDateTest() => Assert.Inconclusive();
        [TestMethod] public void GenreTest() => Assert.Inconclusive();
        [TestMethod] public void PriceTest() => IsProperty<decimal>(nameof(Movie.Price));
    }
}
