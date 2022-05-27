using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Contexts contexts = new Contexts();
            Systems systems = new Systems();
            CreateEntitySystem createEntitySystem = new CreateEntitySystem(contexts);
            systems.Add(createEntitySystem);
            systems.Initialize();
            
            Assert.True(contexts.game.count == 1);
        }
    }
}
