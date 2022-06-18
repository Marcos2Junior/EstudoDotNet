namespace SRP_Aderente
{
    internal class RegistraLog : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
