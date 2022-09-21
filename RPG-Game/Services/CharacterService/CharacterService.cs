using RPG_Game.CoreEntities;

namespace RPG_Game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{ Id = 1 , Name = "Mokoena", Class = RpgClass.MAGE },
            new Character{ Id = 2 , Name = "Tumelo", Class = RpgClass.CLERIC }

        };
        public async Task<ServiceResponse<List<Character>>> CreateCharacter(Character character)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(character);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>>() { Data = characters};
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }
    }
}
