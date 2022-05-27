using System;
using Entitas;

namespace Tests.SourceTests.SystemTests
{
    public abstract class SystemTests : IDisposable
    {
        protected Contexts contexts;
        protected Systems systems;

        // ! This runs before every test !
        protected SystemTests()
        {
            contexts = new Contexts();
            systems = new Systems();
        }
        
        // ! This runs after every test !
        public void Dispose()
        {
        }
    }
}