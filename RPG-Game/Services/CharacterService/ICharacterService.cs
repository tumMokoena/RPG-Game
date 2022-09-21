using RPG_Game.CoreEntities;

namespace RPG_Game.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> GetAllCharacters();
        Task<List<Character>> CreateCharacter(Character character);
    }
}
