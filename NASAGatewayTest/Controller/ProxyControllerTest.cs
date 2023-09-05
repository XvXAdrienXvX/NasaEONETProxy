using Moq;
using NASAGateway.Client;
using NASAGateway.Controllers;
using NASAGatewayTest.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace NASAGatewayTest.Controller
{
    public class ProxyControllerTest
    {
        private ProxyController _proxyController;
        private EONETEventResponse _eventsResponseResult = new();
        [SetUp]
        public void Setup()
        {
            _eventsResponseResult = LoadJson();
        }

        [Test]
        public async Task API_Should_Return_Open_EventsAsync()
        {
            // Arrange
            var httpClientMock = new Mock<IEONETClient>();

            httpClientMock.Setup(x => x.GetEventsByStatus(It.Is<string>(s => s.StartsWith("open"))));

            _proxyController = new ProxyController(httpClientMock.Object);

            // Act
            var result = await _proxyController.GetEventsByStatus("open");

            // Assert
            System.Diagnostics.Debug.WriteLine("Result:" + result);
        }

        private EONETEventResponse LoadJson()
        {
            EONETEventResponse items = new EONETEventResponse();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            String Root = Directory.GetCurrentDirectory();
            string path = Path.Combine(Root, @"TestData\data.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<EONETEventResponse>(json);
            }

            return items;
        }
    }
}
