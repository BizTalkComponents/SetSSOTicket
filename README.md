[![Build status](https://ci.appveyor.com/api/projects/status/github/BizTalkComponents/SetSSOTicket?branch=master)](https://ci.appveyor.com/api/projects/status/github/BizTalkComponents/SetSSOTicket/branch/master)

##Description
Issues a new SSO ticket and writes it to context so that any SSO enabled adapter can access it.

_No parameters_

##Remarks
This component is built for BizTalk 2013 and will not work per default for newer versions of BizTalk.

In order to make it work for newer versions of BizTalk the assembly version need to be redirected by modifying the BTSNTSvc.exe.config and BTSNTSvc64.exe.config files.

##Instructions
Follow the listed instructions to change the assembly version.

1. Open an instance of Developer Command Prompt.
2. Paste the following command: <gacutil -l Microsoft.EnterpriseSingleSignOn.Interop>
3. Take note of the version listed.
4. Paste the following command: <gacutil -l Microsoft.BizTalk.Interop.SSOClient>
5. Take note of the version listed.
6. Open the BTSNTSvc.exe.config and BTSNTSvc64.exe.config files in an text editor.
7. Add the following code snipet to both files:
```
<runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
        <probing privatePath="BizTalk Assemblies;Developer Tools;Tracking;Tracking\interop" />
        <dependentAssembly>
            <assemblyIdentity name="Microsoft.BizTalk.Interop.SSOClient" publicKeyToken="31bf3856ad364e35" culture="neutral" />
            <bindingRedirect oldVersion="7.0.2300.0" newVersion="<The new version of the assembly>"/>
        </dependentAssembly>
        <dependentAssembly>
            <assemblyIdentity name="Microsoft.EnterpriseSingleSignOn.Interop" publicKeyToken="31bf3856ad364e35" culture="neutral" />
            <bindingRedirect oldVersion="7.0.2300.0" newVersion="<The new version of the assembly>"/>
        </dependentAssembly>  
    </assemblyBinding>
</runtime>
```
8. Replace <The new version of the assembly> with respective versions found in step 3 and 5.
9. Restart the Host Instances.
10. The assembly is now redirected and SetSSOTicket should work for versions newer than 7.0.2300.0.