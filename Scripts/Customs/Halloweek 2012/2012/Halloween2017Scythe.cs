using System;
using Server.Network;
using Server.Items;
using Server.Engines.Harvest;

namespace Server.Items
{
	[FlipableAttribute( 0x26BA, 0x26C4 )]
	public class Halloween2017Scythe : BasePoleArm
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosStrengthReq{ get{ return 45; } }
		public override int AosMinDamage{ get{ return 17; } }
		public override int AosMaxDamage{ get{ return 20; } }
		public override int AosSpeed{ get{ return 25; } }
		public override float MlSpeed{ get{ return 2.50f; } }

		public override int OldStrengthReq{ get{ return 45; } }
		public override int OldMinDamage{ get{ return 15; } }
		public override int OldMaxDamage{ get{ return 18; } }
		public override int OldSpeed{ get{ return 25; } }

		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 200; } }

		public override HarvestSystem HarvestSystem{ get{ return null; } }

		[Constructable]
		public Halloween2017Scythe() : base( 0x26BA )
		{
			Weight = 5.0;
			WeaponAttributes.UseBestSkill = 1;
			WeaponAttributes.HitLeechHits = 20;
			ReaperScytheHue();
		}
		public virtual void ReaperScytheHue()
        {
                switch (Utility.Random(4))
                {
                    case 0: Hue=(48); Name=("Reapers Halloween Scythe"); Attributes.WeaponDamage = (10); break;
                    case 1: Hue=(0); Name=("Reapers Halloween Scythe"); Attributes.WeaponDamage = (10); break;
                    case 2: Hue=(1175); Name=("Reapers True Halloween Scythe"); Attributes.SpellChanneling = 1; Attributes.WeaponDamage = (32); break;
                    case 3: Hue=(0); Name=("Reapers Halloween Scythe"); Attributes.WeaponDamage = (10); break;
                }
        }
		public Halloween2017Scythe( Serial serial ) : base( serial )
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

			if ( Weight == 15.0 )
				Weight = 5.0;
		}
	}
}