using System;
using APIspace;
using ModelAndApi;


namespace ObjectWCF
{
    public class ModelAndApi : IAlbum
    {
        void IAlbum.Salvare(string adresa, string persons, string eveniment, string locatie, string tip, DateTime creationDate)
        {
            API api = new API();
            api.Salvare(adresa, persons, eveniment, locatie, tip, creationDate);
        }

        void IAlbum.Sterge(string path)
        {
            API api = new API();
            api.Sterge(path);
        }

        object IAlbum.Afisare()
        {
            API api = new API();
            return api.ShowGridData();
        }

        
       

        public void EditData(string adresa, string editEvent, string editPerson, string editLoc)
        {
            throw new NotImplementedException();
        }

        public object ShowData()
        {
            throw new NotImplementedException();
        }

        public string SaveFile()
        {
            throw new NotImplementedException();
        }

   

        public object AdaugaPersoaneLaId()
        {
            throw new NotImplementedException();
        }

      

        public string Cauta(string result, string eveniment, string persons, string locatie)
        {
            throw new NotImplementedException();
        }
    }
}
