using GSM.Core.Domain.Base;

namespace GSM.Core.Domain.Games
{
    public class Game : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public GameCategory Category { get; set; }

    }
}
