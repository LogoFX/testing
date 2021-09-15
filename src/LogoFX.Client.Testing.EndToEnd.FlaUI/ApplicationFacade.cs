using Attest.Testing.Lifecycle;
using FlaUI.Core;

namespace LogoFX.Client.Testing.EndToEnd.FlaUI
{
    /// <summary>
    /// Implementation of application facade using <see cref="FlaUI"/> framework
    /// </summary>
    public sealed class ApplicationFacade : IApplicationFacade
    {
        /// <inheritdoc />
        public void Start(string startupPath)
        {
            ApplicationContext.Application = Application.Launch(startupPath);
            ApplicationContext.Application.WaitWhileBusy();
        }

        /// <inheritdoc />
        public void Stop()
        {
            ApplicationContext.Application?.Dispose();
        }
    }
}
