using System;

namespace Intersect.Config
{

    public class PlayerOptions
    {

        /// <summary>
        /// A percentage between 0 and 100 which determines the chance in which they will lose any given item in their inventory when killed.
        /// </summary>
        public int ItemDropChance = 0;

        /// <summary>
        /// Number of bank slots a player has.
        /// </summary>
        public int MaxBank = 100;

        /// <summary>
        /// Number of characters an account may create.
        /// </summary>
        public int MaxCharacters = 1;

        /// <summary>
        /// Number of inventory slots a player has.
        /// </summary>
        public int MaxInventory = 35;

        /// <summary>
        /// Max level a player can achieve.
        /// </summary>
        public int MaxLevel = 100;

        /// <summary>
        /// Number of common spell slots a player has.
        /// </summary>
        public int MaxCommonSpells = 35;

        /// <summary>
        /// Number of ultimate spell slots a player has.
        /// </summary>
        public int MaxUltimateSpells = 1;

        /// <summary>
        /// The highest value a single stat can be for a player.
        /// </summary>
        public int MaxStat = 255;

        /// <summary>
        /// How long a player must wait before sending a trade/party/friend request after the first as been denied.
        /// </summary>
        public int RequestTimeout = 300000;

        /// <summary>
        /// Distance (in tiles) between players in which a trade offer can be sent and accepted.
        /// </summary>
        public int TradeRange = 6;

        /// <summary>
        /// Configures whether or not the level of a player is shown next to their name.
        /// </summary>
        public bool ShowLevelByName = false;

        /// <summary>
        /// First thanks for letting me share an idea, of losing XP when dying <3
        /// </summary>
        public int ExpLossOnDeathPercent = 0;

        /// <summary>
        /// If true, it will remove the associated exp, otherwise you will lose the exp based on the exp required to level up.
        /// </summary>
        public bool ExpLossFromCurrentExp = true;

        /// <summary>
        /// Max duration (in ms) that a player need to hold when pressing a direction if only want to turn and not to move
        /// </summary>
        public int TurnOnlyHeldDuration = 60;

        /// <summary>
        /// Amount of time (in ms) required to traverse 1 tile when a player is walking
        /// </summary>
        public int WalkingSpeed = 400;

        /// <summary>
        /// Coefficients for the 3 speeds formula : i0 - i2 * (x-i3) 
        /// </summary>
        public float[] SpeedFormulaCoeffs = {600, 25, 1, 300, 2.5f, 13, 230, 6, 41};

        public int MaxSpeedStat = 60;

        /// <summary>
        /// The id of the animation to use for the trail when a player is running horizontaly
        /// </summary>
        public Guid HorizontalRunningTrailAnimationId = Guid.Empty;

        /// <summary>
        /// The number of pixel we want to offset the animation from the center of the tile
        /// </summary>
        public int HorizontalRunningTrailOffset = 0;

        /// <summary>
        /// The id of the animation to use for the trail when a player is running verticaly
        /// </summary>
        public Guid VerticalRunningTrailAnimationId = Guid.Empty;

        /// <summary>
        /// The number of pixel we want to offset the animation from the center of the tile
        /// </summary>
        public int VerticalRunningTrailOffset = 0;

    }

}
