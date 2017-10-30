using System; 

namespace Server.Items 
{ 
    [DynamicFliping]
	[Flipable( 0x09A8, 0x0E80 )]
	public class BoxOfSouls : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x4B; } }
		public override int DefaultDropSound{ get{ return 0x42; } }
		public override int DefaultMaxItems{ get{ return 500; } }
		public override int DefaultMaxWeight
		{get{
			if (IsSecure)
				return 0;
			return 1600;
			}
		}

		[Constructable]
		public BoxOfSouls() : base( 0x0E80 )
        {
		Name = "A Halloween Box Of Souls";
		Weight = 8.0;
		BoxOfSoulsHue();
		Movable = true;
        }
		public virtual void BoxOfSoulsHue()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=(1150); break;
                    case 1: Hue=(1153); break;
                    case 2: Hue=(1154); break;
                    case 3: Hue=(1176); break;
                    case 4: Hue=(1195); break;
                }
        }
		public BoxOfSouls( Serial serial ) : base( serial )
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