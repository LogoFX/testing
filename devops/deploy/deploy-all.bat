rem TODO: Use common source for all version instances
SET version=2.2.3
rem TODO: Refactor using loop and automatic discovery
call deploy-single.bat LogoFX.Client.Testing.Contracts %version% 
call deploy-single.bat LogoFX.Client.Testing.Shared %version%
call deploy-single.bat LogoFX.Client.Testing.Shared.Caliburn.Micro %version%
call deploy-single.bat LogoFX.Client.Testing.EndToEnd %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.FlaUI %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.White %version% 
call deploy-single.bat LogoFX.Client.Testing.EndToEnd.SpecFlow %version% 
call deploy-single.bat LogoFX.Client.Testing.Integration %version% 
call deploy-single.bat LogoFX.Client.Testing.Integration.NUnit %version% 
call deploy-single.bat LogoFX.Client.Testing.Integration.xUnit %version% 
call deploy-single.bat LogoFX.Client.Testing.Integration.SpecFlow %version%