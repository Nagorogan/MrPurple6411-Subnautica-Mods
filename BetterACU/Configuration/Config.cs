﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;

namespace BetterACU.Configuration
{
    [Menu("Better ACU", LoadOn = MenuAttribute.LoadEvents.MenuOpened | MenuAttribute.LoadEvents.MenuRegistered)]
    public class Config : ConfigFile
    {
        [Slider("Alien Containment Limit", 10, 100, Step = 1)]
        public int WaterParkSize = 10;

#if BZ
        [Slider("Large Room Alien Containment Limit", 20, 200, Step = 1)]
        public int LargeWaterParkSize = 20;
#endif
        [Slider("Overall Power Generation Multiplier", 1, 10, DefaultValue = 1, Step = 1)]
        public int PowerGenSpeed = 1;

        public Dictionary<TechType, float> CreaturePowerGeneration = new Dictionary<TechType, float>() {
#if SN1
            { TechType.Shocker, 2f },
            { TechType.CrabSquid, 1f },
            { TechType.GhostLeviathan, 10f },
            { TechType.GhostLeviathanJuvenile, 5f },
            { TechType.Warper, 1f }
#elif BZ
            { TechType.Jellyfish, 2f },
            { TechType.SquidShark, 1f }
#endif
        }; 

        public Dictionary<string, float> PowerValues = new Dictionary<string, float>();
    }
}
