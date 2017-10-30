using System;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a black cat corpse" )]
	public class BlackCat : BaseCreature
	{
		[Constructable]
		public BlackCat() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a black cat";
			Body = 0xC9;
			Hue = 1175;
			BaseSoundID = 0x69;

			SetStr( 61, 110 );
			SetDex( 62, 160 );
			SetInt( 23, 95 );

			SetHits( 58, 77 );

			SetDamage( 6, 12 );

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.MagicResist, 67.1, 89.0 );
			SetSkill( SkillName.Tactics, 75.1, 96.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 1500;
			Karma = -1500;

			VirtualArmor = 60;

			switch ( Utility.Random( 5 ))
			{
				case 0: Tamable = (false); break;
				case 1: Tamable = (false); break;
				case 2: Tamable = (false); break;
				case 3: Tamable = (false); break;
				case 4: Tamable = (true); break;
			}
			ControlSlots = 1;
			MinTameSkill = 71.1;
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
			TokenDropBC(1);
		}
		public virtual void TokenDropBC(int amount)
        {
            if (0.10 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(3)); break;
					case 1: PackItem(new HalloweenToken(3)); break;
					case 2: PackItem(new HalloweenToken(3)); break;
					case 3: PackItem(new HalloweenToken(3)); break;
					case 4: PackItem(new HalloweenToken(3)); break;
					case 5: PackItem(new HalloweenToken(3)); break;
					case 6: PackItem(new HalloweenToken(5)); break;
					case 7: PackItem(new HalloweenToken(7)); break;
					case 8: PackItem(new HalloweenToken(9)); break;
					case 9: PackItem(new HalloweenToken(11)); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}

		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override int Hides{ get{ return 10; } }
		public override HideType HideType{ get{ return HideType.Spined; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override PackInstinct PackInstinct{ get{ return PackInstinct.Feline; } }

		public BlackCat(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}