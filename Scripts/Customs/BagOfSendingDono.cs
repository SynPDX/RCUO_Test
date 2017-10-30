using System;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    public enum BagOfSendingDonoHue
    {
        Yellow,
        Black,
        Orange,
		Red,
		Blue,
		Pink,
		Brown,
		Purple,
		Green
    }

    public class BagOfSendingDono : Item, TranslocationItem
    {
        private int m_Charges;
        private int m_Recharges;
        private BagOfSendingDonoHue m_BagOfSendingDonoHue;
        [Constructable]
        public BagOfSendingDono()
            : this(RandomHue())
        {
        }

        [Constructable]
        public BagOfSendingDono(BagOfSendingDonoHue hue)
            : base(0xE76)
        {
            this.Weight = 2.0;
			Name = "Bag of Sending (Donation)";
			LootType = LootType.Blessed;
            this.BagOfSendingDonoHue = hue;

            this.m_Charges = Utility.RandomMinMax(250, 250);
        }

        public BagOfSendingDono(Serial serial)
            : base(serial)
        {
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Charges
        {
            get
            {
                return this.m_Charges;
            }
            set
            {
                if (value > this.MaxCharges)
                    this.m_Charges = this.MaxCharges;
                else if (value < 0)
                    this.m_Charges = 0;
                else
                    this.m_Charges = value;

                this.InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int Recharges
        {
            get
            {
                return this.m_Recharges;
            }
            set
            {
                if (value > this.MaxRecharges)
                    this.m_Recharges = this.MaxRecharges;
                else if (value < 0)
                    this.m_Recharges = 0;
                else
                    this.m_Recharges = value;

                this.InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int MaxCharges
        {
            get
            {
                return 250;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int MaxRecharges
        {
            get
            {
                return 5000;
            }
        }
        public string TranslocationItemName
        {
            get
            {
                return "bag of sending";
            }
        }
        //public override string LabelName
        //{
        //    get
        //    {
		//		return "A Bag of Sending (donation)";
                //return 1054104;
          //  }
        //}// a bag of sending
        [CommandProperty(AccessLevel.GameMaster)]
        public BagOfSendingDonoHue BagOfSendingDonoHue
        {
            get
            {
                return this.m_BagOfSendingDonoHue;
            }
            set
            {
                this.m_BagOfSendingDonoHue = value;

                switch ( value )
                {
                    case BagOfSendingDonoHue.Yellow:
                        this.Hue = 0x783;
                        break;
                    case BagOfSendingDonoHue.Black:
                        this.Hue = 0x776;
                        break;
                    case BagOfSendingDonoHue.Orange:
                        this.Hue = 0x782;
                        break;
                    case BagOfSendingDonoHue.Red:
                        this.Hue = 0x78b;
                        break;
                    case BagOfSendingDonoHue.Blue:
                        this.Hue = 0x77c;
                        break;
                    case BagOfSendingDonoHue.Pink:
                        this.Hue = 0x78a;
                        break;
                    case BagOfSendingDonoHue.Brown:
                        this.Hue = 0x798;
                        break;
                    case BagOfSendingDonoHue.Purple:
                        this.Hue = 0x789;
                        break;
                    case BagOfSendingDonoHue.Green:
                        this.Hue = 0x785;
                        break;
                }
            }
        }
        public static BagOfSendingDonoHue RandomHue()
        {
            switch ( Utility.Random(9) )
            {
                case 0:
                    return BagOfSendingDonoHue.Yellow;
				case 1:
                    return BagOfSendingDonoHue.Black;
				case 2:
                    return BagOfSendingDonoHue.Orange;
				case 3:
                    return BagOfSendingDonoHue.Red;
				case 4:
                    return BagOfSendingDonoHue.Blue;
				case 5:
                    return BagOfSendingDonoHue.Pink;
				case 6:
                    return BagOfSendingDonoHue.Brown;
				case 7:
                    return BagOfSendingDonoHue.Purple;
				default:
                    return BagOfSendingDonoHue.Green;
            }
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1060741, this.m_Charges.ToString()); // charges: ~1_val~
        }

        public override void OnSingleClick(Mobile from)
        {
            base.OnSingleClick(from);

            this.LabelTo(from, 1060741, this.m_Charges.ToString()); // charges: ~1_val~
        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            if (from.Alive)
                list.Add(new UseBagEntry(this, this.Charges > 0 && this.IsChildOf(from.Backpack)));
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (from.Region.IsPartOf<Regions.Jail>())
            {
                from.SendMessage("You may not do that in jail.");
            }
            else if (!this.IsChildOf(from.Backpack))
            {
                MessageHelper.SendLocalizedMessageTo(this, from, 1062334, 0x59); // The bag of sending must be in your backpack.
            }
            else if (this.Charges == 0)
            {
                MessageHelper.SendLocalizedMessageTo(this, from, 1042544, 0x59); // This item is out of charges.
            }
            else
            {
                from.Target = new SendTarget(this);
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt((int)1); // version

            writer.WriteEncodedInt((int)this.m_Recharges);

            writer.WriteEncodedInt((int)this.m_Charges);
            writer.WriteEncodedInt((int)this.m_BagOfSendingDonoHue);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            switch ( version )
            {
                case 1:
                    {
                        this.m_Recharges = reader.ReadEncodedInt();
                        goto case 0;
                    }
                case 0:
                    {
                        this.m_Charges = Math.Min(reader.ReadEncodedInt(), this.MaxCharges);
                        this.m_BagOfSendingDonoHue = (BagOfSendingDonoHue)reader.ReadEncodedInt();
                        break;
                    }
            }
        }

        private class UseBagEntry : ContextMenuEntry
        {
            private readonly BagOfSendingDono m_Bag;
            public UseBagEntry(BagOfSendingDono bag, bool enabled)
                : base(6189)
            {
                this.m_Bag = bag;

                if (!enabled)
                    this.Flags |= CMEFlags.Disabled;
            }

            public override void OnClick()
            {
                if (this.m_Bag.Deleted)
                    return;

                Mobile from = this.Owner.From;

                if (from.CheckAlive())
                    this.m_Bag.OnDoubleClick(from);
            }
        }

        private class SendTarget : Target
        {
            private readonly BagOfSendingDono m_Bag;
            public SendTarget(BagOfSendingDono bag)
                : base(-1, false, TargetFlags.None)
            {
                this.m_Bag = bag;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (this.m_Bag.Deleted)
                    return;

                if (from.Region.IsPartOf<Regions.Jail>())
                {
                    from.SendMessage("You may not do that in jail.");
                }
                else if (!this.m_Bag.IsChildOf(from.Backpack))
                {
                    MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1062334, 0x59); // The bag of sending must be in your backpack. 1054107 is gone from client, using generic response
                }
                else if (this.m_Bag.Charges == 0)
                {
                    MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1042544, 0x59); // This item is out of charges.
                }
                else if (targeted is Item)
                {
                    Item item = (Item)targeted;
                    int reqCharges = (int)Math.Max(1, Math.Ceiling(item.TotalWeight / 10.0));

                    if (!item.IsChildOf(from.Backpack))
                    {
                        MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1054152, 0x59); // You may only send items from your backpack to your bank box.
                    }
                    else if (item is BagOfSendingDono || item is Container)
                    {
                        from.Send(new AsciiMessage(this.m_Bag.Serial, this.m_Bag.ItemID, MessageType.Regular, 0x3B2, 3, "", "You cannot send a container through the bag of sending."));
                    }
                    else if (item.LootType == LootType.Cursed)
                    {
                        MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1054108, 0x59); // The bag of sending rejects the cursed item.
                    }
                    else if (!item.VerifyMove(from) || item is Server.Engines.Quests.QuestItem)
                    {
                        MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1054109, 0x59); // The bag of sending rejects that item.
                    }
                    else if (Spells.SpellHelper.IsDoomGauntlet(from.Map, from.Location))
                    {
                        from.SendLocalizedMessage(1062089); // You cannot use that here.
                    }
                    else if (!from.BankBox.TryDropItem(from, item, false))
                    {
                        MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1054110, 0x59); // Your bank box is full.
                    }
                    else if (Core.ML && reqCharges > this.m_Bag.Charges)
                    {
                        from.SendLocalizedMessage(1079932); //You don't have enough charges to send that much weight
                    }
                    else
                    {
                        this.m_Bag.Charges -= (Core.ML ? reqCharges : 1);
                        MessageHelper.SendLocalizedMessageTo(this.m_Bag, from, 1054150, 0x59); // The item was placed in your bank box.
                    }
                }
            }
        }
    }
}