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
    public class SandraHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public SandraHallowQuest()
        {
            Name = "Alura";
                        Title = "the historian";
            CantWalk = true;
			Body = 0x191;
			AddItem( new MagicWizardsHat(Hue=(897)) );
			AddItem( new FemaleElvenRobe(Hue=(897)) );
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new LightningWand() ); break;
				case 1: AddItem( new FireballWand() ); break;
				case 2: AddItem( new FeebleWand() ); break;
			}   
            AddItem( new LongHair(Hue=(1140)) );
            Blessed = true;
            }
        public SandraHallowQuest( Serial serial ) : base( serial )
        {
        }
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new SandraGump2Entry(from, this));
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
        public class SandraGump2Entry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public SandraGump2Entry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( SandraGump2 ) ) )
                    {
                        mobile.SendGump( new SandraGump2( mobile ));
                       
                    }
                }
            }
        }
    }
}