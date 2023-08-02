namespace CustomBadRequestSample
{
    public class CustomeResponce
    {
        public Dictionary<string, string[]> ErrorMessage { get; set; }
        public string RequestId { get; set; }
        public bool IsSuccess { get; set; }
    }
}
