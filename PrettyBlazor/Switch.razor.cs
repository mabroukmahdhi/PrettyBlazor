﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under The Standard Software License (TSSL).
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace PrettyBlazor
{
    public partial class Switch<TValue> : ComponentBase
    {
        [Parameter]
        public TValue Value { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        internal bool HasMatchedCase { get; private set; }

        internal void NotifyMatched() =>
            this.HasMatchedCase = true;
    }
}
