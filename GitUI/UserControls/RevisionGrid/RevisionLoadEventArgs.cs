﻿using GitUIPluginInterfaces;

namespace GitUI.UserControls.RevisionGrid
{
    public class RevisionLoadEventArgs : GitUIEventArgs
    {
        public RevisionLoadEventArgs(IWin32Window? ownerForm, IGitUICommands gitUICommands, Lazy<IReadOnlyList<IGitRef>> getRefs, bool forceRefresh)
            : base(ownerForm, gitUICommands, getRefs)
        {
            ForceRefresh = forceRefresh;
        }

        public bool ForceRefresh { get; init; }
    }
}
