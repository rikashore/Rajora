using Rajora.Models;

namespace Rajora.Entities.Player
{
    public class Player : RajoraEntity<PlayerJsonModel>
    {
        public string Name => Model.Name;

        internal Player(PlayerJsonModel model)
            : base(model)
        { }
    }
}