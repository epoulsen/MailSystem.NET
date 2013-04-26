﻿using NUnit.Framework;

namespace ActiveUp.Net.Tests
{
    public static class FluentTests
    {
        public static void ShouldEqual(this object obj, object other)
        {
            Assert.AreEqual(other, obj);
        }

        public static void ShouldBeNull(this object obj)
        {
            Assert.IsNull(obj);
        }

        public static void ShouldNotBeNull(this object obj)
        {
            Assert.IsNotNull(obj);
        }
    }
}