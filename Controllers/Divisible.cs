using Microsoft.AspNetCore.Mvc;
using NPF.Entities;

namespace NPF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Divisible : ControllerBase
    {

        [HttpPost("byeleven")]
        public IResponse GetDivisibleNumberByEleven(Request request)
        {
            Response response = new();

            if (request.numbers.Count > 0)
            {
                try
                {
                    foreach (var number in request.numbers)
                    {
                        Number newNumber = new(number);
                        response.result.Add(newNumber);
                    }
                }
                catch (Exception ex)
                {
                    ResponseError resError = new(ex.Message);
                    return resError;
                }

                return response;
            }

            return new ResponseError("The list of numbers is empty.");
        }
    }
}