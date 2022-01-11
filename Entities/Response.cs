using NPF.Entities;

namespace NPF
{
    public class Response : IResponse
    {
        public List<Number> result { get; set; }

        public Response()
        {
            result = new List<Number>();
        }
    }
}
