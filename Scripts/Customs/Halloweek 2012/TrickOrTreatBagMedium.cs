using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TrickOrTreatBagMedium : BaseContainer
	{
		[Constructable]
		public TrickOrTreatBagMedium() : base( 0xE76 )
		{
			Weight = 2.0;
			Name = "A Medium Trick Or Treat Bag";

			HalloweenColor();
            Candy(5);
			RareDropM(1);
		}
		public virtual void RareDropM(int amount)
        {
            if (0.2 > Utility.RandomDouble())
                switch (Utility.Random(108))
                {
					case 0: DropItem(new Halloween2017WitchesBrew()); break;
					case 1: DropItem(new Halloween2017DecorativeArmor()); break;
					case 2: DropItem(new Halloween2017DecorativeArmor2()); break;
					case 3: DropItem(new Halloween2017IronMaiden()); break;
					case 4: DropItem(new Halloween2017BeefCarcass()); break;
					case 5: DropItem(new Halloween2017BeefCarcass2()); break;
					case 6: DropItem(new Halloween2017CandleSkull()); break;
					case 7: DropItem(new Halloween2017HangingSkeleton1()); break;
					case 8: DropItem(new Halloween2017HangingSkeleton2()); break;
					case 9: DropItem(new Halloween2017HangingSkeleton3()); break;
					case 10: DropItem(new Halloween2017HangingSkeleton4()); break;
					case 11: DropItem(new Halloween2017HangingSkeleton5()); break;
					case 12: DropItem(new Halloween2017Blood1()); break;
					case 13: DropItem(new Halloween2017Blood2()); break;
					case 14: DropItem(new Halloween2017Blood3()); break;
					case 15: DropItem(new Halloween2017SkullPile()); break;
					case 16: DropItem(new Halloween2017SkullPole()); break;
					case 17: DropItem(new Halloween2017Scarecrow()); break;
					case 18: DropItem(new Halloween2017Lantern()); break;
					case 19: DropItem(new Halloween2017BrokenArmoire()); break;
					case 20: DropItem(new Halloween2017RuinedBookcase()); break;
					case 21: DropItem(new Halloween2017CoveredChair()); break;
					case 22: DropItem(new Halloween2017BrokenChair1()); break;
					case 23: DropItem(new Halloween2017BrokenChair2()); break;
					case 24: DropItem(new Halloween2017BrokenChair3()); break;
					case 25: DropItem(new Halloween2017BrokenClock()); break;
					case 26: DropItem(new Halloween2017DamagedBooks()); break;
					case 27: DropItem(new Halloween2017BrokenChestOfDrawers()); break;
					case 28: DropItem(new Halloween2017StumpAxe()); break;
					case 29: DropItem(new Halloween2017Stump()); break;
					case 30: DropItem(new Halloween2017WTub()); break;
					case 31: DropItem(new Halloween2017ETub()); break;
					case 32: DropItem(new Halloween2017Painting1()); break;
					case 33: DropItem(new Halloween2017Painting2()); break;
					case 34: DropItem(new Halloween2017Painting3()); break;
					case 35: DropItem(new Halloween2017Painting4()); break;
					case 36: DropItem(new Halloween2017Painting5()); break;
					case 37: DropItem(new Halloween2017Painting6()); break;
					case 38: DropItem(new Halloween2017Painting7()); break;
					case 39: DropItem(new Halloween2017Painting8()); break;
					case 40: DropItem(new Halloween2017Grave()); break;
					case 41: DropItem(new Halloween2017Spiderweb1()); break;
					case 42: DropItem(new Halloween2017Spiderweb2()); break;
					case 43: DropItem(new Halloween2017SheafWheat()); break;
					case 44: DropItem(new Halloween2017BonePile1()); break;
					case 45: DropItem(new Halloween2017BonePile2()); break;
					case 46: DropItem(new Halloween2017BonePile3()); break;
					case 47: DropItem(new Halloween2017BonePile4()); break;
					case 48: DropItem(new Halloween2017BonePile5()); break;
					case 49: DropItem(new Halloween2017GraveStone()); break;
					case 50: DropItem(new Halloween2017GraveStone2()); break;
					case 51: DropItem(new Halloween2017GraveStone3()); break;
					case 52: DropItem(new Halloween2017GraveStone4()); break;
					case 53: DropItem(new Halloween2017GraveStone5()); break;
					case 54: DropItem(new Halloween2017GraveStone6()); break;
					case 55: DropItem(new Halloween2017GraveStone7()); break;
					case 56: DropItem(new Halloween2017GraveStone8()); break;
					case 57: DropItem(new Halloween2017GraveStone9()); break;
					case 58: DropItem(new Halloween2017GraveStone10()); break;
					case 59: DropItem(new Halloween2017GraveStone11()); break;
					case 60: DropItem(new Halloween2017GraveStone12()); break;
					case 61: DropItem(new Halloween2017GraveStone13()); break;
					case 62: DropItem(new Halloween2017GraveStone14()); break;
					case 63: DropItem(new Halloween2017GraveStone15()); break;
					case 64: DropItem(new Halloween2017GraveStone16()); break;
					case 65: DropItem(new Halloween2017GraveStone17()); break;
					case 66: DropItem(new Halloween2017GraveStone18()); break;
					case 67: DropItem(new Halloween2017GraveStone19()); break;
					case 68: DropItem(new Halloween2017GraveStone20()); break;
					case 69: DropItem(new Halloween2017GraveStone21()); break;
					case 71: DropItem(new Halloween2017GraveStone22()); break;
					case 72: DropItem(new Halloween2017GraveStone23()); break;
					case 73: DropItem(new Halloween2017GraveStone24()); break;
					case 74: DropItem(new Halloween2017GraveStone25()); break;
					case 75: DropItem(new Halloween2017GraveStone26()); break;
					case 76: DropItem(new Halloween2017HauntedMirror()); break;
					case 77: DropItem(new Halloween2017Blood4()); break;
					case 78: DropItem(new Halloween2017Blood5()); break;
					case 79: DropItem(new Halloween2017Blood6()); break;
					case 80: DropItem(new Halloween2017Blood7()); break;
					case 81: DropItem(new Halloween2017Blood8()); break;
					case 82: DropItem(new Halloween2017Blood9()); break;
					case 83: DropItem(new Halloween2017BoneTable()); break;
					case 84: DropItem(new Halloween2017BoneThrone()); break;
					case 85: DropItem(new Halloween2017BoneCouchEastDeed()); break;
					case 86: DropItem(new Halloween2017BoneCouchSouthDeed()); break;
					case 87: DropItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 88: DropItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 99: DropItem(new Halloween2017Cauldron()); break;
					case 100: DropItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 101: DropItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 102: DropItem(new Halloween2017ShadowStone()); break;
					case 103: DropItem(new Halloween2017ShadowShort()); break;
					case 104: DropItem(new Halloween2017ShadowTall()); break;
					case 105: DropItem(new Halloween2017SpikeStatue()); break;
					case 106: DropItem(new Halloween2017SpikePoleStatue()); break;
					case 107: DropItem(new Halloween2017DaemonPoleStatue()); break;
				}
		}
	public virtual void Candy(int amount)
        {
            for (int i = 0; i < amount; i++)
                switch (Utility.Random(40))
                {
                    case 0: DropItem(new RockCandy()); break;
                    case 1: DropItem(new ChocolateBar()); break;
                    case 2: DropItem(new ChocolateLog()); break;
                    case 3: DropItem(new GummyBear()); break;
                    case 4: DropItem(new GummyMan()); break;
                    case 5: DropItem(new GummyWoman()); break;
                    case 6: DropItem(new GummyZombie()); break;
                    case 7: DropItem(new RockCandy()); break;
                    case 8: DropItem(new ChocolateBar()); break;
                    case 9: DropItem(new ChocolateLog()); break;
                    case 10: DropItem(new GummySkeleton()); break;
                    case 11: DropItem(new ChocolateMan()); break;
                    case 12: DropItem(new ChocolateWoman()); break;
                    case 13: DropItem(new ChocolateSkeleton()); break;
                    case 14: DropItem(new ChocolateZombie()); break;
                    case 15: DropItem(new ChocolateHeart()); break;
                    case 16: DropItem(new GummyHeart()); break;
                    case 17: DropItem(new RockCandy()); break;
                    case 18: DropItem(new ChocolateBar()); break;
                    case 19: DropItem(new ChocolateLog()); break;
                    case 20: DropItem(new GummyBear()); break;
                    case 21: DropItem(new GummyMan()); break;
                    case 22: DropItem(new GummyWoman()); break;
                    case 23: DropItem(new GummyZombie()); break;
                    case 24: DropItem(new RockCandy()); break;
                    case 25: DropItem(new ChocolateBar()); break;
                    case 26: DropItem(new ChocolateLog()); break;
                    case 27: DropItem(new GummySkeleton()); break;
                    case 28: DropItem(new ChocolateMan()); break;
                    case 29: DropItem(new ChocolateWoman()); break;
                    case 30: DropItem(new ChocolateSkeleton()); break;
                    case 31: DropItem(new ChocolateZombie()); break;
                    case 32: DropItem(new ChocolateHeart()); break;
                    case 33: DropItem(new GummyHeart()); break;
                    case 34: DropItem(new ChocolateMiguel()); break;
                    case 35: DropItem(new ChocolateDragonSkull()); break;
                    case 36: DropItem(new GummyWolf()); break;
                    case 37: DropItem(new ChocolateWolf()); break;
                    case 38: DropItem(new GummyWerewolf()); break;
                    case 39: DropItem(new ChocolateWerewolf()); break;
                }
        }
	public virtual void HalloweenColor()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(48); break;
                    case 1: Hue=(1154); break;
                    case 2: Hue=(1175); break;
                }
        }
		public TrickOrTreatBagMedium( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}