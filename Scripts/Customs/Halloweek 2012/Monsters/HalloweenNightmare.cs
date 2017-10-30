using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a hallownightmare corpse" )]
	[Server.Engines.Craft.Forge]
	public class HalloweenNightmare : BaseMount
	{
		public virtual double BoostedSpeed{ get{ return 0.1; } }
		public override bool ReduceSpeedWithDamage{ get{ return false; } }
		[Constructable]
		public HalloweenNightmare() : this( "a hallownightmare" )
		{
		}

		[Constructable]
		public HalloweenNightmare( string name ) : base( name, 0x74, 0x3EA7, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			BaseSoundID = 0xA8;

			SetStr( 506, 535 );
			SetDex( 96, 115 );
			SetInt( 96, 135 );

			SetHits( 308, 345 );

			SetDamage( 24, 30 );

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Fire, 40 );
			SetDamageType( ResistanceType.Energy, 20 );

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.EvalInt, 10.4, 50.0 );
			SetSkill( SkillName.Magery, 10.4, 50.0 );
			SetSkill( SkillName.MagicResist, 85.3, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 80.5, 92.5 );

			Fame = 18000;
			Karma = -18000;
			TokenDropNight(1);
			VirtualArmor = 70;
			switch ( Utility.Random( 5 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBagMedium() ); break;
				case 3: PackItem( new TrickOrTreatBagMedium() ); break;
				case 4: PackItem( new TrickOrTreatBagLarge() ); break;
			}
			switch ( Utility.Random( 5 ))
			{
				case 0: Tamable = (false); break;
				case 1: Tamable = (false); break;
				case 2: Tamable = (false); break;
				case 3: Tamable = (false); break;
				case 4: Tamable = (true); break;
			}
			ControlSlots = 2;
			MinTameSkill = 95.1;
			HalloweenNightmareHue();
			RareDropHNM(1);
			switch ( Utility.Random( 3 ) )
			{
				case 0:
				{
					BodyValue = 116;
					ItemID = 16039;
					break;
				}
				case 1:
				{
					BodyValue = 178;
					ItemID = 16041;
					break;
				}
				case 2:
				{
					BodyValue = 179;
					ItemID = 16055;
					break;
				}
			}

			PackItem( new SulfurousAsh( Utility.RandomMinMax( 3, 5 ) ) );
		}
		public override void OnHarmfulSpell( Mobile from )
		{
			if ( !Controlled && ControlMaster == null )
				CurrentSpeed = BoostedSpeed;
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.LowScrolls );
			AddLoot( LootPack.Potions );
		}

		public override int GetAngerSound()
		{
			if ( !Controlled )
				return 0x16A;

			return base.GetAngerSound();
		}
		public virtual void RareDropHNM(int amount)
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
		public virtual void TokenDropNight(int amount)
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
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override int Meat{ get{ return 5; } }
		public override int Hides{ get{ return 10; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }
		public virtual void HalloweenNightmareHue()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(1175); break;
                    case 1: Hue=(48); break;
                    case 2: Hue=(0); break;
                }
        }
		public HalloweenNightmare( Serial serial ) : base( serial )
		{
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

			if ( BaseSoundID == 0x16A )
				BaseSoundID = 0xA8;
		}
	}
}