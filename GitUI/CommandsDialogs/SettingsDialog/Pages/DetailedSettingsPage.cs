﻿using GitCommands.Settings;

namespace GitUI.CommandsDialogs.SettingsDialog.Pages
{
    public partial class DetailedSettingsPage : RepoDistSettingsPage
    {
        public DetailedSettingsPage()
        {
            InitializeComponent();
            Text = "Detailed";
            Translate();
        }

        protected override void Init(ISettingsPageHost aPageHost)
        {
            base.Init(aPageHost);
            BindSettingsWithControls();
        }

        private DetailedGroup DetailedSettings
        {
            get
            {
                return CurrentSettings.Detailed;
            }
        }

        private void BindSettingsWithControls()
        {
            AddSettingBinding(DetailedSettings.ShowConEmuTab, chkChowConsoleTab);
            AddSettingBinding(DetailedSettings.GetRemoteBranchesDirectlyFromRemote, chkRemotesFromServer);
        }

        public static SettingsPageReference GetPageReference()
        {
            return new SettingsPageReferenceByType(typeof(DetailedSettingsPage));
        }
    }
}
