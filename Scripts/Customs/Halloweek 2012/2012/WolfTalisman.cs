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
	public class WolfTalisman : Item
	{
		[Constructable]
		public WolfTalisman() : base( 0x2F5B )
		{
		Name = "Wolf Talisman";
		Weight = 5;
		Layer = Layer.Talisman;
		WolfTalismanHue();
		}
		public override void OnDoubleClick( Mobile m )
		{
			if( Parent != m )
			{
				m.SendMessage( "You must wear the talisman to use its magic." );
			}
			else
			{
				if ( m.BodyMod == 0 )
				{
					m.SendMessage( "Your body convulses as you crumple to the ground." );
					IMount mount = m.Mount;

					if ( mount != null )
						mount.Rider = null;

					if ( m.Mounted )
						return;
					m.PlaySound( 0x0E6 );  //CHANGE SOUND
					m.HueMod = 0;
					switch (Utility.Random(9))
					{
						case 0: m.BodyMod=(0x17); break;
						case 1: m.BodyMod=(0x19); break;
						case 2: m.BodyMod=(0x1B); break;
						case 3: m.BodyMod=(0x22); break;
						case 4: m.BodyMod=(0x25); break;
						case 5: m.BodyMod=(0x63); break;
						case 6: m.BodyMod=(0x64); break;
						case 7: m.BodyMod=(0xD9); break;
						case 8: m.BodyMod=(0xE1); break;
					}
				}
				else if ( m.BodyMod != 0 )
				{
					m.SendMessage( "You scream as the fur receades back into your skin, your form expanding as you painfully stand up." );
					m.PlaySound( 0x569 );  //CHANGE SOUND
					m.BodyMod = 0;
					m.HueMod = -1;
				}
			}
		}
		public override void OnRemoved( Object o )
		{
			if( o is Mobile )
			{
				((Mobile)o).SendMessage( "You scream as the fur receades back into your skin, your form expanding as you painfully stand up." );
				((Mobile)o).PlaySound( 0x569 );  //CHANGE SOUND
				((Mobile)o).BodyMod = 0;
				((Mobile)o).NameMod = null;
				((Mobile)o).HueMod = -1;
			}
			if( o is Mobile && ((Mobile)o).Kills >= 5)
				{
					((Mobile)o).Criminal = true;
				}
			base.OnRemoved( o );
		}
		public virtual void WolfTalismanHue()
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
		public WolfTalisman( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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