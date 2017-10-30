using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a spooky rotting corpse" )]
	public class HalloweenZombie : BaseCreature
	{
		[Constructable]
		public HalloweenZombie() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a spooky zombie";
			Body = 3;
			BaseSoundID = 471;

			SetStr( 70, 84 );
			SetDex( 50, 61 );
			SetInt( 40, 54 );

			SetHits( 76, 93 );

			SetDamage( 6, 13 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 35 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Poison, 15, 25 );
			SetResistance( ResistanceType.Energy, 15, 25 );

			SetSkill( SkillName.MagicResist, 15.1, 40.0 );
			SetSkill( SkillName.Tactics, 35.1, 50.0 );
			SetSkill( SkillName.Wrestling, 35.1, 50.0 );

			Fame = 700;
			Karma = -700;

			VirtualArmor = 36;
		
			TokenDropZomb(1);
			HalloweenZombieHue();
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
				switch ( Utility.Random( 29 ))
				{
					case 0: c.DropItem(new Halloween2017GraveStone()); break;
					case 1: c.DropItem(new Halloween2017GraveStone2()); break;
					case 2: c.DropItem(new Halloween2017GraveStone3()); break;
					case 3: c.DropItem(new Halloween2017GraveStone4()); break;
					case 4: c.DropItem(new Halloween2017GraveStone5()); break;
					case 5: c.DropItem(new Halloween2017GraveStone6()); break;
					case 6: c.DropItem(new Halloween2017GraveStone7()); break;
					case 7: c.DropItem(new Halloween2017GraveStone8()); break;
					case 8: c.DropItem(new Halloween2017GraveStone9()); break;
					case 9: c.DropItem(new Halloween2017GraveStone10()); break;
					case 10: c.DropItem(new Halloween2017GraveStone11()); break;
					case 11: c.DropItem(new Halloween2017GraveStone12()); break;
					case 12: c.DropItem(new Halloween2017GraveStone13()); break;
					case 13: c.DropItem(new Halloween2017GraveStone14()); break;
					case 14: c.DropItem(new Halloween2017GraveStone15()); break;
					case 15: c.DropItem(new Halloween2017GraveStone16()); break;
					case 16: c.DropItem(new Halloween2017GraveStone17()); break;
					case 17: c.DropItem(new Halloween2017GraveStone18()); break;
					case 18: c.DropItem(new Halloween2017GraveStone19()); break;
					case 19: c.DropItem(new Halloween2017GraveStone20()); break;
					case 20: c.DropItem(new Halloween2017GraveStone21()); break;
					case 21: c.DropItem(new Halloween2017GraveStone22()); break;
					case 22: c.DropItem(new Halloween2017GraveStone23()); break;
					case 23: c.DropItem(new Halloween2017GraveStone24()); break;
					case 24: c.DropItem(new Halloween2017GraveStone25()); break;
					case 25: c.DropItem(new Halloween2017GraveStone26()); break;
					case 26: c.DropItem(new Halloween2017BeefCarcass()); break;
					case 27: c.DropItem(new Halloween2017BeefCarcass2()); break;
					case 28: c.DropItem(new Halloween2017Grave()); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
		}
		public virtual void HalloweenZombieHue()
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
		public virtual void TokenDropZomb(int amount)
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
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }

		public HalloweenZombie( Serial serial ) : base( serial )
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