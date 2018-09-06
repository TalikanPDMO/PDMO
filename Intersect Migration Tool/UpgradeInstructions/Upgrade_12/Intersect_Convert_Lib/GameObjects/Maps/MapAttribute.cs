﻿using System;
using System.Collections.Generic;
using Intersect.Migration.UpgradeInstructions.Upgrade_12.Intersect_Convert_Lib.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Intersect.Migration.UpgradeInstructions.Upgrade_12.Intersect_Convert_Lib.GameObjects.Maps
{
    public class Attribute
    {
        public MapAttributes Type { get; set; }

        //Special Flags
        public AttributeItemFlags Item { get; set; }
        public AttributeZDimensionFlags ZDimension { get; set; }
        public AttributeWarpFlags Warp { get; set; }
        public AttributeSoundFlags  Sound { get; set; }
        public AttributeResourceFlags Resource { get; set; }
        public AttributeAnimationFlags Animation { get; set; }
        public AttributeSlideFlags Slide { get; set; } 

        public Attribute()
        {
            
        }

        public static Attribute CreateAttribute(MapAttributes type)
        {
            var att = new Attribute();
            att.Type = type;
            switch (type)
            {
                case MapAttributes.Walkable:
                    return null;
                case MapAttributes.Blocked:
                    break;
                case MapAttributes.Item:
                    att.Item = new AttributeItemFlags();
                    break;
                case MapAttributes.ZDimension:
                    att.ZDimension = new AttributeZDimensionFlags();
                    break;
                case MapAttributes.NpcAvoid:
                    break;
                case MapAttributes.Warp:
                    att.Warp = new AttributeWarpFlags();
                    break;
                case MapAttributes.Sound:
                    att.Sound = new AttributeSoundFlags();
                    break;
                case MapAttributes.Resource:
                    att.Resource = new AttributeResourceFlags();
                    break;
                case MapAttributes.Animation:
                    att.Animation = new AttributeAnimationFlags();
                    break;
                case MapAttributes.GrappleStone:
                    break;
                case MapAttributes.Slide:
                    att.Slide = new AttributeSlideFlags();
                    break;
            }
            return att;
        }

        public Attribute(string json)
        {
            Load(json);
        }

        public string Data()
        {
            var serializationSettings = new JsonSerializerSettings();
            serializationSettings.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
            serializationSettings.NullValueHandling = NullValueHandling.Ignore;

            //Not sure how to clear out the empty stuff
            var jObject = JObject.FromObject(this, JsonSerializer.Create(serializationSettings));
            
            var keystoRemove = new List<string>();
            foreach (var key in jObject)
            {
                if (key.Value.Type == JTokenType.Object && !key.Value.HasValues)
                {
                    keystoRemove.Add(key.Key);
                }
            }
            foreach (var key in keystoRemove)
                jObject.Remove(key);

            return JsonConvert.SerializeObject(jObject, serializationSettings);
        }

        public void Load(string json)
        {
            JsonConvert.PopulateObject(json, this);
        }
    }

    public class AttributeItemFlags
    {
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class AttributeZDimensionFlags
    {
        public int GatewayTo { get; set; }
        public int BlockedLevel { get; set; }
    }

    public class AttributeWarpFlags
    {
        public Guid MapId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public WarpDirection Direction { get; set; } = WarpDirection.Retain;
    }

    public class AttributeSoundFlags
    {
        public string File { get; set; }
        public int Distance { get; set; }
    }

    public class AttributeResourceFlags
    {
        public Guid ResourceId { get; set; }
        public int SpawnLevel { get; set; }
    }

    public class AttributeAnimationFlags
    {
        public Guid AnimationId { get; set; }
    }

    public class AttributeSlideFlags
    {
        public byte Direction { get; set; }
    }
}