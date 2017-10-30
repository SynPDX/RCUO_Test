using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a hallowtrees corpse" )]
	public class Hallowtree : BaseCreature
	{
		[Constructable]
		public Hallowtree() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a hallowtree";
			Body = 47;
			BaseSoundID = 442;

			SetStr( 66, 215 );
			SetDex( 66, 75 );
			SetInt( 101, 250 );

			SetHits( 104, 149 );
			SetStam( 0 );

			SetDamage( 14, 18 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Poison, 20 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 20, 30 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 45, 55 );
			SetResistance( ResistanceType.Energy, 35, 45 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 90.1, 100.0 );
			SetSkill( SkillName.MagicResist, 100.1, 125.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 50.1, 60.0 );

			Fame = 7500;
			Karma = -7500;

			VirtualArmor = 50;
			Hue = 0;
			PackItem( new Log( 8 ) );
			PackItem( new MandrakeRoot( 5 ) );
			TokenDropHT(1);
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
 
            if (0.08 > Utility.RandomDouble())
				switch ( Utility.Random( 6 ))
				{
					case 0: c.DropItem(new Halloween2017SkullPile()); break;
					case 1: c.DropItem(new Halloween2017Lantern()); break;
					case 2: c.DropItem(new Halloween2017StumpAxe()); break;
					case 3: c.DropItem(new Halloween2017Stump()); break;
					case 4: c.DropItem(new Halloween2017Grave()); break;
					case 5: c.DropItem(new Halloween2017Lantern()); break;
				}
		}
		public virtual void TokenDropHT(int amount)
        {
            if (0.10 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(5)); break;
					case 1: PackItem(new HalloweenToken(5)); break;
					case 2: PackItem(new HalloweenToken(5)); break;
					case 3: PackItem(new HalloweenToken(5)); break;
					case 4: PackItem(new HalloweenToken(5)); break;
					case 5: PackItem(new HalloweenToken(5)); break;
					case 6: PackItem(new HalloweenToken(7)); break;
					case 7: PackItem(new HalloweenToken(9)); break;
					case 8: PackItem(new HalloweenToken(11)); break;
					case 9: PackItem(new HalloweenToken(13)); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
		}

		public override Poison PoisonImmune{ get{ return Poison.Greater; } }
		public override int TreasureMapLevel{ get{ return 2; } }
		public override bool DisallowAllMoves{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }

		public Hallowtree( Serial serial ) : base( serial )
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