using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionEditor
{
    class question
    {
        public int typeOfDifficult { get; set; }
        public string mTitle { get; set; }
        public string mAnswer { get; set; }
        public int mRezult { get; set; }
        public string _mRezult { get; set; }

        public override string ToString()
        {
            return typeOfDifficult + "|" + mTitle + "|" + mAnswer + "|" + mRezult + "|";
        }
    }
}
