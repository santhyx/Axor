namespace Api.Types
{
    internal record ActionResult
    {
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public Error? Error { get; set; }
    }
}
