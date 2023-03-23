namespace SimpleAPI.Dtos
{
    /// <summary>
    ///     Use to retrieve a response to controller with specific typ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public bool Success { get; set; }
        public int Total { get; set; }
        public int HttpStatus { get; set; }
        public T Data { get; set; }
        public string Privileges { get; set; }


    }
}
