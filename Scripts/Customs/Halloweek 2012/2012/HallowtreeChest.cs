using System.Collections;
using System;
using System.Collections.Generic;
using Server.Multis;
using Server.Mobiles;
using Server.Network;
using Server.ContextMenus;

namespace Server.Items 
{ 
    [DynamicFliping]
	[Flipable( 0x4102, 0x4106 )]
	public class HallowtreeChest : LockableContainer
	{

		public override int DefaultGumpID{ get{ return 0x49; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public HallowtreeChest() : base( 0x4102 )
        {
			Weight = 2.0;
			Name = "Hallowtree Chest";
			HallowchestHue();
        }
		public virtual void HallowchestHue()
        {
                switch (Utility.Random(2))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(1175); break;
                }
        }
		public override void OnDoubleClick( Mobile m )
		{
		if ( m.InRange( this.GetWorldLocation(), 2 ) )
			{
				if ( ItemID == 0x4102 )
				{
					m.PlaySound( 0x02D );
					ItemID = 0x4105;
					m.RemoveItem(this);
					m.EquipItem(this);
					Open( m );
				}
				else if ( ItemID == 0x4105 )
				{
					m.PlaySound( 0x02C );
					ItemID = 0x4102;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x4106 )
				{
					m.PlaySound( 0x02D );
					ItemID = 0x4109;
					m.RemoveItem(this);
					m.EquipItem(this);
					Open( m );
				}
				else if ( ItemID == 0x4109 )
				{
					m.PlaySound( 0x02C );
					ItemID = 0x4106;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
			}
		else
			m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
        }
		public HallowtreeChest( Serial serial ) : base( serial )
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
	public class HallowtreeLog : Item
	{
		[Constructable]
		public HallowtreeLog() : this( 1 )
		{
		}
		
		[Constructable]
		public HallowtreeLog( int amount ) : base( 0x1BDD )
		{
			Name = "Hallowtree Log";
			Hue = 1175;
			Stackable = true;
			Amount = 20;
		}
		public HallowtreeLog( Serial serial ) : base( serial )
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