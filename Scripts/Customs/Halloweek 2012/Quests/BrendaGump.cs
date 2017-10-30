using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class BrendaGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("BrendaGump", AccessLevel.GameMaster, new CommandEventHandler(BrendaGump_OnCommand)); 
      } 

      private static void BrendaGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new BrendaGump( e.Mobile ) ); 
      } 

      public BrendaGump( Mobile owner ) : base( 50,50 ) 
      { 
//----------------------------------------------------------------------------------------------------

				AddPage( 0 );
			AddImageTiled(  54, 33, 369, 400, 2624 );
			AddAlphaRegion( 54, 33, 369, 400 );

			AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
			
			AddImage( 97, 49, 9005 );
			AddImageTiled( 58, 39, 29, 390, 10460 );
			AddImageTiled( 412, 37, 31, 389, 10460 );
			AddLabel( 140, 60, 0x34, "A Ball Of Souls" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>*Brenda gazes at you from under the rim of her hat*</I><br><br>" +
"<BASEFONT Color=Yellow> Hail, otherworlder.<br>" + 
"<BASEFONT COLOR=Yellow> The name is Brenda, I've discovered something amazing in the town of Cove!<br>" +
"<BASEFONT COLOR=Yellow> I found that if you collect the souls of the Hallowcreatures in a certain order, you can use their souls to create a pocket in space.<br>" +
"<BASEFONT COLOR=Yellow> This pocket of space can be forced into a magical strongbox. I've decided to name it 'The Box Of Souls'<br>" +
"<BASEFONT COLOR=Yellow> This box essentially can hold more items than a normal box.<br>" +
"<BASEFONT COLOR=Yellow> If you're interested, you'll need a certain magical item. Kill a Master Witch and take her Crystal Ball!<br>" +
"<BASEFONT COLOR=Yellow> I've noticed that some normal witches tend to hold them, but the Master Witch always carries her Crystal Ball.<br>" +
"<BASEFONT COLOR=Yellow> Pay close attention to what I say next...<br>" +
"<BASEFONT COLOR=Yellow> You can only gather souls in the following order: Halloworld Skeleton, Halloworld Zombie, Physical Combat Ghost, Magical Combat Ghost, Scarecrow, Witch, Vampire, Werewolf, and finally the soul of a Reaper.<br>" +
"<BASEFONT COLOR=Yellow> Once you complete collecting all their souls, bring the crystal ball to me.<br>" + 
"</BODY>", false, true);
			
			AddImage( 430, 9, 10441);
			AddImageTiled( 40, 38, 17, 391, 9263 );
			AddImage( 6, 25, 10421 );
			AddImage( 34, 12, 10420 );
			AddImageTiled( 94, 25, 342, 15, 10304 );
			AddImageTiled( 40, 427, 415, 16, 10304 );
			AddImage( -10, 314, 10402 );
			AddImage( 56, 150, 10411 );
			AddImage( 155, 120, 2103 );
			AddImage( 136, 84, 96 );

			AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); 

//--------------------------------------------------------------------------------------------------------------
      } 

      public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      { 
         Mobile from = state.Mobile; 

         switch ( info.ButtonID ) 
         { 
            case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            { 
               //Cancel 
               from.SendMessage( "Now go! Collect as many souls as you can!" );
               break; 
            } 

         }
      }
   }
}