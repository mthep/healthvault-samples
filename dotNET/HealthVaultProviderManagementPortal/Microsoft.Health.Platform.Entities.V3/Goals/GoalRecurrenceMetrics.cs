﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Health.Platform.Entities.V3.Goals
{
    using Microsoft.Health.Platform.Entities.V3.Enums;

    /// <summary>
    /// The recurrence metrics for a goal.
    /// </summary>
    public class GoalRecurrenceMetrics
    {
        /// <summary>
        /// Specifies the recurrence window of the goal
        /// </summary>
        public GoalRecurrenceType WindowType { get; set; }

        /// <summary>
        /// Specifies the number of times the goal's target is intended to be achieved in given window
        /// For example, the goal "walk 5000 steps, 4 times per week" would be represented as: a window of a "week", an occurrence count of 4, and a goal target of 5000.
        /// </summary>
        public int? OccurrenceCount { get; set; }
    }
}