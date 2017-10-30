using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class SandraGump2 : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("SandraGump2", AccessLevel.GameMaster, new CommandEventHandler(SandraGump2_OnCommand)); 
      } 

      private static void SandraGump2_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new SandraGump2( e.Mobile ) ); 
      } 

      public SandraGump2( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Lost Soul" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>A wide-eyed Alura looks pleadingly at you, frazzled and panic stricken</I><br><br>" +
"<BASEFONT COLOR=Yellow> The dungeon of Doom has always been treacherous, but now the forces of evil are truly at work!<br>" +
"<BASEFONT COLOR=Yellow> The Lost Soul is wandering around somewhere near a bloody pentagram, inside Doom, and he aims to bring discord to the world and finish us off!<br>" +
"<BASEFONT COLOR=Yellow> Please! Please go out there and strike him down before he ends our world!<br>" +
"<BASEFONT COLOR=Yellow> Be careful, though! Once you destroy him, his minions will surely seek revenge!<br>" +
"<BASEFONT COLOR=Yellow><I>Alura drops to her knees, pleading to you desperately</I><br>" + 
"<BASEFONT COLOR=Yellow> End our torment, let us drive the Hallowcreatures back!<br>" +
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
               from.SendMessage( "Thanks so much for all your help!" );
               break; 
            } 

         }
      }
   }
}