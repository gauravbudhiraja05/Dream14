namespace Dream14.ViewModels.Global
{
    /// <summary>
    /// Result is a generic data structure that represents each return type of operation
    /// </summary>
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
