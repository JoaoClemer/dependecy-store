using DependencyStore.Models;

namespace DependencyStore.Repositories.Contract
{
    public interface IPromoCodeRepository
    {
        Task<PromoCode?> GetPromoCodeAsync(string promoCode);
    }
}
