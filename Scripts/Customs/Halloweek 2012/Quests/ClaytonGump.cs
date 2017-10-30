using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class ClaytonGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("ClaytonGump", AccessLevel.GameMaster, new CommandEventHandler(ClaytonGump_OnCommand)); 
      } 

      private static void ClaytonGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new ClaytonGump( e.Mobile ) ); 
      } 

      public ClaytonGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "A Missing Father" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>* Clayton looks frightened and distracted *</I><br><br>" +
"<BASEFONT Color=Yellow> You're one of us, right? A Britanian?<br>" + 
"<BASEFONT COLOR=Yellow> My father was the first to enter the orange portals into this world...<br>" +
"<BASEFONT COLOR=Yellow> He's a guard, so it's his duty to protect the people of Skara Brae, but now there's two Skara Braes!<br>" +
"<BASEFONT COLOR=Yellow> He took it upon himself to lend these people a hand in driving back those... Evil creatures and hasn't returned...<br>" +
"<BASEFONT COLOR=Yellow> Could you go in there and find him? Even if he's....<br>" +
"<BASEFONT COLOR=Brown><I>* Dead *</I><br>" +
"<BASEFONT COLOR=Yellow> Please? Help me find my father, or his fate?<br>" +
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
               from.SendMessage( "I really hope he's safe..." );
               break; 
            } 

         }
      }
   }
}