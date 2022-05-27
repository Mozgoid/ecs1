using System;
using Entitas;

namespace Tests.SourceTests.SystemTests.InitializeSystemTests
{
    public abstract class InitializeSystemTests<TInitializeSystem> : SystemTests where TInitializeSystem : IInitializeSystem
    {
        // ! This creates a new instance and initializes it before every test !
        protected InitializeSystemTests()
        {
            TInitializeSystem initializeSystem = (TInitializeSystem)Activator.CreateInstance(typeof(TInitializeSystem), contexts);
            systems.Add(initializeSystem);
            initializeSystem.Initialize();
        }
    }
}