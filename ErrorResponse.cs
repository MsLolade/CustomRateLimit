namespace CustomRateLimit
{
    public class ErrorResponse<T>
    {
        public string Message { get; set; } = "Rate limit exceeded.";
    }
}
