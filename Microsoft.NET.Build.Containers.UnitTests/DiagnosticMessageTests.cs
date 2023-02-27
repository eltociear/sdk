﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Microsoft.NET.Build.Containers.UnitTests
{
    public class DiagnosticMessageTests
    {
        [Fact]
        public void Error_ShouldCreateValidMessage()
        {
            string result = DiagnosticMessage.Error("code", "text");

            Assert.Equal("Containerize : error code : text", result);
        }

        [Fact]
        public void Warning_ShouldCreateValidMessage()
        {
            string result = DiagnosticMessage.Error("code", "text");

            Assert.Equal("Containerize : error code : text", result);
        }
    }
}
