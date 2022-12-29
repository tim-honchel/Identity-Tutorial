using IdentityTutorial.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DatabaseCanConnect()
        {
            var connectionString = ConfigurationHelper.GetApplicationConnectionString();
            var connection = new TestContext(connectionString);
            var canConnect = connection.Database.CanConnect();
            Assert.IsTrue(canConnect);
        }
    }
}