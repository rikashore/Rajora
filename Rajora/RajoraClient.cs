using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rajora
{
    public partial class RajoraClient
    {
        private readonly HttpClient _httpClient;

        public RajoraClient(string authToken)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.clashofclans.com/v1/")
            };

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        }

        #region Clans

        public Task<Clan> GetClanAsync(string clanTag)
        {
            return GetAsync<Clan>(ApiEndpoints.Clans.GetClan(clanTag));
        }

        public Task<List<Clan>> SearchClansAsync()
        {
            return GetAsync<List<Clan>>(ApiEndpoints.Clans.SearchClans());
        }

        public Task<ClanWarLeagueGroup> GetClanCurrentWarLeagueGroupAsync(string clanTag)
        {
            return GetAsync<ClanWarLeagueGroup>(ApiEndpoints.Clans.GetClanCurrentWarLeagueGroup(clanTag));
        }

        public Task<ClanWarLeagueGroup> GetClanWarLeagueWarAsync(string warTag)
        {
            return GetAsync<ClanWarLeagueGroup>(ApiEndpoints.Clans.GetClanLeagueWar(warTag));
        }

        public Task<List<ClanWarlogEntry>> GetClanWarLogAsync(string clanTag)
        {
            return GetAsync<List<ClanWarlogEntry>>(ApiEndpoints.Clans.GetClanWarlog(clanTag));
        }

        public Task<ClanCurrentWar> GetClanCurrentWar(string clanTag)
        {
            return GetAsync<ClanCurrentWar>(ApiEndpoints.Clans.GetClanCurrentWar(clanTag));
        }

        public Task<List<ClanMember>> GetClanMembersAsync(string clanTag)
        {
            return GetAsync<List<ClanMember>>(ApiEndpoints.Clans.GetClanMembers(clanTag));
        }

        #endregion

        #region Players

        public Task<Player> GetPlayerAsync(string playerTag)
        {
            return GetAsync<Player>(ApiEndpoints.Players.GetPlayer(playerTag));
        }

        public Task<PlayerTokenVerification> VerifyPlayerTokenAsync(string playerTag, string token)
        {
            var payload = JsonConvert.SerializeObject(new PlayerToken(token));
            return PostAsync<PlayerTokenVerification>(ApiEndpoints.Players.VerifyPlayerToken(playerTag), payload);
        }

        #endregion

        #region Goldpass

        public Task<CurrentSeasonGoldpass> GetCurrentSeasonGoldpassAsync()
        {
            return GetAsync<CurrentSeasonGoldpass>(ApiEndpoints.Goldpass.GetCurrentSeasonGoldpass());
        }

        #endregion

        #region Labels

        public Task<List<Label>> GetPlayerLabelsAsync()
        {
            return GetAsync<List<Label>>(ApiEndpoints.Labels.GetPlayerLabels());
        }

        public Task<List<Label>> GetClanLabelsAsync()
        {
            return GetAsync<List<Label>>(ApiEndpoints.Labels.GetClanLabels());
        }

        #endregion

        #region Locations

        public Task<List<ClanRanking>> GetClanRankingsByLocationAsync(string locationId)
        {
            return GetAsync<List<ClanRanking>>(ApiEndpoints.Locations.GetClanRankingByLocation(locationId));
        }

        public Task<List<PlayerRanking>> GetPlayerRankingsByLocationAsync(string locationId)
        {
            return GetAsync<List<PlayerRanking>>(ApiEndpoints.Locations.GetPlayerRankingByLocation(locationId));
        }

        public Task<List<ClanVersusRanking>> GetClanVersusRankingsByLocationAsync(string locationId)
        {
            return GetAsync<List<ClanVersusRanking>>(ApiEndpoints.Locations.GetClanVersusRankingByLocation(locationId));
        }

        public Task<List<PlayerVersusRanking>> GetPlayerVersusRankingsByLocationAsync(string locationId)
        {
            return GetAsync<List<PlayerVersusRanking>>(ApiEndpoints.Locations.GetPlayerVersusRankingByLocation(locationId));
        }

        public Task<List<Location>> GetLocationsAsync()
        {
            return GetAsync<List<Location>>(ApiEndpoints.Locations.GetLocations());
        }

        public Task<Location> GetLocationAsync(string locationId)
        {
            return GetAsync<Location>(ApiEndpoints.Locations.GetLocation(locationId));
        }

        #endregion

        #region Leagues

        public Task<List<League>> GetLeaguesAsync()
        {
            return GetAsync<List<League>>(ApiEndpoints.Leagues.GetLeagues());
        }

        public Task<League> GetLeagueAsync(string leagueId)
        {
            return GetAsync<League>(ApiEndpoints.Leagues.GetLeague(leagueId));
        }

        public Task<List<SeasonLeague>> GetLeagueSeasonRankingsAsync(string leagueId, string seasonId)
        {
            return GetAsync<List<SeasonLeague>>(ApiEndpoints.Leagues.GetLeagueSeasonRankings(leagueId, seasonId));
        }

        public Task<List<LeagueSeason>> GetLeagueSeasons(string leagueId)
        {
            return GetAsync<List<LeagueSeason>>(ApiEndpoints.Leagues.GetLeagueSeasons(leagueId));
        }

        public Task<Warleague> GetWarleagueAsync(string leagueId)
        {
            return GetAsync<Warleague>(ApiEndpoints.Leagues.GetWarleague(leagueId));
        }

        public Task<List<Warleague>> GetWarleaguesAsync()
        {
            return GetAsync<List<Warleague>>(ApiEndpoints.Leagues.GetWarleagues());
        }

        #endregion
    }
}