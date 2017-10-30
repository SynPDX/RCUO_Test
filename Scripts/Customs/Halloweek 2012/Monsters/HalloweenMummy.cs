using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a spooky mummy corpse" )]
	public class HalloweenMummy : BaseCreature
	{
		[Constructable]
		public HalloweenMummy() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.4, 0.8 )
		{
			Name = "a spooky mummy";
			Body = 154;
			BaseSoundID = 471;

			SetStr( 346, 370 );
			SetDex( 71, 90 );
			SetInt( 26, 40 );

			SetHits( 86, 103 );

			SetDamage( 15, 27 );

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Cold, 60 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.MagicResist, 15.1, 40.0 );
			SetSkill( SkillName.Tactics, 35.1, 50.0 );
			SetSkill( SkillName.Wrestling, 35.1, 50.0 );

			Fame = 4000;
			Karma = -4000;
			TokenDropMummy(1);
			VirtualArmor = 50;

			if ( Core.ML && Utility.RandomDouble() < .33 )
				PackItem( new Engines.Plants.Seed(2) );
			HalloweenMummyHue();
			PackItem( new Garlic( 5 ) );
			PackItem( new Bandage( 10 ) );
			switch ( Utility.Random( 12 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBag() ); break;
				case 4: PackItem( new TrickOrTreatBag() ); break;
				case 5: PackItem( new TrickOrTreatBag() ); break;
				case 6: PackItem( new TrickOrTreatBag() ); break;
				case 7: PackItem( new TrickOrTreatBag() ); break;
				case 8: PackItem( new TrickOrTreatBag() ); break;
				case 9: PackItem( new TrickOrTreatBagMedium() ); break;
				case 10: PackItem( new TrickOrTreatBagMedium() ); break;
				case 11: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}
		public override void OnDeath(Container c)
        {
            base.OnDeath(c);
 
            if (0.02 > Utility.RandomDouble())
				switch ( Utility.Random( 13 ))
				{
					case 0: c.DropItem(new Halloween2017Blood1()); break;
					case 1: c.DropItem(new Halloween2017Blood2()); break;
					case 2: c.DropItem(new Halloween2017Blood3()); break;
					case 3: c.DropItem(new Halloween2017CoveredChair()); break;
					case 4: c.DropItem(new Halloween2017BrokenChair1()); break;
					case 5: c.DropItem(new Halloween2017BrokenChair2()); break;
					case 6: c.DropItem(new Halloween2017BrokenChair3()); break;
					case 7: c.DropItem(new Halloween2017BrokenClock()); break;
					case 8: c.DropItem(new Halloween2017DamagedBooks()); break;
					case 9: c.DropItem(new Halloween2017Grave()); break;
					case 10: c.DropItem(new Halloween2017Spiderweb1()); break;
					case 11: c.DropItem(new Halloween2017Spiderweb2()); break;
					case 12: c.DropItem(new Halloween2017SheafWheat()); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Gems );
			AddLoot( LootPack.Potions );
		}
		public virtual void HalloweenMummyHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public virtual void TokenDropMummy(int amount)
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
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lesser; } }

		public HalloweenMummy( Serial serial ) : base( serial )
		{
		}

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.FeyAndUndead; }
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