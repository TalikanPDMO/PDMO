using System;

namespace Discord
{
    static class Constants
    {
        public const string DllName = "discord_game_sdk";

        //Add management of 32/64 bits architecture to load the corresponding dll
        public const string DllName32bits = "x86/discord_game_sdk";
        public const string DllName64bits = "x64/discord_game_sdk";
    }
}
