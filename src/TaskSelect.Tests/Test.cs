namespace TaskSelect.Tests
{
    [TestClass]
    public sealed class Test
    {
        [TestMethod]
        public async Task TestMethod()
        {
            // Act
            var (foo, bar) = await Task.Select(Foo(), Bar());
            // Assert
            Assert.AreEqual(42, foo);
            Assert.AreEqual(3.14f, bar);
        }

        private async Task<int> Foo()
        {
            return await Task.FromResult(42);
        }

        private async Task<float> Bar()
        {
            return await Task.FromResult(3.14f);
        }
    }
}
