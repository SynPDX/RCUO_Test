using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x26BD, 0x26C7 )]
	public class Halloween2017BladedStaff : BaseSpear
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }

		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 14; } }
		public override int AosMaxDamage{ get{ return 16; } }
		public override int AosSpeed{ get{ return 37; } }
		public override float MlSpeed{ get{ return 3.00f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 14; } }
		public override int OldMaxDamage{ get{ return 16; } }
		public override int OldSpeed{ get{ return 37; } }

		public override int InitMinHits{ get{ return 21; } }
		public override int InitMaxHits{ get{ return 110; } }

		public override SkillName DefSkill{ get{ return SkillName.Swords; } }

		[Constructable]
		public Halloween2017BladedStaff() : base( 0x26BD )
		{
			Weight = 4.0;
			WeaponAttributes.HitLeechHits = 4;
			HalloweenBladedStaffHue();
		}
		public virtual void HalloweenBladedStaffHue()
        {
                switch (Utility.Random(4))
                {
                    case 0: Hue=(48); Name=("Halloween Bladed Staff"); break;
                    case 1: Hue=(0); Name=("Halloween Bladed Staff"); break;
                    case 2: Hue=(1175); Name=("Halloween Bladed Staff"); break;
                    case 3: Hue=(0); Name=("Halloween Bladed Staff"); break;
                }
        }
		public Halloween2017BladedStaff( Serial serial ) : base( serial )
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