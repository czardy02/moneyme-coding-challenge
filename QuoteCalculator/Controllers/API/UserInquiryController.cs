using Microsoft.AspNetCore.Mvc;
using QuoteCalculator.DbContexts;
using QuoteCalculator.Models.API;
using QuoteCalculator.Models.Data;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace QuoteCalculator.Controllers.API
{
    [ApiController]
    public class UserInquiryController : ControllerBase
    {

        public readonly string parentURL = Environment.GetEnvironmentVariable("PARENT_URL");
        public QuoteCalculatorDbContext dbContext = new QuoteCalculatorDbContext();

        [AcceptVerbs("Post")]
        [Route("api/UserInquiry")]
        public UserInquiryResponseV1 ProcessUserInquiry([FromBody] object requestBody)
        {
            UserInquiryRequestV1 request = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInquiryRequestV1>(requestBody.ToString());
            return this.createUserResponseFrom(request);
        }

            private UserInquiryResponseV1 createUserResponseFrom(UserInquiryRequestV1 request)
            {
                UserInquiryResponseV1 response = new UserInquiryResponseV1();
                response.Headers = this.createHeaders();
                response.User = this.createUserBodyFrom(request);
                response.Product = this.createProductBodyFrom(request);
                response.User.DateOfBirth = DateTime.Parse(request.DateOfBirth.ToString("yyyy-MM-dd"));
                return response;
            }

            private UserInquiryResponseHeadersV1 createHeaders()
            {
                var headers = new UserInquiryResponseHeadersV1();
                headers.RedirectedURL = this.parentURL + "QuotesCalculator";
                return headers;
            }

            private UserInquiryResponseUserBodyResponseV1 createUserBodyFrom(UserInquiryRequestV1 request)
            {
                var user = new UserInquiryResponseUserBodyResponseV1();
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Email = request.Email;
                user.Mobile = request.Mobile;
                user.DateOfBirth = request.DateOfBirth;
                return user;
            }

            private UserInquiryResponseProductBodyResponseV1 createProductBodyFrom(UserInquiryRequestV1 request)
            {
                var product = new UserInquiryResponseProductBodyResponseV1();
                product.SelectedProduct = this.getProductFrom(request);
                product.ProductName = request.ProductName;
                product.Term = request.Term;
                product.AmountRequired = request.AmountRequired;
                return product;
            }

                private Product getProductFrom(UserInquiryRequestV1 request)
                {
                    var requestedProductName = request.ProductName;
                    if (request.ProductName == null || request.ProductName == "") requestedProductName = "Product A";
                    var product = dbContext.Products.Where(product => product.ProductName == requestedProductName).First<Product>();
                    return product;
                }
    }
}
