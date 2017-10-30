using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x26BF, 0x26C9 )]
	public class Halloween2017DoubleBladedStaff : BaseSpear
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }

		public override int AosStrengthReq{ get{ return 50; } }
		public override int AosMinDamage{ get{ return 12; } }
		public override int AosMaxDamage{ get{ return 13; } }
		public override int AosSpeed{ get{ return 49; } }
		public override float MlSpeed{ get{ return 2.25f; } }

		public override int OldStrengthReq{ get{ return 50; } }
		public override int OldMinDamage{ get{ return 12; } }
		public override int OldMaxDamage{ get{ return 13; } }
		public override int OldSpeed{ get{ return 49; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 80; } }

		[Constructable]
		public Halloween2017DoubleBladedStaff() : base( 0x26BF )
		{
			Weight = 2.0;
			WeaponAttributes.HitLeechHits = 8;
			HalloweenDoubleBladedStaffHue();
		}
		public virtual void HalloweenDoubleBladedStaffHue()
        {
                switch (Utility.Random(4))
                {
                    case 0: Hue=(48); Name=("Halloween Double Bladed Staff"); break;
                    case 1: Hue=(0); Name=("Halloween Double Bladed Staff"); break;
                    case 2: Hue=(1175); Name=("Halloween Double Bladed Staff"); break;
                    case 3: Hue=(0); Name=("Halloween Double Bladed Staff"); break;
                }
        }
		public Halloween2017DoubleBladedStaff( Serial serial ) : base( serial )
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

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}