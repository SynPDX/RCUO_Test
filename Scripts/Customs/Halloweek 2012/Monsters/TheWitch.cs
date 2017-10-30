using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a human's corpse" )]
	public class TheWitch : BaseCreature
	{
		[Constructable]
		public TheWitch() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Name = "a master witch";
			Hue = Utility.RandomSkinHue();

			Body = 0x191;
			AddItem( new MagicWizardsHat(Hue=(1175)) );
			AddItem( new FemaleElvenRobe(Hue=(1175)) );
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new LightningWand() ); break;
				case 1: AddItem( new FireballWand() ); break;
				case 2: AddItem( new FeebleWand() ); break;
			}
			SetStr( 125, 150 );
			SetDex( 36, 75 );
			SetInt( 302, 900 );
			SetHits( 325, 1450 );
			SetStam( 51, 150 );

			SetDamage( 18, 24 );

			SetDamageType( ResistanceType.Physical, 20 );
			SetDamageType( ResistanceType.Cold, 50 );
			SetDamageType( ResistanceType.Energy, 60 );

			SetResistance( ResistanceType.Physical, 60, 80 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 65, 75 );
			SetResistance( ResistanceType.Energy, 50, 60 );


			SetSkill( SkillName.Necromancy, 99, 109.1 );
			SetSkill( SkillName.SpiritSpeak, 100.0, 109.0 );

			SetSkill( SkillName.EvalInt, 100.0 );
			SetSkill( SkillName.Magery, 100.1, 113.0 );
			SetSkill( SkillName.Meditation, 95.1, 105.0 );
			SetSkill( SkillName.MagicResist, 100.1, 110.0 );
			SetSkill( SkillName.Tactics, 80.1, 100.0 );

			Fame = 4200;
			Karma = -4200;

			TokenDropTheWitch(1);
			VirtualArmor = 75;
			PackNecroReg( 40, 100 );
			PackItem( new EmptyCrystalBall() );
			switch ( Utility.Random( 5 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBagMedium() ); break;
				case 3: PackItem( new TrickOrTreatBagMedium() ); break;
				case 4: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}
		public override void OnDeath(Container c)
        {
            base.OnDeath(c);
 
            if (0.60 > Utility.RandomDouble())
				switch ( Utility.Random( 14 ))
				{
					case 0: c.DropItem(new Halloween2017Blood1()); break;
					case 1: c.DropItem(new Halloween2017Blood2()); break;
					case 2: c.DropItem(new Halloween2017Blood3()); break;
					case 3: c.DropItem(new Halloween2017SkullPile()); break;
					case 4: c.DropItem(new Halloween2017SkullPole()); break;
					case 5: c.DropItem(new Halloween2017Lantern()); break;
					case 6: c.DropItem(new Halloween2017StumpAxe()); break;
					case 7: c.DropItem(new Halloween2017Spiderweb1()); break;
					case 8: c.DropItem(new Halloween2017Spiderweb2()); break;
					case 9: c.DropItem(new Halloween2017CandleSkull()); break;
					case 10: c.DropItem(new Halloween2017WitchesBrew()); break;
					case 11: c.DropItem(new Halloween2017Stump()); break;
					case 12: c.DropItem(new Halloween2017HauntedMirror()); break;
					case 13: c.DropItem(new Halloween2017Cauldron()); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
			AddLoot( LootPack.Rich );
		}
		public virtual void TokenDropTheWitch(int amount)
        {
            if (0.10 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(12)); break;
					case 1: PackItem(new HalloweenToken(12)); break;
					case 2: PackItem(new HalloweenToken(12)); break;
					case 3: PackItem(new HalloweenToken(12)); break;
					case 4: PackItem(new HalloweenToken(12)); break;
					case 5: PackItem(new HalloweenToken(12)); break;
					case 6: PackItem(new HalloweenToken(15)); break;
					case 7: PackItem(new HalloweenToken(17)); break;
					case 8: PackItem(new HalloweenToken(19)); break;
					case 9: PackItem(new HalloweenToken(21)); break;
				}
		}
		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.FeyAndUndead; }
		}
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }

		public TheWitch( Serial serial ) : base( serial )
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
		public void SpawnBlackCat( Mobile m )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			BlackCat spawned = new BlackCat();

			spawned.Team = this.Team;

			bool validLocation = false;
			Point3D loc = this.Location;

			for ( int j = 0; !validLocation && j < 10; ++j )
			{
				int x = X + Utility.Random( 3 ) - 1;
				int y = Y + Utility.Random( 3 ) - 1;
				int z = map.GetAverageZ( x, y );

				if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
					loc = new Point3D( x, y, Z );
				else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
					loc = new Point3D( x, y, z );
			}

			spawned.MoveToWorld( loc, map );
			spawned.Combatant = m;
		}
		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( this.Hits > (this.HitsMax / 4) )
			{
				if ( 0.25 >= Utility.RandomDouble() )
					SpawnBlackCat( attacker );
			}
		}
	}
}