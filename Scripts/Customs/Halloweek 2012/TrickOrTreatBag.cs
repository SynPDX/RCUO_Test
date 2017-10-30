using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TrickOrTreatBag : BaseContainer
	{
		[Constructable]
		public TrickOrTreatBag() : base( 0xE76 )
		{
			Weight = 2.0;
			Name = "A Small Trick Or Treat Bag";

			HalloweenColor();
            Candy(3);
		}
	public virtual void Candy(int amount)
        {
            for (int i = 0; i < amount; i++)
                switch (Utility.Random(39))
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
                    case 35: DropItem(new GummyWolf()); break;
                    case 36: DropItem(new ChocolateWolf()); break;
                    case 37: DropItem(new GummyWerewolf()); break;
                    case 38: DropItem(new ChocolateWerewolf()); break;
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
		public TrickOrTreatBag( Serial serial ) : base( serial )
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