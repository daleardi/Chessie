﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Chessie")>]
[<assembly: AssemblyProductAttribute("Chessie")>]
[<assembly: AssemblyDescriptionAttribute("Railway-oriented programming for .NET")>]
[<assembly: AssemblyVersionAttribute("0.4.0")>]
[<assembly: AssemblyFileVersionAttribute("0.4.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.4.0"
