using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public interface ICreator
    {
        public Vehicle Create();
    }
}
