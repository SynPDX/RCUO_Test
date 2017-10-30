using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MediumCandyBag : BaseContainer, IDyable
	{
		[Constructable]
		public MediumCandyBag() : base( 0xE75 )
		{
			Layer = Layer.Backpack;
			Weight = 3.0;
			Name = "A Medium Halloween Candy Bag";
			HalloweenMCandyBagColor();
		}
		public virtual void HalloweenMCandyBagColor()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(48); break;
                    case 1: Hue=(1154); break;
                    case 2: Hue=(1175); break;
                }
        }
		public override int DefaultMaxItems{ get{ return 750; } }
		private static Type[] Candy = new Type[]
		{
			typeof( GummyMan ),
			typeof( GummyBear ),
			typeof( MilkChocolateDragonF ),
			typeof( DarkChocolateDragonF ),
			typeof( WhiteChocolateDragonF ),
			typeof( ChocolateLog ),
			typeof( ChocolateBar ),
			typeof( RockCandy ),
			typeof( GummyWoman ),
			typeof( GummyZombie ),
			typeof( GummySkeleton ),
			typeof( ChocolateMan ),
			typeof( ChocolateMiguel ),
			typeof( ChocolateSkeleton ),
			typeof( ChocolateZombie ),
			typeof( ChocolateHeart ),
			typeof( MilkChocolateScales ),
			typeof( DarkChocolateScales ),
			typeof( WhiteChocolateScales ),
			typeof( ChocolateDragonSkull ),
			typeof( ChocolateWoman )
		};
        public override bool OnDragDropInto(Mobile from, Item item, Point3D p)
        {
            if (item is Candy)
            {
                return base.OnDragDropInto(from, item, p);
            }
            else
            {
                from.SendMessage("That is not candy.");
                return false;
            }
        }
        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            if (from == null || dropped == null)
                return false;

            if (dropped is Candy)
            {
                return base.OnDragDrop(from, dropped);
            }
            else
            {
                from.SendMessage("That is not candy.");
                return false;
            }
        }
		public MediumCandyBag( Serial serial ) : base( serial )
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
		public bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted ) return false;

			Hue = sender.DyedHue;

			return true;
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			// if ( version == 0 && ItemID == 0x9B2 )
				ItemID = 0xE75;
		}
	}
}