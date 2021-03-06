using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
   [FlipableAttribute( 0x2683, 0x2684 )]
   public class HalloweenGhostRobeMONSTER : BaseOuterTorso
   {
      [Constructable]
      public HalloweenGhostRobeMONSTER() : base( 0x2683 )
      {
         Weight = 3.0;
         LootType=LootType.Blessed;
         Name = "a ghosts robe";
		 Hue = 0;
         Layer = Layer.OuterTorso;
      }
       public override bool OnEquip( Mobile from )
      {
         if ( ItemID == 0x2683 )
         {
         from.NameMod = "a ghost";
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

      public HalloweenGhostRobeMONSTER( Serial serial ) : base( serial )
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
