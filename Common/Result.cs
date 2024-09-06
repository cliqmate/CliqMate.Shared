namespace CliqMate.Shared.Common
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        // Optional data field to return in case of success
        public object? Data { get; set; }

        // Constructor for a successful result
        private Result(bool isSuccess, string message, object? data = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        // Static method to create a successful result
        public static Result Success(object? data = null, string message = "Operation successful")
        {
            return new Result(true, message, data);
        }

        // Static method to create a failed result
        public static Result Failure(string message = "Operation failed")
        {
            return new Result(false, message);
        }
    }

    // Generic version of the Result class
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        // Constructor for a generic result
        private Result(bool isSuccess, T? data = default, string message = "Operation successful")
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
        }

        // Static method to create a successful result with data
        public static Result<T> Success(T? data, string message = "Operation successful")
        {
            return new Result<T>(true, data, message);
        }

        // Static method to create a failed result
        public static Result<T> Failure(string message = "Operation failed")
        {
            return new Result<T>(false, default, message);
        }
    }
}
