// Guids.cs
// MUST match guids.h
using System;

namespace MMaitre.BitmapVisualizer
{
    static class GuidList
    {
        public const string guidBitmapVisualizerPkgString = "36C67B11-038B-4D2B-ACCB-C42A54E0F5C0";
        public const string guidBitmapVisualizerCmdSetString = "66ec591e-3b2b-4af3-b28b-52ba1b44f4df";

        public static readonly Guid guidBitmapVisualizerCmdSet = new Guid(guidBitmapVisualizerCmdSetString);
    };
}