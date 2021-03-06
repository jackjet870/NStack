﻿#region header

// <copyright file="ConfigurationAspect.cs" company="mikegrabski.com">
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

namespace NStack.Configuration
{
    /// <summary>
    /// A base type for <see cref="IConfigurationAspect"/> implementations.
    /// </summary>
    public abstract class ConfigurationAspect : IConfigurationAspect
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        protected ConfigurationAspect(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the application configuration.
        /// </summary>
        protected IConfiguration Configuration { get; private set; }

        /// <summary>
        /// Gets the configuration environment.
        /// </summary>
        protected IConfigurationEnvironment Environment
        {
            get { return Configuration.Environment; }
        }

        #region Implementation of IConfigurationAspect

        /// <summary>
        ///     Builds the configuration for the aspect.
        /// </summary>
        public void Build()
        {
            Configure();
            ConfigureContainer(Configuration.ContainerRegistry);
        }

        #endregion

        /// <summary>
        /// Where any configuration for the aspect should be done prior to configuring the adapter.
        /// </summary>
        protected abstract void Configure();

        /// <summary>
        /// Configures the container with any services resulting from the configuration.
        /// </summary>
        /// <param name="registry"></param>
        protected abstract void ConfigureContainer(IContainerRegistry registry);
    }
}