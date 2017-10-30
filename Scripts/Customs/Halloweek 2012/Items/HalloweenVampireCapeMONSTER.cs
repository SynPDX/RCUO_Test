using System;

namespace Server.Items
{
	[Flipable( 0x2B05, 0x2B04 )]
	public class HalloweenVampireCapeMONSTER : BaseCloak
	{
		[Constructable]
		public HalloweenVampireCapeMONSTER() : base( 0x2B05 )
		{
			Name = "A Vampire's Cape";
			Weight = 4.0;
			MONSTERVampireCapeHue();
			LootType=LootType.Blessed;
		}
		public virtual void MONSTERVampireCapeHue()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(1175); break;
                    case 1: Hue=(1194); break;
                    case 2: Hue=(1175); break;
                }
        }
		public HalloweenVampireCapeMONSTER( Serial serial ) : base( serial )
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