namespace Challenge01
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}