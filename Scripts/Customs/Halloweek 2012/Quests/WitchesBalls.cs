using System;
using System.Collections;
using Server.Engines.Plants;
using Server.Engines.Quests;
using Server.Engines.Quests.Hag;
using Server.Engines.Quests.Matriarch;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    public class ECrystalTarget : Target
    {
        private EmptyCrystalBall m_Deed;

        public ECrystalTarget(EmptyCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is HalloweenSkeleton)
            {
                HalloweenSkeleton t = (HalloweenSkeleton)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Skeleton." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new SkeleCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Skeleton." );
            }
        }
    }
    public class SkeleCrystalTarget : Target
    {
        private SkeleCrystalBall m_Deed;

        public SkeleCrystalTarget(SkeleCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is HalloweenZombie)
            {
                HalloweenZombie t = (HalloweenZombie)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Zombie." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new ZombCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Zombie." );
            }
        }
    }
    public class ZombCrystalTarget : Target
    {
        private ZombCrystalBall m_Deed;

        public ZombCrystalTarget(ZombCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is GhostPhysical)
            {
                GhostPhysical t = (GhostPhysical)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Physical Ghost." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new PGhostCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Physical Ghost." );
            }
        }
    }
    public class PGhostCrystalTarget : Target
    {
        private PGhostCrystalBall m_Deed;

        public PGhostCrystalTarget(PGhostCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is GhostMagical)
            {
                GhostMagical t = (GhostMagical)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Magical Ghost." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new MGhostCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Magical Ghost." );
            }
        }
    }
    public class MGhostCrystalTarget : Target
    {
        private MGhostCrystalBall m_Deed;

        public MGhostCrystalTarget(MGhostCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is HalloweenScarecrow)
            {
                HalloweenScarecrow t = (HalloweenScarecrow)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Scarecrow." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new ScarecrowCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Scarecrow." );
            }
        }
    }
    public class ScarecrowCrystalTarget : Target
    {
        private ScarecrowCrystalBall m_Deed;

        public ScarecrowCrystalTarget(ScarecrowCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is HalloweenWitch)
            {
                HalloweenWitch t = (HalloweenWitch)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Witch." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new WitchCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Witch." );
            }
        }
    }
    public class WitchCrystalTarget : Target
    {
        private WitchCrystalBall m_Deed;

        public WitchCrystalTarget(WitchCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is TheVampire)
            {
                TheVampire t = (TheVampire)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Vampire." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new VampireCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Vampire." );
            }
        }
    }
    public class VampireCrystalTarget : Target
    {
        private VampireCrystalBall m_Deed;

        public VampireCrystalTarget(VampireCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is FeralHuman)
            {
                FeralHuman t = (FeralHuman)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Werewolf." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new WerewolfCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Werewolf or Feral Human." );
            }
        }
    }
    public class WerewolfCrystalTarget : Target
    {
        private WerewolfCrystalBall m_Deed;

        public WerewolfCrystalTarget(WerewolfCrystalBall deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is TheReaper)
            {
                TheReaper t = (TheReaper)target;
				from.SendMessage( "The crystal ball bursts to life, glowing with the soul energy of a Reaper." );
				from.PlaySound( 0x215 ); //CHANGE SOUND
				m_Deed.Delete();
				from.AddToBackpack( new ReaperCrystalBall() );
            }
            else
            {
				from.SendMessage( "This is not a Reaper." );
            }
        }
    }
	public class EmptyCrystalBall : Item
	{
		[Constructable]
		public EmptyCrystalBall() : base( 0x0E2E )
		{
		Name = "A Crystal Ball";
		Weight = 3;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new ECrystalTarget(this); // Call our target 
            }
        }
		public EmptyCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class SkeleCrystalBall : Item
	{
		[Constructable]
		public SkeleCrystalBall() : base( 0x0E2E )
		{
		Name = "A Skeletal Crystal Ball";
		Weight = 3;
		Hue = 926;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new SkeleCrystalTarget(this); // Call our target 
            }
        }
		public SkeleCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class ZombCrystalBall : Item
	{
		[Constructable]
		public ZombCrystalBall() : base( 0x0E2E )
		{
		Name = "A Zombie Crystal Ball";
		Weight = 3;
		Hue = 1836;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new ZombCrystalTarget(this); // Call our target 
            }
        }
		public ZombCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class PGhostCrystalBall : Item
	{
		[Constructable]
		public PGhostCrystalBall() : base( 0x0E2E )
		{
		Name = "A Physical Ghost Crystal Ball";
		Weight = 3;
		Hue = 1150;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new PGhostCrystalTarget(this); // Call our target 
            }
        }
		public PGhostCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class MGhostCrystalBall : Item
	{
		[Constructable]
		public MGhostCrystalBall() : base( 0x0E2E )
		{
		Name = "A Magical Ghost Crystal Ball";
		Weight = 3;
		Hue = 1153;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new MGhostCrystalTarget(this); // Call our target 
            }
        }
		public MGhostCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class ScarecrowCrystalBall : Item
	{
		[Constructable]
		public ScarecrowCrystalBall() : base( 0x0E2E )
		{
		Name = "A Scarecrow Crystal Ball";
		Weight = 3;
		Hue = 548;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new ScarecrowCrystalTarget(this); // Call our target 
            }
        }
		public ScarecrowCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class WitchCrystalBall : Item
	{
		[Constructable]
		public WitchCrystalBall() : base( 0x0E2E )
		{
		Name = "A Witch Crystal Ball";
		Weight = 3;
		Hue = 897;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new WitchCrystalTarget(this); // Call our target 
            }
        }
		public WitchCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class VampireCrystalBall : Item
	{
		[Constructable]
		public VampireCrystalBall() : base( 0x0E2E )
		{
		Name = "A Vampire Crystal Ball";
		Weight = 3;
		Hue = 1194;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new VampireCrystalTarget(this); // Call our target 
            }
        }
		public VampireCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class WerewolfCrystalBall : Item
	{
		[Constructable]
		public WerewolfCrystalBall() : base( 0x0E2E )
		{
		Name = "A Werewolf Crystal Ball";
		Weight = 3;
		Hue = 1190;
		}
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target 
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("The crystal ball glistens.");
                from.Target = new WerewolfCrystalTarget(this); // Call our target 
            }
        }
		public WerewolfCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
	public class ReaperCrystalBall : Item
	{
		[Constructable]
		public ReaperCrystalBall() : base( 0x0E2E )
		{
		Name = "A Reaper Crystal Ball";
		Weight = 3;
		Hue = 1175;
		}
		public ReaperCrystalBall( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}