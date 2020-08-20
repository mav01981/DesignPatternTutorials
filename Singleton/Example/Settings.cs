using System.Text;

namespace Singleton.Example
{
    public class Settings
    {
        public string DatabaseConnectionString { get; set; } = "";
        public string ProcessFolder { get; set; }
        public string SaveFolder { get; set; }

        public override string ToString() =>
           new StringBuilder()
           .AppendLine(DatabaseConnectionString)
           .AppendLine(ProcessFolder)
           .AppendLine(SaveFolder)
           .ToString();
    }
}
