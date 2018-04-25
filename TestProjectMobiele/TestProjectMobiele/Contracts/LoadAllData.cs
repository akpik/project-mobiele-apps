using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TestProjectMobiele
{
    class LoadAllData
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
