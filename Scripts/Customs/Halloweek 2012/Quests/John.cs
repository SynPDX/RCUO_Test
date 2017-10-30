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
    [CorpseName( "John corpse" )]
    public class JohnHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public JohnHallowQuest()
        {
            Name = "John";
                        Title = "the pro-trick or treater";
            Body = 400;
            CantWalk = true;
            AddItem( new Sandals() );
            AddItem( new HalloweenJohnRobe());
            AddItem( new GnarledStaff() );
            int hairHue = 1153;
           
 
            switch ( Utility.Random( 1 ) )
            {
                case 0: AddItem( new LongHair( hairHue ) ); break;
            }
           
            Blessed = true;
           
            }
 
            public virtual int GetBootsHue()
            {
            return 1161;
        	}
 
        public JohnHallowQuest( Serial serial ) : base( serial )
        {
        }
 
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new JohnGumpEntry(from, this));
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
 
        public class JohnGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public JohnGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( JohnGump ) ) )
                    {
                        mobile.SendGump( new JohnGump( mobile ));
                       
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
                    if(dropped.Amount!=20)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "You're either giving me too many or too few Halloween Tokens.", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Thank you so much! I will be known as the best Trick Or Treater!" );
	 
					dropped.Delete();
					if( Utility.Random( 100 ) < 100 )
						switch ( Utility.Random( 8 ) )
						{               
							case 0:    mobile.AddToBackpack( new SmallCandyBag() ); break;
							case 1:    mobile.AddToBackpack( new SmallCandyBag() ); break;
							case 2:    mobile.AddToBackpack( new SmallCandyBag() ); break;
							case 3:    mobile.AddToBackpack( new SmallCandyBag() ); break;
							case 4:    mobile.AddToBackpack( new SmallCandyBag() ); break;
							case 5:    mobile.AddToBackpack( new MediumCandyBag() ); break;
							case 6:    mobile.AddToBackpack( new MediumCandyBag() ); break;
							case 7:    mobile.AddToBackpack( new LargeCandyBag() ); break;
						}
						return true;
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "These... Are not Halloween Tokens...", mobile.NetState );
                }
            }
            return false;
        }
    }
}