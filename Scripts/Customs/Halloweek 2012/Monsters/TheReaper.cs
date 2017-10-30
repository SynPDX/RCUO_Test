using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fifth;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "a human's corpse" )]
	public class TheReaper : BaseCreature
	{
		[Constructable]
		public TheReaper() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "The Reaper";
			Name = "Grim";
			Hue = Utility.RandomSkinHue();

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				AddItem( new HalloweenReaperRobeMONSTER() );
			}
			else
			{
				Body = 0x190;
				AddItem( new HalloweenReaperRobeMONSTER() );
			}
			AddItem( new Halloween2017Scythe() );
			SetStr( 305, 425 );
			SetDex( 72, 150 );
			SetInt( 505, 750 );
			Hue = 0;
			SetHits( 7500, 13000 );
			SetStam( 102, 300 );

			SetDamage( 25, 35 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Energy, 40, 50 );
			RareDropReaper(1);
			SetSkill( SkillName.Anatomy, 100.0, 100.5 );
			SetSkill( SkillName.EvalInt, 100.1, 100.1 );
			SetSkill( SkillName.Magery, 95.5, 100.0 );
			SetSkill( SkillName.Meditation, 49.1, 50.0 );
			SetSkill( SkillName.MagicResist, 125.0, 150.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 100.0, 100.1 );
			SetSkill( SkillName.Fencing, 90.1, 100.0 );
			SetSkill( SkillName.Macing, 90.1, 100.0 );
			SetSkill( SkillName.Swords, 90.1, 100.0 );
			RidingReaper();
			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 80;
			
			PackItem( new TrickOrTreatBagMedium() );
			PackItem( new TrickOrTreatBagLarge() );
			PackItem( new Gold(60000) );
			PackItem( new Gold(25000) );
			TokenDropReaper(1);
			QuestDropReaper(1);
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
					case 0: PackItem(new Halloween2017Blood1()); break;
					case 1: PackItem(new Halloween2017Blood2()); break;
					case 2: PackItem(new Halloween2017Blood3()); break;
					case 3: PackItem(new Halloween2017SkullPile()); break;
					case 4: PackItem(new Halloween2017SkullPole()); break;
					case 5: PackItem(new Halloween2017Lantern()); break;
					case 6: PackItem(new Halloween2017CoveredChair()); break;
					case 7: PackItem(new Halloween2017StumpAxe()); break;
					case 8: PackItem(new Halloween2017Spiderweb1()); break;
					case 9: PackItem(new Halloween2017Spiderweb2()); break;
					case 10: PackItem(new Halloween2017Painting1()); break;
					case 11: PackItem(new Halloween2017Painting2()); break;
					case 12: PackItem(new Halloween2017Painting3()); break;
					case 13: PackItem(new Halloween2017Painting4()); break;
					case 14: PackItem(new Halloween2017Painting5()); break;
					case 15: PackItem(new Halloween2017Painting6()); break;
					case 16: PackItem(new Halloween2017Painting7()); break;
					case 17: PackItem(new Halloween2017Painting8()); break;
				}
		}
		public virtual void TokenDropReaper(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(100)); break;
					case 1: PackItem(new HalloweenToken(100)); break;
					case 2: PackItem(new HalloweenToken(100)); break;
					case 3: PackItem(new HalloweenToken(100)); break;
					case 4: PackItem(new HalloweenToken(100)); break;
					case 5: PackItem(new HalloweenToken(100)); break;
					case 6: PackItem(new HalloweenToken(120)); break;
					case 7: PackItem(new HalloweenToken(140)); break;
					case 8: PackItem(new HalloweenToken(160)); break;
					case 9: PackItem(new HalloweenToken(200)); break;
				}
		}
		public virtual void RidingReaper()
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 3 ))
				{
					case 0: break;
					case 1: break;
					case 2: new HalloweenSkeletalHorse().Rider = this; break;
				}
		}
		public virtual void RareDropReaper(int amount)
        {
            if (0.50 > Utility.RandomDouble())
					PackItem(new HalloweenReaperRobe());
		}
		public virtual void QuestDropReaper(int amount)
        {
            if (0.5 > Utility.RandomDouble())
					PackItem(new CaptainHead());
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 3 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool AutoDispel{ get{ return true; } }
		public override double AutoDispelChance{ get{ return 1.0; } }
		public override bool BardImmune{ get{ return !Core.SE; } }
		public override bool Unprovokable{ get{ return Core.SE; } }
		public override bool Uncalmable{ get{ return Core.SE; } }
		public override Poison PoisonImmune{ get{ return Poison.Greater; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 3; } }

		public void SpawnGhosts( Mobile target )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			int ghosts = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is GhostPhysical || m is GhostMagical )
					++ghosts;
			}

			if ( ghosts < 16 )
			{
				PlaySound( 0x3D );

				int newghostsx = Utility.RandomMinMax( 3, 6 );

				for ( int i = 0; i < newghostsx; ++i )
				{
					BaseCreature ghostsx;

					switch ( Utility.Random( 5 ) )
					{
						default:
						case 0: case 1:	ghostsx = new GhostPhysical(); break;
						case 2: case 3:	ghostsx = new GhostMagical(); break;
						case 4:			ghostsx = new GhostPhysical(); break;
					}

					ghostsx.Team = this.Team;

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

					ghostsx.MoveToWorld( loc, map );
					ghostsx.Combatant = target;
				}
			}
		}

		public void DoSpecialAbility( Mobile target )
		{
			if ( target == null || target.Deleted ) //sanity
				return;

			if ( 0.1 >= Utility.RandomDouble() ) // 10% chance to more ghosts
				SpawnGhosts( target );
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			DoSpecialAbility( attacker );
		}

		public override void OnGaveMeleeAttack( Mobile defender )
		{
			base.OnGaveMeleeAttack( defender );

			DoSpecialAbility( defender );
		}

		public TheReaper( Serial serial ) : base( serial )
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