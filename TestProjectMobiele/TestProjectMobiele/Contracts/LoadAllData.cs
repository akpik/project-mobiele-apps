using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TestProjectMobiele
{
    public class LoadAllData
    {
        public AllDataRepository AllData;
        public LoadAllData()
        {
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
        public void LoadGezinnen()
        {
            Gezin item = new Gezin
            {
                GezinsCode = "Awesome item",
                Email = "blabla"
            };
            App.MobileService.GetSyncTable("tblGezin");
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
