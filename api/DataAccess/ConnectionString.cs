namespace api.DataAccess
{
    public class ConnectionString
    {
        public string cs { get; set; }

        private string server="h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com:";

        private string port="3306";

        private string database="zl3i9yi1gn87k9o6";

        private string userName="erwqxfqip7qa13s3";

        private string password="suuewnfp46ipsqom";

        public ConnectionString()
        {
            cs = $"server={server};port={port};database={database};userName={userName};password={password};";
        }

    }
}