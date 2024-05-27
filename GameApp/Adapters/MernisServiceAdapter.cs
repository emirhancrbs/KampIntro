using GameApp.Abstract;
using GameApp.Entites;
using MernisServiceReference;

namespace GameApp.Adapters
{
    internal class MernisServiceAdapter : IPlayerCheckService
    {
        public async Task<bool> CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName, player.LastName, player.DateOfBirth.Year);
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
