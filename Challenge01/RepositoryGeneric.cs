namespace Challenge01
{
    public class RepositoryGeneric<TKey , TValue> where TValue : IEntity<TKey>
    {
        public Dictionary<TKey, TValue> Store { get; init; } = new Dictionary<TKey, TValue>();

        public TValue Add(TKey tkey, TValue tvalue)
        {
            Store.Add(tkey, tvalue);
            return Store[tkey];
        }

        public TValue Update(TKey tkey, TValue tvalue)
        {
            Store[tkey] = tvalue;
            return Store[tkey];
        }

        public void Delete(TKey tkey)
        {
            Store.Remove(tkey);
        }

        public TValue Get(TKey tkey)
        {
            return Store[tkey];
        }

        public List<TValue> GetAll()
        {
            return Store.Values.ToList();
        }
    }
}