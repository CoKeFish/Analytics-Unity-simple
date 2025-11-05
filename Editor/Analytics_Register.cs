#if UNITY_EDITOR

using UnityEditor;

using MyCompany.ModuleSymbols;

namespace Marmary.Analytics

{

    // Registro de símbolos para Analytics
    // Este registro solo se ejecutará si MODULE_SYMBOLS_SYSTEM_ENABLED está definido

#if MODULE_SYMBOLS_SYSTEM_ENABLED

    [InitializeOnLoad]

    public static class Analytics_Register

    {

        static Analytics_Register()

        {

            var desc = new ModuleSymbolDescriptor

            {

                moduleName = "Analytics",

                options = new SymbolOption[]

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

