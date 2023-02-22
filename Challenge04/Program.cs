using Challenge01;

namespace Challenge04
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var repository = new RepositoryGeneric<int, EntityGeneric<int, string>>();

            var entity1 = new EntityGeneric<int, string>(1, "Mercury");
            var entity2 = new EntityGeneric<int, string>(2, "Venus");
            var entity3 = new EntityGeneric<int, string>(3, "Earth");
            var entity4 = new EntityGeneric<int, string>(4, "Mars");

            repository.Add(entity1.Id, new EntityGeneric<int, string>(entity1.Id, entity1.Value));
            repository.Add(entity2.Id, new EntityGeneric<int, string>(entity2.Id, entity2.Value));
            repository.Add(entity3.Id, new EntityGeneric<int, string>(entity3.Id, entity3.Value));
            repository.Add(entity4.Id, new EntityGeneric<int, string>(entity4.Id, entity4.Value));

            repository.GetAll().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("------------------------------------------");

            var resp1 = repository.GetAll( e => {
                            if (e.Value.StartsWith("M"))
                                return e;

                            return null;
                        });

            resp1.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("------------------------------------------");

            var resp2 = repository.GetAll(e => {
                if (e.Value.Contains("th"))
                    return e;

                return null;
            });

            resp2.ForEach(e => Console.WriteLine(e));
        }

    }
}