using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities.Contracts
{
    public static class HaveContract
    {
        public const string TABLE_NAME = "Have";

        public const string FK_COL_BOOKSHOP = BookShopContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + BookShopContract.COL_ID;

        public const string FK_COL_BOOK = BookContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + BookContract.COL_ID;
    }
}
