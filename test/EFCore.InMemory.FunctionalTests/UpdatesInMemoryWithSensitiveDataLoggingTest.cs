// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if !Test20
using Microsoft.EntityFrameworkCore.InMemory.Internal;
#endif

namespace Microsoft.EntityFrameworkCore
{
    public class UpdatesInMemoryWithSensitiveDataLoggingTest : UpdatesInMemoryTestBase<UpdatesInMemoryWithSensitiveDataLoggingFixture>
    {
        public UpdatesInMemoryWithSensitiveDataLoggingTest(UpdatesInMemoryWithSensitiveDataLoggingFixture fixture)
            : base(fixture)
        {
        }

#if !Test20
        protected override string UpdateConcurrencyTokenMessage
            => InMemoryStrings.UpdateConcurrencyTokenExceptionSensitive("Product", "{Id: 984ade3c-2f7b-4651-a351-642e92ab7146}", "{Price: 3.49}", "{Price: 1.49}");
#endif
    }
}
