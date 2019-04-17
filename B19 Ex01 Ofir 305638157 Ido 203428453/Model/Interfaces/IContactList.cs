namespace Model.Interfaces
{
    public interface IContactList 
    {    
        string GetCsvHeader();
        void MakeCsvFromContactList(string i_FilePath);
    } 
}