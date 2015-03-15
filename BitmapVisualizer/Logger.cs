using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMaitre.BitmapVisualizer
{
    static class Logger
    {
        internal static void EnterMethod(object obj, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            Debug.WriteLine("[ {0}.{1}", obj.GetType().ToString(), memberName);
        }

        internal static void ExitMethod(object obj, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            Debug.WriteLine("] {0}.{1}", obj.GetType().ToString(), memberName);
        }

        internal static void ExitMethodWithMessage(object obj, string message, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            Debug.WriteLine("] {0}.{1}: {2}", obj.GetType().ToString(), memberName, message);
        }

        internal static void Message(object obj, string message, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            Debug.WriteLine("- {0}.{1}: {2}", obj.GetType().ToString(), memberName, message);
        }
    }
}
