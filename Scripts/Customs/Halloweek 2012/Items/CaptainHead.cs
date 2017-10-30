using System;

namespace Server.Items
{
	public class CaptainHead : Item
	{
		[Constructable]
		public CaptainHead() : this( 1 )
		{
		}
		[Constructable]
		public CaptainHead( int amount ) : base( 0x1CE1 )
		{
			Name = "The Head of Captain Harold Garden";
			Stackable = false;
			Hue = 1154;
		}
		public CaptainHead( Serial serial ) : base( serial )
		{
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