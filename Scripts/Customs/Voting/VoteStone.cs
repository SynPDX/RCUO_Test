using System;
using System.Collections;
using System.Collections.Generic;

using Server;
using Server.Misc;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Accounting;

using Server.Voting;

namespace Server.Items
{
	/// <summary>
	/// The Vote Stone object.
	/// </summary>
	public class VoteStone : VoteItem
	{
		private string _LabelMessage = "";
		/// <summary>
		/// The message appended to the displayed ObjectPropertyList when the vote stone GetProperties method is called.
		/// </summary>
		[CommandProperty(AccessLevel.GameMaster)]
		public string LabelMessage
		{
			get { return _LabelMessage; }
			set
			{
				_LabelMessage = value;
				InvalidateProperties();
			}
		}

		/// <summary>
		/// Constructs a new instance of VoteStone.
		/// </summary>
		[Constructable]
		public VoteStone()
			: this("Vote Stone")
		{ }

		/// <summary>
		/// Constructs a new instance of VoteStone with an optional Name.
		/// </summary>
		/// <param name="name">Name supllied for this instance of VoteStone.</param>
		[Constructable]
		public VoteStone(string name)
			: this(name, 0)
		{ }

		/// <summary>
		/// Constructs a new instance of VoteStone with an option Name and Hue.
		/// </summary>
		/// <param name="name">Name supplied for this instance of VoteStone.</param>
		/// <param name="hue">Hue supplied for this instance of VoteStone.</param>
		[Constructable]
		public VoteStone(string name, int hue)
			: base(0xED4)
		{
			Name = name;
			Hue = hue;

			Movable = false;
		}

		public override bool OnBeforeVote(Mobile from)
		{ return base.OnBeforeVote(from); }

		//public override void OnVote(Mobile from, VoteStatus status)
		//{ base.OnVote(from, status); }
		public override void OnVote(Mobile m, VoteStatus status)
        {
            base.OnVote(m, status);
            if (status == VoteStatus.Success)
            //switch (Utility.Random( 100 ))
			{
				if (Utility.Random( 100 ) <= 100 )
				{
					int rand = Utility.Random(100);
					if ( rand <= 80 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 15 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(15));
					}
					else if ( rand <= 90 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 50 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(50));
					}
					else if ( rand <= 95 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 100 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(100));
					}
					else if ( rand <= 97 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 250 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(250));
					}
					else if ( rand <= 99 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 500 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(500));
					}
					else if ( rand <= 100 )
					{
					m.SendMessage("Thanks for voting, you have been rewarded 50 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(50));
					}
				}
				
				
				
				/*if (Utility.RandomDouble() < .8 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 15 tokens. Keep voting for a chance to get a larger amount of tokens!");
					m.AddToBackpack(new VoteToken(15));
				}
				if (Utility.RandomDouble() < .1 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 50 tokens. Keep voting for a chance to get a larger amount of tokens!");	
					m.AddToBackpack(new VoteToken(50));
				}
				if (Utility.RandomDouble() < .05 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 100 tokens. Keep voting for a chance to get a larger amount of tokens!");	
					m.AddToBackpack(new VoteToken(100));
				}
				if (Utility.RandomDouble() < .02 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 250 tokens. Keep voting for a chance to get a larger amount of tokens!");	
					m.AddToBackpack(new VoteToken(250));
				}
				if (Utility.RandomDouble() < .02 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 500 tokens. Keep voting for a chance to get a larger amount of tokens!");	
					m.AddToBackpack(new VoteToken(500));
				}
				if (Utility.RandomDouble() < .01 )
				{
					m.SendMessage("Thanks for voting, you have been rewarded 1000 tokens. Keep voting for a chance to get a larger amount of tokens!");	
					m.AddToBackpack(new VoteToken(1000));}
				}*/
            /*{
			80	default: m.SendMessage("Thanks for voting, you have been rewarded 15 tokens. Keep voting for a chance to get a larger amount of tokens!");
						 m.AddToBackpack(new VoteToken(15)); break;
            10    case 0: m.SendMessage("Thanks for voting, you have been rewarded 50 tokens. Keep voting for a chance to get a larger amount of tokens!");	
						      m.AddToBackpack(new VoteToken(50)); break;
            5    case 4: m.SendMessage("Thanks for voting, you have been rewarded 100 tokens. Keep voting for a chance to get a larger amount of tokens!");	
						      m.AddToBackpack(new VoteToken(100)); break;
            2    case 5: m.SendMessage("Thanks for voting, you have been rewarded 250 tokens. Keep voting for a chance to get a larger amount of tokens!");	
						      m.AddToBackpack(new VoteToken(250)); break;
            2    case 7: m.SendMessage("Thanks for voting, you have been rewarded 500 tokens. Keep voting for a chance to get a larger amount of tokens!");	
						  m.AddToBackpack(new VoteToken(500)); break;
            1    case 8: m.SendMessage("Thanks for voting, you have been rewarded 1000 tokens. Keep voting for a chance to get a larger amount of tokens!");	
						 m.AddToBackpack(new VoteToken(1000)); break;
            }*/
        }
	}
	
		public override void OnAfterVote(Mobile from, VoteStatus status)
		{ base.OnAfterVote(from, status); }

		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);

			if (VoteSite.Valid)
			{
				list.Add(1070722,
					String.Format(
						//"<BASEFONT COLOR=#00FF00>{0}<BASEFONT COLOR=#FFFFFF>" +
						//"\n[{1}] " +
						//"{2}",
						//_LabelMessage,
						//VoteSite.Name,
						//VoteSite.URL.ToUpper()
						"<BASEFONT COLOR=#00FF00>{0}<BASEFONT COLOR=#FFFFFF>" +
						//"\n[{1}] " +
						//"{2}",
						_LabelMessage,
						VoteSite.Name,
						VoteSite.URL.ToUpper()
					)
				);
			}
			else
			{ list.Add(1070722, "<BIG><BASEFONT COLOR=#FF0000>Voting is currently unavailable.</BIG><BASEFONT COLOR=#FFFFFF>"); }
		}

		public VoteStone(Serial serial)
			: base(serial)
		{ }

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			int version = 0;

			writer.Write(version);

			switch (version)
			{
				case 0:
					{
						writer.Write(_LabelMessage);
					} break;
			}
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			switch (version)
			{
				case 0:
					{
						_LabelMessage = reader.ReadString();
					} break;
			}
		}
	}
}