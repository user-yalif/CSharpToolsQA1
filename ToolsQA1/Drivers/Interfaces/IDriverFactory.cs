namespace ToolsQA1.Drivers.Interfaces
{
    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(string browserType);
    }
}
