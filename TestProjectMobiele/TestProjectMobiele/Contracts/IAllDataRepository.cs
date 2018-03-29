using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProjectMobiele.Models;

namespace TestProjectMobiele.Contracts
{
    public interface IAllDataRepository
    {
        Task<List<Kleuter>> GetKleutersAsync(string klascode);


        
    }
}
