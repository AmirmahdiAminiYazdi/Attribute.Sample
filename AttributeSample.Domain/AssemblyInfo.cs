﻿using Attribute.Sample.CustomAttributes;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyCopyright("My copyright")]
[assembly: InternalsVisibleTo("Attribute.Sample.Core.Domain.Test")]
[assembly:AutoScanForDependency]
