using API_INTRO.Models;

namespace API_INTRO.Interfaces
{
    public interface IPizzaRepository
    {
        Pizza GetById(int id);
        List<Pizza> GetAll();
        bool Create(Pizza pizza);
        void Delete(int id);
    }
}
