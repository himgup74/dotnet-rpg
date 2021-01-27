using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
         public List<Character> Get();
         public Character GetSingle();
          public Character GetId(int id);
    }
}
