﻿

using System;
using System.Collections.Generic;

using NUnit.Framework;

using FluentAssertions;

using Moq;

namespace NStack.Conditions
{
    [TestFixture]
    public class GenericCollectionVariableTests
    {
        #region Setup/Teardown for fixture

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
        }

        #endregion

        #region Setup/Teardown for each test

        [SetUp]
        public void SetUpTest()
        {
        }

        [TearDown]
        public void TearDownTest()
        {
        }

        #endregion

        [Test]
        public void IsEmpty_should_pass()
        {
            // Arrange
            var list = new List<string>();

            // Act / Assert
            list.Invoking(value => Requires.That(list).IsEmpty())
                .ShouldNotThrow();

            list.Invoking(value => Ensures.That(list).IsEmpty())
                .ShouldNotThrow();
        }
        
        [Test]
        public void IsEmpty_should_fail()
        {
            // Arrange
            var list = new List<string> {""};

            // Act / Assert
            list.Invoking(value => Requires.That(list).IsEmpty())
                .ShouldThrow<ArgumentException>();
            
            list.Invoking(value => Ensures.That(list).IsEmpty())
                .ShouldThrow<PostConditionException>();
        } 
        
        [Test]
        public void IsNotEmpty_should_pass()
        {
            // Arrange
            var list = new List<string> {""};

            // Act / Assert
            list.Invoking(value => Requires.That(list).IsNotEmpty())
                .ShouldNotThrow();
            
            list.Invoking(value => Ensures.That(list).IsNotEmpty())
                .ShouldNotThrow();
        }
        
        [Test]
        public void IsNotEmpty_should_fail()
        {
            // Arrange
            var list = new List<string>();

            // Act / Assert
            list.Invoking(value => Requires.That(list).IsNotEmpty())
                .ShouldThrow<ArgumentException>();
            
            list.Invoking(value => Ensures.That(list).IsNotEmpty())
                .ShouldThrow<PostConditionException>();
        }

        [Test]
        public void HasCountOf_should_pass()
        {
            // Arrange
            var list = new List<string> {""};

            // Act / Assert
            list.Invoking(value => Requires.That(list).HasCountOf(1))
                .ShouldNotThrow();
            
            list.Invoking(value => Ensures.That(list).HasCountOf(1))
                .ShouldNotThrow();

        }
        
        [Test]
        public void HasCountOf_should_fail()
        {
            // Arrange
            var list = new List<string> {""};

            // Act / Assert
            list.Invoking(value => Requires.That(list).HasCountOf(0))
                .ShouldThrow<ArgumentException>();
            
            list.Invoking(value => Ensures.That(list).HasCountOf(0))
                .ShouldThrow<PostConditionException>();

        }
    }
}