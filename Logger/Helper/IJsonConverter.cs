namespace Logger.Helper
{
    public interface IJsonConverter
    {
        T Deserialize<T>() where T : class;
    }
}