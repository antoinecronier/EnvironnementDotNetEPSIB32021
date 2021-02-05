using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities.Contracts
{
    public static class BookContract
    {
        public const string TABLE_NAME = "Book";

        public const string COL_ID = GeneralContract.DEFAULT_ID;

        public const string COL_NAME = "name";
        public const string COL_NBPAGE = "nb" + GeneralContract.WORD_DELIMITER + "page";

        public const string FK_COL_EDITOR = EditorContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + EditorContract.COL_ID;
        public const string FK_COL_CUSTOMER = CustomerContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + CustomerContract.COL_ID;
    }
}
