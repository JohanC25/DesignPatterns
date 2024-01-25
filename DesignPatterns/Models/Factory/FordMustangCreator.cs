using DesignPatterns.Models.Builder;
using DesignPatterns.Models;

namespace DesignPatterns.Models.Factory
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder.Build();
        }
    }
}
