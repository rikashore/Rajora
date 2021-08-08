using Rajora.Models;

namespace Rajora.Entities
{
    public abstract class RajoraEntity<TModel> where TModel : BaseJsonModel
    {
        protected TModel Model { get; }

        protected RajoraEntity(TModel model)
        {
            Model = model;
        }
    }
}