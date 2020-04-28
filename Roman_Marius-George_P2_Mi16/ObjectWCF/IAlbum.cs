using System;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface IAlbum
    {
        [OperationContract]
        void Salvare(string adresa,  string persons, string eveniment, string locatie, string tip, DateTime creationDate);
        [OperationContract]
        void Sterge(string path);
        [OperationContract]
        object Afisare();
        [OperationContract]
        object AdaugaPersoaneLaId();
        [OperationContract]
        string SaveFile();
        [OperationContract]
        void EditData(string adresa, string eveniment, string persons, string loc);
        [OperationContract]
        string Cauta(string result, string eveniment, string persons, string locatie);
    }
}
