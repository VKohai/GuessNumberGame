using GuessNumberGame.Abstractions;
using GuessNumberGame.Entities;

namespace GuessNumberGame.Repositories;
public class PlayerRepository : IRepository<Player>
{
    private static IList<Player> Entities => new List<Player>();
    public Player? Get(int id)
    {
        var model = Entities.FirstOrDefault(x => x.Id == id);
        return model;
    }

    public IEnumerable<Player> GetAll()
    {
        return Entities;
    }

    public void Create(Player entity)
    {
        if (!Entities.Contains(entity))
            Entities.Add(entity);
    }

    public void Delete(int id)
    {
        var model = Entities.FirstOrDefault(p => p.Id == id);
        if (model != null)
        {
            Entities.Remove(model);
        }
    }

    public void Update(Player entity)
    {
        var model = Entities.FirstOrDefault(p => p.Id == entity.Id);
        if (model != null)
        {
            model = entity;
        }
    }
}
