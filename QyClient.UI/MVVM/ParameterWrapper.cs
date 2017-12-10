namespace QyClient.UI.MVVM
{
    public class ParameterWrapper
    {
        public object Sender { get; set; }
        public object Parameter { get; set; }

        public ParameterWrapper(object sender, object parameter)
        {
            Sender = sender;
            Parameter = parameter;
        }
    }
}
