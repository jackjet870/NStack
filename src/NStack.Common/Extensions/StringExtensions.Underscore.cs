﻿#region header

// <copyright file="StringExtensions.Underscore.cs" company="mikegrabski.com">
//    Copyright 2013 Mike Grabski
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>

#endregion

using System.Text;

namespace NStack.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     Returns a representation of the original string where Pascal-cased words are separated by underscores, and the whole thing is lower cased.
        /// </summary>
        /// <param name="original"> The original string. </param>
        /// <returns> </returns>
        public static string Underscore(this string original)
        {
            var buffer = new StringBuilder();

            for (int i = 0; i < original.Length; i++)
            {
                char c = original[i];

                if (char.IsLetterOrDigit(c)) buffer.Append(char.ToLower(c));

                if (i + 1 >= original.Length) continue;

                char next = original[i + 1];

                if ((!char.IsNumber(c) || !char.IsNumber(next)) && (char.IsUpper(next) || char.IsNumber(next)))
                    buffer.Append("_");
            }

            return buffer.ToString();
        }
    }
}