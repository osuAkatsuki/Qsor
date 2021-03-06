﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using osu.Framework.Allocation;
using osu.Framework.Screens;
using osu.Framework.Testing;
using Qsor.Game.Screens;

namespace Qsor.Tests.Visual.Scenes
{
    [TestFixture]
    public class IntroTestScene : TestScene
    {
        public override IReadOnlyList<Type> RequiredTypes => new[]
        {
            typeof(IntroScreen)
        };

        [BackgroundDependencyLoader]
        private void Load()
        {
            var stack = new ScreenStack();
            
            Add(stack);
    
            AddStep("Start sequence", () =>
            {
                stack.Push(new IntroScreen());
            });
            
            AddStep("Exit sequence", () =>
            {
                stack.Exit();
            });
        }
    }
}