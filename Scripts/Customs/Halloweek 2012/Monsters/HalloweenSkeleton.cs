using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a spooky skeletal corpse" )]
	public class HalloweenSkeleton : BaseCreature
	{
		[Constructable]
		public HalloweenSkeleton() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a spooky skeleton";
			Body = Utility.RandomList( 50, 56 );
			BaseSoundID = 0x48D;

			SetStr( 80, 96 );
			SetDex( 75, 86 );
			SetInt( 40, 54 );

			SetHits( 81, 98 );

			SetDamage( 6, 12 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 35 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 15, 40 );
			SetResistance( ResistanceType.Poison, 15, 25 );
			SetResistance( ResistanceType.Energy, 15, 25 );

			SetSkill( SkillName.MagicResist, 45.1, 60.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 45.1, 55.0 );

			Fame = 650;
			Karma = -650;

			VirtualArmor = 32;

			TokenDropSkel(1);
			HalloweenSkeletonHue();
			switch ( Utility.Random( 5 ))
			{
				case 0: PackItem( new BoneArms() ); break;
				case 1: PackItem( new BoneChest() ); break;
				case 2: PackItem( new BoneGloves() ); break;
				case 3: PackItem( new BoneLegs() ); break;
				case 4: PackItem( new BoneHelm() ); break;
			}
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
				switch ( Utility.Random( 14 ))
				{
					case 0: c.DropItem(new Halloween2017CandleSkull()); break;
					case 1: c.DropItem(new Halloween2017CandleSkull()); break;
					case 2: c.DropItem(new Halloween2017HangingSkeleton1()); break;
					case 3: c.DropItem(new Halloween2017HangingSkeleton2()); break;
					case 4: c.DropItem(new Halloween2017HangingSkeleton3()); break;
					case 5: c.DropItem(new Halloween2017HangingSkeleton4()); break;
					case 6: c.DropItem(new Halloween2017HangingSkeleton5()); break;
					case 7: c.DropItem(new Halloween2017SkullPile()); break;
					case 8: c.DropItem(new Halloween2017SkullPole()); break;
					case 9: c.DropItem(new Halloween2017BonePile1()); break;
					case 10: c.DropItem(new Halloween2017BonePile2()); break;
					case 11: c.DropItem(new Halloween2017BonePile3()); break;
					case 12: c.DropItem(new Halloween2017BonePile4()); break;
					case 13: c.DropItem(new Halloween2017BonePile5()); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
		}
		public virtual void HalloweenSkeletonHue()
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
		public virtual void TokenDropSkel(int amount)
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

		public HalloweenSkeleton( Serial serial ) : base( serial )
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
