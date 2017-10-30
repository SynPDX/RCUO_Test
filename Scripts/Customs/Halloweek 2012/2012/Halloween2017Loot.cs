//Items scripted, and list compiled by: Montegro
/*Contained within this script;
Halloween2017WitchesBrew
Halloween2017DecorativeArmor
Halloween2017DecorativeArmor2
Halloween2017IronMaiden
Halloween2017BeefCarcass
Halloween2017BeefCarcass2
Halloween2017CandleSkull
Halloween2017HangingSkeleton1-5
Halloween2017Blood1-3
Halloween2017SkullPile
Halloween2017SkullPole
Halloween2017Scarecrow
Halloween2017Lantern
Halloween2017BrokenArmoire
Halloween2017RuinedBookcase
Halloween2017CoveredChair
Halloween2017BrokenChair1-3
Halloween2017BrokenClock
Halloween2017DamagedBooks
Halloween2017BrokenChestOfDrawers
Halloween2017StumpAxe
Halloween2017Stump
Halloween2017WTub
Halloween2017ETub
Halloween2017Painting1-8
Halloween2017GraveStone
Halloween2017GraveStone2-26
Halloween2017Grave
Halloween2017Spiderweb1-2
Halloween2017BonePile1-5
Halloween2017SheafWheat
Halloween2017HauntedMirror
Halloween2017Blood4-9
Halloween2017BoneTable
Halloween2017BoneThrone
Halloween2017BoneCouchEastAddon
Halloween2017BoneCouchEastDeed
Halloween2017BoneCouchSouthAddon
Halloween2017BoneCouchSouthDeed
Halloween2017SacrificialAlterEastAddon
Halloween2017SacrificialAlterEastDeed
Halloween2017SacrificialAlterSouthAddon
Halloween2017SacrificialAlterSouthDeed
Halloween2017Cauldron
Halloween2017StoneCoffinEastDeed
Halloween2017StoneCoffinEastAddon
Halloween2017StoneCoffinSouthDeed
Halloween2017StoneCoffinSouthAddon
Halloween2017ShadowStone
Halloween2017ShadowShort
Halloween2017ShadowTall
Halloween2017SpikeStatue
Halloween2017SpikePoleStatue
Halloween2017DaemonPoleStatue
JackOLantern1-2*/
using System.Collections;
using System;
using System.Collections.Generic;
using Server.Multis;
using Server.Mobiles;
using Server.Network;
using Server.ContextMenus;

namespace Server.Items
{
	[Furniture]
	[Flipable(0x1E35,0x1E34)]
	public class Halloween2017Scarecrow : Item
	{
		[Constructable]
		public Halloween2017Scarecrow() : base( 0x1E35 )
            {
			Weight = 10.0;
			Name = "A Halloween Scarecrow";
			ScarecrowHue();
            }
		public virtual void ScarecrowHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Scarecrow( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017Lantern : BaseEquipableLight
	{
		public override int LitItemID
		{
			get
			{
				if ( ItemID == 0xA15 || ItemID == 0xA17 )
					return ItemID;

				return 0xA22;
			}
		}

		public override int UnlitItemID
		{
			get
			{
				if ( ItemID == 0xA18 )
					return ItemID;

				return 0xA25;
			}
		}

		[Constructable]
		public Halloween2017Lantern() : base( 0xA25 )
		{
			if ( Burnout )
				Duration = TimeSpan.FromMinutes( 20 );
			else
				Duration = TimeSpan.Zero;

			Burning = false;
			Light = LightType.Circle300;
			Weight = 2.0;
			Name = "A Halloween Lantern";
			Lantern2017Color();
		}
		public virtual void Lantern2017Color()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(48); break;
                    case 1: Hue=(1154); break;
                    case 2: Hue=(1175); break;
                }
        }
		public Halloween2017Lantern( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	[Furniture]
	[Flipable(0x0C13,0x0C12)]
	public class Halloween2017BrokenArmoire : Item
	{
		[Constructable]
		public Halloween2017BrokenArmoire() : base( 0x0C13 )
            {
			Weight = 17.0;
			Name = "A Halloween Broken Armoire";
			BrokenArmoireHue();
            }
		public virtual void BrokenArmoireHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenArmoire( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C14,0x0C15)]
	public class Halloween2017RuinedBookcase : Item
	{
		[Constructable]
		public Halloween2017RuinedBookcase() : base( 0x0C14 )
            {
			Weight = 19.0;
			Name = "A Halloween Ruined Bookcase";
			RuinedBookcaseHue();
            }
		public virtual void RuinedBookcaseHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017RuinedBookcase( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C17,0x0C18)]
	public class Halloween2017CoveredChair : Item
	{
		[Constructable]
		public Halloween2017CoveredChair() : base( 0x0C17 )
            {
			Weight = 12.0;
			Name = "A Halloween Covered Chair";
			CoveredChairHue();
            }
		public virtual void CoveredChairHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017CoveredChair( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C11,0x0C10)]
	public class Halloween2017BrokenChair1 : Item
	{
		[Constructable]
		public Halloween2017BrokenChair1() : base( 0x0C11 )
            {
			Weight = 4.0;
			Name = "A Halloween Broken Chair";
			BrokenChair1Hue();
            }
		public virtual void BrokenChair1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenChair1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C19,0x0C1A)]
	public class Halloween2017BrokenChair2 : Item
	{
		[Constructable]
		public Halloween2017BrokenChair2() : base( 0x0C19 )
            {
			Weight = 4.0;
			Name = "A Halloween Broken Chair";
			BrokenChair2Hue();
            }
		public virtual void BrokenChair2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenChair2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C1B,0x0C1C,0x0C1D,0x0C1E)]
	public class Halloween2017BrokenChair3 : Item
	{
		[Constructable]
		public Halloween2017BrokenChair3() : base( 0x0C1B )
            {
			Weight = 6.0;
			Name = "A Halloween Broken Chair";
			BrokenChair3Hue();
            }
		public virtual void BrokenChair3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenChair3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017BrokenClock : Item
	{
		[Constructable]
		public Halloween2017BrokenClock() : base( 0x0C1F )
            {
			Weight = 6.0;
			Name = "A Halloween Broken Clock";
			BrokenClockHue();
            }
		public virtual void BrokenClockHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenClock( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017DamagedBooks : Item
	{
		[Constructable]
		public Halloween2017DamagedBooks() : base( 0x0C16 )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Books";
			DamagedBooksHue();
            }
		public virtual void DamagedBooksHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017DamagedBooks( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0C24,0x0C25)]
	public class Halloween2017BrokenChestOfDrawers : Item
	{
		[Constructable]
		public Halloween2017BrokenChestOfDrawers() : base( 0x0C24 )
            {
			Weight = 11.0;
			Name = "A Halloween Broken Chest Of Drawers";
			BrokenCODHue();
            }
		public virtual void BrokenCODHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BrokenChestOfDrawers( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0E56,0x0E58)]
	public class Halloween2017StumpAxe : Item
	{
		[Constructable]
		public Halloween2017StumpAxe() : base( 0x0E56 )
            {
			Weight = 11.0;
			Name = "A Halloween Stump";
			StumpAxeHue();
            }
		public virtual void StumpAxeHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017StumpAxe( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0E57,0x0E59)]
	public class Halloween2017Stump : Item
	{
		[Constructable]
		public Halloween2017Stump() : base( 0x0E57 )
            {
			Weight = 9.0;
			Name = "A Halloween Stump";
			StumpHue();
            }
		public virtual void StumpHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Stump( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017WTub : Item
	{
		[Constructable]
		public Halloween2017WTub() : base( 0x0E7B )
            {
			Weight = 11.0;
			Name = "A Halloween Water Tub";
			WTubHue();
            }
		public virtual void WTubHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017WTub( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017ETub : Item
	{
		[Constructable]
		public Halloween2017ETub() : base( 0x0E83 )
            {
			Weight = 11.0;
			Name = "A Halloween Tub";
			ETubHue();
            }
		public virtual void ETubHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017ETub( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EE7,0x0EC9)]
	public class Halloween2017Painting1 : Item
	{
		[Constructable]
		public Halloween2017Painting1() : base( 0x0EE7 )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting1Hue();
            }
		public virtual void Painting1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EC8,0x0EC8)]
	public class Halloween2017Painting2 : Item
	{
		[Constructable]
		public Halloween2017Painting2() : base( 0x0EC8 )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting2Hue();
            }
		public virtual void Painting2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EA3,0x0EA4)]
	public class Halloween2017Painting3 : Item
	{
		[Constructable]
		public Halloween2017Painting3() : base( 0x0EA3 )
            {
			Weight = 5.0;
			Name = "A Halloween Painting";
			Painting3Hue();
            }
		public virtual void Painting3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EA6,0x0EA6)]
	public class Halloween2017Painting4 : Item
	{
		[Constructable]
		public Halloween2017Painting4() : base( 0x0EA6 )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting4Hue();
            }
		public virtual void Painting4Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting4( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EA7,0x0EA7)]
	public class Halloween2017Painting5 : Item
	{
		[Constructable]
		public Halloween2017Painting5() : base( 0x0EA7 )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting5Hue();
            }
		public virtual void Painting5Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting5( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EA8,0x0EA8)]
	public class Halloween2017Painting6 : Item
	{
		[Constructable]
		public Halloween2017Painting6() : base( 0x0EA8 )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting6Hue();
            }
		public virtual void Painting6Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting6( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0E9F,0x0E9F)]
	public class Halloween2017Painting7 : Item
	{
		[Constructable]
		public Halloween2017Painting7() : base( 0x0E9F )
            {
			Weight = 5.0;
			Name = "A Halloween Portrait";
			Painting7Hue();
            }
		public virtual void Painting7Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting7( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EA0,0x0EA0)]
	public class Halloween2017Painting8 : Item
	{
		[Constructable]
		public Halloween2017Painting8() : base( 0x0EA0 )
            {
			Weight = 10.0;
			Name = "A Halloween Painting";
			Painting8Hue();
            }
		public virtual void Painting8Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Painting8( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0ED4,0x0ED5)]
	public class Halloween2017GraveStone : Item
	{
		[Constructable]
		public Halloween2017GraveStone() : base( 0x0ED4 )
            {
			Weight = 16.0;
			Name = "A Halloween Gravestone";
			GravestoneHue();
            }
		public virtual void GravestoneHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0ED6,0x0ED6)]
	public class Halloween2017GraveStone2 : Item
	{
		[Constructable]
		public Halloween2017GraveStone2() : base( 0x0ED6 )
            {
			Weight = 16.0;
			Name = "A Halloween Gravestone";
			Gravestone2Hue();
            }
		public virtual void Gravestone2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0ED7,0x0ED8)]
	public class Halloween2017GraveStone3 : Item
	{
		[Constructable]
		public Halloween2017GraveStone3() : base( 0x0ED7 )
            {
			Weight = 14.0;
			Name = "A Halloween Gravestone";
			Gravestone3Hue();
            }
		public virtual void Gravestone3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EDB,0x0EDC)]
	public class Halloween2017GraveStone4 : Item
	{
		[Constructable]
		public Halloween2017GraveStone4() : base( 0x0EDB )
            {
			Weight = 16.0;
			Name = "A Halloween Gravestone";
			Gravestone4Hue();
            }
		public virtual void Gravestone4Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone4( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EDD,0x0EDE)]
	public class Halloween2017GraveStone5 : Item
	{
		[Constructable]
		public Halloween2017GraveStone5() : base( 0x0EDD )
            {
			Weight = 16.0;
			Name = "A Halloween Gravestone";
			Gravestone5Hue();
            }
		public virtual void Gravestone5Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone5( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EDF,0x0EE0)]
	public class Halloween2017Grave : Item
	{
		[Constructable]
		public Halloween2017Grave() : base( 0x0EDF )
            {
			Weight = 6.0;
			Name = "A Halloween Grave";
			GraveHue();
            }
		public virtual void GraveHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Grave( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EE3,0x0EE4)]
	public class Halloween2017Spiderweb1 : Item
	{
		[Constructable]
		public Halloween2017Spiderweb1() : base( 0x0EE3 )
            {
			Weight = 4.0;
			Name = "A Halloween Spiderweb";
			Spiderweb1Hue();
            }
		public virtual void Spiderweb1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Spiderweb1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0EE5,0x0EE6)]
	public class Halloween2017Spiderweb2 : Item
	{
		[Constructable]
		public Halloween2017Spiderweb2() : base( 0x0EE5 )
            {
			Weight = 4.0;
			Name = "A Halloween Spiderweb";
			Spiderweb2Hue();
            }
		public virtual void Spiderweb2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Spiderweb2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[DynamicFliping]
	[Flipable( 0x0ECA, 0x0ECB )]
	public class Halloween2017BonePile1 : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x9; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public Halloween2017BonePile1() : base( 0x0ECA )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Bones";
			BonePile1Hue();
            }
		public virtual void BonePile1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BonePile1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[DynamicFliping]
	[Flipable( 0x0ECC, 0x0ECD )]
	public class Halloween2017BonePile2 : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x9; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public Halloween2017BonePile2() : base( 0x0ECC )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Bones";
			BonePile2Hue();
            }
		public virtual void BonePile2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BonePile2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[DynamicFliping]
	[Flipable( 0x0ECE, 0x0ECE )]
	public class Halloween2017BonePile3 : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x9; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public Halloween2017BonePile3() : base( 0x0ECE )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Bones";
			BonePile3Hue();
            }
		public virtual void BonePile3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BonePile3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[DynamicFliping]
	[Flipable( 0x0ECF, 0x0ED0 )]
	public class Halloween2017BonePile4 : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x9; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public Halloween2017BonePile4() : base( 0x0ECF )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Bones";
			BonePile4Hue();
            }
		public virtual void BonePile4Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BonePile4( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[DynamicFliping]
	[Flipable( 0x0ED1, 0x0ED2 )]
	public class Halloween2017BonePile5 : BaseContainer
	{

		public override int DefaultGumpID{ get{ return 0x9; } }
		public override int DefaultDropSound{ get{ return 0x42; } }


		[Constructable]
		public Halloween2017BonePile5() : base( 0x0ED1 )
            {
			Weight = 8.0;
			Name = "A Halloween Pile Of Bones";
			BonePile5Hue();
            }
		public virtual void BonePile5Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BonePile5( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0F36,0x0F36)]
	public class Halloween2017SheafWheat : Item
	{
		[Constructable]
		public Halloween2017SheafWheat() : base( 0x0F36 )
            {
			Weight = 1.0;
			Name = "A Halloween Sheaf of Wheat";
			Stackable = true;
			SheafWheatHue();
            }
		public virtual void SheafWheatHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017SheafWheat( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1165,0x1166)]
	public class Halloween2017GraveStone6 : Item
	{
		[Constructable]
		public Halloween2017GraveStone6() : base( 0x1165 )
            {
			Weight = 8.0;
			Name = "A Halloween Gravestone";
			Gravestone6Hue();
            }
		public virtual void Gravestone6Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone6( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1167,0x1168)]
	public class Halloween2017GraveStone7 : Item
	{
		[Constructable]
		public Halloween2017GraveStone7() : base( 0x1167 )
            {
			Weight = 11.0;
			Name = "A Halloween Gravestone";
			Gravestone7Hue();
            }
		public virtual void Gravestone7Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone7( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1169,0x116A)]
	public class Halloween2017GraveStone8 : Item
	{
		[Constructable]
		public Halloween2017GraveStone8() : base( 0x1169 )
            {
			Weight = 10.0;
			Name = "A Halloween Gravestone";
			Gravestone8Hue();
            }
		public virtual void Gravestone8Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone8( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x116B,0x116C)]
	public class Halloween2017GraveStone9 : Item
	{
		[Constructable]
		public Halloween2017GraveStone9() : base( 0x116B )
            {
			Weight = 10.0;
			Name = "A Halloween Gravestone";
			Gravestone9Hue();
            }
		public virtual void Gravestone9Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone9( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x116D,0x116E)]
	public class Halloween2017GraveStone10 : Item
	{
		[Constructable]
		public Halloween2017GraveStone10() : base( 0x116D )
            {
			Weight = 13.0;
			Name = "A Halloween Gravestone";
			Gravestone10Hue();
            }
		public virtual void Gravestone10Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone10( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x116F,0x1170)]
	public class Halloween2017GraveStone11 : Item
	{
		[Constructable]
		public Halloween2017GraveStone11() : base( 0x116F )
            {
			Weight = 13.0;
			Name = "A Halloween Gravestone";
			Gravestone11Hue();
            }
		public virtual void Gravestone11Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone11( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1171,0x1172)]
	public class Halloween2017GraveStone12 : Item
	{
		[Constructable]
		public Halloween2017GraveStone12() : base( 0x1171 )
            {
			Weight = 10.0;
			Name = "A Halloween Gravestone";
			Gravestone12Hue();
            }
		public virtual void Gravestone12Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone12( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1173,0x1174)]
	public class Halloween2017GraveStone13 : Item
	{
		[Constructable]
		public Halloween2017GraveStone13() : base( 0x1173 )
            {
			Weight = 11.0;
			Name = "A Halloween Gravestone";
			Gravestone13Hue();
            }
		public virtual void Gravestone13Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone13( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1175,0x1175)]
	public class Halloween2017GraveStone14 : Item
	{
		[Constructable]
		public Halloween2017GraveStone14() : base( 0x1175 )
            {
			Weight = 11.0;
			Name = "A Halloween Gravestone";
			Gravestone14Hue();
            }
		public virtual void Gravestone14Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone14( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1176,0x1176)]
	public class Halloween2017GraveStone15 : Item
	{
		[Constructable]
		public Halloween2017GraveStone15() : base( 0x1176 )
            {
			Weight = 11.0;
			Name = "A Halloween Gravestone";
			Gravestone15Hue();
            }
		public virtual void Gravestone15Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone15( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1177,0x1178)]
	public class Halloween2017GraveStone16 : Item
	{
		[Constructable]
		public Halloween2017GraveStone16() : base( 0x1177 )
            {
			Weight = 12.0;
			Name = "A Halloween Gravestone";
			Gravestone16Hue();
            }
		public virtual void Gravestone16Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone16( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1179,0x1179)]
	public class Halloween2017GraveStone17 : Item
	{
		[Constructable]
		public Halloween2017GraveStone17() : base( 0x1179 )
            {
			Weight = 13.0;
			Name = "A Halloween Gravestone";
			Gravestone17Hue();
            }
		public virtual void Gravestone17Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone17( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x117A,0x117A)]
	public class Halloween2017GraveStone18 : Item
	{
		[Constructable]
		public Halloween2017GraveStone18() : base( 0x117A )
            {
			Weight = 13.0;
			Name = "A Halloween Gravestone";
			Gravestone18Hue();
            }
		public virtual void Gravestone18Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone18( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x117B,0x117C)]
	public class Halloween2017GraveStone19 : Item
	{
		[Constructable]
		public Halloween2017GraveStone19() : base( 0x117B )
            {
			Weight = 13.0;
			Name = "A Halloween Gravestone";
			Gravestone19Hue();
            }
		public virtual void Gravestone19Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone19( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x117D,0x117D)]
	public class Halloween2017GraveStone20 : Item
	{
		[Constructable]
		public Halloween2017GraveStone20() : base( 0x117D )
            {
			Weight = 12.0;
			Name = "A Halloween Gravestone";
			Gravestone20Hue();
            }
		public virtual void Gravestone20Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone20( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x117E,0x117E)]
	public class Halloween2017GraveStone21 : Item
	{
		[Constructable]
		public Halloween2017GraveStone21() : base( 0x117E )
            {
			Weight = 12.0;
			Name = "A Halloween Gravestone";
			Gravestone21Hue();
            }
		public virtual void Gravestone21Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone21( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x117F,0x1180)]
	public class Halloween2017GraveStone22 : Item
	{
		[Constructable]
		public Halloween2017GraveStone22() : base( 0x117F )
            {
			Weight = 12.0;
			Name = "A Halloween Gravestone";
			Gravestone22Hue();
            }
		public virtual void Gravestone22Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone22( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1181,0x1181)]
	public class Halloween2017GraveStone23 : Item
	{
		[Constructable]
		public Halloween2017GraveStone23() : base( 0x1181 )
            {
			Weight = 12.0;
			Name = "A Halloween Gravestone";
			Gravestone23Hue();
            }
		public virtual void Gravestone23Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone23( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1182,0x1182)]
	public class Halloween2017GraveStone24 : Item
	{
		[Constructable]
		public Halloween2017GraveStone24() : base( 0x1182 )
            {
			Weight = 11.0;
			Name = "A Halloween Gravestone";
			Gravestone24Hue();
            }
		public virtual void Gravestone24Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone24( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1183,0x1183)]
	public class Halloween2017GraveStone25 : Item
	{
		[Constructable]
		public Halloween2017GraveStone25() : base( 0x1183 )
            {
			Weight = 14.0;
			Name = "A Halloween Gravestone";
			Gravestone25Hue();
            }
		public virtual void Gravestone25Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone25( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1184,0x1184)]
	public class Halloween2017GraveStone26 : Item
	{
		[Constructable]
		public Halloween2017GraveStone26() : base( 0x1184 )
            {
			Weight = 14.0;
			Name = "A Halloween Gravestone";
			Gravestone26Hue();
            }
		public virtual void Gravestone26Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017GraveStone26( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x124A,0x124A)]
	public class Halloween2017IronMaiden : Item
	{
		[Constructable]
		public Halloween2017IronMaiden() : base( 0x124A )
            {
			Weight = 23.0;
			Name = "A Halloween Iron Maiden";
			IronMaidenHue();
            }
		public virtual void IronMaidenHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public override void OnDoubleClick( Mobile m )
		{
		if ( m.InRange( this.GetWorldLocation(), 2 ) )
			{
				if ( ItemID == 0x124A )
				{
					m.SendMessage( "Your skin crawls as the iron maiden creaks open." );
					m.PlaySound( 0x235 );
					ItemID = 0x124B;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x124B )
				{
					m.SendMessage( "You jump as the iron maiden slides closed." );
					m.PlaySound( 0x235 );
					ItemID = 0x124A;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
			}
		else
			m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
        }
		public Halloween2017IronMaiden( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x142A,0x142A)]
	public class Halloween2017WitchesBrew : Item
	{
		[Constructable]
		public Halloween2017WitchesBrew() : base( 0x142A )
            {
			Weight = 14.0;
			Name = "A Halloween Witches Brew";
			WitchBrewHue();
            }
		public virtual void WitchBrewHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017WitchesBrew( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1508,0x151C)]
	public class Halloween2017DecorativeArmor : Item
	{
		[Constructable]
		public Halloween2017DecorativeArmor() : base( 0x1508 )
            {
			Weight = 23.0;
			Name = "A Halloween Decorative Armor";
			DecArmHue();
            }
		public virtual void DecArmHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public override void OnDoubleClick( Mobile m )
		{
		if ( m.InRange( this.GetWorldLocation(), 2 ) )
			{
				if ( ItemID == 0x1508 )
				{
					m.SendMessage( "The axe falls from the armor's hands, causing you to jump." );
					m.PlaySound( 0x237 );
					ItemID = 0x1509;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x1509 )
				{
					m.SendMessage( "You put the axe back in the armor's hands." );
					ItemID = 0x1508;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x151D )
				{
					m.SendMessage( "You put the axe back in the armor's hands." );
					ItemID = 0x151C;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x151C )
				{
					m.SendMessage( "The axe falls from the armor's hands, causing you to jump." );
					m.PlaySound( 0x237 );
					ItemID = 0x151D;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
			}
		else
			m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
        }
		public Halloween2017DecorativeArmor( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x151A,0x1512)]
	public class Halloween2017DecorativeArmor2 : Item
	{
		[Constructable]
		public Halloween2017DecorativeArmor2() : base( 0x151A )
            {
			Weight = 23.0;
			Name = "A Halloween Decorative Armor";
			DecArm2Hue();
            }
		public virtual void DecArm2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public override void OnDoubleClick( Mobile m )
		{
		if ( m.InRange( this.GetWorldLocation(), 2 ) )
			{
				if ( ItemID == 0x151A )
				{
					m.SendMessage( "The axe falls from the armor's hands, causing you to jump." );
					m.PlaySound( 0x237 );
					ItemID = 0x151B;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x151B )
				{
					m.SendMessage( "You put the axe back in the armor's hands." );
					ItemID = 0x151A;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x1512 )
				{
					m.SendMessage( "The axe falls from the armor's hands, causing you to jump." );
					m.PlaySound( 0x237 );
					ItemID = 0x1513;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x1513 )
				{
					m.SendMessage( "You put the axe back in the armor's hands." );
					ItemID = 0x1512;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
			}
		else
			m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
        }
		public Halloween2017DecorativeArmor2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1871,0x1872)]
	public class Halloween2017BeefCarcass : Item
	{
		[Constructable]
		public Halloween2017BeefCarcass() : base( 0x1871 )
            {
			Weight = 28.0;
			Name = "A Halloween Beef Carcass";
			BeefCarcassHue();
            }
		public virtual void BeefCarcassHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BeefCarcass( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1873,0x1874)]
	public class Halloween2017BeefCarcass2 : Item
	{
		[Constructable]
		public Halloween2017BeefCarcass2() : base( 0x1873 )
            {
			Weight = 28.0;
			Name = "A Halloween Beef Carcass";
			BeefCarcass2Hue();
            }
		public virtual void BeefCarcass2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BeefCarcass2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017CandleSkull : BaseLight
	{
		public override int LitItemID
		{
			get
			{
				if ( ItemID == 0x1583 || ItemID == 0x1854 )
					return 0x1854;

				return 0x1858;
			}
		}

		public override int UnlitItemID
		{
			get
			{
				if ( ItemID == 0x1853 || ItemID == 0x1584 )
					return 0x1853;

				return 0x1857;
			}
		}

		[Constructable]
		public Halloween2017CandleSkull() : base( 0x1853 )
		{
			if ( Burnout )
				Duration = TimeSpan.FromMinutes( 25 );
			else
				Duration = TimeSpan.Zero;

			Burning = false;
			Light = LightType.Circle150;
			Weight = 5.0;
			Name = "A Halloween Skull Candle";
			CandleSkullHue();
		}
		public virtual void CandleSkullHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017CandleSkull( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	[Furniture]
	[Flipable(0x1A01,0x1A02)]
	public class Halloween2017HangingSkeleton1 : Item
	{
		[Constructable]
		public Halloween2017HangingSkeleton1() : base( 0x1A01 )
            {
			Weight = 12.0;
			Name = "A Halloween Hanging Skeleton";
			HangSkel1Hue();
            }
		public virtual void HangSkel1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017HangingSkeleton1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1A03,0x1A04)]
	public class Halloween2017HangingSkeleton2 : Item
	{
		[Constructable]
		public Halloween2017HangingSkeleton2() : base( 0x1A03 )
            {
			Weight = 12.0;
			Name = "A Halloween Hanging Skeleton";
			HangSkel2Hue();
            }
		public virtual void HangSkel2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017HangingSkeleton2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1A05,0x1A06)]
	public class Halloween2017HangingSkeleton3 : Item
	{
		[Constructable]
		public Halloween2017HangingSkeleton3() : base( 0x1A05 )
            {
			Weight = 12.0;
			Name = "A Halloween Hanging Skeleton";
			HangSkel3Hue();
            }
		public virtual void HangSkel3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017HangingSkeleton3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1A09,0x1A0A)]
	public class Halloween2017HangingSkeleton4 : Item
	{
		[Constructable]
		public Halloween2017HangingSkeleton4() : base( 0x1A09 )
            {
			Weight = 12.0;
			Name = "A Halloween Hanging Skeleton";
			HangSkel4Hue();
            }
		public virtual void HangSkel4Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017HangingSkeleton4( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1B1D,0x1B1E)]
	public class Halloween2017HangingSkeleton5 : Item
	{
		[Constructable]
		public Halloween2017HangingSkeleton5() : base( 0x1B1D )
            {
			Weight = 18.0;
			Name = "A Halloween Hanging Skeleton With Meat";
			HangSkel5Hue();
            }
		public virtual void HangSkel5Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017HangingSkeleton5( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1D94,0x1D94)]
	public class Halloween2017Blood1 : Item
	{
		[Constructable]
		public Halloween2017Blood1() : base( 0x1D94 )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood1Hue();
            }
		public virtual void Blood1Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1D95,0x1D95)]
	public class Halloween2017Blood2 : Item
	{
		[Constructable]
		public Halloween2017Blood2() : base( 0x1D95 )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood2Hue();
            }
		public virtual void Blood2Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x1D96,0x1D96)]
	public class Halloween2017Blood3 : Item
	{
		[Constructable]
		public Halloween2017Blood3() : base( 0x1D96 )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood3Hue();
            }
		public virtual void Blood3Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood3( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x21FC,0x21FC)]
	public class Halloween2017SkullPile : Item
	{
		[Constructable]
		public Halloween2017SkullPile() : base( 0x21FC )
            {
			Weight = 8.0;
			Name = "A Halloween Skull Pile";
			SkullPileHue();
            }
		public virtual void SkullPileHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017SkullPile( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x2204,0x2204)]
	public class Halloween2017SkullPole : Item
	{
		[Constructable]
		public Halloween2017SkullPole() : base( 0x2204 )
            {
			Weight = 8.0;
			Name = "A Halloween Skull Pole";
			SkullPoleHue();
            }
		public virtual void SkullPoleHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017SkullPole( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x2A7B,0x2A7D)]
	public class Halloween2017HauntedMirror : Item
	{
		[Constructable]
		public Halloween2017HauntedMirror() : base( 0x2A7B )
            {
			Weight = 18.0;
			Name = "A Halloween Haunted Mirror";
			HauntedMirrorHue();
            }
		public virtual void HauntedMirrorHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public override void OnDoubleClick( Mobile m )
		{
		if ( m.InRange( this.GetWorldLocation(), 2 ) )
			{
				if ( ItemID == 0x2A7B )
				{
					m.SendMessage( "A ghastly face appears in the mirror." );
					m.PlaySound( 0x179 );
					ItemID = 0x2A7C;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x2A7C )
				{
					m.SendMessage( "The face fades away from the mirror." );
					ItemID = 0x2A7B;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x2A7D )
				{
					m.SendMessage( "A ghastly face appears in the mirror." );
					m.PlaySound( 0x179 );
					ItemID = 0x2A7E;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
				else if ( ItemID == 0x2A7E )
				{
					m.SendMessage( "The face fades away from the mirror." );
					ItemID = 0x2A7D;
					m.RemoveItem(this);
					m.EquipItem(this);
				}
			}
		else
			m.LocalOverheadMessage( MessageType.Regular, 0x3B2, 1019045 ); // I can't reach that.
        }
		public Halloween2017HauntedMirror( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122A,0x122A)]
	public class Halloween2017Blood4 : Item
	{
		[Constructable]
		public Halloween2017Blood4() : base( 0x122A )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood4Hue();
            }
		public virtual void Blood4Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood4( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122B,0x122B)]
	public class Halloween2017Blood5 : Item
	{
		[Constructable]
		public Halloween2017Blood5() : base( 0x122B )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood5Hue();
            }
		public virtual void Blood5Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood5( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122C,0x122C)]
	public class Halloween2017Blood6 : Item
	{
		[Constructable]
		public Halloween2017Blood6() : base( 0x122C )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood6Hue();
            }
		public virtual void Blood6Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood6( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122D,0x122D)]
	public class Halloween2017Blood7 : Item
	{
		[Constructable]
		public Halloween2017Blood7() : base( 0x122D )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood7Hue();
            }
		public virtual void Blood7Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood7( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122E,0x122E)]
	public class Halloween2017Blood8 : Item
	{
		[Constructable]
		public Halloween2017Blood8() : base( 0x122E )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood8Hue();
            }
		public virtual void Blood8Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood8( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x122F,0x122F)]
	public class Halloween2017Blood9 : Item
	{
		[Constructable]
		public Halloween2017Blood9() : base( 0x122F )
            {
			Weight = 3.0;
			Name = "A Halloween Blood Splatter";
			Blood9Hue();
            }
		public virtual void Blood9Hue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Blood9( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017BoneCouchEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017BoneCouchEastDeed(); } }

		[Constructable]
		public Halloween2017BoneCouchEastAddon()
		{
			AddComponent( new AddonComponent( 0x2A7F ), 0, 1, 0 );
			AddComponent( new AddonComponent( 0x2A80 ), 0, 0, 0 );
		}

		public Halloween2017BoneCouchEastAddon( Serial serial ) : base( serial )
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

	public class Halloween2017BoneCouchEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017BoneCouchEastAddon(); } }

		[Constructable]
		public Halloween2017BoneCouchEastDeed()
		{
		Name = "Halloween Bone Couch East Deed";
		Hue = 1194;
		}

		public Halloween2017BoneCouchEastDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017BoneCouchSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017BoneCouchSouthDeed(); } }

		[Constructable]
		public Halloween2017BoneCouchSouthAddon()
		{
			AddComponent( new AddonComponent( 0x2A5A ), 1, 0, 0 );
			AddComponent( new AddonComponent( 0x2A5B ), 0, 0, 0 );
		}

		public Halloween2017BoneCouchSouthAddon( Serial serial ) : base( serial )
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

	public class Halloween2017BoneCouchSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017BoneCouchSouthAddon(); } }

		[Constructable]
		public Halloween2017BoneCouchSouthDeed()
		{
		Name = "Halloween Bone Couch South Deed";
		Hue = 1194;
		}

		public Halloween2017BoneCouchSouthDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x2A5C,0x2A5C)]
	public class Halloween2017BoneTable : Item
	{
		[Constructable]
		public Halloween2017BoneTable() : base( 0x2A5C )
            {
			Weight = 3.0;
			Name = "A Halloween Bone Table";
			BTableHue();
            }
		public virtual void BTableHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BoneTable( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x2A58,0x2A59)]
	public class Halloween2017BoneThrone : Item
	{
		[Constructable]
		public Halloween2017BoneThrone() : base( 0x2A58 )
            {
			Weight = 3.0;
			Name = "A Halloween Bone Throne";
			BThroneHue();
            }
		public virtual void BThroneHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017BoneThrone( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017SacrificialAlterEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017SacrificialAlterEastDeed(); } }

		[Constructable]
		public Halloween2017SacrificialAlterEastAddon()
		{
			AddComponent( new AddonComponent( 0x2A9C ), 0, 1, 0 );
			AddComponent( new AddonComponent( 0x2A9D ), 0, 0, 0 );
		}

		public Halloween2017SacrificialAlterEastAddon( Serial serial ) : base( serial )
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

	public class Halloween2017SacrificialAlterEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017SacrificialAlterEastAddon(); } }

		[Constructable]
		public Halloween2017SacrificialAlterEastDeed()
		{
		Name = "Halloween Sacrificial Altar East Deed";
		Hue = 1194;
		}

		public Halloween2017SacrificialAlterEastDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017SacrificialAlterSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017SacrificialAlterSouthDeed(); } }

		[Constructable]
		public Halloween2017SacrificialAlterSouthAddon()
		{
			AddComponent( new AddonComponent( 0x2A9A ), 1, 0, 0 );
			AddComponent( new AddonComponent( 0x2A9B ), 0, 0, 0 );
			Name = "Holloween Sacrificial Altar";
		}

		public Halloween2017SacrificialAlterSouthAddon( Serial serial ) : base( serial )
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

	public class Halloween2017SacrificialAlterSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017SacrificialAlterSouthAddon(); } }

		[Constructable]
		public Halloween2017SacrificialAlterSouthDeed()
		{
		Name = "Halloween Sacrificial Altar South Deed";
		Hue = 1194;
		}

		public Halloween2017SacrificialAlterSouthDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x0974,0x0975)]
	public class Halloween2017Cauldron : Item
	{
		[Constructable]
		public Halloween2017Cauldron() : base( 0x0974 )
            {
			Weight = 10.0;
			Name = "A Halloween Cauldron";
			CauldronHue();
            }
		public virtual void CauldronHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017Cauldron( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017StoneCoffinSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017StoneCoffinSouthDeed(); } }

		[Constructable]
		public Halloween2017StoneCoffinSouthAddon()
		{
			AddComponent( new AddonComponent( 0x304A ), 1, 0, 0 );
			AddComponent( new AddonComponent( 0x304B ), 0, 0, 0 );
		}

		public Halloween2017StoneCoffinSouthAddon( Serial serial ) : base( serial )
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

	public class Halloween2017StoneCoffinSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017StoneCoffinSouthAddon(); } }

		[Constructable]
		public Halloween2017StoneCoffinSouthDeed()
		{
		Name = "Halloween Stone Coffin South Deed";
		Hue = 1175;
		}

		public Halloween2017StoneCoffinSouthDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017StoneCoffinEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new Halloween2017StoneCoffinEastDeed(); } }

		[Constructable]
		public Halloween2017StoneCoffinEastAddon()
		{
			AddComponent( new AddonComponent( 0x3048 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 0x3049 ), 0, 0, 0 );
		}

		public Halloween2017StoneCoffinEastAddon( Serial serial ) : base( serial )
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

	public class Halloween2017StoneCoffinEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new Halloween2017StoneCoffinEastAddon(); } }

		[Constructable]
		public Halloween2017StoneCoffinEastDeed()
		{
		Name = "Halloween Stone Coffin East Deed";
		Hue = 1175;
		}

		public Halloween2017StoneCoffinEastDeed( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x364B,0x369B)]
	public class Halloween2017DaemonPoleStatue : Item
	{
		[Constructable]
		public Halloween2017DaemonPoleStatue() : base( 0x364B )
            {
			Weight = 16.0;
			Name = "A Halloween Shadow Daemon Statue";
			DPHue();
            }
		public virtual void DPHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017DaemonPoleStatue( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	[Furniture]
	[Flipable(0x364D,0x369C)]
	public class Halloween2017SpikePoleStatue : Item
	{
		[Constructable]
		public Halloween2017SpikePoleStatue() : base( 0x364D )
            {
			Weight = 12.0;
			Name = "A Halloween Spiked Post";
			SPHue();
            }
		public virtual void SPHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017SpikePoleStatue( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017SpikeStatue : Item
	{
		[Constructable]
		public Halloween2017SpikeStatue() : base( 0x364C )
            {
			Weight = 14.0;
			Name = "A Halloween Spike";
			SpikeHue();
            }
		public virtual void SpikeHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017SpikeStatue( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017ShadowShort : Item
	{
		[Constructable]
		public Halloween2017ShadowShort() : base( 0x364E )
            {
			Weight = 14.0;
			Name = "A Short Halloween Shadow";
			SShadowHue();
            }
		public virtual void SShadowHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017ShadowShort( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017ShadowTall : Item
	{
		[Constructable]
		public Halloween2017ShadowTall() : base( 0x364F )
            {
			Weight = 17.0;
			Name = "A Tall Halloween Shadow";
			TShadowHue();
            }
		public virtual void TShadowHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017ShadowTall( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class Halloween2017ShadowStone : Item
	{
		[Constructable]
		public Halloween2017ShadowStone() : base( 0x3650 )
            {
			Weight = 24.0;
			Name = "A Halloween Shadow Stone";
			ShadowStoneHue();
            }
		public virtual void ShadowStoneHue()
        {
                switch (Utility.Random(8))
                {
                    case 0: Hue=(0); break;
                    case 1: Hue=(0); break;
                    case 2: Hue=(0); break;
                    case 3: Hue=(1175); break;
                    case 4: Hue=(48); break;
                    case 5: Hue=(0); break;
                    case 6: Hue=(0); break;
                    case 7: Hue=(0); break;
                }
        }
		public Halloween2017ShadowStone( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
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
	public class JackOLantern1 : BaseLight
	{
		public override int LitItemID{ get { return 0x4691; } }
		public override int UnlitItemID{ get { return 0x4694; } }
		
		[Constructable]
		public JackOLantern1() : base( 0x4694 )
		{
			Movable = true;
			Duration = TimeSpan.Zero;
			Burning = false;
			Light = LightType.Circle150;
			Weight = 6.0;
			Name = "Halloween Jack O' Lantern";
		}

		public JackOLantern1( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class JackOLantern2 : BaseLight
	{
		public override int LitItemID{ get { return 0x4695; } }
		public override int UnlitItemID{ get { return 0x4698; } }
		
		[Constructable]
		public JackOLantern2() : base( 0x4698 )
		{
			Movable = true;
			Duration = TimeSpan.Zero;
			Burning = false;
			Light = LightType.Circle150;
			Weight = 6.0;
			Name = "Halloween Jack O' Lantern";
		}

		public JackOLantern2( Serial serial ) : base( serial )
		{
		}
		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			LabelTo( from, "Halloween 2017" );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Halloween 2017"  );
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}