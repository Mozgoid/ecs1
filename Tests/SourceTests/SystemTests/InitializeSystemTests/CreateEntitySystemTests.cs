using Xunit;

namespace Tests.SourceTests.SystemTests.InitializeSystemTests
{
    public sealed class CreateEntitySystemTests : InitializeSystemTests<CreateEntitySystem>
    {
        [Fact]
        private void ItCreatesOneEntity()
        {
            Assert.True(contexts.game.count == 1);
        }
    }
}