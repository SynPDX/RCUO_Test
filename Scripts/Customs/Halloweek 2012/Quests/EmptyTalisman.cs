using System;
using System.Collections;
using Server.Engines.Plants;
using Server.Engines.Quests;
using Server.Engines.Quests.Hag;
using Server.Engines.Quests.Matriarch;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    public class WTalismanTarget : Target
    {
        private EmptyTalisman m_Deed;

        public WTalismanTarget(EmptyTalisman deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is FeralHuman)
            {
                FeralHuman t = (FeralHuman)target;
				from.SendMessage( "The talisman bursts to life, glowing with the soul energy of a Werewolf." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new WolfTalisman() );
            }
            else
            {
				from.SendMessage( "This is not a Feral Human or Werewolf." );
            }
        }
    }
	public class EmptyTalisman : Item
	{
		[Constructable]
		public EmptyTalisman() : base( 0x2F5B )
		{
		Name = "An Empty Talisman";
		Weight = 5;
		Layer = Layer.Talisman;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The talisman glistens.");
                from.Target = new WTalismanTarget(this); // Call our target 
            }
        }
		public EmptyTalisman( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class FullTalisman : Item
	{
		[Constructable]
		public FullTalisman() : base( 0x2F5B )
		{
		Name = "Full Talisman";
		Weight = 5;
		Layer = Layer.Talisman;
		FTHue();
		}
		public virtual void FTHue()
        {
                switch (Utility.Random(10))
                {
                    case 0: Hue=(1159); break;
                    case 1: Hue=(1160); break;
                    case 2: Hue=(1161); break;
                    case 3: Hue=(1162); break;
                    case 4: Hue=(1163); break;
                    case 5: Hue=(1164); break;
                    case 6: Hue=(1170); break;
                    case 7: Hue=(1171); break;
                    case 8: Hue=(1172); break;
                    case 9: Hue=(1176); break;
                }
        }
		public FullTalisman( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}