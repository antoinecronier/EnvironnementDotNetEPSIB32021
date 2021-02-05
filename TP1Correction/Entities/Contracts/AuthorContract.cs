using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities.Contracts
{
    public static class AuthorContract
    {
        public const string TABLE_NAME = "Author";

        public const string COL_ID = GeneralContract.DEFAULT_ID;

        public const string COL_FIRSTNAME = "firstname";
        public const string COL_LASTNAME = "lastname";
    }
}
