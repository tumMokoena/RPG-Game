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
        public async Task<List<Character>> CreateCharacter(Character character)
        {
            characters.Add(character);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
