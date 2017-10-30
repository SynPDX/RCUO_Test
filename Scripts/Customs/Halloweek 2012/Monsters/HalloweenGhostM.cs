using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a human's corpse" )]
	public class GhostMagical : BaseCreature
	{
		[Constructable]
		public GhostMagical() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Name = "a ghost";
			Hue = Utility.RandomSkinHue();

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				AddItem( new HalloweenGhostRobeMONSTER() );
			}
			else
			{
				Body = 0x190;
				AddItem( new HalloweenGhostRobeMONSTER() );
			}

			SetStr( 100, 110 );
			SetDex( 81, 95 );
			SetInt( 276, 305 );

			SetHits( 91, 108 );
			RareDropGM(1);
			SetDamage( 16, 26 );

			SetDamageType( ResistanceType.Physical, 10 );
			SetDamageType( ResistanceType.Cold, 40 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 40, 60 );
			SetResistance( ResistanceType.Fire, 20, 30 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 55, 65 );
			SetResistance( ResistanceType.Energy, 40, 50 );


			SetSkill( SkillName.Necromancy, 89, 99.1 );
			SetSkill( SkillName.SpiritSpeak, 90.0, 99.0 );

			SetSkill( SkillName.EvalInt, 100.0 );
			SetSkill( SkillName.Magery, 70.1, 80.0 );
			SetSkill( SkillName.Meditation, 85.1, 95.0 );
			SetSkill( SkillName.MagicResist, 80.1, 100.0 );
			SetSkill( SkillName.Tactics, 70.1, 90.0 );

			Fame = 1800;
			Karma = -1800;

			VirtualArmor = 50;
			PackNecroReg( 17, 24 );
			TokenDropGM(1);
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
		public override void OnDeath(Container c)
        {
            base.OnDeath(c);
 
            if (0.02 > Utility.RandomDouble())
				switch ( Utility.Random( 18 ))
				{
					case 0: c.DropItem(new Halloween2017Blood1()); break;
					case 1: c.DropItem(new Halloween2017Blood2()); break;
					case 2: c.DropItem(new Halloween2017Blood3()); break;
					case 3: c.DropItem(new Halloween2017SkullPile()); break;
					case 4: c.DropItem(new Halloween2017SkullPole()); break;
					case 5: c.DropItem(new Halloween2017Lantern()); break;
					case 6: c.DropItem(new Halloween2017CoveredChair()); break;
					case 7: c.DropItem(new Halloween2017StumpAxe()); break;
					case 8: c.DropItem(new Halloween2017Spiderweb1()); break;
					case 9: c.DropItem(new Halloween2017Spiderweb2()); break;
					case 10: c.DropItem(new Halloween2017Painting1()); break;
					case 11: c.DropItem(new Halloween2017Painting2()); break;
					case 12: c.DropItem(new Halloween2017Painting3()); break;
					case 13: c.DropItem(new Halloween2017Painting4()); break;
					case 14: c.DropItem(new Halloween2017Painting5()); break;
					case 15: c.DropItem(new Halloween2017Painting6()); break;
					case 16: c.DropItem(new Halloween2017Painting7()); break;
					case 17: c.DropItem(new Halloween2017Painting8()); break;
				}
		}
		public virtual void TokenDropGM(int amount)
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
		public virtual void RareDropGM(int amount)
        {
            if (0.02 > Utility.RandomDouble())
					PackItem(new HalloweenGhostRobe());
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
		}

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.FeyAndUndead; }
		}
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }

		public GhostMagical( Serial serial ) : base( serial )
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