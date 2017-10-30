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
    [CorpseName( "Zach corpse" )]
    public class ZachHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public ZachHallowQuest()
        {
            Name = "Zach";
                        Title = "the jack o' farmer";
            Body = 400;
            CantWalk = true;
            int hairHue = 248;
           	AddItem( new StrawHat() );
			AddItem( new ShortPants(Hue=(248)) );
			AddItem( new Shirt(Hue=(548)) );
			AddItem( new Halloween2017Pitchfork() );
 
            switch ( Utility.Random( 1 ) )
            {
                case 0: AddItem( new LongHair( hairHue ) ); break;
            }
           
            Blessed = true;
           
            }
 
            public virtual int GetBootsHue()
            {
            return 248;
        	}
 
        public ZachHallowQuest( Serial serial ) : base( serial )
        {
        }
 
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new ZachGumpEntry(from, this));
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
 
        public class ZachGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public ZachGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( ZachGump ) ) )
                    {
                        mobile.SendGump( new ZachGump( mobile ));
                       
                    }
                }
            }
        }
 
        public override bool OnDragDrop( Mobile from, Item dropped )
        {                 
                    Mobile m = from;
            PlayerMobile mobile = m as PlayerMobile;
 
            if ( mobile != null)
            {
                if( dropped is HalloweenToken )
                {
                    if(dropped.Amount!=50)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 248, false, "You kidding me? Jack O' Lanterns aren't worth that much.", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Thank you, enjoy your Jack O' Lantern." );
	 
					dropped.Delete();
					if( Utility.Random( 100 ) < 100 )
						switch ( Utility.Random( 2 ) )
						{               
							case 0:    mobile.AddToBackpack( new JackOLantern1() ); break;
							case 1:    mobile.AddToBackpack( new JackOLantern2() ); break;
						}
						return true;
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 248, false, "These are not Halloween Tokens...", mobile.NetState );
                }
            }
            return false;
        }
    }
}