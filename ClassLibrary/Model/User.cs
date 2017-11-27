using System;

namespace ClassLibrary.Model
{
    public class User
    {
        public static readonly int bartender = 1;
        public static readonly int admin = 2;

        private long id;
        private String login;
        private String password;
        private int permission;

        public long Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Permission { get => permission; set => permission = value; }
    }
}
