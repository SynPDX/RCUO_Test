using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;

using System.Collections.Generic;
 
namespace Server.Mobiles
{
    [CorpseName( "Chester corpse" )]
    public class ChesterHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public ChesterHallowQuest()
        {
            Name = "Chester";
                        Title = "the chest maker";
            Body = 400;
            CantWalk = true;
			switch ( Utility.Random( 2 ) )
			{
				case 0: AddItem( new LongPants( GetRandomHue() ) ); break;
				case 1: AddItem( new ShortPants( GetRandomHue() ) ); break;
			}
			switch ( Utility.Random( 3 ) )
			{
				case 0: AddItem( new FancyShirt( GetRandomHue() ) ); break;
				case 1: AddItem( new Doublet( GetRandomHue() ) ); break;
				case 2: AddItem( new Shirt( GetRandomHue() ) ); break;
			}
			switch ( Utility.Random( 4 ) )
			{
				case 0: AddItem( new Shoes( GetShoeHue() ) ); break;
				case 1: AddItem( new Boots( GetShoeHue() ) ); break;
				case 2: AddItem( new Sandals( GetShoeHue() ) ); break;
				case 3: AddItem( new ThighBoots( GetShoeHue() ) ); break;
			}
            int hairHue = 400;
			
			Utility.AssignRandomHair( this, hairHue );
			Utility.AssignRandomFacialHair( this, hairHue );
           
            Blessed = true;
           
            }
 
            public virtual int GetBootsHue()
            {
            return 1161;
        	}
 
        public ChesterHallowQuest( Serial serial ) : base( serial )
        {
        }
 
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new ChesterGumpEntry(from, this));
        }
       
 
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }
 
        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
 
        public class ChesterGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public ChesterGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
            {
                m_Mobile = from;
                m_Giver = giver;
            }
 
            public override void OnClick()
            {
               
 
                          if( !( m_Mobile is PlayerMobile ) )
                    return;
               
                PlayerMobile mobile = (PlayerMobile) m_Mobile;
 
                {
                    if ( ! mobile.HasGump( typeof( ChesterGump ) ) )
                    {
                        mobile.SendGump( new ChesterGump( mobile ));
                       
                    }
                }
            }
        }
 		public virtual int GetRandomHue()
		{
			switch ( Utility.Random( 5 ) )
			{
				default:
				case 0: return Utility.RandomBlueHue();
				case 1: return Utility.RandomGreenHue();
				case 2: return Utility.RandomRedHue();
				case 3: return Utility.RandomYellowHue();
				case 4: return Utility.RandomNeutralHue();
			}
		}
		public virtual int GetShoeHue()
		{
			if ( 0.1 > Utility.RandomDouble() )
				return 0;

			return Utility.RandomNeutralHue();
		}
        public override bool OnDragDrop( Mobile from, Item dropped )
        {                 
                    Mobile m = from;
            PlayerMobile mobile = m as PlayerMobile;
 
            if ( mobile != null)
            {
                if( dropped is HallowtreeLog )
                {
                    if(dropped.Amount!=20)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "This isn't enough Hallowtree Wood to work with.", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Thank you for avenging my son, here you go." );
	 
					dropped.Delete();
					
					mobile.AddToBackpack( new HallowtreeChest() );
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "This isn't Hallowtree Wood.", mobile.NetState );
                }
            }
            return false;
        }
    }
}