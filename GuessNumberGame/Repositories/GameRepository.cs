using GuessNumberGame.Abstractions;
using GuessNumberGame.Entities;

namespace GuessNumberGame.Repositories;
public class GameRepository : IRepository<Game>
{
    private static IList<Game> Entities { get; }

    static GameRepository()
    {
        Entities = new List<Game>();
    }

    public void Create(Game entity)
    {
        if (!Entities.Contains(entity))
            Entities.Add(entity);
    }

    public void Delete(int id)
    {
        var model = Entities.FirstOrDefault(e => e.Id == id);
        if (model != null)
            Entities.Remove(model);
    }

    public Game? Get(int id)
    {
        var model = Entities.FirstOrDefault(e => e.Id == id);
        return model;
    }

    public IEnumerable<Game> GetAll()
    {
        return Entities;
    }

    public void Update(Game entity)
    {
        var model = Entities.FirstOrDefault(e => e.Id == entity.Id);
        if (model != null)
        {
            model = entity;
        }
    }
}
