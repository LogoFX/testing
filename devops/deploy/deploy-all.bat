rem TODO: Use common source for all version instances
SET version=2.2.4
rem TODO: Refactor using loop and automatic discovery
call deploy-single.bat LogoFX.Client.Tests.Contracts %version% 
call deploy-single.bat LogoFX.Client.Tests.Shared %version%
call deploy-single.bat LogoFX.Client.Tests.Shared.Caliburn.Micro %version%
call deploy-single.bat LogoFX.Client.Tests.EndToEnd %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.FlaUI %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.White %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.SpecFlow %version% 
call deploy-single.bat LogoFX.Client.Tests.Integration %version% 
call deploy-single.bat LogoFX.Client.Tests.Integration.NUnit %version% 
call deploy-single.bat LogoFX.Client.Testing.Integration.xUnit %version% 
call deploy-single.bat LogoFX.Client.Tests.Integration.SpecFlow %version%