#if UNITY_EDITOR

using Marmary.Utils.Editor.ModuleSymbols;
using UnityEditor;

namespace Marmary.Analytics.Editor

{


#if MODULE_SYMBOLS_SYSTEM_ENABLED

    /// <summary>
    /// Provides functionality for registering analytics-related components within the Marmary.Analytics namespace.
    /// </summary>
    /// <remarks>
    /// This static class is initialized automatically through Unity's editor process
    /// and is part of the Marmary.Analytics module. It is designed to handle tasks related
    /// to analytics registration.
    /// </remarks>
    [InitializeOnLoad]

    public static class AnalyticsRegister

    {
        /// <summary>
        /// Registers the "Analytics" module and its associated conditional compilation symbols into the
        /// <see cref="ModuleSymbolRegistry"/> at editor initialization.
        /// </summary>
        /// <remarks>
        /// The "Analytics" module provides support for integrating analytics features using Unity Services.
        /// This registration defines a symbol, "ANALYTICS_ENABLED", that can be enabled or disabled
        /// to toggle analytics functionality in the project. The default setting for this symbol is disabled.
        /// </remarks>
        static AnalyticsRegister()

        {

            var desc = new ModuleSymbolDescriptor

            {

                ModuleName = "Analytics",

                Options = new[]

                {

                    new SymbolOption { symbol = "ANALYTICS_ENABLED", description = "Habilita el sistema de analytics con Unity Services", enabledByDefault = false }

                }

            };

            ModuleSymbolRegistry.Register(desc);

        }

    }

#endif

}

#endif

