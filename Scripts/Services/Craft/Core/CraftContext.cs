using System;
using System.IO;
using System.Collections.Generic;
using Server.Engines.Plants;

namespace Server.Engines.Craft
{
    public enum CraftMarkOption
    {
        MarkItem,
        DoNotMark,
        PromptForMark
    }

    #region SA
    public enum CraftQuestOption
    {
        QuestItem,
        NonQuestItem
    }
    #endregion
	
    public class CraftContext
    {
        public Mobile Owner { get; private set; }
        public CraftSystem System { get; private set; }

        private readonly List<CraftItem> m_Items;
        private int m_LastResourceIndex;
        private int m_LastResourceIndex2;
        private int m_LastGroupIndex;
        private bool m_DoNotColor;
        private CraftMarkOption m_MarkOption;
        private CraftQuestOption m_QuestOption;
        private int m_MakeTotal;
        private PlantHue m_RequiredPlantHue;

        #region Hue State Vars
        private bool m_CheckedHues;
        private List<int> m_Hues;
        private Item m_CompareHueTo;

        public bool CheckedHues
        {
            get
            {
                return this.m_CheckedHues;
            }
            set
            {
                this.m_CheckedHues = value;
            }
        }
        public List<int> Hues
        {
            get
            {
                return this.m_Hues;
            }
            set
            {
                this.m_Hues = value;
            }
        }
        public Item CompareHueTo
        {
            get
            {
                return this.m_CompareHueTo;
            }
            set
            {
                this.m_CompareHueTo = value;
            }
        }
        #endregion

        public List<CraftItem> Items
        {
            get
            {
                return this.m_Items;
            }
        }
        public int LastResourceIndex
        {
            get
            {
                return this.m_LastResourceIndex;
            }
            set
            {
                this.m_LastResourceIndex = value;
            }
        }
        public int LastResourceIndex2
        {
            get
            {
                return this.m_LastResourceIndex2;
            }
            set
            {
                this.m_LastResourceIndex2 = value;
            }
        }
        public int LastGroupIndex
        {
            get
            {
                return this.m_LastGroupIndex;
            }
            set
            {
                this.m_LastGroupIndex = value;
            }
        }
        public bool DoNotColor
        {
            get
            {
                return this.m_DoNotColor;
            }
            set
            {
                this.m_DoNotColor = value;
            }
        }
        public CraftMarkOption MarkOption
        {
            get
            {
                return this.m_MarkOption;
            }
            set
            {
                this.m_MarkOption = value;
            }
        }
        #region SA
        public CraftQuestOption QuestOption
        {
            get
            {
                return this.m_QuestOption;
            }
            set
            {
                this.m_QuestOption = value;
            }
        }

        public int MakeTotal 
        { 
            get
            {
                return m_MakeTotal;
            } 
            set 
            {
                m_MakeTotal = value;
            } 
        }

        public PlantHue RequiredPlantHue
        { 
            get { return m_RequiredPlantHue; } 
            set { m_RequiredPlantHue = value; } 
        }

        public PlantPigmentHue RequiredPigmentHue { get; set; }
        #endregion

        public CraftContext(Mobile owner, CraftSystem system)
        {
            Owner = owner;
            System = system;

            this.m_Items = new List<CraftItem>();
            this.m_LastResourceIndex = -1;
            this.m_LastResourceIndex2 = -1;
            this.m_LastGroupIndex = -1;

            this.m_CheckedHues = false;
            this.m_Hues = new List<int>();
            this.m_CompareHueTo = null;
            this.m_QuestOption = CraftQuestOption.NonQuestItem;
            m_RequiredPlantHue = PlantHue.None;
            RequiredPigmentHue = PlantPigmentHue.None;

            Contexts.Add(this);
        }

        public CraftItem LastMade
        {
            get
            {
                if (this.m_Items.Count > 0)
                    return this.m_Items[0];

                return null;
            }
        }

        public void OnMade(CraftItem item)
        {
            this.m_Items.Remove(item);

            if (this.m_Items.Count == 10)
                this.m_Items.RemoveAt(9);

            this.m_Items.Insert(0, item);
        }
		
        public void ResetHueStateVars()
        {
            this.m_CheckedHues = false;
            this.m_Hues = new List<int>();
            this.m_CompareHueTo = null;
        }

        public virtual void Serialize(GenericWriter writer)
        {
            writer.Write((int)0);

            writer.Write(Owner);
            writer.Write(GetSystemIndex(System));
            writer.Write(m_LastResourceIndex);
            writer.Write(m_LastResourceIndex2);
            writer.Write(m_LastGroupIndex);
            writer.Write(m_DoNotColor);
            writer.Write((int)m_MarkOption);
            writer.Write((int)m_QuestOption);

            writer.Write(m_MakeTotal);
        }

        public CraftContext(GenericReader reader)
        {
            int version = reader.ReadInt();

            m_Items = new List<CraftItem>();

            Owner = reader.ReadMobile();
            int sysIndex = reader.ReadInt();
            m_LastResourceIndex = reader.ReadInt();
            m_LastResourceIndex2 = reader.ReadInt();
            m_LastGroupIndex = reader.ReadInt();
            m_DoNotColor = reader.ReadBool();
            m_MarkOption = (CraftMarkOption)reader.ReadInt();
            m_QuestOption = (CraftQuestOption)reader.ReadInt();

            m_MakeTotal = reader.ReadInt();

            System = GetCraftSystem(sysIndex);

            if (System != null && Owner != null)
            {
                System.AddContext(Owner, this);
                Contexts.Add(this);
            }
        }

        public int GetSystemIndex(CraftSystem system)
        {
            for (int i = 0; i < _Systems.Length; i++)
            {
                if (_Systems[i] == system)
                    return i;
            }

            return -1;
        }

        public CraftSystem GetCraftSystem(int i)
        {
            if (i >= 0 && i < _Systems.Length)
                return _Systems[i];

            return null;
        }

        #region Serialize/Deserialize Persistence
        private static string FilePath = Path.Combine("Saves", "CraftContext", "Contexts.bin");

        private static List<CraftContext> Contexts = new List<CraftContext>();

        public static CraftSystem[] Systems { get { return _Systems; } }
        private static CraftSystem[] _Systems = new CraftSystem[11];

        public static void Configure()
        {
            _Systems[0] = DefAlchemy.CraftSystem;
            _Systems[1] = DefBlacksmithy.CraftSystem;
            _Systems[2] = DefBowFletching.CraftSystem;
            _Systems[3] = DefCarpentry.CraftSystem;
            _Systems[4] = DefCartography.CraftSystem;
            _Systems[5] = DefCooking.CraftSystem;
            _Systems[6] = DefGlassblowing.CraftSystem;
            _Systems[7] = DefInscription.CraftSystem;
            _Systems[8] = DefMasonry.CraftSystem;
            _Systems[9] = DefTailoring.CraftSystem;
            _Systems[10] = DefTinkering.CraftSystem;

            EventSink.WorldSave += OnSave;
            EventSink.WorldLoad += OnLoad;
        }

        public static void OnSave(WorldSaveEventArgs e)
        {
            Persistence.Serialize(
                FilePath,
                writer =>
                {
                    writer.Write(0); // version

                    writer.Write(Contexts.Count);
                    Contexts.ForEach(c => c.Serialize(writer));
                });
        }

        public static void OnLoad()
        {
            Persistence.Deserialize(
                FilePath,
                reader =>
                {
                    int version = reader.ReadInt();

                    int count = reader.ReadInt();
                    for (int i = 0; i < count; i++)
                    {
                        new CraftContext(reader);
                    }
                });
        }
        #endregion
    }
}
