// Guids.cs
// MUST match guids.h
using System;

namespace ShellApplication.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "d257e8f7-8829-43b8-bba5-290ae25600e3";
        public const string guidAboutBoxPackageCmdSetString = "c75895f1-997c-40cb-84aa-c2b1d5959a07";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}