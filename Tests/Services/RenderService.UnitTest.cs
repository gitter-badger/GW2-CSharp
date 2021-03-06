﻿using GW2CSharp.Services;
using GW2CSharp.Services.Enums;
using NUnit.Framework;
using System;
using System.Drawing;

namespace Tests.Services
{
    [TestFixture]
    public class RenderServiceUnitTest
    {
        [Test]
        public void CanRenderBitmap()
        {
            Bitmap bitmap = RenderService.GetImage("943538394A94A491C8632FBEF6203C2013443555", "102478", FileFormat.png);

            Assert.NotNull(bitmap);
        }

        [Test]
        public void ThrowsErrorOnNotFound()
        {
            Assert.Throws<ArgumentException>(() => RenderService.GetImage("45345345", "43534643", FileFormat.png));
        }
    }
}
