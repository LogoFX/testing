using Attest.Testing.Lifecycle;
using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.Integration
{
    /// <inheritdoc />
    public sealed class StartClientApplicationService : IStartClientApplicationService
    {
        private readonly IStartApplicationService _startApplicationService;

        /// <summary>
        /// Creates a new instance of <see cref="StartClientApplicationService"/>
        /// </summary>
        /// <param name="startApplicationService"></param>
        public StartClientApplicationService(IStartApplicationService startApplicationService)
        {
            _startApplicationService = startApplicationService;
        }

        /// <inheritdoc />
        public void Start()
        {
            _startApplicationService.Start(string.Empty);
        }
    }
}