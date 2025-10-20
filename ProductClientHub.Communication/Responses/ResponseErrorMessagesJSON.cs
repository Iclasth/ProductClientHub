namespace ProductClientHub.Communication.Responses
{
    public class ResponseErrorMessagesJSON
    {
        public List<string> ErrorsMensages { get; private set; }

        public ResponseErrorMessagesJSON(string message)
        {
            ErrorsMensages = [message];
        }
    }
}
