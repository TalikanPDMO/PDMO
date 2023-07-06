using Intersect.Enums;

namespace Intersect.Config
{

    public class CombatOptions
    {

        public int BlockingSlow = 30; //Slow when moving with a shield. Default 30%

        public int CombatTime = 10000; //10 seconds

        public int MaxAttackRate = 200; //5 attacks per second

        public int MaxDashSpeed = 200;

        public int MinAttackRate = 500; //2 attacks per second

        public double AttackAnimationTimeRatio = 0.5;

        //Combat
        public int RegenTime = 3000; //3 seconds

        //A été mis à true par Moussmous pour décrire les actions de combats dans le chat
        public bool EnableCombatChatMessages = true; // Enables or disables combat chat messages.

        //Spells

        public int MaxDisplayNextSpells = 10; // To avoid infinite loop when displaying if design errors 

        /// <summary>
        /// If enabled this allows spell casts to stop/be canceled if the player tries to move around (WASD)
        /// </summary>
        public bool MovementCancelsCast = false;

        // Cooldowns

        /// <summary>
        /// Configures whether cooldowns within cooldown groups should match.
        /// </summary>
        public bool MatchGroupCooldowns = true;

        /// <summary>
        /// Only used when <seealso cref="MatchGroupCooldowns"/> is enabled!
        /// Configures whether cooldowns are being matched to the highest cooldown within a cooldown group when true, or are matched to the current item or spell being used when false.
        /// </summary>
        public bool MatchGroupCooldownHighest = true;

        /// <summary>
        /// Only used when <seealso cref="MatchGroupCooldowns"/> is enabled!
        /// Configures whether cooldown groups between items and spells are shared.
        /// </summary>
        public bool LinkSpellAndItemCooldowns = true;

        /// <summary>
        /// Configures whether or not using a spell or item should trigger a global cooldown.
        /// </summary>
        public bool EnableGlobalCooldowns = false;

        /// <summary>
        /// Configures the duration (in milliseconds) which the global cooldown lasts after each ability.
        /// Only used when <seealso cref="EnableGlobalCooldowns"/> is enabled!
        /// </summary>
        public int GlobalCooldownDuration = 1500;

        /// <summary>
        /// Configures the maximum distance a target is allowed to be from the player when auto targetting.
        /// </summary>
        public int MaxPlayerAutoTargetRadius = 15;

        public double[][] TableElementalTypes = new double[][]
        {
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,}
        };

        public double[][] TrueTableElementalTypes = new double[][]
        {
            new double [] {1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 0.5, 2.0, 0.5, 1.0, 1.0, 0.5, 2.0, 0.5, 0.5, 0.5, 0.5, 0.0, 0.5, 0.5, 2.0, 1.0, 1.0, 0.5,},
            new double [] {1.0, 1.0, 0.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0, 0.5, 2.0,},
            new double [] {1.0, 1.0, 1.0, 2.0, 0.5, 0.5, 2.0, 0.5, 2.0, 1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 0.5, 1.0, 1.0, 0.5, 2.0, 1.0, 0.5, 0.5, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 0.5, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5,},
            new double [] {1.0, 2.0, 0.5, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0,},
            new double [] {1.0, 0.5, 1.0, 1.0, 2.0, 1.0, 0.5, 0.5, 0.5, 0.5, 1.0, 0.5, 1.0, 1.0, 2.0, 2.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 2.0, 2.0, 1.0, 1.0, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0, 2.0,},
            new double [] {1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 1.0, 1.0, 0.5, 0.5, 1.0, 2.0, 2.0, 2.0, 1.0, 0.5, 2.0, 1.0, 1.0, 0.5, 1.0, 1.0, 2.0,},
            new double [] {1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 0.5, 1.0, 0.5, 0.5, 2.0, 1.0, 2.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 2.0, 2.0, 1.0,},
            new double [] {1.0, 2.0, 2.0, 1.0, 2.0, 1.0, 1.0, 0.5, 1.0, 1.0, 0.5, 2.0, 0.5, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5,},
            new double [] {1.0, 1.0, 1.0, 1.0, 2.0, 0.0, 1.0, 1.0, 2.0, 1.0, 1.0, 2.0, 0.5, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0,},
            new double [] {1.0, 1.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 0.0, 1.0, 0.5, 1.0, 1.0, 1.0, 2.0, 2.0, 1.0,},
            new double [] {1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 0.0, 1.0, 1.0, 0.5, 0.5, 1.0,},
            new double [] {1.0, 1.0, 0.5, 1.0, 1.0, 2.0, 1.0, 1.0, 2.0, 0.5, 1.0, 0.5, 1.0, 1.0, 2.0, 0.0, 1.0, 1.0, 1.0,}
        };

    }

}
