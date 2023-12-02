namespace ClotheShop.Class
{
    public class CustomEventArgs : EventArgs
    {
        public object value1;
        public object value2;

        public CustomEventArgs(string value1, string value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
        }

        public object Value1
        {
            get => value1;
            set => value1 = value;
        }
        public object Value2
        {
            get => value2;
            set => value2 = value;
        }
    }
}