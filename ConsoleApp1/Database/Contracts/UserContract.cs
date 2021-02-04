using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database.Contracts
{
    public static class UserContract
    {
        public const String USER_TABLE = "user";
        public const String USER_ID = "id";
        public const String USER_FIRSTNAME = "firstname";
        public const String USER_LASTNAME = "lastname";

        public const String DATABASE_NAME_CONCAT = "_";

        public const String USER_COLUMN_ID = USER_TABLE + DATABASE_NAME_CONCAT + USER_ID;

        public const String USER_COLUMN_FIRSTNAME = USER_TABLE + DATABASE_NAME_CONCAT + USER_FIRSTNAME;

        public const String USER_COLUMN_LASTNAME = USER_TABLE + DATABASE_NAME_CONCAT + USER_LASTNAME;
    }
}
