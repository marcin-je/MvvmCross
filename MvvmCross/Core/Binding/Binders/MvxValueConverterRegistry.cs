// MvxValueConverterRegistry.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Binding.Binders
{
    using Platform.Converters;

    public class MvxValueConverterRegistry
        : MvxNamedInstanceRegistry<IMvxValueConverter>
          , IMvxValueConverterLookup
          , IMvxValueConverterRegistry
    {
    }
}