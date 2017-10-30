using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
   [FlipableAttribute( 0x2683, 0x2684 )]
   public class Halloween2017Robe : BaseOuterTorso
   {
      [Constructable]
      public Halloween2017Robe() : base( 0x2683 )
      {
         Weight = 3.0;
         Name = "A Halloween 2017 Robe";
		 Halloween2017RobeHue();
         Layer = Layer.OuterTorso;
      }
	public virtual void Halloween2017RobeHue()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(48); break;
                    case 1: Hue=(1154); break;
                    case 2: Hue=(1175); break;
                }
        }
      public override void OnDoubleClick( Mobile m )
      {
         if( Parent != m )
         {
            m.SendMessage( "You must be wearing the robe to use it!" );
         }
         else
         {
            if ( ItemID == 0x2683 || ItemID == 0x2684 )
            {
               m.SendMessage( "You lower the hood." );
               m.PlaySound( 0x57 );
               ItemID = 0x1F03;
               m.RemoveItem(this);
               m.EquipItem(this);
            }
            else if ( ItemID == 0x1F03 || ItemID == 0x1F04 )
            {
               m.SendMessage( "You pull the hood over your head." );
               m.PlaySound( 0x57 );
               ItemID = 0x2683;
               m.RemoveItem(this);
               m.EquipItem(this);

            }
         }
      }
      public Halloween2017Robe( Serial serial ) : base( serial )
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
