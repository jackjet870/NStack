﻿#region header
// <copyright file="IContainerRegistry.cs" company="mikegrabski.com">
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

using System;

namespace NStack.Configuration
{
    /// <summary>
    /// A contract implemented by an adapter for a specific IoC container implementation.
    /// </summary>
    public interface IContainerRegistry
    {
        /// <summary>
        /// Registers an implementation of a service using an @delegate in the default scope.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation.</typeparam>
        /// <param name="delegate">The @delegate that will be invoked when the service needs to be resolved.</param>
        /// <param name="name">Optional name of hte service implementation.</param>
        void Register<TService, TImplementation>(Func<IResolver, TImplementation> @delegate, string name = null);

        /// <summary>
        /// Registers an implementation type of the specified service type in the default scope.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation.</typeparam>
        /// <param name="name">The name of the service implementation.</param>
        void Register<TService, TImplementation>(string name = null)
            where TImplementation : TService;

        /// <summary>
        /// Registers a generic implementation type of the specified generic service type in the default scope.
        /// </summary>
        /// <param name="service">The generic type of the service.</param>
        /// <param name="implementation">The generic type of the implementation.</param>
        /// <param name="name">The name of the service implementation.</param>
        void RegisterGeneric(Type service, Type implementation, string name = null);

        /// <summary>
        /// Registers a single instance of the implementation type for the specified service type.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation.</typeparam>
        /// <param name="name">The name of the service implementation.</param>
        void RegisterSingleInstance<TService, TImplementation>(string name = null)
            where TImplementation : TService;

        /// <summary>
        /// Registers a single instance of an instance as the specified type.
        /// </summary>
        /// <param name="type">The type the instance should be registered as.</param>
        /// <param name="instance">The service instance.</param>
        /// <param name="name">The name of the service instance.</param>
        void RegisterSingleInstance(Type type, object instance, string name = null);

        /// <summary>
        /// Registers an instance of the specified service type as the single instance.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation.</typeparam>
        /// <param name="instance">The service instance.</param>
        /// <param name="name">Optional name of the service implementation.</param>
        void RegisterSingleInstance<TService, TImplementation>(TImplementation instance, string name = null)
            where TImplementation : class, TService;

        /// <summary>
        /// Registers a single instance of the implementation type for the specified service type, where the implementation is constructed using the specified delegate.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <typeparam name="TImplementation">The implementation type.</typeparam>
        /// <param name="delegate">The delegate invoked to construct the implementation.</param>
        /// <param name="name">The name of the service implementation.</param>
        void RegisterSingleInstance<TService, TImplementation>(Func<IResolver, TImplementation> @delegate, string name = null)
            where TImplementation : TService;
    }
}