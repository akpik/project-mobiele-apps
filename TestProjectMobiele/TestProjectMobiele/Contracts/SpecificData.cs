using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectMobiele
{
    public class SpecificData
    {
        LoadAllData loadData = new LoadAllData();
        AllDataRepository allData;

        public SpecificData()
        {
            allData = loadData.GetAllData();
        }

        public Foto getSpecificFoto(int fotoID)
        {
            Foto f = null;
            foreach (Foto foto in allData.AllFotos)
            {
                if (foto.FotoID == fotoID)
                {
                    f = foto;
                }
            }
            return f;
        }

        public Gezin getSpecificGezin(int gezinsID)
        {
            Gezin g = null;
            foreach (Gezin gezin in allData.AllGezins)
            {
                if (gezin.GezinsID == gezinsID)
                {
                    g = gezin;
                }
            }
            return g;
        }

        public Hoek getSpecificHoek(int hoekID)
        {
            Hoek h = null;
            foreach (Hoek hoek in allData.AllHoeken)
            {
                if (hoek.HoekID == hoekID)
                {
                    h = hoek;
                }
            }
            return h;
        }

        public Klas getSpecificKlas(int klasID)
        {
            Klas k = null;
            foreach (Klas klas in allData.AllKlassen)
            {
                if (klas.KlasID == klasID)
                {
                    k = klas;
                }
            }
            return k;
        }

        public Kleuter getSpecificKleuter(int kleuterID)
        {
            Kleuter k = null;
            foreach (Kleuter kleuter in allData.AllKleuters)
            {
                if (kleuter.KleuterID == kleuterID)
                {
                    k = kleuter;
                }
            }
            return k;
        }

        public Leerkracht getSpecificLeerkracht(string leerkrachtCode)
        {
            Leerkracht l = null;
            foreach (Leerkracht leerkracht in allData.AllLeerkrachten)
            {
                if (leerkracht.LeerkrachtCode == leerkrachtCode)
                {
                    l = leerkracht;
                }
            }
            return l;
        }

        public School getSpecificSchool(int schoolID)
        {
            School s = null;
            foreach (School school in allData.AllScholen)
            {
                if (school.SchoolID == schoolID)
                {
                    s = school;
                }
            }
            return s;
        }
    }
}
