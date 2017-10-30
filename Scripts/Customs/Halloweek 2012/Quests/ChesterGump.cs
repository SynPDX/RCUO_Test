using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class ChesterGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("ChesterGump", AccessLevel.GameMaster, new CommandEventHandler(ChesterGump_OnCommand)); 
      } 

      private static void ChesterGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new ChesterGump( e.Mobile ) ); 
      } 

      public ChesterGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "A Fathers Woe" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>A sorrowful man looks up at you</I><br><br>" +
"<BASEFONT Color=Yellow> Hail, otherworlder.<br>" + 
"<BASEFONT COLOR=Yellow> I'm sorry for my appearence.<br>" +
"<BASEFONT COLOR=Yellow> My son has just passed you see, one of those Hallowtrees have eaten him on his way home before this whole invasion began.<br>" +
"<BASEFONT COLOR=Yellow> Many knew of the Hallowtree and their existance, but there was never a way to find them, they always blended in with the rest of those damndable trees.<br>" +
"<BASEFONT COLOR=Yellow> Since my sons passing, I have taken up a new profession, Chest Making. I have this new chest, as you can see beside me, which can be made from the wood of a Hallowtree.<br>" +
"<BASEFONT COLOR=Yellow> Not all Hallowtrees are sturdy enough to use however, you need to find a Master Hallowtree.<br>" +
"<BASEFONT COLOR=Yellow> You haven't seen one before? Well that's because they blend in pretty well as well, the trees first appear as Walking Hallowtrees.<br>" +
"<BASEFONT COLOR=Yellow> Kill one of those and their true form will appear. Once you kill the Master Hallowtree, bring me its timber, they appear black and are very special.<br>" +
"<BASEFONT COLOR=Brown> How many? 20 logs should be enough.<br>" +
"<BASEFONT COLOR=Yellow> Thanks for assisting me in this, may virtue be with you.<br>" +
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
               from.SendMessage( "Please bring me as much wood as you can, I'd like to see them suffer." );
               break; 
            } 

         }
      }
   }
}