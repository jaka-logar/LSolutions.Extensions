﻿using System;
using Xunit;

namespace LSolutions.Extensions.Tests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void NullCheckTest()
        {
            object nullObject = null;
            Assert.Throws<ArgumentNullException>(() => nullObject.NullCheck());

            object obj = new object();
            obj.NullCheck();
            Assert.True(true);
        }
    }
}