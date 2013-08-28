﻿#region header

// <copyright file="NHRepositoryTests.cs" company="mikegrabski.com">
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

using Moq;

using NHibernate;

using NUnit.Framework;

namespace NStack.Data
{
    [TestFixture]
    public class NHRepositoryTests
    {
        #region Setup/Teardown

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
        }

        [SetUp]
        public void SetUpTest()
        {
        }

        [TearDown]
        public void TearDownTest()
        {
        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
        }

        #endregion

        [Test]
        public void Session_should_use_unit_of_work_session()
        {
            // Arrange
            var factory = new Mock<ISessionFactory>();
            factory.Setup(c => c.OpenSession())
                   .Returns(Mock.Of<ISession>());

            var uow = new NHUnitOfWork(factory.Object);

            var repository = new NHRepository<object, int>(uow);

            // Act
            IUnitOfWorkScope scope = repository.UnitOfWork.Scope();
            object ignore = repository.Get(1);

            // Assert
            factory.Verify(c => c.OpenSession(), Times.Once());
        }
    }
}