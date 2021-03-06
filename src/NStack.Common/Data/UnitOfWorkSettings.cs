﻿#region header

// <copyright file="UnitOfWorkSettings.cs" company="mikegrabski.com">
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

namespace NStack.Data
{
    /// <summary>
    ///     A static type containing unit of work settings.
    /// </summary>
    public static class UnitOfWorkSettings
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        static UnitOfWorkSettings()
        {
            AutoCommit = true;
        }

        /// <summary>
        ///     Gets or sets whether or not a unit of work should be committed automatically when it is closed.
        /// </summary>
        public static bool AutoCommit { get; set; }
    }
}