﻿// LogiFrame
// Copyright 2015 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using LogiFrame.Drawing;

namespace LogiFrame
{
    /// <summary>
    ///     Provides data for the <see cref="E:LogiFrame.LCDApp.Rendered" /> event.
    /// </summary>
    public class RenderedEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RenderedEventArgs" /> class.
        /// </summary>
        /// <param name="bitmap">The bitmap.</param>
        public RenderedEventArgs(MonochromeBitmap bitmap)
        {
            Bitmap = bitmap;
        }

        /// <summary>
        ///     Gets the rendered bitmap.
        /// </summary>
        public MonochromeBitmap Bitmap { get; }
    }
}