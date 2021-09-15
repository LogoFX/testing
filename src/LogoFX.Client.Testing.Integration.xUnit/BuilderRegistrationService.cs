using Attest.Testing.Core.xUnit;
using Attest.Testing.FakeData;
using Solid.Patterns.Builder;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.xUnit
{
    /// <summary>
    /// Represents builder registration service for xUnit.net-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public sealed class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BuilderRegistrationService"/>.
        /// </summary>
        /// <param name="dependencyRegistrator">The dependency registrator.</param>
        /// <param name="dependencyResolver">The dependency resolver.</param>
        public BuilderRegistrationService(
            IDependencyRegistrator dependencyRegistrator, 
            IDependencyResolver dependencyResolver)
            :base(dependencyRegistrator, dependencyResolver) {}

        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilderProduct(builder);
        }
    }
}
