using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a vampire bat corpse" )]
	public class HalloweenVampireBat : BaseCreature
	{
		[Constructable]
		public HalloweenVampireBat() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a vampire bat";
			Body = 317;
			BaseSoundID = 0x270;
			Hue = 987;

			SetStr( 91, 110 );
			SetDex( 91, 115 );
			SetInt( 26, 50 );

			SetHits( 75, 97 );

			SetDamage( 7, 9 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Poison, 20 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 15, 25 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.MagicResist, 70.1, 95.0 );
			SetSkill( SkillName.Tactics, 55.1, 80.0 );
			SetSkill( SkillName.Wrestling, 30.1, 55.0 );

			Fame = 1000;
			Karma = -1000;

			VirtualArmor = 14;
			switch ( Utility.Random( 5 ))
			{
				case 0: Tamable = (false); break;
				case 1: Tamable = (false); break;
				case 2: Tamable = (false); break;
				case 3: Tamable = (false); break;
				case 4: Tamable = (true); break;
			}
			ControlSlots = 1;
			MinTameSkill = 61.1;
			switch ( Utility.Random( 10 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBag() ); break;
				case 4: PackItem( new TrickOrTreatBag() ); break;
				case 5: PackItem( new TrickOrTreatBag() ); break;
				case 6: PackItem( new TrickOrTreatBag() ); break;
				case 7: PackItem( new TrickOrTreatBagMedium() ); break;
				case 8: PackItem( new TrickOrTreatBagMedium() ); break;
				case 9: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Poor );
		}

		public override int GetIdleSound()
		{
			return 0x29B;
		}

		public HalloweenVampireBat( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}