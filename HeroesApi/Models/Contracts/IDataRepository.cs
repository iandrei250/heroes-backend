using HeroesApi.Models;

namespace Models.Contracts;
public interface IDataRepository
{
    Task<IEnumerable<Hero>> GetAllAsync();
    Task<Hero?> GetAsync(long id);
    Task AddAsync(Hero entity);
    Task UpdateAsync(Hero entityToUpdate, Hero entity);
    Task DeleteAsync(Hero entity);
}