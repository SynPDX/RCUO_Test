using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
   [FlipableAttribute( 0x2683, 0x2684 )]
   public class HalloweenReaperRobeMONSTER : BaseOuterTorso
   {
      [Constructable]
      public HalloweenReaperRobeMONSTER() : base( 0x2683 )
      {
         Weight = 3.0;
         LootType=LootType.Blessed;
         Name = "the reaper's robe";
		 Hue = 1175;
         Layer = Layer.OuterTorso;
      }
       public override bool OnEquip( Mobile from )
      {
         if ( ItemID == 0x2683 )
         {
         from.NameMod = "the reaper";
         }
         return base.OnEquip(from);
      }

      public override void OnRemoved( Object o )
      {
      if( o is Mobile )
      {
          ((Mobile)o).NameMod = null;
      }
      if( o is Mobile && ((Mobile)o).Kills >= 5)
               {
               ((Mobile)o).Criminal = true;
                }
      base.OnRemoved( o );
      }

      public HalloweenReaperRobeMONSTER( Serial serial ) : base( serial )
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
