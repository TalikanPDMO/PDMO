using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class MapPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public MapPacket()
        {
        }

        public MapPacket(
            Guid mapId,
            bool deleted,
            string data = null,
            byte[] tileData = null,
            byte[] attributeData = null,
            byte[] mapRegionIdsData = null,
            int revision = -1,
            int gridX = -1,
            int gridY = -1,
            bool[] borders = null
        )
        {
            MapId = mapId;
            Deleted = deleted;
            Data = data;
            TileData = tileData;
            AttributeData = attributeData;
            MapRegionsIdsData = mapRegionIdsData;
            Revision = revision;
            GridX = gridX;
            GridY = gridY;
            CameraHolds = borders;
        }

        [Key(0)]
        public Guid MapId { get; set; }

        [Key(1)]
        public bool Deleted { get; set; }

        [Key(2)]
        public string Data { get; set; }

        [Key(3)]
        public byte[] TileData { get; set; }

        [Key(4)]
        public byte[] AttributeData { get; set; }

        [Key(5)]
        public byte[] MapRegionsIdsData { get; set; }

        [Key(6)]
        public int Revision { get; set; }

        [Key(7)]
        public int GridX { get; set; }

        [Key(8)]
        public int GridY { get; set; }

        [Key(9)]
        public bool[] CameraHolds { get; set; }

        [Key(10)]
        public MapEntitiesPacket MapEntities { get; set; }

        [Key(11)]
        public MapItemsPacket MapItems { get; set; }

    }

}
