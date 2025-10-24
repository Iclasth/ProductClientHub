namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public class ErrorOnvValidationException : ProductClientHubException
    {
        private readonly List<string> _errors;
        public ErrorOnvValidationException(List<string> errorMessages) : base(string.Empty)
        {
            _errors = errorMessages;
        }

        public override List<string> GetErrors() => _errors;

    }
    
}
