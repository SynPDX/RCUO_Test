using System;
using Server.Engines.VeteranRewards;
using Server.Gumps;
using Server.Multis;
using Server.Network;

namespace Server.Items
{
	public class Halloween2017SkullRugSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{ 
			get
			{ 
				Halloween2017SkullRugSouthDeed deed = new Halloween2017SkullRugSouthDeed();
				deed.TMap = m_TMap;

				return deed; 
			} 
		}

		private int m_TMap;		

		[CommandProperty( AccessLevel.GameMaster )]
		public int TMap
		{
			get{ return m_TMap; }
			set{ m_TMap = value; InvalidateProperties(); }
		}

		private Timer m_Timer;
		

		[Constructable]
		public Halloween2017SkullRugSouthAddon() : base()
		{
			AddComponent( new AddonComponent( 0x4709 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 0x470C ), -1, -1, 0 );
			AddComponent( new AddonComponent( 0x470F ),  0, -1, 0 );
			AddComponent( new AddonComponent( 0x470D ),  1, -1, 0 );
			AddComponent( new AddonComponent( 0x470E ),  2, -1, 0 );
			AddComponent( new AddonComponent( 0x4708 ), -2,  0, 0 );
			AddComponent( new AddonComponent( 0x470B ), -1,  0, 0 );
			AddComponent( new AddonComponent( 0x4707 ),  0,  0, 0 );
			AddComponent( new AddonComponent( 0x4710 ),  1,  0, 0 );
			AddComponent( new AddonComponent( 0x470A ),  2,  0, 0 );
			AddComponent( new AddonComponent( 0x4714 ), -2,  1, 0 );
			AddComponent( new AddonComponent( 0x4713 ), -1,  1, 0 );
			AddComponent( new AddonComponent( 0x4711 ),  0,  1, 0 );
			AddComponent( new AddonComponent( 0x4715 ),  1,  1, 0 );
			AddComponent( new AddonComponent( 0x4712 ),  2,  1, 0 );
			
			m_Timer = Timer.DelayCall( TimeSpan.FromDays( 7 ), TimeSpan.FromDays( 7 ), new TimerCallback( GiveTMap ) );
			Hue = 1175;
		}

		public Halloween2017SkullRugSouthAddon( Serial serial ) : base( serial )
		{
		}
		
		private void GiveTMap()
		{
			m_TMap = Math.Min( 10, m_TMap +1 );
			
		}
		
		public override void OnComponentUsed( AddonComponent c, Mobile from )
		{			
			BaseHouse house = BaseHouse.FindHouseAt( this );

			if (!from.InRange(GetWorldLocation(), 2) || !from.InLOS(this) || !((from.Z - Z) > -3 && (from.Z - Z) < 3))
			{
				from.LocalOverheadMessage(Network.MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
			}
			else if ( house != null && house.HasSecureAccess( from, SecureLevel.Friends ) )
			{
				if ( m_TMap > 0 )
				{
					Item TMap = null;

					switch ( Utility.Random( 1 ) )
					{
						case 0: TMap = new TreasureMap( Utility.RandomMinMax( 1, 6 ), Map.Trammel ); break;
					}

					int amount = Math.Min( 1, m_TMap );
					TMap.Amount = amount;
					
					if ( !from.PlaceInBackpack( TMap ) )
					{
						from.SendLocalizedMessage( 1078837 ); // Your backpack is full! Please make room and try again.
					}
					else
					{
						m_TMap -= amount;
						from.SendLocalizedMessage( 1150084 ); // A treasure map has been placed in your backpack.
					}
				}
				else 
					from.SendLocalizedMessage( 1150083 ); // The item only produces resources once per week.
			}
			else 
				from.SendLocalizedMessage( 1061637 ); // You are not allowed to access this.
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version

			writer.Write( (int) m_TMap );

			if ( m_Timer != null )
				writer.Write( (DateTime) m_Timer.Next );
			else
				writer.Write( (DateTime) DateTime.Now + TimeSpan.FromDays( 7 ) );
		}
            
        public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();

			m_TMap = reader.ReadInt();

			DateTime next = reader.ReadDateTime();

			if ( next < DateTime.Now )
				next = DateTime.Now;	

			m_Timer = Timer.DelayCall( next - DateTime.Now, TimeSpan.FromDays( 7 ), new TimerCallback( GiveTMap ) );
		}
		
	}

	public class Halloween2017SkullRugSouthDeed : BaseAddonDeed
	{
		
		public override BaseAddon Addon
		{ 
			get
			{ 
				Halloween2017SkullRugSouthAddon addon = new Halloween2017SkullRugSouthAddon();
				addon.TMap = m_TMap;

				return addon; 
			} 
		}	

		private int m_TMap;		

		[CommandProperty( AccessLevel.GameMaster )]
		public int TMap
		{
			get{ return m_TMap; }
			set{ m_TMap = value; InvalidateProperties(); }
		}
		

		[Constructable]
		public Halloween2017SkullRugSouthDeed() 
		{
			Name = "Halloween 2017 Skull Rug South Deed";
		}

		public Halloween2017SkullRugSouthDeed( Serial serial ) : base( serial )
		{
		}
		
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version

			writer.Write( (int) m_TMap );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();

			m_TMap = reader.ReadInt();
		}
	}
	public class Halloween2017SkullRugEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{ 
			get
			{ 
				Halloween2017SkullRugEastDeed deed = new Halloween2017SkullRugEastDeed();
				deed.TMap = m_TMap;

				return deed; 
			} 
		}

		private int m_TMap;		

		[CommandProperty( AccessLevel.GameMaster )]
		public int TMap
		{
			get{ return m_TMap; }
			set{ m_TMap = value; InvalidateProperties(); }
		}

		private Timer m_Timer;
		

		[Constructable]
		public Halloween2017SkullRugEastAddon() : base()
		{
			AddComponent( new AddonComponent( 18200 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 18199 ),  0, 2, 0 );
			AddComponent( new AddonComponent( 18198 ), 	1, 2, 0 );
			AddComponent( new AddonComponent( 18211 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 18210 ), 	0, 1, 0 );
			AddComponent( new AddonComponent( 18209 ), 	1, 1, 0 );
			AddComponent( new AddonComponent( 18238 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 18237 ),  0, 0, 0 );
			AddComponent( new AddonComponent( 18236 ),  1, 0, 0 );
			AddComponent( new AddonComponent( 18241 ), -1,-1, 0 );
			AddComponent( new AddonComponent( 18240 ),  0,-1, 0 );
			AddComponent( new AddonComponent( 18239 ),  1,-1, 0 );
			AddComponent( new AddonComponent( 18244 ), -1,-2, 0 );
			AddComponent( new AddonComponent( 18243 ),  0,-2, 0 );
			AddComponent( new AddonComponent( 18242 ),  1,-2, 0 );
			
			m_Timer = Timer.DelayCall( TimeSpan.FromDays( 7 ), TimeSpan.FromDays( 7 ), new TimerCallback( GiveTMap ) );
			
			Hue = 1175;
		}
		

		public Halloween2017SkullRugEastAddon( Serial serial ) : base( serial )
		{
		}
		
		private void GiveTMap()
		{
			m_TMap = Math.Min( 10, m_TMap +1 );
			
		}
		
		public override void OnComponentUsed( AddonComponent c, Mobile from )
		{			
			BaseHouse house = BaseHouse.FindHouseAt( this );

			if (!from.InRange(GetWorldLocation(), 2) || !from.InLOS(this) || !((from.Z - Z) > -3 && (from.Z - Z) < 3))
			{
				from.LocalOverheadMessage(Network.MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
			}
			else if ( house != null && house.HasSecureAccess( from, SecureLevel.Friends ) )
			{
				if ( m_TMap > 0 )
				{
					Item TMap = null;

					switch ( Utility.Random( 1 ) )
					{
						case 0: TMap = new TreasureMap( Utility.RandomMinMax( 1, 6 ), Map.Trammel ); break;
					}

					int amount = Math.Min( 1, m_TMap );
					TMap.Amount = amount;
					
					if ( !from.PlaceInBackpack( TMap ) )
					{
						from.SendLocalizedMessage( 1078837 ); // Your backpack is full! Please make room and try again.
					}
					else
					{
						m_TMap -= amount;
						from.SendLocalizedMessage( 1150084 ); // A treasure map has been placed in your backpack.
					}
				}
				else 
					from.SendLocalizedMessage( 1150083 ); // The item only produces resources once per week.
			}
			else 
				from.SendLocalizedMessage( 1061637 ); // You are not allowed to access this.
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
			
			writer.Write( (int) m_TMap );

			if ( m_Timer != null )
				writer.Write( (DateTime) m_Timer.Next );
			else
				writer.Write( (DateTime) DateTime.Now + TimeSpan.FromDays( 7 ) );
		}
            
        public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
			
			m_TMap = reader.ReadInt();

			DateTime next = reader.ReadDateTime();

			if ( next < DateTime.Now )
				next = DateTime.Now;	

			m_Timer = Timer.DelayCall( next - DateTime.Now, TimeSpan.FromDays( 7 ), new TimerCallback( GiveTMap ) );
		}
		
	}

	public class Halloween2017SkullRugEastDeed : BaseAddonDeed
	{
		
		public override int LabelNumber{ get{ return 1150047; } } // A Skull Rug (East)
		
		public override BaseAddon Addon
		{ 
			get
			{ 
				Halloween2017SkullRugEastAddon addon = new Halloween2017SkullRugEastAddon();
				addon.TMap = m_TMap;

				return addon; 
			} 
		}	

		private int m_TMap;		

		[CommandProperty( AccessLevel.GameMaster )]
		public int TMap
		{
			get{ return m_TMap; }
			set{ m_TMap = value; InvalidateProperties(); }
		}
		

		[Constructable]
		public Halloween2017SkullRugEastDeed() 
		{
			Name = "Halloween 2017 Skull Rug East Deed";
		}

		public Halloween2017SkullRugEastDeed( Serial serial ) : base( serial )
		{
		}
		
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version

			writer.Write( (int) m_TMap );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
			
			m_TMap = reader.ReadInt();
		}
	}
}