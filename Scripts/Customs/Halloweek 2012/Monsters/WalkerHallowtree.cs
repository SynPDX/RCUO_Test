using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Engines.CannedEvil;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "a hallowtrees corpse" )]
	public class WalkingHallowtree : BaseCreature
	{
		private bool m_TrueForm;
		[Constructable]
		public WalkingHallowtree() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a walking hallowtree";
			Body = 0x11D;
			BaseSoundID = 442;

			SetStr( 66, 215 );
			SetDex( 66, 75 );
			SetInt( 101, 250 );

			SetHits( 104, 149 );

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

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 50;
			Hue = 0;
			PackItem( new HallowtreeLog( 1 ) );
			PackItem( new MandrakeRoot( 25 ) );
			TokenDropHT(2);
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
		public override bool OnBeforeDeath()
        {
 			if ( m_TrueForm )
			{
				if (0.08 > Utility.RandomDouble())
					switch ( Utility.Random( 6 ))
					{
						case 0: PackItem(new Halloween2017SkullPile()); break;
						case 1: PackItem(new Halloween2017Lantern()); break;
						case 2: PackItem(new Halloween2017StumpAxe()); break;
						case 3: PackItem(new Halloween2017Stump()); break;
						case 4: PackItem(new Halloween2017Grave()); break;
						case 5: PackItem(new Halloween2017Lantern()); break;
					}
					
				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
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
		public void Morph()
		{
			if ( m_TrueForm )
				return;
			m_TrueForm = true;
			PlaySound( 0x1BA );
			Name = "A Master Hallowtree";
			BodyValue = 47;
			BaseSoundID = 442;
			Hue = 1175;

			SetStr( 300, 500 );
			SetDex( 105, 125 );
			SetInt( 300, 550 );

			SetHits( 775, 825 );
			SetStam( 0 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Poison, 20 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 25, 35 );
			SetResistance( ResistanceType.Poison, 55, 65 );
			SetResistance( ResistanceType.Energy, 45, 55 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 90.1, 100.0 );
			SetSkill( SkillName.MagicResist, 100.1, 125.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 50.1, 60.0 );

			Hits = HitsMax;

			PublicOverheadMessage( MessageType.Regular, GetRandomHue(),  true, "N-NO!" );

			Map map = this.Map;
			int newghostsx = 4;
				for ( int i = 0; i < newghostsx; ++i )
				{
					BaseCreature ghostsx;

					switch ( Utility.Random( 6 ) )
					{
						default:
						case 0: case 1:	ghostsx = new Hallowtree(); break;
						case 2: case 3:	ghostsx = new Hallowtree(); break;
						case 4:			ghostsx = new Hallowtree(); break;
					}

					ghostsx.Team = this.Team;

					bool validLocation = false;
					Point3D loc = this.Location;

					for ( int j = 0; !validLocation && j < 10; ++j )
					{
						int x = X + GetRandomLocation();
						int y = Y + GetRandomLocation();
						int z = map.GetAverageZ( x, y );

						if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
							loc = new Point3D( x, y, Z );
						else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
							loc = new Point3D( x, y, z );
					}

					ghostsx.MoveToWorld( loc, map );
				}
		}
		public virtual int GetRandomLocation()
		{
			switch ( Utility.Random( 2 ) )
			{
				default:
				case 0: return - Utility.Random( 6 );
				case 1: return + Utility.Random( 6 );
			}
		}
		public virtual int GetRandomHue()
		{
			switch ( Utility.Random( 5 ) )
			{
				default:
				case 0: return Utility.RandomBlueHue();
				case 1: return Utility.RandomGreenHue();
				case 2: return Utility.RandomRedHue();
				case 3: return Utility.RandomYellowHue();
				case 4: return Utility.RandomNeutralHue();
			}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss );
			AddLoot( LootPack.Meager );
		}
		public override Poison PoisonImmune{ get{ return Poison.Greater; } }
		public override int TreasureMapLevel{ get{ return 2; } }
		public override bool DisallowAllMoves{ get{ return m_TrueForm; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }

		public WalkingHallowtree( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_TrueForm );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			
			switch ( version )
			{
				case 0:
				{
					m_TrueForm = reader.ReadBool();
					break;
				}
			}
		}
	}
}