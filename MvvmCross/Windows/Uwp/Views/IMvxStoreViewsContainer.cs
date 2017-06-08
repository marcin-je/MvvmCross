﻿// IMvxStoreViewsContainer.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Uwp.Views
{
    using Core.Views;

    public interface IMvxStoreViewsContainer
        : IMvxViewsContainer
            , IMvxWindowsViewModelLoader
            , IMvxWindowsViewModelRequestTranslator
    {        
    }
}