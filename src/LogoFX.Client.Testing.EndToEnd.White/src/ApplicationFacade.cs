using Attest.Testing.Lifecycle;
using TestStack.White;

namespace LogoFX.Client.Testing.EndToEnd.White
{   
    /// <summary>
    /// Implementation of application facade using <see cref="TestStack.White"/> framework
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