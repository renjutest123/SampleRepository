using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.API.Controllers;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Results;
using System.Collections.Generic;
using Sample.API.Models;

namespace Sample.API.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestGetAllPersons()
        {            
            var personscontroller = new PersonsController();
            var actionResult = personscontroller.GetAllPersons();
            var response = actionResult as OkNegotiatedContentResult<IEnumerable<Person>>;
            Assert.IsNotNull(response);
            



            // Act
            //var response = controller.Get(10);

            // Assert
            //Product product;
            // Assert.IsTrue(response.TryGetContentValue<Product>(out product));
            // Assert.AreEqual(10, product.Id);

        }

        [TestMethod]
        public void TestGetPerson()
        {
            var personscontroller = new PersonsController();
            var actionResult = personscontroller.GetPerson(1);
            var retrievedID = ((OkNegotiatedContentResult<Person>)actionResult).Content.ID;
            Assert.AreEqual(1, retrievedID);
        }
    }
}
