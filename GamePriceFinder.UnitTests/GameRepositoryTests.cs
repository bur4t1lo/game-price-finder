using NUnit.Framework;
using Moq;
using Microsoft.EntityFrameworkCore;
using GamePriceFinder.DataAccess.Entities;
using GamePriceFinder.DataAccess.Repositories;
using System.Threading.Tasks;
using GamePriceFinder.DataAccess;

namespace GamePriceFinder.UnitTests
{
    [TestFixture]
    public class GameRepositoryTests
    {
        [Test]
        public async Task AddGameAsync_GameIsAdded()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<GamePriceFinderDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDbForAddingGame") // ”никальное им€ дл€ каждого теста
                .Options;

            var gameToAdd = new Game { Title = "Test Game", Genre = "Test Genre" };

            // Act
            using (var context = new GamePriceFinderDbContext(options))
            {
                var repository = new Repository<Game>(context);
                await repository.AddAsync(gameToAdd);
                await context.SaveChangesAsync();
            }

            // Assert
            using (var context = new GamePriceFinderDbContext(options))
            {
                var game = await context.Games.FirstOrDefaultAsync();
                Assert.NotNull(game, "Game should not be null");
                Assert.AreEqual("Test Game", game.Title, "Title should be 'Test Game'");
                Assert.AreEqual("Test Genre", game.Genre, "Genre should be 'Test Genre'");
            }
        }
    }
}
