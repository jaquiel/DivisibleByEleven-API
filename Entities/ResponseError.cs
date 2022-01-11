namespace NPF.Entities
{
    public class ResponseError : IResponse
    {
        public string error { get; set; }

        public ResponseError(string message)
        {
            error = message;
        }
    }
}
