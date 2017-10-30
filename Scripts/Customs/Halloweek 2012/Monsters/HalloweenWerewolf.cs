using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a werewolf corpse" )]
	public class FeralHuman : BaseCreature
	{
		private bool m_TrueForm;
		public virtual double BoostedSpeed{ get{ return 0.1; } }		
		[Constructable]
		public FeralHuman() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Name = "a feral human";
			Hue = Utility.RandomSkinHue();

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
			}
			else
			{
				Body = 0x190;
			}
			InitOutfit();
			SetStr( 50, 70 );
			SetDex( 15, 30 );
			SetInt( 61, 75 );
			SetHits( 40, 60 );
			SetDamage( 5, 15 );
			
			SetResistance( ResistanceType.Physical, 40, 55 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Poison, 15, 25 );
			SetResistance( ResistanceType.Energy, 10, 20 );
			
			TokenDropWW(2);
			SetSkill( SkillName.Fencing, 66.0, 97.5 );
			SetSkill( SkillName.Macing, 65.0, 87.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Swords, 65.0, 87.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 30.0, 67.5 );

			Fame = 1200;
			Karma = -1200;
			switch ( Utility.Random( 6 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBagMedium() ); break;
				case 4: PackItem( new TrickOrTreatBagMedium() ); break;
				case 5: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}
		public void Morph()
		{
			if ( m_TrueForm )
				return;

			m_TrueForm = true;
			PlaySound( 0x569 );
			Name = "A Werewolf";
			BodyValue = 250;
			Hue = GetRandomHue();
			SetStr( 100, 110 );
			SetDex( 40, 60 );
			SetInt( 30, 50 );
			SetHits( 300, 325 );
			SetDamage( 20, 30 );
			SetSkill( SkillName.Fencing, 95.0, 110.5 );
			SetSkill( SkillName.Macing, 95.0, 110.5 );
			SetSkill( SkillName.MagicResist, 95.0, 110.5 );
			SetSkill( SkillName.Swords, 95.0, 110.5 );
			SetSkill( SkillName.Tactics, 95.0, 110.5 );
			SetSkill( SkillName.Wrestling, 95.0, 110.5 );

			Hits = HitsMax;

			PublicOverheadMessage( MessageType.Regular, GetRandomHue(),  true, "I'm... Turning!!!" );

			Map map = this.Map;
		}
		public virtual int GetHairHue()
		{
			return Utility.RandomHairHue();
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
		public virtual int GetShoeHue()
		{
			if ( 0.1 > Utility.RandomDouble() )
				return 0;

			return Utility.RandomNeutralHue();
		}
		public virtual void InitOutfit()
		{
			switch ( Utility.Random( 3 ) )
			{
				case 0: AddItem( new FancyShirt( GetRandomHue() ) ); break;
				case 1: AddItem( new Doublet( GetRandomHue() ) ); break;
				case 2: AddItem( new Shirt( GetRandomHue() ) ); break;
			}

			switch ( Utility.Random( 4 ) )
			{
				case 0: AddItem( new Shoes( GetShoeHue() ) ); break;
				case 1: AddItem( new Boots( GetShoeHue() ) ); break;
				case 2: AddItem( new Sandals( GetShoeHue() ) ); break;
				case 3: AddItem( new ThighBoots( GetShoeHue() ) ); break;
			}

			int hairHue = GetHairHue();

			Utility.AssignRandomHair( this, hairHue );
			Utility.AssignRandomFacialHair( this, hairHue );

			if ( Female )
			{
				switch ( Utility.Random( 6 ) )
				{
					case 0: AddItem( new ShortPants( GetRandomHue() ) ); break;
					case 1:
					case 2: AddItem( new Kilt( GetRandomHue() ) ); break;
					case 3:
					case 4:
					case 5: AddItem( new Skirt( GetRandomHue() ) ); break;
				}
			}
			else
			{
				switch ( Utility.Random( 2 ) )
				{
					case 0: AddItem( new LongPants( GetRandomHue() ) ); break;
					case 1: AddItem( new ShortPants( GetRandomHue() ) ); break;
				}
			}
		}
		public virtual void TokenDropWW(int amount)
        {
            if (0.2 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(5)); break;
					case 1: PackItem(new HalloweenToken(5)); break;
					case 2: PackItem(new HalloweenToken(5)); break;
					case 3: PackItem(new HalloweenToken(5)); break;
					case 4: PackItem(new HalloweenToken(5)); break;
					case 5: PackItem(new HalloweenToken(5)); break;
					case 6: PackItem(new HalloweenToken(5)); break;
					case 7: PackItem(new HalloweenToken(9)); break;
					case 8: PackItem(new HalloweenToken(11)); break;
					case 9: PackItem(new HalloweenToken(12)); break;
				}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Meager );
		}
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }
		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 325 : 56; } }
		public FeralHuman( Serial serial ) : base( serial )
		{
		}
		public override void OnHarmfulSpell( Mobile from )
		{
			if ( !Controlled && ControlMaster == null )
				CurrentSpeed = BoostedSpeed;
		}
		public override void OnGotMeleeAttack( Mobile attacker )
		{
			if ( !Controlled && ControlMaster == null )
				CurrentSpeed = BoostedSpeed;
		}
		public override void OnCombatantChange()
		{
			if ( Combatant == null && !Controlled && ControlMaster == null )
				CurrentSpeed = PassiveSpeed;
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
			
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
		public override bool OnBeforeDeath()
		{
			if ( m_TrueForm )
			{
				if (0.02 > Utility.RandomDouble())
					switch ( Utility.Random( 11 ))
					{
						case 0: PackItem(new Halloween2017Blood1()); break;
						case 1: PackItem(new Halloween2017Blood2()); break;
						case 2: PackItem(new Halloween2017Blood3()); break;
						case 3: PackItem(new Halloween2017BrokenArmoire()); break;
						case 4: PackItem(new Halloween2017RuinedBookcase()); break;
						case 5: PackItem(new Halloween2017BrokenChair1()); break;
						case 6: PackItem(new Halloween2017BrokenChair2()); break;
						case 7: PackItem(new Halloween2017BrokenChair3()); break;
						case 8: PackItem(new Halloween2017BrokenClock()); break;
						case 9: PackItem(new Halloween2017DamagedBooks()); break;
						case 10: PackItem(new Halloween2017BrokenChestOfDrawers()); break;
					}

				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
			}
		}
		public override int GetAngerSound()
		{
			return 0x52D;
		}

		public override int GetIdleSound()
		{
			return 0x52C;
		}

		public override int GetAttackSound()
		{
			return 0x52B;
		}

		public override int GetHurtSound()
		{
			return 0x52E;
		}

		public override int GetDeathSound()
		{
			return 0x52A;
		}
	}
}