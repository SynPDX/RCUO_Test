using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a white chocolate dragon corpse" )]
	public class WhiteChocolateDragon : BaseCreature
	{
		[Constructable]
		public WhiteChocolateDragon () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a white chocolate dragon";
			Body = Utility.RandomList( 60, 61 );
			BaseSoundID = 362;

			SetStr( 411, 440 );
			SetDex( 143, 162 );
			SetInt( 111, 150 );

			SetHits( 261, 278 );

			SetDamage( 13, 19 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Fire, 20 );

			SetResistance( ResistanceType.Physical, 45, 50 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 40, 50 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.MagicResist, 65.1, 80.0 );
			SetSkill( SkillName.Tactics, 65.1, 90.0 );
			SetSkill( SkillName.Wrestling, 65.1, 80.0 );

			Fame = 6000;
			Karma = -6000;

			VirtualArmor = 66;
			switch ( Utility.Random( 5 ))
			{
				case 0: Tamable = (false); break;
				case 1: Tamable = (false); break;
				case 2: Tamable = (false); break;
				case 3: Tamable = (false); break;
				case 4: Tamable = (true); break;
			}
			ControlSlots = 2;
			MinTameSkill = 84.3;
			Hue = 556;
			PackReg( 3 );
			RareDropWCD(1);
			TokenDropWCD(1);
			switch ( Utility.Random( 9 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBag() ); break;
				case 4: PackItem( new TrickOrTreatBag() ); break;
				case 5: PackItem( new TrickOrTreatBag() ); break;
				case 6: PackItem( new TrickOrTreatBagMedium() ); break;
				case 7: PackItem( new TrickOrTreatBagMedium() ); break;
				case 8: PackItem( new TrickOrTreatBagLarge() ); break;
			}
			switch ( Utility.Random( 3 ))
			{
				case 0: PackItem( new WhiteChocolateDragonF() ); break;
				case 1: PackItem( new ChocolateDragonSkull() ); break;
				case 2: PackItem( new WhiteChocolateScales(5) ); break;
			}
		}
		public virtual void RareDropWCD(int amount)
        {
            if (0.09 > Utility.RandomDouble())
				switch ( Utility.Random( 15 ))
				{
					case 0: PackItem(new Halloween2017BrokenChair1()); break;
					case 1: PackItem(new Halloween2017BrokenChair2()); break;
					case 2: PackItem(new Halloween2017BrokenChair3()); break;
					case 3: PackItem(new Halloween2017BrokenClock()); break;
					case 4: PackItem(new Halloween2017DamagedBooks()); break;
					case 5: PackItem(new Halloween2017BrokenChestOfDrawers()); break;
					case 6: PackItem(new Halloween2017Lantern()); break;
					case 7: PackItem(new Halloween2017BrokenArmoire()); break;
					case 8: PackItem(new Halloween2017RuinedBookcase()); break;
					case 9: PackItem(new Halloween2017DecorativeArmor()); break;
					case 10: PackItem(new Halloween2017DecorativeArmor2()); break;
					case 11: PackItem(new Halloween2017IronMaiden()); break;
					case 12: PackItem(new Halloween2017BeefCarcass()); break;
					case 13: PackItem(new Halloween2017BeefCarcass2()); break;
					case 14: PackItem(new Halloween2017CandleSkull()); break;
				}
		}
		public virtual void TokenDropWCD(int amount)
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
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool ReacquireOnMovement{ get{ return true; } }
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override int TreasureMapLevel{ get{ return 2; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Fish; } }

		public WhiteChocolateDragon( Serial serial ) : base( serial )
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