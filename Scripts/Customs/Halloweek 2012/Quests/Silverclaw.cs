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
    [CorpseName( "Silverclaw corpse" )]
    public class SilverclawHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public SilverclawHallowQuest()
        {
            Name = "Silverclaw";
                        Title = "the puppy";
            Body = 225;
            CantWalk = true;
            Blessed = true;
        }
        public SilverclawHallowQuest( Serial serial ) : base( serial )
        {
        }
 
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new SilverclawGumpEntry(from, this));
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
 
        public class SilverclawGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public SilverclawGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( SilverclawGump ) ) )
                    {
                        mobile.SendGump( new SilverclawGump( mobile ));
                       
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
                if( dropped is FullTalisman )
                {
                    if(dropped.Amount!=1)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "This isn't a full talisman.", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Here you go! All set, enjoy your talisman." );
	 
					dropped.Delete();
					if( Utility.Random( 100 ) < 100 )
						switch ( Utility.Random( 8 ) )
						{               
							case 0:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 1:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 2:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 3:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 4:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 5:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 6:    mobile.AddToBackpack( new WolfTalisman() ); break;
							case 7:    mobile.AddToBackpack( new PureWolfTalisman() ); break;
						}
					from.PlaySound( 0x5AA );
						return true;
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "This isn't a full talisman.", mobile.NetState );
                }
            }
            return false;
        }
    }
}