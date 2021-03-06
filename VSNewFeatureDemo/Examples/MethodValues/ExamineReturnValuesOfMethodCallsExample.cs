﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VSNewFeatureDemo.Examples.MethodValues
{
    class ExamineReturnValuesOfMethodCallsExample : IExample
    {
        public void Show()
        {
            // 1. Set a breakpoint here
            Method1();
            // 2. Then step into Method1 
            // 3. Set a breakpoint here
            int y = Method2();
            // 4. Then step into Method2 
        }

        static void Method1()
        {
            // 1. Step over the following line
            int result = Multiply(FourTimes(Five()), Six());
            // 2. Then view the return values in the Autos window
        }

        static int Method2()
        {
            // 1. Step over the following line
            return Five();
            // 2. Then view the return values in the Autos window
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int FourTimes(int x)
        {
            return 4 * x;
        }

        static int Five()
        {
            return 5;
        }

        static int Six()
        {
            return 6;
        }
    }
}
