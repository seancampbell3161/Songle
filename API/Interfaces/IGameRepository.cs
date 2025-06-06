using API.Data.Entities;
using API.DTOs;

namespace API.Interfaces;

public interface IGameRepository
{
    Task<int?> AddUserGuessAsync(UserGuessDto guess);
    Task AddUserScoreAsync(UserResultDto result);
    Task<UserScoreDto> GetUserScoreAsync(string userId);
    Task<List<UserScoreDto>> GetHighScoresAsync();
    Task<SongOfTheDay?> GetSongOfTheDayAsync();
    Task<int> GetSongOfTheDaySongIdAsync();
    Task AddNewSongOfTheDayAsync();
    Task<bool> ValidateUserFinishedSongAsync(UserGuessDto userGuess);
}