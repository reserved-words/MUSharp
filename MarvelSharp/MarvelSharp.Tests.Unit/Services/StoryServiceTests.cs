﻿using MarvelSharp.Interfaces;
using MarvelSharp.Model;
using MarvelSharp.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarvelSharp.Tests.Unit.Services
{
    [TestFixture]
    public class StoryServiceTests
    {
        private const string MockApiPublicKey = "";
        private const string MockApiPrivateKey = "";
        private const string MockUrl = "https://mock-url.com/";
        private const string MockHttpResponse = "{ 'code' : '200' }";

        private Mock<IHttpService> _mockHttpService;
        private Mock<IUrlBuilder> _mockUrlBuilder;
        private Mock<IParser<Story>> _mockParser;

        [SetUp]
        public void SetUp()
        {
            _mockHttpService = new Mock<IHttpService>();
            _mockUrlBuilder = new Mock<IUrlBuilder>();
            _mockParser = new Mock<IParser<Story>>();
            _mockUrlBuilder.Setup(u => u.BuildUrl(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), null)).Returns(MockUrl);
            _mockHttpService.Setup(h => h.GetAsync(It.IsAny<string>())).ReturnsAsync(MockHttpResponse);
            _mockParser.Setup(p => p.ParseList(It.IsAny<object>())).Returns(new List<Story>());
        }

        private StoryService GetSubjectUnderTest()
        {
            return new StoryService(_mockHttpService.Object, _mockParser.Object, _mockUrlBuilder.Object, MockApiPublicKey, MockApiPrivateKey);
        }

        [Test]
        public void GetAllAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetAllAsync(null).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, MarvelApi.GetAllStories, null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetByIdAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetByIdAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetStory, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<Story>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetByCharacterAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetByCharacterAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetCharacterStories, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetByComicAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetByComicAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetComicStories, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetByCreatorAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetByCreatorAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetCreatorStories, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetBySeriesAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetBySeriesAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetSeriesStories, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }

        [Test]
        public void GetByEventAsync_CallsApiMethod()
        {
            // Arrange
            var sut = GetSubjectUnderTest();

            // Act
            var result = sut.GetByEventAsync(0).Result;

            // Assert
            _mockUrlBuilder.Verify(u => u.BuildUrl(MockApiPublicKey, MockApiPrivateKey, string.Format(MarvelApi.GetEventStories, 0), null), Times.Once);
            _mockHttpService.Verify(s => s.GetAsync(MockUrl), Times.Once);
            _mockParser.Verify(p => p.GetResponse<List<Story>>(It.IsAny<object>()), Times.Once);
        }
    }
}