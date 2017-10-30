using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class JohnGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("JohnGump", AccessLevel.GameMaster, new CommandEventHandler(JohnGump_OnCommand)); 
      } 

      private static void JohnGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new JohnGump( e.Mobile ) ); 
      } 

      public JohnGump( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=Yellow><I>* John looks at you with interest. *</I><br><br>" +
"<BASEFONT Color=Yellow> Hey!!! You're one of those other-worlder's right?<br>" + 
"<BASEFONT COLOR=Yellow> Well, hopefully you already know our problem, if not, please speak with Sandra.<br>" +
"<BASEFONT COLOR=Yellow> I'll make this simple... One detail not mentioned about those creatures have killed many children in this world.<br>" +
"<BASEFONT COLOR=Yellow> You see, October is the month which our children celebrate our defeating all of those evil creatures by dressing as them and gathering candy throughout the kingdom of Englandia.<br>" +
"<BASEFONT COLOR=Yellow> What's that? The kingdom in your world is called Britania? That's just silly. So, in killing the children, they've stolen their bags of candy.<br>" +
"<BASEFONT COLOR=Yellow> Unfortunately this horrible event happened just after I perfected a new technology in Candy Gathering that would have given me a head up above everyone else.<br>" +
"<BASEFONT COLOR=Yellow> What's that? Candy Gathering Technology is not silly! Regular bags can only hold about one hundred and twenty five pieces of individual candy. My bags can hold much much more.<br>" +
"<BASEFONT COLOR=Yellow> How much? It depends on the size, I call my invention...<br>" +
"<BASEFONT COLOR=Brown><I>* Candy Bags *</I><br>" +
"<BASEFONT COLOR=Yellow> I'll sell it to you, for a price. Every year we give out 'Halloween Tokens' to a select few trick or treaters, so these creatures are bound to be holding some.<br>" +
"<BASEFONT COLOR=Yellow> They come in three colors, Black, Orange, and White. Give me twenty of one group of the colors of these tokens and I'll give you a random Candy Bag, sure to make you happy with how much it can hold.<br>" +
"<BASEFONT COLOR=Yellow> What are you waiting for? Get out there and get those tokens!<br>" + 
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
               from.SendMessage( "See you when you gather the tokens!" );
               break; 
            } 

         }
      }
   }
}