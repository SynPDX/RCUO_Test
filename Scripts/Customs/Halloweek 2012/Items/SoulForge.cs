using System;
using Server;

namespace Server.Items
{
	[Server.Engines.Craft.Forge]
	public class Halloween2017SoulForge : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017SoulForgeDeed(); } }

		[Constructable]
		[Server.Engines.Craft.Forge]
		public Halloween2017SoulForge()
		{
			AddComponent( new AddonComponent( 0x44C7 ), 0, 0, 0 );
			Name = "Halloween 2017 Soul Forge";
			Hue = 1175;
		}

		public Halloween2017SoulForge( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}

	public class Halloween2017SoulForgeDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017SoulForge(); } }

		[Constructable]
		public Halloween2017SoulForgeDeed()
		{
		Name = "Halloween Soul Forge";
		Hue = 1175;
		}

		public Halloween2017SoulForgeDeed( Serial serial ) : base( serial )
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

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}