namespace Model.Interfaces
{
    public interface ICsvSerializable 
    {    
        string GetCsvHeader();

        void WriteCsv(string i_FilePath);
    } 
}