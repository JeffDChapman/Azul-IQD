using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulIQD{

    public partial class InputName : Form
    {

        private int tbnameLen;
        private string rightMostL;
        private bool namePluralized;
        private string workingAlias;
        private string thirdchar;
        private int hasUnderscore;
        private int chkForVowel;
        private string secPartName;
        private int secPartLen;
        private string vowelList;
        private bool flag1und;
        private int anotherUnd;

        public string SuggestAlias(string tableToAlias)
        {
            namePluralized = false;
            vowelList = "aeiou";
            flag1und = false;

            tbnameLen = tableToAlias.Length;
            rightMostL = tableToAlias.Substring(tbnameLen - 1, 1);
            if (rightMostL.ToLower() == "s") { namePluralized = true; }
            if (namePluralized) { tbnameLen--; }

            if (tbnameLen < 6)
            {
                return tableToAlias.Substring(0, 1);
            }

            hasUnderscore = tableToAlias.IndexOf("_");
            if (hasUnderscore < 0)
            {
                workingAlias = tableToAlias.Substring(0, 2);
                chkForVowel = 2;
            }
            else
            {
                flag1und = true;
                workingAlias = tableToAlias.Substring(0, 1);
                workingAlias += tableToAlias.Substring(hasUnderscore + 1, 1);

                secPartName = tableToAlias.Substring(hasUnderscore + 1);
                secPartLen = secPartName.Length;
                if (namePluralized) { secPartLen--; }
                if (secPartLen < 6)
                {
                    return workingAlias;
                }
                chkForVowel = hasUnderscore + 2;
            }

            anotherUnd = tableToAlias.IndexOf("_", hasUnderscore + 1);
            if (flag1und && (anotherUnd >= 0))
            {
                workingAlias += tableToAlias.Substring(anotherUnd + 1, 1);
                if (namePluralized) { workingAlias += "s"; }
                return workingAlias;
            }

            thirdchar = tableToAlias.Substring(chkForVowel, 1);
            if (vowelList.IndexOf(thirdchar) < 0)
            { workingAlias += thirdchar; }
            else
            { workingAlias += tableToAlias.Substring(chkForVowel + 1, 1); }

            if (namePluralized) { workingAlias += "s"; }

            return workingAlias;

        }
    }
}