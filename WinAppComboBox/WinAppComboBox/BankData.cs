using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppComboBox
{
    public class BankData
    {
        public BankData()
        {
            BankList = new List<Bank>()
            {
                new Bank{ BankCode = "001" },                
                new Bank{ BankCode = "002" },
                new Bank{ BankCode = "003" }
            };

        }
        public List<Bank> BankList  { get; set; }


    }
}
