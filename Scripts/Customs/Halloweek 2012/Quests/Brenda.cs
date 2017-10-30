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
    [CorpseName( "Brenda corpse" )]
    public class BrendaHallowQuest : Mobile
    {
        public virtual bool IsInvulnerable{ get{ return true; } }
        [Constructable]
        public BrendaHallowQuest()
        {
            Name = "Brenda";
                        Title = "the soul tinker";
            CantWalk = true;
			Body = 0x191;
			AddItem( new MagicWizardsHat(Hue=(1175)) );
			AddItem( new FemaleElvenRobe(Hue=(1175)) );
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new LightningWand() ); break;
				case 1: AddItem( new FireballWand() ); break;
				case 2: AddItem( new FeebleWand() ); break;
			}   
            AddItem( new LongHair(Hue=(1175)) );
            Blessed = true;
            }
        public BrendaHallowQuest( Serial serial ) : base( serial )
        {
        }
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new BrendaGumpEntry(from, this));
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
        public class BrendaGumpEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;
           
            public BrendaGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if ( ! mobile.HasGump( typeof( BrendaGump ) ) )
                    {
                        mobile.SendGump( new BrendaGump( mobile ));
                       
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
                if( dropped is ReaperCrystalBall )
                {
                    if(dropped.Amount!=1)
                    {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "Is this a joke?", mobile.NetState );
					    return false;
                    }
					else
					{
					mobile.SendMessage( "Alright, here you go! Enjoy your box, thank you for the souls." );
	 
					dropped.Delete();
					mobile.AddToBackpack( new BoxOfSouls() );
					}
				}
                else
                {
                    this.PrivateOverheadMessage( MessageType.Regular, 1161, false, "This isn't a Reaper Crystal Ball...", mobile.NetState );
				}
			}
            return false;
        }
    }
}