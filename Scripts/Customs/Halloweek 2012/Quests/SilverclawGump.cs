using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class SilverclawGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("SilverclawGump", AccessLevel.GameMaster, new CommandEventHandler(SilverclawGump_OnCommand)); 
      } 

      private static void SilverclawGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new SilverclawGump( e.Mobile ) ); 
      } 

      public SilverclawGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "A Tinkers Surprise" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>* Silverclaw sniffs the ground at your feet before wagging its tail excitedly. *</I><br><br>" +
"<BASEFONT Color=Yellow> Psst~ * You hear, looking around, you seem a bit confused as to where the noise could have come from. *<br>" + 
"<BASEFONT COLOR=Yellow> Hey. * You continue to look around confused. *<br>" +
"<BASEFONT COLOR=Yellow> Down here! * Silverclaw barked, getting your attention. * Cool huh? * The dog wagged its tail happily. *<br>" +
"<BASEFONT COLOR=Yellow> You seem confused, let me explain. I'm currently under a spell. By choice, don't be worried, I want to be this way.<br>" +
"<BASEFONT COLOR=Yellow> I was tinkering around with this Talisman I found on a Vampire's Corpse when all of a sudden a Werewolf attacked me! I hit it with the Talisman and it started to glow!<br>" +
"<BASEFONT COLOR=Yellow> The Talisman I mean, not the Werewolf. I finished off the Werewolf and continued to study the Talisman. With my tools, I managed to unlock a cool effect of the Talisman.<br>" +
"<BASEFONT COLOR=Yellow> If you wear it and then use it, you're transformed into a Wolf! If you're lucky and get a powerful soul, you even have a chance of transforming into a Werewolf!<br>" +
"<BASEFONT COLOR=Yellow> Unlike the Werewolves though, you retain control of yourself! It's a disguise!<br>" +
"<BASEFONT COLOR=Yellow> The Werewolves will still attack you though, they know their own scent so don't try using it to get past them...<br>" +
"<BASEFONT COLOR=Yellow> Anyway, I'm getting ahead of myself. If you get me a Full Talisman, I'll tinker around with your Talisman to unlock its potential. Just kill a Vampire to get an Empty Talisman, and use it on a FeralHuman or a Werewolf.<br>" +
"<BASEFONT COLOR=Yellow> Why would Vampires have the Talisman? Haven't you ever wondered how Vampires retain control of the Werewolves? They use the Talismans to seal the souls of the Werewolves away to trap them forever. A fate possibly worse than death.<br>" +
"<BASEFONT COLOR=Yellow> Don't worry! As human's and elves we can't use the Talismans to their full strength, we don't have the requiered magical ability, so you'll only take a piece of their soul, allowing them to continue living even after death, through you.<br>" +
"<BASEFONT COLOR=Yellow> Now... * Silverclaw's tail began wagging again. * Go, fetch!<br>" +
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
               from.SendMessage( "Good luck!" );
               break; 
            } 

         }
      }
   }
}