using DesignPatterns.Models;
using DesignPatterns.Models.Builder;

namespace DesignPatterns.Models.Factory
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetModel("Explorer")
                .SetColor("Black")
                .Build();
        }
    }
}
