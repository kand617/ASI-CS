/*
 * ASI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ASI.PCL;
using ASI.PCL.Utilities; 
using ASI.PCL.Http.Client;
using ASI.PCL.Http.Response;
using ASI.Tests.Helpers;
using NUnit.Framework;
using ASI.PCL;
using ASI.PCL.Controllers;
using ASI.PCL.Exceptions;

namespace ASI.Tests
{
    [TestFixture]
    public class MiscControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static MiscController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Misc;
        }

        /// <summary>
        /// TODO: Add Description 
        /// </summary>
        [Test]
        public async Task TestTradeNames1() 
        {
            // Parameters for the API call
            string q = "cab";

            // Perform API call

            try
            {
                await controller.GetTradeNamesAsync(q);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// TODO: Add Description 
        /// </summary>
        [Test]
        public async Task TestGETASIProduct1() 
        {
            // Parameters for the API call
            string authToken = null;
            string xid = "573-5613789";

            // Perform API call

            try
            {
                await controller.GETASIProductAsync(authToken, xid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}