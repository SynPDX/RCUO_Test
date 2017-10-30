using System;

namespace Server.Items
{
	public class HalloweenToken : Item
	{
		public override double DefaultWeight
		{
			get { return ( Core.ML ? ( 0.02 / 3 ) : 0.02 ); }
		}

		[Constructable]
		public HalloweenToken() : this( 1 )
		{
		}

		[Constructable]
		public HalloweenToken( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
		{
		}

		[Constructable]
		public HalloweenToken( int amount ) : base( 0xEED )
		{
			Name = "Halloween Tokens";
			Stackable = true;
			Amount = amount;
			HalloweenTokenColor();
		}
		public virtual void HalloweenTokenColor()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(48); break;
                    case 1: Hue=(1175); break;
					case 2: Hue=(1154); break;
				}
		}
		public HalloweenToken( Serial serial ) : base( serial )
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
		public override int GetDropSound()
		{
			if ( Amount <= 1 )
				return 0x2E4;
			else if ( Amount <= 5 )
				return 0x2E5;
			else
				return 0x2E6;
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