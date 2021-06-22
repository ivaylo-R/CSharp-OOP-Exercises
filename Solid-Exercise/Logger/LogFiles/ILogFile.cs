namespace LoggerProblem.Contracts
{
    public interface ILogFile
    {
        void Write(string msg);
        long Size { get; }  


    }
}
