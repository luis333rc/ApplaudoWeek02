using System.Collections.Generic;

namespace Challenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var repository = new RepositoryGeneric<int, EntityGeneric<int, string>>();
                repository.Add(1, new EntityGeneric<int, string>(1, "C#"));

                var entity2 = new EntityGeneric<int, string>(2, "Java");
                var entity3 = new EntityGeneric<int, string>(3, "Ruby");

                repository.Add(entity2.Id, new EntityGeneric<int, string>(entity2.Id, entity2.Value));
                repository.Add(entity3.Id, new EntityGeneric<int, string>(entity3.Id, entity3.Value));

                repository.GetAll().ForEach(e => Console.WriteLine(e));

                Console.WriteLine("Get Id: 2 -> " + repository.Get(2));

                var entity4 = new EntityGeneric<int, string>(4, "Python");
                Console.WriteLine("Update Id: 2 -> " + repository.Update(2, entity4));

                repository.GetAll().ForEach(e => Console.WriteLine(e));

                repository.Delete(2);
                Console.WriteLine("Id 2 Deleted ...");

                repository.GetAll().ForEach(e => Console.WriteLine(e));
            }
            catch (Exception)
            {
                Console.WriteLine("There was a problem");
            }
            
        }
    }
}