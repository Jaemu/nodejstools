﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.NodejsTools.Npm {
    public class TokenEventArgs : EventArgs {

        public TokenEventArgs(
            string value,
            TokenFlags flags,
            int leadingEqualsCount) {
            Value = value;
            Flags = flags;
            LeadingEqualsCount = leadingEqualsCount;
        }

        public string Value { get; private set; }
        public TokenFlags Flags { get; private set; }
        public int LeadingEqualsCount { get; private set; }
    }
}
