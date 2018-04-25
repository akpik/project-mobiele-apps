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

        private void LoadFotos()
        {

        }
        private void LoadGezinnen()
        {

        }
        private void LoadHoeken()
        {

        }
        private void LoadKlassen()
        {

        }
        private void LoadKleuters()
        {

        }
        private void LoadLeerkrachten()
        {

        }
        private void LoadScholen()
        {

        }
    }
}
