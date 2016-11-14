namespace _10.ImplementLinkedList
{
    public class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
        }

        public ListItem<T> NextItem { get; set; }

        public T Value { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}