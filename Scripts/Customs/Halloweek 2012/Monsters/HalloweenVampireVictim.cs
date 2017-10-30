using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a human corpse" )]
	public class HalloweenVampireVictim : BaseCreature
	{	
		[Constructable]
		public HalloweenVampireVictim() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Name = "a vampiric victim";
			Hue = Utility.RandomSkinHue();

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
			}
			else
			{
				Body = 0x190;
			}
			InitOutfit();
			SetStr( 20, 40 );
			SetDex( 15, 30 );
			SetInt( 10, 30 );
			SetHits( 20, 40 );
			SetDamage( 1, 3 );
			
			SetResistance( ResistanceType.Physical, 15, 30 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Poison, 15, 25 );
			SetResistance( ResistanceType.Energy, 10, 20 );
			
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Tactics, 34.0, 52.5 );
			SetSkill( SkillName.Wrestling, 30.0, 40.5 );

			Fame = 500;
			Karma = -500;
		}
		public virtual void InitOutfit()
		{
			switch ( Utility.Random( 3 ) )
			{
				case 0: AddItem( new FancyShirt( Hue=(0) ) ); break;
				case 1: AddItem( new Doublet( Hue=(0) ) ); break;
				case 2: AddItem( new Shirt( Hue=(0) ) ); break;
			}

			switch ( Utility.Random( 4 ) )
			{
				case 0: AddItem( new Shoes( Hue=(0) ) ); break;
				case 1: AddItem( new Boots( Hue=(0) ) ); break;
				case 2: AddItem( new Sandals( Hue=(0) ) ); break;
				case 3: AddItem( new ThighBoots( Hue=(0) ) ); break;
			}

			int hairHue = GetHairHue();

			Utility.AssignRandomHair( this, hairHue );
			Utility.AssignRandomFacialHair( this, hairHue );

			if ( Female )
			{
				switch ( Utility.Random( 6 ) )
				{
					case 0: AddItem( new ShortPants( Hue=(0) ) ); break;
					case 1:
					case 2: AddItem( new Kilt( Hue=(0) ) ); break;
					case 3:
					case 4:
					case 5: AddItem( new Skirt( Hue=(0) ) ); break;
				}
			}
			else
			{
				switch ( Utility.Random( 2 ) )
				{
					case 0: AddItem( new LongPants( Hue=(0) ) ); break;
					case 1: AddItem( new ShortPants( Hue=(0) ) ); break;
				}
			}
		}
		public virtual int GetHairHue()
		{
			return Utility.RandomHairHue();
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public HalloweenVampireVictim( Serial serial ) : base( serial )
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