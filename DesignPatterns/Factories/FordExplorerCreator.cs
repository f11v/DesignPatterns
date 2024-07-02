using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerCreator
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder
                   .setModel("Explorer")
                    .Build();
        }

    }
}
