namespace Model.Interfaces
{
    public interface ICsvSerializable 
    {    
        string GetCsvHeader();
        void MakeCsvFromContactList(string i_FilePath);
    } 
}