﻿#region header
// <copyright file="NullableArgumentBase.cs" company="mikegrabski.com">
//    Copyright 2012 Mike Grabski
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

using System;

using NStack.Annotations;

namespace NStack.Conditions
{
    public abstract class NullableArgumentBase<T, TThis> : ArgumentBase<T, TThis>
        where TThis : NullableArgumentBase<T, TThis>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        protected NullableArgumentBase(T value, string name) : base(value, name)
        {
        }


        /// <summary>
        /// Asserts that the specified argument is not null.
        /// </summary>
        /// <param name="message">The exception message.</param>
        [AssertionMethod]
        public TThis IsNotNull(string message = null)
        {
            if (Value.Equals(default(T))) throw new ArgumentNullException(Name, message);

            return (TThis)this;
        }

        /// <summary>
        /// Asserts that the specified argument is null.
        /// </summary>
        /// <param name="message">The exception message.</param>
        [AssertionMethod]
        public TThis IsNull(string message = null)
        {
            if (!(Value.Equals(default(T)))) throw new ArgumentNullException(Name, message);

            return (TThis)this;
        }
    }
}