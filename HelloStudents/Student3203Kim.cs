using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    internal class Student3203Kim : StudentBase
    {
        public override string Hello()
        {
            return "안녕하세요? 저는 " + this + "입니다!";
        }
    }
}
