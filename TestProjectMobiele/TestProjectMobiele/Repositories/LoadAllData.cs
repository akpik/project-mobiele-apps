using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TestProjectMobiele
{
    public class LoadAllData
    {
        private IDataConnection dbContext;

        public AllDataRepository AllData;

        public LoadAllData(IDataConnection dbContext)
        {
            this.dbContext = dbContext;
            if (AllData == null)
            {
                AllData = new AllDataRepository();
            }
            LoadFotos();
            LoadGezinnen();
            LoadHoeken();
            LoadKlassen();
            LoadKleuters();
            LoadLeerkrachten();
            LoadScholen();
        }

        public AllDataRepository GetAllData()
        {
            return AllData;
        }

        public void ResetAllData()
        {
            AllData = null;
            AllData = new AllDataRepository();
        }

        public void LoadFotos()
        {
            
        }
        public async Task<int> LoadGezinnen()
        {
            Gezin item = new Gezin
            {
                GezinsCode = "Awesome item",
                Email = "blabla"
            };
            await dbContext.Gezinnen.AddAsync(item);
            return await dbContext.SaveChangesAsync();
        }
        public void LoadHoeken()
        {

        }
        public void LoadKlassen()
        {

        }
        public void LoadKleuters()
        {

        }
        public void LoadLeerkrachten()
        {

        }
        public void LoadScholen()
        {

        }
    }
}
