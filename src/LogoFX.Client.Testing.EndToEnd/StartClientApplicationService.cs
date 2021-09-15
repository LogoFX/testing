using System.IO;
using Attest.Testing.Application;
using Attest.Testing.Lifecycle;
using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.EndToEnd
{
    /// <inheritdoc />    
    public sealed class StartClientApplicationService : IStartClientApplicationService
    {
        private readonly IStartApplicationService _startApplicationService;
        private readonly IApplicationPathInfo _applicationPathInfo;

        /// <summary>
        /// Creates new instance of <see cref="StartClientApplicationService"/>
        /// </summary>
        /// <param name="startApplicationService">The actual start application service</param>
        /// <param name="applicationPathInfo">The application path information</param>
        public StartClientApplicationService(
            IStartApplicationService startApplicationService,
            IApplicationPathInfo applicationPathInfo)
        {
            _startApplicationService = startApplicationService;
            _applicationPathInfo = applicationPathInfo;
        }

        /// <inheritdoc />
        public void Start()
        {
            //The SetCurrentDirectory() trick
            //is needed in both Fake and Real
            //In both cases it allows the app to correctly read its modules
            //as Solid.Composition uses Directory.GetCurrentDirectory() internally
            //to locate the root folder
            //In Fake case it also allows correct builder serialization location
            var testDirectory = Directory.GetCurrentDirectory();
            var applicationPath = Path.Combine(testDirectory, _applicationPathInfo.RelativePath,
                _applicationPathInfo.Executable);
            var applicationDirectory = Path.GetDirectoryName(applicationPath);
            Directory.SetCurrentDirectory(applicationDirectory);
            _startApplicationService.Start(applicationPath);
            Directory.SetCurrentDirectory(testDirectory);
        }
    }
}