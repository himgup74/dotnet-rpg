using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Services
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character>()
        {
                new Character(),
                new Character {Id = 1,Name = "Sam"},
                new Character {Name = "Tom",HitPoints=999},

        };

        public List<Character> Get()
        {
            return characters;
        }

        public  Character GetId(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id  );
        }

        public Character GetSingle()
        {
            return characters[2];
           
        }
    }
}