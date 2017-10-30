using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x26C1, 0x26CB )]
	public class Halloween2017CrescentBlade : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 55; } }
		public override int AosMinDamage{ get{ return 11; } }
		public override int AosMaxDamage{ get{ return 14; } }
		public override int AosSpeed{ get{ return 47; } }
		public override float MlSpeed{ get{ return 2.50f; } }

		public override int OldStrengthReq{ get{ return 55; } }
		public override int OldMinDamage{ get{ return 11; } }
		public override int OldMaxDamage{ get{ return 14; } }
		public override int OldSpeed{ get{ return 47; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 51; } }
		public override int InitMaxHits{ get{ return 80; } }

		[Constructable]
		public Halloween2017CrescentBlade() : base( 0x26C1 )
		{
			Weight = 1.0;
			WeaponAttributes.HitLeechHits = 5;
			HalloweenCrescentBladeHue();
		}
		public virtual void HalloweenCrescentBladeHue()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=(48); Name=("Halloween Crescent Blade"); Attributes.WeaponDamage = (10); break;
                    case 1: Hue=(0); Name=("Halloween Crescent Blade"); Attributes.WeaponDamage = (10); break;
                    case 2: Hue=(1175); Name=("Dark Halloween Crescent Blade"); Attributes.WeaponDamage = (10); break;
                    case 3: Hue=(0); Name=("Halloween Crescent Blade"); Attributes.WeaponDamage = (10); break;
                    case 4: Hue=(1154); Name=("True Moon Halloween Crescent Blade"); Attributes.WeaponDamage = (32); break;
                }
        }
		public Halloween2017CrescentBlade( Serial serial ) : base( serial )
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