﻿using System;
using System.Collections.Generic;
using MarvelSharp.Interfaces;
using MarvelSharp.Tests.Unit.Helpers;
using MarvelSharp.Utilities;
using Moq;
using NUnit.Framework;

namespace MarvelSharp.Tests.Unit.Utilities
{
    public class UrlBuilderTests
    {
        private const string PublicApiKey = "publicKey2724";
        private const string PrivateApiKey = "privateKey0983";
        private const string TestUrlSuffix = "urlSuffix236";
        private const string TestHashedValue = "hashValue5050";
        private const string CurrentTimeString = "000215091502";

        private readonly DateTime _currentTime = new DateTime(2000,2,15,9,15,2);

        [Test]
        public void BuildUrl_GivenNullParameters_ReturnsCorrectUrl()
        {
            // Arrange
            var mockHasher = new Mock<IHasher>();
            var mockDateProvider = new Mock<IDateProvider>();
            mockHasher.Setup(h => h.Hash(It.IsAny<string>())).Returns(TestHashedValue);
            mockDateProvider.Setup(d => d.GetCurrentTime()).Returns(_currentTime);
            var sut = new UrlBuilder(mockHasher.Object, mockDateProvider.Object);

            // Act
            var result = sut.BuildUrl(PublicApiKey, PrivateApiKey, TestUrlSuffix);

            // Assert
            Assert.That(result.StartsWith($"{MarvelApi.Base}{TestUrlSuffix}?"));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterApiKey, PublicApiKey));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterTimeStamp, CurrentTimeString));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterHash, TestHashedValue));
        }

        [Test]
        public void BuildUrl_GivenNotNullParameters_ReturnsCorrectUrl()
        {
            // Arrange
            var mockHasher = new Mock<IHasher>();
            var mockDateProvider = new Mock<IDateProvider>();
            var mockParameters = new Mock<IParameters>();
            var mockDictionary = new Dictionary<string,string>
            {
                { "TestKey1", "TestValue1" },
                { "TestKey2", "TestValue2" },
                { "TestKey3", "TestValue3" }
            };
            mockHasher.Setup(h => h.Hash(It.IsAny<string>())).Returns(TestHashedValue);
            mockDateProvider.Setup(d => d.GetCurrentTime()).Returns(_currentTime);
            mockParameters.Setup(p => p.ToDictionary()).Returns(mockDictionary);

            var sut = new UrlBuilder(mockHasher.Object, mockDateProvider.Object);
            
            // Act
            var result = sut.BuildUrl(PublicApiKey, PrivateApiKey, TestUrlSuffix, mockParameters.Object);

            // Assert
            Assert.That(result.StartsWith($"{MarvelApi.Base}{TestUrlSuffix}?"));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterApiKey, PublicApiKey));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterTimeStamp, CurrentTimeString));
            Assert.That(result.ContainsKeyValuePair(MarvelApi.ParameterHash, TestHashedValue));
            
            foreach (var entry in mockDictionary)
            {
                Assert.That(result.ContainsKeyValuePair(entry.Key, entry.Value), $"String does not contain the an expression for {entry.Key}={entry.Value}");
            }
        }
    }
}
