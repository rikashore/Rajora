using System;
using Rajora.Extensions;

namespace Rajora
{
    internal static class ApiEndpoints
    {
        internal static class Players
        {
            internal static Uri GetPlayer(string tag) => "players/{0}".FormatUri(tag);
            internal static Uri VerifyPlayerToken(string token) => "players/{0}/verifytoken".FormatUri(token);
        }

        internal static class Labels
        {
            internal static Uri GetPlayerLabels() => "labels/players".FormatUri();
            internal static Uri GetClanLabels() => "labels/clans".FormatUri();
        }

        internal static class Goldpass
        {
            internal static Uri GetCurrentSeasonGoldpass() => "goldpass/seasons/current".FormatUri();
        }

        internal static class Locations
        {
            internal static Uri GetClanRankingByLocation(string locationId) => "locations/{0}/rankings/clans".FormatUri(locationId);
            internal static Uri GetClanVersusRankingByLocation(string locationId) => "locations/{0}/rankings/clans-versus".FormatUri(locationId);

            internal static Uri GetPlayerRankingByLocation(string locationId) => "locations/{0}/rankings/players".FormatUri(locationId);
            internal static Uri GetPlayerVersusRankingByLocation(string locationId) => "locations/{0}/rankings/players-versus".FormatUri(locationId);

            internal static Uri GetLocations() => "locations".FormatUri();
            internal static Uri GetLocation(string locationId) => "locations/{0}".FormatUri(locationId);
        }

        internal static class Leagues
        {
            internal static Uri GetLeagues() => "leagues".FormatUri();
            internal static Uri GetLeague(string leagueId) => "leagues/{0}".FormatUri(leagueId);

            internal static Uri GetLeagueSeasonRankings(string leagueId, string seasonId) => "leagues/{0}/seasons/{1}".FormatUri(leagueId, seasonId);
            internal static Uri GetLeagueSeasons(string leagueId) => "leagues/{0}/seasons".FormatUri(leagueId);

            internal static Uri GetWarleagues() => "warleagues".FormatUri();
            internal static Uri GetWarleague(string leagueId) => "warleagues/{0}".FormatUri(leagueId);
        }

        internal static class Clans
        {
            internal static Uri GetClanCurrentWarLeagueGroup(string clanTag) => "clans/{0}/currentwar/leaguegroup".FormatUri(clanTag);
            internal static Uri GetClanLeagueWar(string warTag) => "clanwarleagues/wars/{0}".FormatUri(warTag);
            internal static Uri GetClanCurrentWar(string clanTag) => "clans/{0}/currentwar".FormatUri(clanTag);

            internal static Uri GetClanWarlog(string clanTag) => "clans/{0}/warlog".FormatUri(clanTag);

            internal static Uri SearchClans() => "clans".FormatUri();
            internal static Uri GetClan(string clanTag) => "clans/{0}".FormatUri(clanTag);

            internal static Uri GetClanMembers(string clanTag) => "clans/{0}/members".FormatUri(clanTag);
        }
    }
}