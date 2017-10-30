using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class SandraGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("SandraGump", AccessLevel.GameMaster, new CommandEventHandler(SandraGump_OnCommand)); 
      } 

      private static void SandraGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new SandraGump( e.Mobile ) ); 
      } 

      public SandraGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "A Halloworld" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>*Sandra smiles as you approach*</I><br><br>" +
"<BASEFONT Color=Yellow> Someone from our alternate world?<br>" + 
"<BASEFONT COLOR=Yellow> A lot has happened to our world, and we are in dire straits...<br>" +
"<BASEFONT COLOR=Yellow> No one is sure exactly when it started, or where, but before we knew it we were attacked. The first confirmed defeat, I'm told, happened at Jhelom.<br>" +
"<BASEFONT COLOR=Yellow> Once they fell, the Hallowcreatures, as I call them, used the Moongates to invade the rest of our world. We were over-run and under prepared for this invasion.<br>" +
"<BASEFONT COLOR=Yellow> Thousands fell.<br>" +
"<BASEFONT COLOR=Yellow> Skara Brae became a fall back point, the only town left unattacked, so we quickly gathered everyone we could, and destroyed the Moongate that's still here.<br>" +
"<BASEFONT COLOR=Yellow> We put up an iron fence to keep out the enemies, but they made it past the first gate, the second still stands and redirected the magical energy of the Moongate to cross to your world.<br>" +
"<BASEFONT COLOR=Yellow> The Hallowcreatures have destroyed much of the land, this island and the connecting continent is all that remains as we've defended it.<br>" +
"<BASEFONT COLOR=Yellow> Please help us in defending it! We opened a portal to your world to ask for your assistance, if we don't stop them here, I fear they will finally destroy our world and move on to yours.<br>" +
"<BASEFONT COLOR=Yellow> Unfortunately the resulting blast of our worlds destruction may resonate across the ether and rupture your world.<br>" +
"<BASEFONT COLOR=Yellow> So you see, you have something to lose from this as well... Please assist us in turning these creatures back, with your help we may turn this into a winning fight!<br>" + 
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
               from.SendMessage( "Goodluck, thank you for helping us." );
               break; 
            } 

         }
      }
   }
}