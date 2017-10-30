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
    [CorpseName( "Clayton corpse" )]
    public class ClaytonHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public ClaytonHallowQuest()
        {
            Name = "Clayton";
                        Title = "the Captain's son";
            Body = 400;
            CantWalk = true;
            AddItem( new Sandals() );
            AddItem( new HalloweenReaperRobeMONSTER());
            AddItem( new Halloween2017Scythe() );
            int hairHue = 1127;
           
 
            switch ( Utility.Random( 1 ) )
            {
                case 0: AddItem( new LongHair( hairHue ) ); break;
            }
           
            Blessed = true;
           
            }
 
            public virtual int GetBootsHue()
            {
            return 1127;
        	}
 
        public ClaytonHallowQuest( Serial serial ) : base( serial )
        {
        }
 
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new ClaytonGumpEntry(from, this));
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
 
        public class ClaytonGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public ClaytonGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( ClaytonGump ) ) )
                    {
                        mobile.SendGump( new ClaytonGump( mobile ));
                       
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
                if( dropped is CaptainHead )
                {
                    if(dropped.Amount!=1)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 1127, false, "That doesn't prove that my father is gone...", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Oh god... Well... Here, take his shield. He would have wanted you to have it. Thank you for proving to me that he's finally... Dead..." );
	 
					dropped.Delete();
         
					mobile.AddToBackpack( new CaptainsShield() );
						return true;
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 1127, false, "That doesn't prove that my father is gone...", mobile.NetState );
                }
            }
            return false;
        }
    }
}