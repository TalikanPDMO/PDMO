using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Config
{
    public class ClashOfElementOptions
    {
        // ClashOfElement
        public int COEUpdateInterval = 1000;
        public int COEMinRegistrationTime = 5000;
        public int COEAcceptMatchPopupTime = 15000;
        public int COEBeforeMatchTime = 20000;
        public int COEMaxMatchDuration = 300000;
        public int COEAfterMatchTime = 5000;

        // Preparations slots before starting the match
        public Guid COEPreparationMapId = Guid.Empty;// TODO

        public int Location1_PreparationX = 0;
        public int Location1_PreparationY = 0;

        public int Location2_PreparationX = 3;
        public int Location2_PreparationY = 0;

        // Combat slots when the match starts
        public Guid CEOCombatMapId = Guid.Empty; // Empty by default, need to be change manually

        public int Location1_CombatX = 1;
        public int Location1_CombatY = 0;

        public int Location2_CombatX = 2;
        public int Location2_CombatY = 0;
    }
}
