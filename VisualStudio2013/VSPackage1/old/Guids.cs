// Guids.cs
// MUST match guids.h
using System;

namespace Company.VSPackage1
{
    static class GuidList
    {
        public const string guidVSPackage1PkgString = "69ced282-803b-4eaf-9e76-ce0579e088cb";
        public const string guidVSPackage1CmdSetString = "0e28f1ad-ab98-434a-b42f-9dd452ca043d";
        public static readonly Guid guidVSPackage1CmdSet = new Guid(guidVSPackage1CmdSetString);
    };
}