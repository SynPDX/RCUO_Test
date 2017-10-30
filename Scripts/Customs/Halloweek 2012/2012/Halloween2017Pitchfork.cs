using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0xE87, 0xE88 )]
	public class Halloween2017Pitchfork : BaseSpear
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }

		public override int AosStrengthReq{ get{ return 55; } }
		public override int AosMinDamage{ get{ return 13; } }
		public override int AosMaxDamage{ get{ return 14; } }
		public override int AosSpeed{ get{ return 43; } }
		public override float MlSpeed{ get{ return 2.50f; } }

		public override int OldStrengthReq{ get{ return 15; } }
		public override int OldMinDamage{ get{ return 4; } }
		public override int OldMaxDamage{ get{ return 16; } }
		public override int OldSpeed{ get{ return 45; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 60; } }

		[Constructable]
		public Halloween2017Pitchfork() : base( 0xE87 )
		{
			Weight = 11.0;
			Attributes.AttackChance = 15;
			Attributes.WeaponDamage = 50;
			HalloweenPitchforkHue();
		}
		public virtual void HalloweenPitchforkHue()
        {
                switch (Utility.Random(4))
                {
                    case 0: Hue=(48); Name=("Halloween Pitchfork"); break;
                    case 1: Hue=(0); Name=("Halloween Pitchfork"); break;
                    case 2: Hue=(1175); Name=("Halloween Pitchfork"); break;
                    case 3: Hue=(0); Name=("Halloween Pitchfork"); break;
                }
        }
		public Halloween2017Pitchfork( Serial serial ) : base( serial )
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

			if ( Weight == 10.0 )
				Weight = 11.0;
		}
	}
}