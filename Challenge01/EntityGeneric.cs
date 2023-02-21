namespace Challenge01
{
    public class EntityGeneric<TKey, TValue> : IEntity<TKey>
    {
        public TKey Id { get ; set; }

        public TValue Value { get; set; }


        public EntityGeneric(TKey tkey, TValue tvalue)
        {
            Id = tkey;
            Value = tvalue;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Value: {Value}";
        }
    }
}