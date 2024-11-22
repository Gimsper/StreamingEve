namespace Eve.Shared.Utils
{
    public class ResultOperation
    {
        public bool StateOperation { get; set; } = true;
        public string MessageResult { get; set; } = string.Empty;
        public string MessageError { get; set; } = string.Empty;
    }

    public class ResultOperation<T> : ResultOperation where T : class
    {
        public T? Result { get; set; } = null;
        public List<T>? Results { get; set; } = null;
    }

    public class ResultOperationStruct<S> : ResultOperation where S : struct
    {
        public S? Result { get; set; } = null;
        public List<S>? Results { get; set; } = null;
    }
}
