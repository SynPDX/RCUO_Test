using System;
using Server;

namespace Server.Items
{
	public class CaptainsShield : BaseShield
	{
		public override int BasePhysicalResistance{ get{ return 4; } }
		public override int BaseFireResistance{ get{ return 2; } }
		public override int BaseColdResistance{ get{ return 1; } }
		public override int BasePoisonResistance{ get{ return 2; } }
		public override int BaseEnergyResistance{ get{ return 3; } }

		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 200; } }

		public override int AosStrReq{ get{ return 90; } }

		public override int ArmorBase{ get{ return 28; } }

		[Constructable]
		public CaptainsShield() : base( 0x2B01 )
		{
			Weight = 10.0;
			Hue = 1154;
			Name = "Captain Garden's Shield";
			Attributes.SpellChanneling = (1);
			Attributes.ReflectPhysical = (5);
			Attributes.Luck = (100);
		}

		public CaptainsShield( Serial serial ) : base(serial)
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
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );//version
		}
	}
}
