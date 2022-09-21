using RPG_Game.CoreEntities;

namespace RPG_Game.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<List<Character>>> CreateCharacter(Character character);
    }
}
