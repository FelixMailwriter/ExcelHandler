namespace ExcelHandler
{
    public interface Operation
    {
        bool  doCompare(string param1, string param2, string parameter);
        string getDescription();
    }
}