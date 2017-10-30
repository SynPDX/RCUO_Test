using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fifth;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "a halloween dragon's corpse" )]
	public class HalloweenDragon : BaseCreature
	{
		[Constructable]
		public HalloweenDragon() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "The Halloween Dragon";
			Body = 46;
			BaseSoundID = 362;
			
			SetStr( 305, 425 );
			SetDex( 72, 150 );
			SetInt( 505, 750 );

			SetHits( 6300, 9400 );
			SetStam( 102, 300 );

			SetDamage( 45, 55 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Energy, 40, 50 );

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

			Fame = 27500;
			Karma = -27500;
			switch ( Utility.Random( 3 ))
			{
                case 0: Hue=(48); break;
                case 1: Hue=(1154); break;
                case 2: Hue=(1175); break;
			}
			VirtualArmor = 80;
			RareDropHD(4);
			TokenDropHD(3);
			PackItem( new TrickOrTreatBagMedium() );
			PackItem( new TrickOrTreatBagLarge() );
			PackItem( new Halloween2017Robe() );
			PackItem( new Gold(60000) );
			PackItem( new Gold(60000) );
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
		public virtual void RareDropHD(int amount)
        {
			switch ( Utility.Random( 76 ))
			{
				case 0: PackItem(new Halloween2017WitchesBrew()); break;
				case 1: PackItem(new Halloween2017DecorativeArmor()); break;
				case 2: PackItem(new Halloween2017DecorativeArmor2()); break;
				case 3: PackItem(new Halloween2017IronMaiden()); break;
				case 4: PackItem(new Halloween2017BeefCarcass()); break;
				case 5: PackItem(new Halloween2017BeefCarcass2()); break;
				case 6: PackItem(new Halloween2017CandleSkull()); break;
				case 7: PackItem(new Halloween2017HangingSkeleton1()); break;
				case 8: PackItem(new Halloween2017HangingSkeleton2()); break;
				case 9: PackItem(new Halloween2017HangingSkeleton3()); break;
				case 10: PackItem(new Halloween2017HangingSkeleton4()); break;
				case 11: PackItem(new Halloween2017HangingSkeleton5()); break;
				case 12: PackItem(new Halloween2017Blood1()); break;
				case 13: PackItem(new Halloween2017Blood2()); break;
				case 14: PackItem(new Halloween2017Blood3()); break;
				case 15: PackItem(new Halloween2017SkullPile()); break;
				case 16: PackItem(new Halloween2017SkullPole()); break;
				case 17: PackItem(new Halloween2017Scarecrow()); break;
				case 18: PackItem(new Halloween2017Lantern()); break;
				case 19: PackItem(new Halloween2017BrokenArmoire()); break;
				case 20: PackItem(new Halloween2017RuinedBookcase()); break;
				case 21: PackItem(new Halloween2017CoveredChair()); break;
				case 22: PackItem(new Halloween2017BrokenChair1()); break;
				case 23: PackItem(new Halloween2017BrokenChair2()); break;
				case 24: PackItem(new Halloween2017BrokenChair3()); break;
				case 25: PackItem(new Halloween2017BrokenClock()); break;
				case 26: PackItem(new Halloween2017DamagedBooks()); break;
				case 27: PackItem(new Halloween2017BrokenChestOfDrawers()); break;
				case 28: PackItem(new Halloween2017StumpAxe()); break;
				case 29: PackItem(new Halloween2017Stump()); break;
				case 30: PackItem(new Halloween2017WTub()); break;
				case 31: PackItem(new Halloween2017ETub()); break;
				case 32: PackItem(new Halloween2017Painting1()); break;
				case 33: PackItem(new Halloween2017Painting2()); break;
				case 34: PackItem(new Halloween2017Painting3()); break;
				case 35: PackItem(new Halloween2017Painting4()); break;
				case 36: PackItem(new Halloween2017Painting5()); break;
				case 37: PackItem(new Halloween2017Painting6()); break;
				case 38: PackItem(new Halloween2017Painting7()); break;
				case 39: PackItem(new Halloween2017Painting8()); break;
				case 40: PackItem(new Halloween2017Grave()); break;
				case 41: PackItem(new Halloween2017Spiderweb1()); break;
				case 42: PackItem(new Halloween2017Spiderweb2()); break;
				case 43: PackItem(new Halloween2017SheafWheat()); break;
				case 44: PackItem(new Halloween2017BonePile1()); break;
				case 45: PackItem(new Halloween2017BonePile2()); break;
				case 46: PackItem(new Halloween2017BonePile3()); break;
				case 47: PackItem(new Halloween2017BonePile4()); break;
				case 48: PackItem(new Halloween2017BonePile5()); break;
				case 49: PackItem(new Halloween2017GraveStone()); break;
				case 50: PackItem(new Halloween2017GraveStone2()); break;
				case 51: PackItem(new Halloween2017GraveStone3()); break;
				case 52: PackItem(new Halloween2017GraveStone4()); break;
				case 53: PackItem(new Halloween2017GraveStone5()); break;
				case 54: PackItem(new Halloween2017GraveStone6()); break;
				case 55: PackItem(new Halloween2017GraveStone7()); break;
				case 56: PackItem(new Halloween2017GraveStone8()); break;
				case 57: PackItem(new Halloween2017GraveStone9()); break;
				case 58: PackItem(new Halloween2017GraveStone10()); break;
				case 59: PackItem(new Halloween2017GraveStone11()); break;
				case 60: PackItem(new Halloween2017GraveStone12()); break;
				case 61: PackItem(new Halloween2017GraveStone13()); break;
				case 62: PackItem(new Halloween2017GraveStone14()); break;
				case 63: PackItem(new Halloween2017GraveStone15()); break;
				case 64: PackItem(new Halloween2017GraveStone16()); break;
				case 65: PackItem(new Halloween2017GraveStone17()); break;
				case 66: PackItem(new Halloween2017GraveStone18()); break;
				case 67: PackItem(new Halloween2017GraveStone19()); break;
				case 68: PackItem(new Halloween2017GraveStone20()); break;
				case 69: PackItem(new Halloween2017GraveStone21()); break;
				case 71: PackItem(new Halloween2017GraveStone22()); break;
				case 72: PackItem(new Halloween2017GraveStone23()); break;
				case 73: PackItem(new Halloween2017GraveStone24()); break;
				case 74: PackItem(new Halloween2017GraveStone25()); break;
				case 75: PackItem(new Halloween2017GraveStone26()); break;
			}
		}
		public virtual void TokenDropHD(int amount)
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
		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 5 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool ReacquireOnMovement{ get{ return true; } }
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override bool AutoDispel{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }
		public override Poison HitPoison{ get{ return Utility.RandomBool() ? Poison.Lesser : Poison.Regular; } }
		public override int TreasureMapLevel{ get{ return 5; } }

		public void SpawnHalloween( Mobile target )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			int ghosts = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is GhostPhysical || m is GhostMagical || m is HalloweenNightmare || m is HalloweenWitch || m is HalloweenScarecrow || m is HalloweenMummy || m is HalloweenZombie || m is WhiteChocolateDragon || m is MilkChocolateDragon || m is DarkChocolateDragon || m is HalloweenSkeleton )
					++ghosts;
			}

			if ( ghosts < 16 )
			{
				PlaySound( 0x3D );

				int newghostsx = Utility.RandomMinMax( 3, 6 );

				for ( int i = 0; i < newghostsx; ++i )
				{
					BaseCreature ghostsx;

					switch ( Utility.Random( 11 ) )
					{
						default:
						case 0: ghostsx = new GhostPhysical(); break;
						case 1: ghostsx = new GhostMagical(); break;
						case 2: ghostsx = new HalloweenNightmare(); break;
						case 3: ghostsx = new HalloweenWitch(); break;
						case 4: ghostsx = new HalloweenScarecrow(); break;
						case 5: ghostsx = new HalloweenMummy(); break;
						case 6: ghostsx = new HalloweenZombie(); break;
						case 7: ghostsx = new WhiteChocolateDragon(); break;
						case 8: ghostsx = new MilkChocolateDragon(); break;
						case 9: ghostsx = new MilkChocolateDragon(); break;
						case 10: ghostsx = new HalloweenSkeleton(); break;
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
				SpawnHalloween( target );
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

		public HalloweenDragon( Serial serial ) : base( serial )
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