using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fifth;
using Server.Engines.CannedEvil;
using System.Collections;

namespace Server.Mobiles
{
	[CorpseName( "a vampire's corpse" )]
	public class TheVampire : BaseCreature
	{
		[Constructable]
		public TheVampire() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the vampire";
			GetHairHue();

			Utility.AssignRandomHair( this );
			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				AddItem( new HalloweenVampireCapeMONSTER() );
				FemaleVampireCloths(1);
				FemaleVampireNames(1);
			}
			else
			{
				Body = 0x190;
				AddItem( new HalloweenVampireCapeMONSTER() );
				MaleVampireCloths(1);
				MaleVampireNames(1);
				Utility.AssignRandomFacialHair( this );
			}
			SetStr( 150, 212 );
			SetDex( 36, 75 );
			SetInt( 202, 350 );
			Hue = 0;
			SetHits( 325, 450 );
			SetStam( 51, 150 );

			SetDamage( 18, 24 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 40, 50 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 70, 90 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Energy, 40, 50 );
			RareDropVampire(1);
			SetSkill( SkillName.Necromancy, 89, 99.1 );
			SetSkill( SkillName.SpiritSpeak, 90.0, 99.0 );
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

			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 80;
			
			PackItem( new TrickOrTreatBagMedium() );
			PackItem( new Gold(2500) );
			TokenDropVampire(1);
			QuestDropVampire(1);
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
		public virtual void TokenDropVampire(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(15)); break;
					case 1: PackItem(new HalloweenToken(15)); break;
					case 2: PackItem(new HalloweenToken(15)); break;
					case 3: PackItem(new HalloweenToken(15)); break;
					case 4: PackItem(new HalloweenToken(15)); break;
					case 5: PackItem(new HalloweenToken(15)); break;
					case 6: PackItem(new HalloweenToken(15)); break;
					case 7: PackItem(new HalloweenToken(25)); break;
					case 8: PackItem(new HalloweenToken(35)); break;
					case 9: PackItem(new HalloweenToken(45)); break;
				}
		}
		public virtual void MaleVampireNames(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 146 ))
				{
					case 0: Name=("Aaron"); break;
					case 1: Name=("Acheron"); break;
					case 2: Name=("Alabaster"); break;
					case 3: Name=("Alfes"); break;
					case 4: Name=("Algul"); break;
					case 5: Name=("Alvantin"); break;
					case 6: Name=("Argent"); break;
					case 7: Name=("Armand"); break;
					case 8: Name=("Armenki"); break;
					case 9: Name=("Ash"); break;
					case 10: Name=("Asher"); break;
					case 11: Name=("Augustine"); break;
					case 12: Name=("Babylon"); break;
					case 13: Name=("Blade"); break;
					case 14: Name=("Blue"); break;
					case 15: Name=("Boris"); break;
					case 16: Name=("Bram"); break;
					case 17: Name=("Brink"); break;
					case 18: Name=("Conti"); break;
					case 19: Name=("Crimson"); break;
					case 20: Name=("Cross"); break;
					case 21: Name=("Daetrine"); break;
					case 22: Name=("Damian"); break;
					case 23: Name=("Damon"); break;
					case 24: Name=("Darius"); break;
					case 25: Name=("Dax"); break;
					case 26: Name=("December"); break;
					case 27: Name=("Devin"); break;
					case 28: Name=("Dimitri"); break;
					case 29: Name=("Drachen"); break;
					case 30: Name=("Draegan"); break;
					case 31: Name=("Drakkar"); break;
					case 32: Name=("Draven"); break;
					case 33: Name=("Dred"); break;
					case 34: Name=("Dusk"); break;
					case 35: Name=("Echo"); break;
					case 36: Name=("Edge"); break;
					case 37: Name=("Elijah"); break;
					case 38: Name=("Eric"); break;
					case 39: Name=("Eventide"); break;
					case 40: Name=("February"); break;
					case 41: Name=("Felipe"); break;
					case 42: Name=("Felix"); break;
					case 43: Name=("Folleti"); break;
					case 44: Name=("Forest"); break;
					case 45: Name=("Forestor"); break;
					case 46: Name=("Frost"); break;
					case 47: Name=("Gabriel"); break;
					case 48: Name=("Garan"); break;
					case 49: Name=("Garrett"); break;
					case 50: Name=("Gavner"); break;
					case 51: Name=("Gossamer"); break;
					case 52: Name=("Gotham"); break;
					case 53: Name=("Granite"); break;
					case 54: Name=("Gusty"); break;
					case 55: Name=("Hades"); break;
					case 56: Name=("Hunter"); break;
					case 57: Name=("Illusion"); break;
					case 58: Name=("Infinity"); break;
					case 59: Name=("Ivar"); break;
					case 60: Name=("Jagger"); break;
					case 61: Name=("Jett"); break;
					case 62: Name=("Julian"); break;
					case 63: Name=("Kaige"); break;
					case 64: Name=("Kaleo"); break;
					case 65: Name=("Kane"); break;
					case 66: Name=("Konrad"); break;
					case 67: Name=("Kraven"); break;
					case 68: Name=("Langley"); break;
					case 69: Name=("Laurent"); break;
					case 70: Name=("Layre"); break;
					case 71: Name=("Leopold"); break;
					case 72: Name=("Leviathan"); break;
					case 73: Name=("Locke"); break;
					case 74: Name=("Lucas"); break;
					case 75: Name=("Lucifer"); break;
					case 76: Name=("Magnus"); break;
					case 77: Name=("Maladict"); break;
					case 78: Name=("Malcohm"); break;
					case 79: Name=("Marius"); break;
					case 80: Name=("Marko"); break;
					case 81: Name=("Marlowe"); break;
					case 82: Name=("Mayze"); break;
					case 83: Name=("Meteor"); break;
					case 84: Name=("Mink"); break;
					case 85: Name=("Mirage"); break;
					case 86: Name=("Mitchelle"); break;
					case 87: Name=("Morrow"); break;
					case 88: Name=("Mortum"); break;
					case 89: Name=("Nash"); break;
					case 90: Name=("Nathan"); break;
					case 91: Name=("Nicolae"); break;
					case 92: Name=("Nicolas"); break;
					case 93: Name=("Obsidian"); break;
					case 94: Name=("October"); break;
					case 95: Name=("Oleander"); break;
					case 96: Name=("Onyx"); break;
					case 97: Name=("Otis"); break;
					case 98: Name=("Pagan"); break;
					case 99: Name=("Pardon"); break;
					case 100: Name=("Phury"); break;
					case 101: Name=("Prysm"); break;
					case 102: Name=("Quentin"); break;
					case 103: Name=("Rapture"); break;
					case 104: Name=("Redcap"); break;
					case 105: Name=("Rakshasas"); break;
					case 106: Name=("Rave"); break;
					case 107: Name=("Refuge"); break;
					case 108: Name=("Rido"); break;
					case 109: Name=("Sable"); break;
					case 110: Name=("Sabre"); break;
					case 111: Name=("Salem"); break;
					case 112: Name=("Santiago"); break;
					case 113: Name=("Satanei"); break;
					case 114: Name=("Seraphim"); break;
					case 115: Name=("Seth"); break;
					case 116: Name=("Severus"); break;
					case 117: Name=("Shadow"); break;
					case 118: Name=("Silas"); break;
					case 119: Name=("Sorin"); break;
					case 120: Name=("Solomon"); break;
					case 121: Name=("Soul"); break;
					case 122: Name=("Steele"); break;
					case 123: Name=("Stefan"); break;
					case 124: Name=("Strigon"); break;
					case 125: Name=("Talon"); break;
					case 126: Name=("Tempest"); break;
					case 127: Name=("Thorment"); break;
					case 128: Name=("Thunder"); break;
					case 129: Name=("Upir"); break;
					case 130: Name=("Viktor"); break;
					case 131: Name=("Vlad"); break;
					case 132: Name=("Vladamir"); break;
					case 133: Name=("Vincen"); break;
					case 134: Name=("Wednesday"); break;
					case 135: Name=("Wish"); break;
					case 136: Name=("Willow"); break;
					case 137: Name=("Wrath"); break;
					case 138: Name=("Xavier"); break;
					case 139: Name=("Yolando"); break;
					case 140: Name=("Zane"); break;
					case 141: Name=("Zaire"); break;
					case 142: Name=("Ze"); break;
					case 143: Name=("Zer"); break;
					case 144: Name=("Zillah"); break;
					case 145: Name=("Zorak"); break;
				}
		}
		public virtual void FemaleVampireNames(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 85 ))
				{
					case 0: Name=("Armenia"); break;
					case 1: Name=("Apple"); break;
					case 2: Name=("Angeline"); break;
					case 3: Name=("Brie"); break;
					case 4: Name=("Harlot"); break;
					case 5: Name=("Demonia"); break;
					case 6: Name=("Karmi"); break;
					case 7: Name=("Jocelyn"); break;
					case 8: Name=("Leeta"); break;
					case 9: Name=("Quota"); break;
					case 10: Name=("Ilene"); break;
					case 11: Name=("Fatima"); break;
					case 12: Name=("Margorie"); break;
					case 13: Name=("Ophelia"); break;
					case 14: Name=("Riley"); break;
					case 15: Name=("Xenia"); break;
					case 16: Name=("Sukuya"); break;
					case 17: Name=("Carmina"); break;
					case 18: Name=("Frita"); break;
					case 19: Name=("Clarita"); break;
					case 20: Name=("Zofia"); break;
					case 21: Name=("Imeena"); break;
					case 22: Name=("Kallee"); break;
					case 23: Name=("Lucia"); break;
					case 24: Name=("Maxine"); break;
					case 25: Name=("Gwin"); break;
					case 26: Name=("Gem"); break;
					case 27: Name=("Floris"); break;
					case 28: Name=("Narween"); break;
					case 29: Name=("Quintessa"); break;
					case 30: Name=("Xoxo"); break;
					case 31: Name=("Wysteria"); break;
					case 32: Name=("Belinda"); break;
					case 33: Name=("Beatrix"); break;
					case 34: Name=("Elphina"); break;
					case 35: Name=("Albanian"); break;
					case 36: Name=("Cherry"); break;
					case 37: Name=("Juniper"); break;
					case 38: Name=("Jayde"); break;
					case 39: Name=("Lament"); break;
					case 40: Name=("Magwina"); break;
					case 41: Name=("Habitha"); break;
					case 42: Name=("Grimina"); break;
					case 43: Name=("Katreena"); break;
					case 44: Name=("Nylora"); break;
					case 45: Name=("Paprika"); break;
					case 46: Name=("Yureka"); break;
					case 47: Name=("Ukara"); break;
					case 48: Name=("Upiorzyca"); break;
					case 49: Name=("Ulsa"); break;
					case 50: Name=("Xyla"); break;
					case 51: Name=("Oma"); break;
					case 52: Name=("Slovenian"); break;
					case 53: Name=("Umona"); break;
					case 54: Name=("Yoko"); break;
					case 55: Name=("Yellow"); break;
					case 56: Name=("Trik"); break;
					case 57: Name=("Romanian"); break;
					case 58: Name=("Qutie"); break;
					case 59: Name=("Thistle"); break;
					case 60: Name=("Sybil"); break;
					case 61: Name=("Montenegro"); break;
					case 62: Name=("Zen"); break;
					case 63: Name=("Thyia"); break;
					case 64: Name=("Adrasteia"); break;
					case 65: Name=("Akeldama"); break;
					case 66: Name=("Callidora"); break;
					case 67: Name=("Akantha"); break;
					case 68: Name=("Despoina"); break;
					case 69: Name=("Natasha"); break;
					case 70: Name=("Natassa"); break;
					case 71: Name=("Natasa"); break;
					case 72: Name=("Narkissa"); break;
					case 73: Name=("Ambrosia"); break;
					case 74: Name=("Eva"); break;
					case 75: Name=("Iezabel"); break;
					case 76: Name=("Kharis"); break;
					case 77: Name=("Nerine"); break;
					case 78: Name=("Kora"); break;
					case 79: Name=("Semele"); break;
					case 80: Name=("Maia"); break;
					case 81: Name=("Thana"); break;
					case 82: Name=("Selene"); break;
					case 83: Name=("Polona"); break;
					case 84: Name=("Thyone"); break;
				}
		}
		public virtual void GetHairHue()
		{
			switch ( Utility.Random( 5 ))
			{
				case 0: HairHue=(1154); FacialHairHue=(1154); break;
				case 1: HairHue=(1175); FacialHairHue=(1154); break;
				case 2: HairHue=(1899); FacialHairHue=(1154); break;
				case 3: HairHue=(1900); FacialHairHue=(1154); break;
				case 4: HairHue=(1908); FacialHairHue=(1154); break;
			}
		}
		public virtual void FemaleVampireCloths(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 8 ))
				{
					case 0: AddItem(new FancyShirt(Hue=(1194))); AddItem(new Skirt(Hue=(1194))); AddItem(new Boots(Hue=1175)); break;
					case 1: AddItem(new FancyShirt(Hue=(1194))); AddItem(new FurSarong(Hue=(1194))); AddItem(new Boots(Hue=1175)); break;
					case 2: AddItem(new FancyShirt(Hue=(1194))); AddItem(new Kilt(Hue=(1194))); AddItem(new Boots(Hue=1175)); break;
					case 3: AddItem(new FancyShirt(Hue=(1194))); AddItem(new ElvenPants(Hue=(1194))); AddItem(new Boots(Hue=1175)); break;
					case 4: AddItem(new FancyShirt(Hue=(0))); AddItem(new Skirt(Hue=(1175))); AddItem(new Boots(Hue=1175)); break;
					case 5: AddItem(new FancyShirt(Hue=(0))); AddItem(new FurSarong(Hue=(1175))); AddItem(new Boots(Hue=1175)); break;
					case 6: AddItem(new FancyShirt(Hue=(0))); AddItem(new Kilt(Hue=(1175))); AddItem(new Boots(Hue=1175)); break;
					case 7: AddItem(new FancyShirt(Hue=(0))); AddItem(new ElvenPants(Hue=(902))); AddItem(new Boots(Hue=1175)); break;
				}
		}
		public virtual void MaleVampireCloths(int amount)
        {
            if (1 > Utility.RandomDouble())
				switch ( Utility.Random( 4 ))
				{
					case 0: AddItem(new FancyShirt(Hue=(1194))); AddItem(new ElvenPants(Hue=(1194))); AddItem(new Boots(Hue=1175)); break;
					case 1: AddItem(new FancyShirt(Hue=(0))); AddItem(new ElvenPants(Hue=(902))); AddItem(new Boots(Hue=1175)); break;
					case 2: AddItem(new FancyShirt(Hue=(1194))); AddItem(new ElvenPants(Hue=(1194))); AddItem(new Boots(Hue=1175)); AddItem(new Surcoat(Hue=1194)); break;
					case 3: AddItem(new FancyShirt(Hue=(0))); AddItem(new ElvenPants(Hue=(902))); AddItem(new Boots(Hue=1175)); AddItem(new Surcoat(Hue=1175)); break;
				}
		}
		public virtual void RareDropVampire(int amount)
        {
            if (0.50 > Utility.RandomDouble())
					PackItem(new HalloweenVampireCape());
		}
		public virtual void QuestDropVampire(int amount)
        {
            if (0.8 > Utility.RandomDouble())
					PackItem(new EmptyTalisman());
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 1 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 1 );
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

		public void SpawnVictim( Mobile target )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			int victims = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is HalloweenVampireVictim || m is HalloweenVampireBat )
					++victims;
			}

			if ( victims < 6 )
			{
				PlaySound( 0x3D );

				int newvictimsx = Utility.RandomMinMax( 1, 2 );

				for ( int i = 0; i < newvictimsx; ++i )
				{
					BaseCreature victimsx;

					switch ( Utility.Random( 5 ) )
					{
						default:
						case 0: case 1:	victimsx = new HalloweenVampireVictim(); break;
						case 2: case 3:	victimsx = new HalloweenVampireBat(); break;
						case 4:			victimsx = new HalloweenVampireVictim(); break;
					}

					victimsx.Team = this.Team;

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

					victimsx.MoveToWorld( loc, map );
					victimsx.Combatant = target;
				}
			}
		}
		public void EatVictim()
		{
			ArrayList toEat = new ArrayList();
  
			foreach ( Mobile m in this.GetMobilesInRange( 2 ) )
			{
				if ( m is HalloweenVampireVictim )
					toEat.Add( m );
			}

			if ( toEat.Count > 0 )
			{
				PlaySound( Utility.Random( 0x3B, 2 ) ); // Eat sound

				foreach ( Mobile m in toEat )
				{
					Hits += (m.Hits / 2);
					m.Kill();
				}
			}
		}
		public void DoSpecialAbility( Mobile target )
		{
			if ( target == null || target.Deleted ) //sanity
				return;

			if ( 0.2 >= Utility.RandomDouble() ) // 20% chance to more victims
				SpawnVictim( target );
				
			if ( 0.1 >= Utility.RandomDouble() ) // 10% chance to eat victims
				EatVictim();
		}
		
		public override void OnHarmfulSpell( Mobile attacker )
		{
			if ( !Controlled && ControlMaster == null )
			DoSpecialAbility( attacker );
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

		public TheVampire( Serial serial ) : base( serial )
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