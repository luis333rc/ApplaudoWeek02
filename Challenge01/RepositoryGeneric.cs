namespace Challenge01
{
    public class RepositoryGeneric<TKey , IEntity>
    {
        public Dictionary<TKey, IEntity> Store { get; init; } = new Dictionary<TKey, IEntity>();

        public IEntity Add(TKey tkey, IEntity tValue)
        {
            Store.Add(tkey, tValue);
            return Store[tkey];
        }

        public IEntity Update(TKey tkey, IEntity tValue)
        {
            Store[tkey] = tValue;
            return Store[tkey];
        }

        public void Delete(TKey tKey)
        {
            Store.Remove(tKey);
        }

        public IEntity Get(TKey tKey)
        {
            return Store[tKey];
        }

        public List<IEntity> GetAll()
        {
            return Store.Values.ToList();
        }
    }
}