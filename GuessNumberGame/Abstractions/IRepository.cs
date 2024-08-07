namespace GuessNumberGame.Abstractions;
public interface IRepository<TEntity>
{
    static IList<TEntity>? Entities { get; set; }

    TEntity? Get(int id);
    IEnumerable<TEntity> GetAll();
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
}
