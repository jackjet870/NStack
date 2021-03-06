﻿#region header

// <copyright file="StringCapitalizeTests.cs" company="mikegrabski.com">
//    Copyright 2013 Mike Grabski
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>

#endregion

using FluentAssertions;

using NUnit.Framework;

namespace NStack.Extensions
{
    [TestFixture]
    public class StringCapitalizeTests
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUpTest()
        {
        }

        [TearDown]
        public void TearDownTest()
        {
        }

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
        }

        #endregion

        [Test]
        public void Capitalize_should_capitalize()
        {
            "this is a TEST".Capitalize().Should().Be("This is a test");
            "   this is a TEST!".Capitalize().Should().Be("   This is a test!");
        }
    }
}