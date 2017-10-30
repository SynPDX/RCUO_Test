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
	[CorpseName( "the body of a lost soul" )]
	public class LostSoul : BaseCreature
	{
		private bool m_TrueForm;
		[Constructable]
		public LostSoul() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a lost soul";
			BodyValue = 146;
			Hue = 1175;

			SetStr( 900, 1000 );
			SetDex( 125, 135 );
			SetInt( 1000, 1200 );

			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 60;

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 60, 80 );
			SetResistance( ResistanceType.Poison, 60, 80 );
			SetResistance( ResistanceType.Energy, 60, 80 );

			SetSkill( SkillName.Wrestling, 90.1, 100.0 );
			SetSkill( SkillName.Tactics, 90.2, 110.0 );
			SetSkill( SkillName.MagicResist, 120.2, 160.0 );
			SetSkill( SkillName.Magery, 120.0 );
			SetSkill( SkillName.EvalInt, 120.0 );
			SetSkill( SkillName.Meditation, 120.0 );
			Fame = 45000;
			Karma = -45000;

			VirtualArmor = 50;
			Hue = 0;
			switch ( Utility.Random( 2 ))
			{
				case 0: PackItem( new Halloween2017SkullRugSouthDeed() ); break; 
			    case 1: PackItem( new Halloween2017SkullRugEastDeed() ); break;
			}
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
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 2 ))
				{
					case 0: PackItem( new Halloween2017SkullRugSouthDeed() ); break; 
					case 1: PackItem( new Halloween2017SkullRugEastDeed() ); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
                switch ( Utility.Random( 213 ))
                {
                    case 0: PackItem(new RunicHammer(CraftResource.Valorite, 20)); break;
                    case 1: PackItem(new RunicHammer(CraftResource.Valorite, 5)); break;
                    case 2: PackItem(new RunicHammer(CraftResource.Valorite, 3)); break;
                    case 3: PackItem(new RunicHammer(CraftResource.Valorite, 1)); break;
                    case 4: PackItem(new RunicHammer(CraftResource.Verite, 20)); break;
                    case 5: PackItem(new RunicHammer(CraftResource.Verite, 5)); break;
                    case 6: PackItem(new RunicHammer(CraftResource.Verite, 3)); break;
                    case 7: PackItem(new RunicHammer(CraftResource.Verite, 1)); break;
                    case 8: PackItem(new RunicHammer(CraftResource.Agapite, 20)); break;
                    case 9: PackItem(new RunicHammer(CraftResource.Agapite, 20)); break;
                    case 10: PackItem(new RunicHammer(CraftResource.Agapite, 5)); break;
                    case 11: PackItem(new RunicHammer(CraftResource.Agapite, 5)); break;
                    case 12: PackItem(new RunicHammer(CraftResource.Agapite, 3)); break;
                    case 13: PackItem(new RunicHammer(CraftResource.Agapite, 3)); break;
                    case 14: PackItem(new RunicHammer(CraftResource.Agapite, 2)); break;
                    case 15: PackItem(new RunicHammer(CraftResource.Agapite, 2)); break;
                    case 16: PackItem(new RunicHammer(CraftResource.Gold, 20)); break;
                    case 17: PackItem(new RunicHammer(CraftResource.Gold, 20)); break;
                    case 18: PackItem(new RunicHammer(CraftResource.Gold, 20)); break;
                    case 19: PackItem(new RunicHammer(CraftResource.Gold, 20)); break;
                    case 20: PackItem(new RunicHammer(CraftResource.Gold, 5)); break;
                    case 21: PackItem(new RunicHammer(CraftResource.Gold, 5)); break;
                    case 22: PackItem(new RunicHammer(CraftResource.Gold, 5)); break;
                    case 23: PackItem(new RunicHammer(CraftResource.Gold, 5)); break;
                    case 24: PackItem(new RunicHammer(CraftResource.Bronze, 20)); break;
                    case 25: PackItem(new RunicHammer(CraftResource.Bronze, 20)); break;
                    case 26: PackItem(new RunicHammer(CraftResource.Bronze, 20)); break;
                    case 27: PackItem(new RunicHammer(CraftResource.Bronze, 20)); break;
                    case 28: PackItem(new RunicHammer(CraftResource.Bronze, 5)); break;
                    case 29: PackItem(new RunicHammer(CraftResource.Bronze, 5)); break;
                    case 30: PackItem(new RunicHammer(CraftResource.Bronze, 5)); break;
                    case 31: PackItem(new RunicHammer(CraftResource.Bronze, 5)); break;
                    case 32: PackItem(new RunicHammer(CraftResource.Copper, 20)); break;
                    case 33: PackItem(new RunicHammer(CraftResource.Copper, 20)); break;
                    case 34: PackItem(new RunicHammer(CraftResource.Copper, 20)); break;
                    case 35: PackItem(new RunicHammer(CraftResource.Copper, 20)); break;
                    case 36: PackItem(new RunicHammer(CraftResource.Copper, 5)); break;
                    case 37: PackItem(new RunicHammer(CraftResource.Copper, 5)); break;
                    case 38: PackItem(new RunicHammer(CraftResource.Copper, 5)); break;
                    case 39: PackItem(new RunicHammer(CraftResource.Copper, 5)); break;
                    case 40: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 41: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 42: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 43: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 44: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 45: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 46: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 47: PackItem(new RunicHammer(CraftResource.ShadowIron, 20)); break;
                    case 48: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 49: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 50: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 51: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 52: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 53: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 54: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 55: PackItem(new RunicHammer(CraftResource.ShadowIron, 5)); break;
                    case 56: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 57: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 58: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 59: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 60: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 61: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 62: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 63: PackItem(new RunicHammer(CraftResource.DullCopper, 20)); break;
                    case 64: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 65: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 66: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 67: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 68: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 69: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 70: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 71: PackItem(new RunicHammer(CraftResource.DullCopper, 5)); break;
                    case 72: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 73: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 74: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 75: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 76: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 77: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 78: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 79: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 80: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 81: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 20)); break;
                    case 82: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 5)); break;
                    case 83: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 5)); break;
                    case 84: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 5)); break;
                    case 85: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 5)); break;
                    case 86: PackItem(new RunicSewingKit(CraftResource.SpinedLeather, 5)); break;
                    case 87: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 88: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 89: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 90: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 91: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 92: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 93: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 94: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 95: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 96: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 20)); break;
                    case 97: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 5)); break;
                    case 98: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 5)); break;
                    case 99: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 5)); break;
                    case 100: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 5)); break;
                    case 101: PackItem(new RunicSewingKit(CraftResource.HornedLeather, 5)); break;
                    case 102: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 20)); break;
                    case 103: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 20)); break;
                    case 104: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 105: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 106: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 20)); break;
                    case 107: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 108: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 109: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 20)); break;
                    case 110: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 111: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 20)); break;
                    case 112: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 113: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 114: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 115: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 116: PackItem(new RunicSewingKit(CraftResource.BarbedLeather, 5)); break;
                    case 117: PackItem(new RunicFletcherTool(CraftResource.OakWood, 20)); break;
                    case 118: PackItem(new RunicFletcherTool(CraftResource.OakWood, 20)); break;
                    case 119: PackItem(new RunicFletcherTool(CraftResource.OakWood, 5)); break;
                    case 120: PackItem(new RunicFletcherTool(CraftResource.OakWood, 5)); break;
                    case 121: PackItem(new RunicFletcherTool(CraftResource.OakWood, 5)); break;
                    case 122: PackItem(new RunicFletcherTool(CraftResource.OakWood, 5)); break;
                    case 123: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 124: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 125: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 126: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 127: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 128: PackItem(new RunicFletcherTool(CraftResource.OakWood, 3)); break;
                    case 129: PackItem(new RunicFletcherTool(CraftResource.AshWood, 20)); break;
                    case 130: PackItem(new RunicFletcherTool(CraftResource.AshWood, 20)); break;
                    case 131: PackItem(new RunicFletcherTool(CraftResource.AshWood, 5)); break;
                    case 132: PackItem(new RunicFletcherTool(CraftResource.AshWood, 5)); break;
                    case 133: PackItem(new RunicFletcherTool(CraftResource.AshWood, 5)); break;
                    case 134: PackItem(new RunicFletcherTool(CraftResource.AshWood, 5)); break;
                    case 135: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 136: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 137: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 138: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 139: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 140: PackItem(new RunicFletcherTool(CraftResource.AshWood, 3)); break;
                    case 141: PackItem(new RunicFletcherTool(CraftResource.YewWood, 20)); break;
                    case 142: PackItem(new RunicFletcherTool(CraftResource.YewWood, 20)); break;
                    case 143: PackItem(new RunicFletcherTool(CraftResource.YewWood, 5)); break;
                    case 144: PackItem(new RunicFletcherTool(CraftResource.YewWood, 5)); break;
                    case 145: PackItem(new RunicFletcherTool(CraftResource.YewWood, 5)); break;
                    case 146: PackItem(new RunicFletcherTool(CraftResource.YewWood, 5)); break;
                    case 147: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 148: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 149: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 150: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 151: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 152: PackItem(new RunicFletcherTool(CraftResource.YewWood, 3)); break;
                    case 153: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 20)); break;
                    case 154: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 20)); break;
                    case 155: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 5)); break;
                    case 156: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 5)); break;
                    case 157: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 5)); break;
                    case 158: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 5)); break;
                    case 159: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 160: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 161: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 162: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 163: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 164: PackItem(new RunicFletcherTool(CraftResource.Heartwood, 3)); break;
                    case 165: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 20)); break;
                    case 166: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 20)); break;
                    case 167: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 5)); break;
                    case 168: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 5)); break;
                    case 169: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 5)); break;
                    case 170: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 5)); break;
                    case 171: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 172: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 173: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 174: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 175: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 176: PackItem(new RunicDovetailSaw(CraftResource.OakWood, 3)); break;
                    case 177: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 20)); break;
                    case 178: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 20)); break;
                    case 179: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 5)); break;
                    case 180: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 5)); break;
                    case 181: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 5)); break;
                    case 182: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 5)); break;
                    case 183: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 184: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 185: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 186: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 187: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 188: PackItem(new RunicDovetailSaw(CraftResource.AshWood, 3)); break;
                    case 189: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 20)); break;
                    case 190: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 20)); break;
                    case 191: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 5)); break;
                    case 192: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 5)); break;
                    case 193: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 5)); break;
                    case 194: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 5)); break;
                    case 195: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 196: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 197: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 198: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 199: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 200: PackItem(new RunicDovetailSaw(CraftResource.YewWood, 3)); break;
                    case 201: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 20)); break;
                    case 202: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 20)); break;
                    case 203: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 5)); break;
                    case 204: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 5)); break;
                    case 205: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 5)); break;
                    case 206: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 5)); break;
                    case 207: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                    case 208: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                    case 209: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                    case 210: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                    case 211: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                    case 212: PackItem(new RunicDovetailSaw(CraftResource.Heartwood, 3)); break;
                }
            PackItem( new Gold(60000) );
			PackItem( new Gold(60000) );
			PackItem( new Gold(25000) );
			PackItem( new Gold(25000) );
			PackItem( new Gold(60000) );
			PackItem( new Gold(10000) );
		
				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
			}
		}
		public override void OnDeath(Container c)
		{
			base.OnDeath(c);

			// Random non-craft skill PS, can be 5, 10, 15 or 20
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 20));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 20));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			
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
			Name = "the corrupted lost soul";
			BodyValue = 308;
			Hue = 1175;

			Hits = HitsMax;
			Stam = StamMax;
			Mana = ManaMax;

			PublicOverheadMessage( MessageType.Regular, GetRandomHue(),  true, "Y-you!" );

			Map map = this.Map;
			int newghostsx = 8;
				for ( int i = 0; i < newghostsx; ++i )
				{
					BaseCreature ghostsx;

					switch ( Utility.Random( 12 ) )
					{
						default:
						case 0:  ghostsx = new DarkChocolateDragon(); break;
						case 1:	 ghostsx = new WhiteChocolateDragon(); break;
						case 2:  ghostsx = new MilkChocolateDragon(); break;
						case 3:	 ghostsx = new HalloweenWitch(); break;
						case 4:	 ghostsx = new HalloweenScarecrow(); break;
						case 5:  ghostsx = new HalloweenSkeleton(); break;
						case 6:	 ghostsx = new HalloweenZombie(); break;
						case 7:  ghostsx = new GhostPhysical(); break;
						case 8:	 ghostsx = new GhostMagical(); break;
						case 9:  ghostsx = new HalloweenMummy(); break;
						case 10: ghostsx = new HalloweenVampireBat(); break;
						case 11: ghostsx = new TheVampire(); break;
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
		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 45000 : 28000; } }
		[CommandProperty( AccessLevel.GameMaster )]
		public override int ManaMax{ get{ return 3000; } }
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
		public virtual int GetRandomLocation()
		{
			switch ( Utility.Random( 2 ) )
			{
				default:
				case 0: return - Utility.Random( 6 );
				case 1: return + Utility.Random( 6 );
			}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss, 4 );
			AddLoot( LootPack.Meager );
		}
		public override Poison PoisonImmune{ get{ return Poison.Greater; } }
		public override int TreasureMapLevel{ get{ return 2; } }
		public override bool DisallowAllMoves{ get{ return m_TrueForm; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }

		public LostSoul( Serial serial ) : base( serial )
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