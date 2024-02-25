using System;

using Intersect.Client.General;
using Intersect.Enums;

namespace Intersect.Client.Entities
{

    public partial class Status
    {
        public static int REMAINING_INFINITE = -11111;
        public string Data = "";

        public int[] Shield = new int[(int) Vitals.VitalCount];

        public Guid SpellId;

        public long TimeRecevied = 0;

        public long TimeRemaining = 0;

        public long TotalDuration = 1;

        public StatusTypes Type;

        public string SourceSpellName;

        public bool[] EffectiveStatBuffs = new bool[(int)Stats.StatCount];

        public Status(Guid spellId, StatusTypes type, string data, long timeRemaining, long totalDuration, string sourceSpellName, bool[] effectiveStatBuffs)
        {
            SpellId = spellId;
            Type = type;
            Data = data;
            TimeRemaining = timeRemaining;
            TotalDuration = totalDuration;
            TimeRecevied = Globals.System.GetTimeMs();
            SourceSpellName = sourceSpellName;
            if (effectiveStatBuffs != null)
            {
                EffectiveStatBuffs = effectiveStatBuffs;
            }
        }

        public bool IsActive()
        {
            return TotalDuration == -1 || RemainingMs() > 0;
        }

        public long RemainingMs()
        {
            if (TotalDuration == -1)
            {
                return REMAINING_INFINITE;
            }
            var timeDiff = Globals.System.GetTimeMs() - TimeRecevied;

            return TimeRemaining - timeDiff;
        }

    }

}
