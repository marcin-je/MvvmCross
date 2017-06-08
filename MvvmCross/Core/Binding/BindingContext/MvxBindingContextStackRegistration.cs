// MvxBindingContextStackRegistration.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Binding.BindingContext
{
    using System;

    using Platform;
    using Platform.Platform;

    public class MvxBindingContextStackRegistration<TBindingContext>
        : IDisposable
    {
        protected IMvxBindingContextStack<TBindingContext> Stack => Mvx.Resolve<IMvxBindingContextStack<TBindingContext>>();

        public MvxBindingContextStackRegistration(TBindingContext toRegister)
        {
            Stack.Push(toRegister);
        }

        ~MvxBindingContextStackRegistration()
        {
            MvxTrace.Error("You should always Dispose of MvxBindingContextStackRegistration");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Stack.Pop();
            }
        }
    }
}