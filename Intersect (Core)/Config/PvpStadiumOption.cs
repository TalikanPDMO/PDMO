using System;

namespace Intersect.Config
{

    public class PvpStadiumOption
    {

        //PvpStadium
        public int StadiumUpdateInterval = 1000;
        public int MinRegistrationTime = 5000;
        public int AcceptMatchPopupTime = 15000;
        public int BeforeMatchTime = 20000;
        public int MaxMatchDuration = 300000;
        public int AfterMatchTime = 5000;


        // Preparations slots before starting the match
        public Guid StadiumPreparationMapId = Guid.Empty; // Empty by default, need to be change manually

        public int Location1_PreparationX = 0;
        public int Location1_PreparationY = 0;

        public int Location2_PreparationX = 3;
        public int Location2_PreparationY = 0;


        // Combat slots when the match starts
        public Guid StadiumCombatMapId = Guid.Empty; // Empty by default, need to be change manually

        public int Location1_CombatX = 1;
        public int Location1_CombatY = 0;

        public int Location2_CombatX = 2;
        public int Location2_CombatY = 0;
    }

}
