public class Database
{
    private static Database instance;
    public string connect;
    public string command;

    private Database()
    {
        this.connect = "db:load";
    }

    public static Database GetInstance()
    {
        if (instance == null)
            instance = new Database();

        return instance;
    }

    public void query(string sql)
    {
        this.command=$"{this.connect} {sql}";
        Console.WriteLine($"perform {sql}");
    }
}
