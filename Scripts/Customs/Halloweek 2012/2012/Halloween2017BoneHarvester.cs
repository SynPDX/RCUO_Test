using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x26BB, 0x26C5 )]
	public class Halloween2017BoneHarvester : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 25; } }
		public override int AosMinDamage{ get{ return 13; } }
		public override int AosMaxDamage{ get{ return 15; } }
		public override int AosSpeed{ get{ return 36; } }
		public override float MlSpeed{ get{ return 3.00f; } }

		public override int OldStrengthReq{ get{ return 25; } }
		public override int OldMinDamage{ get{ return 13; } }
		public override int OldMaxDamage{ get{ return 15; } }
		public override int OldSpeed{ get{ return 36; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 70; } }

		[Constructable]
		public Halloween2017BoneHarvester() : base( 0x26BB )
		{
			Weight = 3.0;
			WeaponAttributes.HitLeechHits = 7;
			HalloweenBoneHarvesterHue();
		}
		public virtual void HalloweenBoneHarvesterHue()
        {
                switch (Utility.Random(4))
                {
                    case 0: Hue=(48); Name=("Halloween Bone Harvester"); break;
                    case 1: Hue=(0); Name=("Halloween Bone Harvester"); break;
                    case 2: Hue=(1175); Name=("Halloween Bone Harvester"); break;
                    case 3: Hue=(0); Name=("Halloween Bone Harvester"); break;
                }
        }
		public Halloween2017BoneHarvester( Serial serial ) : base( serial )
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