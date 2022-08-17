

using GestionDeTarjetas.Models.Encryption;

namespace GestionDeTarjetas.Models
{
    public class Inicialization
    {
        public PlataformaSecure PlataformaSecure { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public Inicialization(string server, string database, string user, string password)
        {
            PlataformaSecure = new PlataformaSecure();
            Server = server;
            Database = database;
            User = user;
            Password = password;
        }


        public string GetConnectionString()
        {
            return $"Server={Server};Database={Database};User={User};Password={PlataformaSecure.Decode(Password)}";
        }
    }
}
