namespace Abraks.Services.Admin.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Rewards;
    using Common.Admin.ViewModels.Rewards;

    public interface IAdminRewardService
    {
        Task<IEnumerable<RewardsViewModel>> GetRewards();

        Task<int> AddReward(RewardAddingBindingModel model);

        Task<RewardDetailsViewModel> GetRewardDetails(int id);
    }
}
