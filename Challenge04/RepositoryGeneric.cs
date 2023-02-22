using Challenge01;
using System.Security.Principal;

namespace Challenge04
{
    internal partial class Program
    {
        public class RepositoryGeneric<TKey, TValue> where TValue : IEntity<TKey>
        {
            public Dictionary<TKey, TValue> Store { get; init; } = new Dictionary<TKey, TValue>();

            public delegate TValue? FilterDelegate(TValue value);

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

            public List<TValue> GetAll(FilterDelegate filter)
            {
                var list = Store.Values;
                var resp = new List<TValue>();

                foreach (var value in list)
                {
                    if (filter(value) is not null)
                        resp.Add(value);
                }

                return resp;
            }

        }  
    }    
}