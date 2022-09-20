namespace Api.Types
{
    internal record FailableResult<TData>
    {
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public TData? Data { get; set; }
        public Error? Error { get; set; }
    }
}
