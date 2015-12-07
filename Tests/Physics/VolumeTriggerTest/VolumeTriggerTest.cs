﻿using System;
using NUnit.Framework;
using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Input;
using SiliconStudio.Xenko.Testing;

namespace VolumeTriggerTest
{
    [TestFixture]
    public class VolumeTriggerTest
    {
        private const string Path = "samples\\Physics\\VolumeTrigger\\Bin\\Windows\\Debug\\VolumeTrigger.exe";

#if TEST_ANDROID
        private const PlatformType TestPlatform = PlatformType.Android;
#else
        private const PlatformType TestPlatform = PlatformType.Windows;
#endif

        [Test]
        public void TestLaunch()
        {
            using (var game = new GameTest(Path, TestPlatform))
            {
                game.Wait(TimeSpan.FromMilliseconds(2000));
            }
        }

        [Test]
        public void TestInputs()
        {
            using (var game = new GameTest(Path, TestPlatform))
            {
                game.Wait(TimeSpan.FromMilliseconds(2000));

                game.TakeScreenshot();

                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));

                game.TakeScreenshot();

                game.Wait(TimeSpan.FromMilliseconds(500));
            }
        }
    }
}
