using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class ZachGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("ZachGump", AccessLevel.GameMaster, new CommandEventHandler(ZachGump_OnCommand)); 
      } 

      private static void ZachGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new ZachGump( e.Mobile ) ); 
      } 

      public ZachGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "A Trick Of Treater's Dismay" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>Zach seems rather busy carving something...</I><br><br>" +
"<BASEFONT Color=Yellow> Hey there, you interested in what I'm doin'?<br>" + 
"<BASEFONT COLOR=Yellow> Well, I use ta' be th' one takin' care o' a farm out there.<br>" +
"<BASEFONT COLOR=Yellow><I>Zach motioned across the river.</I><br>" +
"<BASEFONT COLOR=Yellow> So, I took the remainder of my crop jus' before th' Hallowhorde came, an' I started doin' ma business.<br>" +
"<BASEFONT COLOR=Yellow> Y'see, I make Jack O' Lantern's for th' various houses an' sell them in exchange for token's.<br>" +
"<BASEFONT COLOR=Yellow> Use ta' cost ya' only 30 Halloween Tokens, but seein' as I may neva' see ma farm 'gain, I need t' be raisin' ma prices.<br>" +
"<BASEFONT COLOR=Yellow> S'here's th' deal, ya give me 50 tokens, I'll be givin' ya a Jack O' Lantern. Simple as that.<br>" +
"<BASEFONT COLOR=Yellow> While yer out there, give those livin' Scarecrows a good kick in th' rocks fer me.<br>" +
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
               from.SendMessage( "A really good kick in th' rocks." );
               break; 
            } 

         }
      }
   }
}