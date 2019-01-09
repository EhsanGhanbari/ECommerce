namespace ECommerce.Services
{
    /// <summary>
    /// Messaging of service usually return a message (success of fail)
    /// this class is kinda a DRY one !
    /// </summary>
    public class BaseResponse
    {
        private bool _success;

        public bool Success
        {
            get { return _success; }
            set
            {
                MessageType = value ? MessageType.Success : MessageType.UnSuccess;
                _success = value;
            }
        }

        /// <summary>
        /// Retrieved Messages
        /// </summary>
        public string Message { get; set; }

        public MessageType MessageType { get; set; }
    }
}
