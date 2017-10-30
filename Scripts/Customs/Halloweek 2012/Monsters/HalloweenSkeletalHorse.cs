using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "an undead horse corpse" )]
	public class HalloweenSkeletalHorse : BaseMount
	{
		[Constructable] 
		public HalloweenSkeletalHorse() : this( "a spooky skeletal steed" )
		{
		}

		[Constructable]
		public HalloweenSkeletalHorse( string name ) : base( name, 793, 0x3EBB, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			SetStr( 91, 100 );
			SetDex( 46, 55 );
			SetInt( 46, 60 );

			SetHits( 41, 50 );

			SetDamage( 5, 12 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 50, 60 );
			SetResistance( ResistanceType.Cold, 90, 95 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 10, 15 );
			TokenDropSH(1);
			SetSkill( SkillName.MagicResist, 95.1, 100.0 );
			SetSkill( SkillName.Tactics, 50.0 );
			SetSkill( SkillName.Wrestling, 70.1, 80.0 );
			HalloweenSkeletalHorseHue();
			Fame = 1000;
			Karma = -1000;
			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = 87.1;
			switch ( Utility.Random( 12 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBag() ); break;
				case 4: PackItem( new TrickOrTreatBag() ); break;
				case 5: PackItem( new TrickOrTreatBag() ); break;
				case 6: PackItem( new TrickOrTreatBag() ); break;
				case 7: PackItem( new TrickOrTreatBag() ); break;
				case 8: PackItem( new TrickOrTreatBag() ); break;
				case 9: PackItem( new TrickOrTreatBagMedium() ); break;
				case 10: PackItem( new TrickOrTreatBagMedium() ); break;
				case 11: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}

		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public virtual void HalloweenSkeletalHorseHue()
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
		public virtual void TokenDropSH(int amount)
        {
            if (0.10 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(3)); break;
					case 1: PackItem(new HalloweenToken(3)); break;
					case 2: PackItem(new HalloweenToken(3)); break;
					case 3: PackItem(new HalloweenToken(3)); break;
					case 4: PackItem(new HalloweenToken(3)); break;
					case 5: PackItem(new HalloweenToken(3)); break;
					case 6: PackItem(new HalloweenToken(5)); break;
					case 7: PackItem(new HalloweenToken(7)); break;
					case 8: PackItem(new HalloweenToken(9)); break;
					case 9: PackItem(new HalloweenToken(11)); break;
				}
		}
		public HalloweenSkeletalHorse( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch( version )
			{
				case 0:
				{
					Name = "a skeletal steed";
					Tamable = false;
					MinTameSkill = 0.0;
					ControlSlots = 0;
					break;
				}
			}
		}
	}
}