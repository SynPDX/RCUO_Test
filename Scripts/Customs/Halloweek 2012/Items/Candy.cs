//Items scripted, and list compiled by: Montegro
/*Contained within this script;
GummyMan
GummyBear
MilkChocolateDragonF
DarkChocolateDragonF
WhiteChocolateDragonF
ChocolateLog
ChocolateBar
RockCandy
GummyWoman
GummyZombie
GummySkeleton
ChocolateMan
ChocolateWoman
ChocolateMiguel
ChocolateSkeleton
ChocolateZombie
ChocolateHeart
GummyHeart
MilkChocolateScales
DarkChocolateScales
WhiteChocolateScales
ChocolateDragonSkull
GummyWolf
ChocolateWolf
GummyWerewolf
ChocolateWerewolf*/
using System;
using System.Collections;
using Server.Network;
using System.Collections.Generic;
using Server.ContextMenus;

namespace Server.Items
{
	public abstract class Candy : Item
	{
		private Mobile m_Poisoner;
		private Poison m_Poison;
		private int m_FillFactor;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Poisoner
		{
			get { return m_Poisoner; }
			set { m_Poisoner = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public Poison Poison
		{
			get { return m_Poison; }
			set { m_Poison = value; }
		}
		
		[CommandProperty( AccessLevel.GameMaster )]
		public int FillFactor
		{
			get { return m_FillFactor; }
			set { m_FillFactor = value; }
		}

		public Candy( int itemID ) : this( 1, itemID )
		{
		}

		public Candy( int amount, int itemID ) : base( itemID )
		{
			Stackable = true;
			Amount = amount;
			m_FillFactor = 1;
		}

		public Candy( Serial serial ) : base( serial )
		{
		}

		//public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		//{
			//base.GetContextMenuEntries( from, list );

			//if ( from.Alive )
				//list.Add( new ContextMenus.EatEntry( from, this ) );
		//}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !Movable )
				return;

			if ( from.InRange( this.GetWorldLocation(), 1 ) )
			{
				Eat( from );
			}
		}

		public virtual bool Eat( Mobile from )
		{
			// Fill the Mobile with FillFactor
			if ( FillHunger( from, m_FillFactor ) )
			{
				// Play a random "eat" sound
				from.PlaySound( Utility.Random( 0x3A, 3 ) );

				if ( from.Body.IsHuman && !from.Mounted )
					from.Animate( 34, 5, 1, true, false, 0 );

				if ( m_Poison != null )
					from.ApplyPoison( m_Poisoner, m_Poison );

				Consume();

				return true;
			}

			return false;
		}

		static public bool FillHunger( Mobile from, int fillFactor )
		{
			if ( from.Hunger >= 20 )
			{
				from.SendLocalizedMessage( 500867 ); // You are simply too full to eat any more!
				return false;
			}
			
			int iHunger = from.Hunger + fillFactor;
			if ( from.Stam < from.StamMax )
				from.Stam += Utility.Random( 6, 3 ) + fillFactor/5;//restore some stamina
			if ( iHunger >= 20 )
			{
				from.Hunger = 20;
				from.SendLocalizedMessage( 500872 ); // You manage to eat the food, but you are stuffed!
			}
			else
			{
				from.Hunger = iHunger;

				if ( iHunger < 5 )
					from.SendLocalizedMessage( 500868 ); // You eat the food, but are still extremely hungry.
				else if ( iHunger < 10 )
					from.SendLocalizedMessage( 500869 ); // You eat the food, and begin to feel more satiated.
				else if ( iHunger < 15 )
					from.SendLocalizedMessage( 500870 ); // After eating the food, you feel much less hungry.
				else
					from.SendLocalizedMessage( 500871 ); // You feel quite full after consuming the food.
			}

			return true;
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 4 ); // version

			writer.Write( m_Poisoner );

			Poison.Serialize( m_Poison, writer );
			writer.Write( m_FillFactor );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					switch ( reader.ReadInt() )
					{
						case 0: m_Poison = null; break;
						case 1: m_Poison = Poison.Lesser; break;
						case 2: m_Poison = Poison.Regular; break;
						case 3: m_Poison = Poison.Greater; break;
						case 4: m_Poison = Poison.Deadly; break;
					}

					break;
				}
				case 2:
				{
					m_Poison = Poison.Deserialize( reader );
					break;
				}
				case 3:
				{
					m_Poison = Poison.Deserialize( reader );
					m_FillFactor = reader.ReadInt();
					break;
				}
				case 4:
				{
					m_Poisoner = reader.ReadMobile();
					goto case 3;
				}
			}
		}
	}
	public class RockCandy : Candy
	{
		[Constructable]
		public RockCandy() : this( 1 )
		{
		}

		[Constructable]
		public RockCandy( int amount ) : base( amount, 0x19BA )
		{
			Name = "Rock Candy";
			RockCandyColor();
			Weight = 1.0;
			this.FillFactor = 3;
		}
		public virtual void RockCandyColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public RockCandy( Serial serial ) : base( serial )
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
	public class ChocolateBar : Candy
	{
		[Constructable]
		public ChocolateBar() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateBar( int amount ) : base( amount, 0x1BF2 )
		{
			ChocolateRandomizer();
			this.FillFactor = 1;
			ChocolateAmount();
			Stackable = true;
		}
		public virtual void ChocolateRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Bar"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Bar"); break;
                    case 2: Hue=(556); Name=("White Chocolate Bar"); break;
                }
        }
		public virtual void ChocolateAmount()
        {
                switch (Utility.Random(3))
                {
                    case 0: Amount=(2); break;
                    case 1: Amount=(1); break;
                    case 2: Amount=(3); break;
                }
        }
		public ChocolateBar( Serial serial ) : base( serial )
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
	public class ChocolateLog : Candy
	{
		[Constructable]
		public ChocolateLog() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateLog( int amount ) : base( amount, 0x1BDD )
		{
			ChocolateLRandomizer();
			this.FillFactor = 2;
			ChocolateLAmount();
			Stackable = true;
		}
		public virtual void ChocolateLRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Log"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Log"); break;
                    case 2: Hue=(556); Name=("White Chocolate Log"); break;
                }
        }
		public virtual void ChocolateLAmount()
        {
                switch (Utility.Random(3))
                {
                    case 0: Amount=(2); break;
                    case 1: Amount=(1); break;
                    case 2: Amount=(3); break;
                }
        }
		public ChocolateLog( Serial serial ) : base( serial )
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
	public class WhiteChocolateDragonF : Candy
	{
		[Constructable]
		public WhiteChocolateDragonF() : this( 1 )
		{
		}
		[Constructable]
		public WhiteChocolateDragonF( int amount ) : base( amount, 0x20D6 )
		{
			Name = "White Chocolate Dragon";
			this.FillFactor = 5;
			Hue = 556;
			Stackable = false;
		}
		public WhiteChocolateDragonF( Serial serial ) : base( serial )
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
	public class DarkChocolateDragonF : Candy
	{
		[Constructable]
		public DarkChocolateDragonF() : this( 1 )
		{
		}
		[Constructable]
		public DarkChocolateDragonF( int amount ) : base( amount, 0x20D6 )
		{
			Name = "Dark Chocolate Dragon";
			this.FillFactor = 5;
			Hue = 1011;
			Stackable = false;
		}
		public DarkChocolateDragonF( Serial serial ) : base( serial )
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
	public class MilkChocolateDragonF : Candy
	{
		[Constructable]
		public MilkChocolateDragonF() : this( 1 )
		{
		}
		[Constructable]
		public MilkChocolateDragonF( int amount ) : base( amount, 0x20D6 )
		{
			Name = "Milk Chocolate Dragon";
			this.FillFactor = 5;
			Hue = 643;
			Stackable = false;
		}
		public MilkChocolateDragonF( Serial serial ) : base( serial )
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
	public class GummyBear : Candy
	{
		[Constructable]
		public GummyBear() : this( 1 )
		{
		}

		[Constructable]
		public GummyBear( int amount ) : base( amount, 0x211E )
		{
			Name = "Gummy Bear";
			GBearColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GBearColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyBear( Serial serial ) : base( serial )
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
	public class GummyMan : Candy
	{
		[Constructable]
		public GummyMan() : this( 1 )
		{
		}

		[Constructable]
		public GummyMan( int amount ) : base( amount, 0x20CD )
		{
			Name = "Gummy Man";
			GManColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GManColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyMan( Serial serial ) : base( serial )
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
	public class GummyWoman : Candy
	{
		[Constructable]
		public GummyWoman() : this( 1 )
		{
		}

		[Constructable]
		public GummyWoman( int amount ) : base( amount, 0x20CE )
		{
			Name = "Gummy Woman";
			GWomanColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GWomanColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyWoman( Serial serial ) : base( serial )
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
	public class GummyZombie : Candy
	{
		[Constructable]
		public GummyZombie() : this( 1 )
		{
		}

		[Constructable]
		public GummyZombie( int amount ) : base( amount, 0x20EC )
		{
			Name = "Gummy Zombie";
			GZombieColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GZombieColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyZombie( Serial serial ) : base( serial )
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
	public class GummySkeleton : Candy
	{
		[Constructable]
		public GummySkeleton() : this( 1 )
		{
		}

		[Constructable]
		public GummySkeleton( int amount ) : base( amount, 0x20E7 )
		{
			Name = "Gummy Skeleton";
			GSkeletonColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GSkeletonColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummySkeleton( Serial serial ) : base( serial )
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
	public class ChocolateMan : Candy
	{
		[Constructable]
		public ChocolateMan() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateMan( int amount ) : base( amount, 0x20CD )
		{
			ChocolateManRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateManRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Man"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Man"); break;
                    case 2: Hue=(556); Name=("White Chocolate Man"); break;
                }
        }
		public ChocolateMan( Serial serial ) : base( serial )
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
	public class ChocolateWoman : Candy
	{
		[Constructable]
		public ChocolateWoman() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateWoman( int amount ) : base( amount, 0x20CE )
		{
			ChocolateWomanRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateWomanRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Woman"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Woman"); break;
                    case 2: Hue=(556); Name=("White Chocolate Woman"); break;
                }
        }
		public ChocolateWoman( Serial serial ) : base( serial )
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
	public class ChocolateMiguel : Candy
	{
		[Constructable]
		public ChocolateMiguel() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateMiguel( int amount ) : base( amount, 0x20DE )
		{
			ChocolateMiguelRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateMiguelRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Miguel, Father Of Pepitos"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Miguel, Father Of Pepitos"); break;
                    case 2: Hue=(556); Name=("White Chocolate Miguel, Father Of Pepitos"); break;
                }
        }
		public ChocolateMiguel( Serial serial ) : base( serial )
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
	public class ChocolateSkeleton : Candy
	{
		[Constructable]
		public ChocolateSkeleton() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateSkeleton( int amount ) : base( amount, 0x20E7 )
		{
			ChocolateSkelRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateSkelRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Skeleton"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Skeleton"); break;
                    case 2: Hue=(556); Name=("White Chocolate Skeleton"); break;
                }
        }
		public ChocolateSkeleton( Serial serial ) : base( serial )
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
	public class ChocolateZombie : Candy
	{
		[Constructable]
		public ChocolateZombie() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateZombie( int amount ) : base( amount, 0x20EC )
		{
			ChocolateZombRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateZombRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Zombie"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Zombie"); break;
                    case 2: Hue=(556); Name=("White Chocolate Zombie"); break;
                }
        }
		public ChocolateZombie( Serial serial ) : base( serial )
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
	public class ChocolateHeart : Candy
	{
		[Constructable]
		public ChocolateHeart() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateHeart( int amount ) : base( amount, 0x024B )
		{
			ChocolateHeartRandomizer();
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void ChocolateHeartRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Heart"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Heart"); break;
                    case 2: Hue=(556); Name=("White Chocolate Heart"); break;
                }
        }
		public ChocolateHeart( Serial serial ) : base( serial )
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
	public class GummyHeart : Candy
	{
		[Constructable]
		public GummyHeart() : this( 1 )
		{
		}

		[Constructable]
		public GummyHeart( int amount ) : base( amount, 0x024B )
		{
			Name = "Gummy Heart";
			GummyHeartColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GummyHeartColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyHeart( Serial serial ) : base( serial )
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
	public class MilkChocolateScales : Candy
	{
		[Constructable]
		public MilkChocolateScales() : this( 1 )
		{
		}
		[Constructable]
		public MilkChocolateScales( int amount ) : base( amount, 0x26B4 )
		{
			Hue = 643;
			Name = "Milk Chocolate Scales";
			this.FillFactor = 1;
			MChocolateScAmount();
			Stackable = true;
		}
		public virtual void MChocolateScAmount()
        {
                switch (Utility.Random(3))
                {
                    case 0: Amount=(7); break;
                    case 1: Amount=(5); break;
                    case 2: Amount=(3); break;
                }
        }
		public MilkChocolateScales( Serial serial ) : base( serial )
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
	public class DarkChocolateScales : Candy
	{
		[Constructable]
		public DarkChocolateScales() : this( 1 )
		{
		}
		[Constructable]
		public DarkChocolateScales( int amount ) : base( amount, 0x26B4 )
		{
			Hue = 1015;
			Name = "Dark Chocolate Scales";
			this.FillFactor = 1;
			DChocolateScAmount();
			Stackable = true;
		}
		public virtual void DChocolateScAmount()
        {
                switch (Utility.Random(3))
                {
                    case 0: Amount=(7); break;
                    case 1: Amount=(5); break;
                    case 2: Amount=(3); break;
                }
        }
		public DarkChocolateScales( Serial serial ) : base( serial )
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
	public class WhiteChocolateScales : Candy
	{
		[Constructable]
		public WhiteChocolateScales() : this( 1 )
		{
		}
		[Constructable]
		public WhiteChocolateScales( int amount ) : base( amount, 0x26B4 )
		{
			Hue = 556;
			Name = "White Chocolate Scales";
			this.FillFactor = 1;
			WChocolateScAmount();
			Stackable = true;
		}
		public virtual void WChocolateScAmount()
        {
                switch (Utility.Random(3))
                {
                    case 0: Amount=(7); break;
                    case 1: Amount=(5); break;
                    case 2: Amount=(3); break;
                }
        }
		public WhiteChocolateScales( Serial serial ) : base( serial )
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
	public class ChocolateDragonSkull : Candy
	{
		[Constructable]
		public ChocolateDragonSkull() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateDragonSkull( int amount ) : base( amount, 0x224E )
		{
			ChocolateDSNRandomizer();
			this.FillFactor = 6;
			ChocolateDSRandomizer();
		}
		public virtual void ChocolateDSNRandomizer()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Dragon Skull"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Dragon Skull"); break;
                    case 2: Hue=(556); Name=("White Chocolate Dragon Skull"); break;
                }
        }
		public virtual void ChocolateDSRandomizer()
        {
                switch (Utility.Random(4))
                {
                    case 0: ItemID=(0x224E); break;
                    case 1: ItemID=(0x224F); break;
                    case 2: ItemID=(0x2250); break;
                    case 3: ItemID=(0x2251); break;
                }
        }
		public ChocolateDragonSkull( Serial serial ) : base( serial )
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
	public class GummyWolf : Candy
	{
		[Constructable]
		public GummyWolf() : this( 1 )
		{
		}

		[Constructable]
		public GummyWolf( int amount ) : base( amount, 0x2122 )
		{
			Name = "Gummy Wolf";
			GummyWolfColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
			GummyWRandomizer();
		}
		public virtual void GummyWRandomizer()
        {
                switch (Utility.Random(6))
                {
                    case 0: ItemID=(0x2122); break;
                    case 1: ItemID=(0x25CF); break;
                    case 2: ItemID=(0x25D3); break;
                    case 3: ItemID=(0x25D2); break;
                    case 4: ItemID=(0x25D1); break;
                    case 5: ItemID=(0x25D0); break;
                }
        }
		public virtual void GummyWolfColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyWolf( Serial serial ) : base( serial )
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
	public class ChocolateWolf : Candy
	{
		[Constructable]
		public ChocolateWolf() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateWolf( int amount ) : base( amount, 0x2122 )
		{
			ChocolateWolfName();
			this.FillFactor = 6;
			ChocolateWRandomizer();
		}
		public virtual void ChocolateWRandomizer()
        {
                switch (Utility.Random(6))
                {
                    case 0: ItemID=(0x2122); break;
                    case 1: ItemID=(0x25CF); break;
                    case 2: ItemID=(0x25D3); break;
                    case 3: ItemID=(0x25D2); break;
                    case 4: ItemID=(0x25D1); break;
                    case 5: ItemID=(0x25D0); break;
                }
        }
		public virtual void ChocolateWolfName()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Wolf"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Wolf"); break;
                    case 2: Hue=(556); Name=("White Chocolate Wolf"); break;
                }
        }
		public ChocolateWolf( Serial serial ) : base( serial )
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
	public class GummyWerewolf : Candy
	{
		[Constructable]
		public GummyWerewolf() : this( 1 )
		{
		}

		[Constructable]
		public GummyWerewolf( int amount ) : base( amount, 0x2770 )
		{
			Name = "Gummy Werewolf";
			GummyWerewolfColor();
			Weight = 1.0;
			this.FillFactor = 2;
			Stackable = false;
		}
		public virtual void GummyWerewolfColor()
        {
                switch (Utility.Random(5))
                {
                    case 0: Hue=Utility.RandomBlueHue(); break;
                    case 1: Hue=Utility.RandomGreenHue(); break;
                    case 2: Hue=Utility.RandomRedHue(); break;
                    case 3: Hue=Utility.RandomYellowHue(); break;
                    case 4: Hue=Utility.RandomPinkHue(); break;
                }
        }
		public GummyWerewolf( Serial serial ) : base( serial )
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
	public class ChocolateWerewolf : Candy
	{
		[Constructable]
		public ChocolateWerewolf() : this( 1 )
		{
		}
		[Constructable]
		public ChocolateWerewolf( int amount ) : base( amount, 0x2770 )
		{
			ChocolateWerewolfName();
			this.FillFactor = 6;
		}
		public virtual void ChocolateWerewolfName()
        {
                switch (Utility.Random(3))
                {
                    case 0: Hue=(643); Name=("Milk Chocolate Werewolf"); break;
                    case 1: Hue=(1015); Name=("Dark Chocolate Werewolf"); break;
                    case 2: Hue=(556); Name=("White Chocolate Werewolf"); break;
                }
        }
		public ChocolateWerewolf( Serial serial ) : base( serial )
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
}