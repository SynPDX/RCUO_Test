using Server;
using System;

namespace Server.Items
{
    public class RobeBearingTheCrestOfBlackthorn1 : Robe
    {
        public override bool IsArtifact { get { return true; } }
        
        [Constructable]
        public RobeBearingTheCrestOfBlackthorn1()
            : base()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.BonusHits = 3;
            Attributes.BonusInt = 5;
            Hue = 2075;
        }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public RobeBearingTheCrestOfBlackthorn1(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}