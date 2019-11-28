using System;
using System.Collections;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = new Answers();
            answers.Demonstrate(Method.ToString);
        }
    }

    enum Method
    {
        ToUpper,
        ToLower,
        Trim,
        GetIndex,
        Substring,
        Replace,
        NullTest,
        SplitAndJoin,
        ToString
    }

}

