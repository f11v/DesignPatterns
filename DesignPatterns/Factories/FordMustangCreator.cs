using DesignPatterns.Infraestructure.FactoryMethod;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangCreator : ICreator
    {
        public Vehicle Create ()
        {
            var builder = new CarModelBuilder();
            return builder
                .setModel("Mustang")
                .setColor("Red")
                .Build();
        }
    }
}
