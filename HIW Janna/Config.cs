﻿using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using System.Collections.Generic;

namespace HIW_Janna
{
    public static class Config
    {
        private const string MenuName = "Janna";

        private static readonly Menu Menu;

        static Config()
        {
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to PartyJanna settings menu!");

            Settings.Initialize();
        }

        public static void Initialize() { }

        public static class Settings
        {
            private static readonly Menu Menu0, Menu1, Menu2, Menu3, Menu4, Menu5, Menu6, Menu7, Menu8, Menu9;

            static Settings()
            {
                Menu0 = Config.Menu.AddSubMenu("Drawings");
                Draw.Initialize();

                Menu1 = Config.Menu.AddSubMenu("Anti Gapcloser");
                AntiGapcloser.Initialize();

                Menu2 = Config.Menu.AddSubMenu("Interrupt");
                Interrupter.Initialize();

                Menu3 = Config.Menu.AddSubMenu("Item Usage");
                Items.Initialize();

                Menu4 = Config.Menu.AddSubMenu("Auto Shield");
                AutoShield.Initialize();

                Menu5 = Config.Menu.AddSubMenu("Combo");
                Combo.Initialize();

                Menu6 = Config.Menu.AddSubMenu("Flee");
                Flee.Initialize();

                Menu7 = Config.Menu.AddSubMenu("Harass");
                Harass.Initialize();

                Menu8 = Config.Menu.AddSubMenu("Humanizer");
                Humanizer.Initialize();
            }

            public static void Initialize()
            {
            }

            public static class Draw
            {
                private static readonly CheckBox _drawQ;
                private static readonly CheckBox _drawW;
                private static readonly CheckBox _drawE;
                private static readonly CheckBox _drawR;

                public static bool DrawQ
                {
                    get { return _drawQ.CurrentValue; }
                }
                public static bool DrawW
                {
                    get { return _drawW.CurrentValue; }
                }
                public static bool DrawE
                {
                    get { return _drawE.CurrentValue; }
                }
                public static bool DrawR
                {
                    get { return _drawR.CurrentValue; }
                }

                static Draw()
                {
                    Menu0.AddGroupLabel("Drawings");

                    _drawQ = Menu0.Add("drawQ", new CheckBox("Draw Q Range"));
                    _drawW = Menu0.Add("drawW", new CheckBox("Draw W Range"));
                    _drawE = Menu0.Add("drawE", new CheckBox("Draw E Range"));
                    _drawR = Menu0.Add("drawR", new CheckBox("Draw R Range"));
                }

                public static void Initialize() { }
            }

            public static class Items
            {
                private static readonly CheckBox _useItems;
                private static readonly Slider _allyHpPercentageDamage, _allyHpPercentageCc;

                public static bool UseItems
                {
                    get { return _useItems.CurrentValue; }
                }
                public static int AllyHpPercentageDamage
                {
                    get { return _allyHpPercentageDamage.CurrentValue; }
                }
                public static int AllyHpPercentageCC
                {
                    get { return _allyHpPercentageCc.CurrentValue; }
                }

                static Items()
                {
                    Menu3.AddGroupLabel("Items");

                    _useItems = Menu3.Add("useItems", new CheckBox("Use Items"));

                    Menu3.AddSeparator(13);

                    _allyHpPercentageDamage = Menu3.Add("allyHpPercentage", new Slider("Min. Ally Health on Damage (%):", 50, 1));

                    Menu3.AddSeparator(13);

                    _allyHpPercentageCc = Menu3.Add("allyHpPercentageCc", new Slider("Min. Ally Health on CC (%):", 100, 1));
                }

                public static void Initialize() { }
            }

            public static class AntiGapcloser
            {
                private static readonly CheckBox _antiGapcloser;

                public static bool AntiGap
                {
                    get { return _antiGapcloser.CurrentValue; }
                }

                static AntiGapcloser()
                {
                    Menu1.AddGroupLabel("Anti Gapcloser");

                    _antiGapcloser = Menu1.Add("antiGapcloser", new CheckBox("Anti Gapcloser"));
                }

                public static void Initialize() { }
            }

            public static class Interrupter
            {
                private static readonly CheckBox _qInterrupt;
                private static readonly CheckBox _qInterruptDangerous;
                private static readonly CheckBox _rInterruptDangerous;

                public static bool QInterrupt
                {
                    get { return _qInterrupt.CurrentValue; }
                }
                public static bool QInterruptDangerous
                {
                    get { return _qInterruptDangerous.CurrentValue; }
                }
                public static bool RInterruptDangerous
                {
                    get { return _rInterruptDangerous.CurrentValue; }
                }

                static Interrupter()
                {
                    Menu2.AddGroupLabel("Interrupt");

                    _qInterrupt = Menu2.Add("qInterrupt", new CheckBox("Interrupt low/med-danger spells with Q"));
                    Menu2.AddSeparator(13);

                    _qInterruptDangerous = Menu2.Add("rInterrupt", new CheckBox("Interrupt high-danger spells with Q"));
                    Menu2.AddSeparator(13);

                    _rInterruptDangerous = Menu2.Add("rInterruptDangerous", new CheckBox("Interrupt high-danger spells with R"));
                }

                public static void Initialize() { }
            }

            public static class AutoShield
            {
                private static readonly CheckBox _boostAD;
                private static readonly CheckBox _selfShield;
                private static readonly CheckBox _turretShieldMinion, _turretShieldChampion;
                private static readonly CheckBox _autoUltimate;
                private static readonly ComboBox _priorMode;
                private static readonly List<Slider> _sliders, _ultSliders;
                private static readonly List<AIHeroClient> _heros;
                private static readonly List<CheckBox> _shieldAllyList, _shieldSpellList, _ultAllyList;


                public static bool BoostAD
                {
                    get { return _boostAD.CurrentValue; }
                }
                public static bool SelfShield
                {
                    get { return _selfShield.CurrentValue; }
                }
                public static bool TurretShieldMinion
                {
                    get { return _turretShieldMinion.CurrentValue; }
                }
                public static bool TurretShieldChampion
                {
                    get { return _turretShieldChampion.CurrentValue; }
                }
                public static int PriorMode
                {
                    get { return _priorMode.SelectedIndex; }
                }
                public static List<Slider> Sliders
                {
                    get { return _sliders; }
                }
                public static List<Slider> UltSliders
                {
                    get { return _ultSliders; }
                }
                public static List<AIHeroClient> Heros
                {
                    get { return _heros; }
                }
                public static List<CheckBox> ShieldAllyList
                {
                    get { return _shieldAllyList; }
                }
                public static List<CheckBox> ShieldSpellList
                {
                    get { return _shieldSpellList; }
                }
                public static List<CheckBox> UltAllyList
                {
                    get { return _ultAllyList; }
                }
                public static bool AutoUltimate
                {
                    get { return _autoUltimate.CurrentValue; }
                }

                static AutoShield()
                {
                    _shieldAllyList = new List<CheckBox>();
                    _shieldSpellList = new List<CheckBox>();
                    _ultAllyList = new List<CheckBox>();

                    Menu4.AddGroupLabel("Auto Shield");

                    _boostAD = Menu4.Add("autoShieldBoostAd", new CheckBox("Boost ADCarry Basic Attacks with Shield"));
                    Menu4.AddSeparator(13);

                    _selfShield = Menu4.Add("selfShield", new CheckBox("Shield Yourself from Basic Attacks"));
                    Menu4.AddSeparator(13);

                    _turretShieldMinion = Menu4.Add("turretShieldMinion", new CheckBox("Shield Turrets from Enemy Minions", false));
                    Menu4.AddSeparator(13);

                    _turretShieldChampion = Menu4.Add("turretShieldChampion", new CheckBox("Shield Turrets from Enemy Champions"));
                    Menu4.AddSeparator(13);

                    _priorMode = Menu4.Add("autoShieldPriorMode", new ComboBox("AutoShield Priority Mode:", 0, new string[] { "Lowest Health", "Priority Level" }));
                    Menu4.AddSeparator(13);

                    Menu4.AddGroupLabel("Janna E");

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _shieldAllyList.Add(Menu4.Add<CheckBox>("shield" + ally.ChampionName, new CheckBox(string.Format("Shield {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu4.AddSeparator(13);

                    _sliders = new List<Slider>();
                    _heros = new List<AIHeroClient>();

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _sliders.Add(Menu4.Add<Slider>("prior" + ally.ChampionName, new Slider(string.Format("{0}'s Priority:", ally.ChampionName), 1, 1, EntityManager.Heroes.Allies.Count)));

                        Menu4.AddSeparator(13);

                        _heros.Add(ally);
                    }

                    foreach (var enemy in EntityManager.Heroes.Enemies)
                    {
                        for (int i = 0; i <= 185; i++)
                        {
                            if (MissileDatabase.missileDatabase[i, 2] == enemy.ChampionName)
                                _shieldSpellList.Add(Menu4.Add<CheckBox>(MissileDatabase.missileDatabase[i, 0] + i, new CheckBox(string.Format("Shield from {0}'s {1} ({2})                                                 {3}", MissileDatabase.missileDatabase[i, 2], MissileDatabase.missileDatabase[i, 1], MissileDatabase.missileDatabase[i, 0], i))));
                        }
                    }

                    Menu4.AddGroupLabel("Janna R");

                    _autoUltimate = Menu4.Add("autoUltimate", new CheckBox("Auto-Ult Enabled", false));

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _ultAllyList.Add(Menu4.Add<CheckBox>("autoUlt" + ally.ChampionName, new CheckBox(string.Format("Ultimate on {0} ({1})", ally.ChampionName, ally.Name))));
                    }

                    Menu4.AddSeparator(13);

                    _ultSliders = new List<Slider>();

                    foreach (var ally in EntityManager.Heroes.Allies)
                    {
                        _ultSliders.Add(Menu4.Add<Slider>("ultHealth" + ally.ChampionName, new Slider(string.Format("{0}'s Health (%):", ally.ChampionName), 50, 1)));

                        Menu4.AddSeparator(13);

                    }
                }

                public static void Initialize() { }
            }

            public static class Combo
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                static Combo()
                {
                    Menu5.AddGroupLabel("Combo");

                    _useQ = Menu5.Add("comboUseQ", new CheckBox("Use Q"));
                    _useW = Menu5.Add("comboUseW", new CheckBox("Use W"));
                }

                public static void Initialize() { }
            }

            public static class Flee
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                static Flee()
                {
                    Menu6.AddGroupLabel("Flee");

                    _useQ = Menu6.Add("fleeUseQ", new CheckBox("Use Q"));
                    _useW = Menu6.Add("fleeUseW", new CheckBox("Use W"));
                }

                public static void Initialize() { }
            }

            public static class Harass
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _autoHarass;
                private static readonly Slider _autoHarassManaPercent;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool AutoHarass
                {
                    get { return _autoHarass.CurrentValue; }
                }
                public static int AutoHarassManaPercent
                {
                    get { return _autoHarassManaPercent.CurrentValue; }
                }

                static Harass()
                {
                    Menu7.AddGroupLabel("Harass");

                    _useQ = Menu7.Add("harassUseQ", new CheckBox("Use Q"));
                    Menu7.AddSeparator(13);

                    _useW = Menu7.Add("harassUseW", new CheckBox("Use W"));
                    Menu7.AddSeparator();

                    _autoHarass = Menu7.Add("autoHarass", new CheckBox("Auto W Harass"));
                    Menu7.AddSeparator(13);

                    _autoHarassManaPercent = Menu7.Add<Slider>("autoHarassManaPercent", new Slider("Auto Harass min. mana %:", 75, 1));
                }

                public static void Initialize() { }
            }

            public static class Humanizer
            {
                private static readonly CheckBox _qCastDelayEnabled;
                private static readonly CheckBox _eCastDelayEnabled;
                private static readonly CheckBox _rCastDelayEnabled;
                private static readonly Slider _qCastDelay;
                private static readonly Slider _eCastDelay;
                private static readonly Slider _rCastDelay;
                private static readonly CheckBox _qRndmDelay;
                private static readonly CheckBox _eRndmDelay;
                private static readonly CheckBox _rRndmDelay;

                public static bool QCastDelayEnabled
                {
                    get { return _qCastDelayEnabled.CurrentValue; }
                }
                public static bool ECastDelayEnabled
                {
                    get { return _eCastDelayEnabled.CurrentValue; }
                }
                public static bool RCastDelayEnabled
                {
                    get { return _rCastDelayEnabled.CurrentValue; }
                }
                public static int QCastDelay
                {
                    get { return _qCastDelay.CurrentValue; }
                }
                public static int ECastDelay
                {
                    get { return _eCastDelay.CurrentValue; }
                }
                public static int RCastDelay
                {
                    get { return _rCastDelay.CurrentValue; }
                }
                public static bool QRndmDelay
                {
                    get { return _qRndmDelay.CurrentValue; }
                }
                public static bool ERndmDelay
                {
                    get { return _eRndmDelay.CurrentValue; }
                }
                public static bool RRndmDelay
                {
                    get { return _rRndmDelay.CurrentValue; }
                }

                static Humanizer()
                {
                    Menu8.AddGroupLabel("Humanizer");

                    _qCastDelayEnabled = Menu8.Add("qCastDelayEnabled", new CheckBox("Enabled", false));
                    _qCastDelay = Menu8.Add<Slider>("qCastDelay", new Slider("Q Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _eCastDelayEnabled = Menu8.Add("eCastDelayEnabled", new CheckBox("Enabled", false));
                    _eCastDelay = Menu8.Add<Slider>("eCastDelay", new Slider("E Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _rCastDelayEnabled = Menu8.Add("rCastDelayEnabled", new CheckBox("Enabled", false));
                    _rCastDelay = Menu8.Add<Slider>("rCastDelay", new Slider("R Cast Delay (1sec = 1000ms):", 500, 250, 1000));
                    Menu8.AddSeparator();

                    _qRndmDelay = Menu8.Add("qRndmDelay", new CheckBox("Randomize Q Cast Delay"));
                    Menu8.AddSeparator();

                    _eRndmDelay = Menu8.Add("eRndmDelay", new CheckBox("Randomize E Cast Delay"));
                    Menu8.AddSeparator();

                    _rRndmDelay = Menu8.Add("rRndmDelay", new CheckBox("Randomize R Cast Delay"));
                    Menu8.AddSeparator();
                }

                public static void Initialize() { }
            }
        }
    }
}
