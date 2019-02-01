/* 
 * WINSMS
 *
 * WinSMS RESTful API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@winsms.co.za
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CreditsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CreditsApiTests
    {
        private CreditsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreditsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreditsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CreditsApi
            //Assert.IsInstanceOfType(typeof(CreditsApi), instance, "instance is a CreditsApi");
        }

        
        /// <summary>
        /// Test GetCreditBalance
        /// </summary>
        [Test]
        public void GetCreditBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCreditBalance();
            //Assert.IsInstanceOf<CreditBalanceResponse> (response, "response is CreditBalanceResponse");
        }
        
        /// <summary>
        /// Test TransferCredits
        /// </summary>
        [Test]
        public void TransferCreditsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreditTransferDetails creditTransferDetails = null;
            //var response = instance.TransferCredits(creditTransferDetails);
            //Assert.IsInstanceOf<CreditTransferResponse> (response, "response is CreditTransferResponse");
        }
        
    }

}
