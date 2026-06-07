public class LMSConfigurationManager
{
    private static LMSConfigurationManager instance;

    public string InstituteName { get; set; }
    public string Version { get; set; }
    public string AdminContact { get; set; }

    private LMSConfigurationManager()
    {
        InstituteName = "ABC Training Institute";
        Version = "1.0";
        AdminContact = "admin@abc.com";
    }

    public static LMSConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new LMSConfigurationManager();
        }

        return instance;
    }
}