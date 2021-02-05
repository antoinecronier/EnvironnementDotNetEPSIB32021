using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities.Contracts
{
    public static class BuyContract
    {
        public const string TABLE_NAME = "Buy";

        public const string COL_ID = GeneralContract.DEFAULT_ID;

        public const string COL_PRICE = "price";

        public const string FK_COL_BOOK = BookContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + BookContract.COL_ID;
        public const string FK_COL_BOOKSHOP = BookShopContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + BookShopContract.COL_ID;
        public const string FK_COL_CUSTOMER = CustomerContract.TABLE_NAME + GeneralContract.WORD_DELIMITER + CustomerContract.COL_ID;
    }
}
