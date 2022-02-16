<VisualStudioProject>
    <ECSHARP
        ProjectType = "Local"
        ProductVersion = "7.10.3077"
        SchemaVersion = "1.0"
        ProjectGuid = "{4EE8F770-5668-4B62-B030-91DF5F24E4E2}"
    >
        <Build>
            <Settings
                ApplicationIcon = ""
                AssemblyKeyContainerName = ""
                AssemblyName = "TomislavApp"
                AssemblyOriginatorKeyFile = ""
                DelaySign = "false"
                OutputType = "WinExe"
                OutputFileFolder = "\Program Files\TomislavApp"
                RootNamespace = "TomislavApp"
                StartupObject = ""
            >
                <Platform Name = "Windows CE" />
                <Config
                    Name = "Debug|Windows CE"
                    AllowUnsafeBlocks = "false"
                    BaseAddress = "0"
                    CheckForOverflowUnderflow = "false"
                    ConfigurationOverrideFile = ""
                    DefineConstants = "DEBUG;TRACE"
                    DocumentationFile = ""
                    DebugSymbols = "true"
                    FileAlignment = "4096"
                    IncrementalBuild = "false"
                    Optimize = "false"
                    OutputPath = "bin\Debug\"
                    RegisterForComInterop = "false"
                    RemoveIntegerChecks = "false"
                    TreatWarningsAsErrors = "false"
                    WarningLevel = "4"
                />
                <Config
                    Name = "Release|Windows CE"
                    AllowUnsafeBlocks = "false"
                    BaseAddress = "0"
                    CheckForOverflowUnderflow = "false"
                    ConfigurationOverrideFile = ""
                    DefineConstants = "TRACE"
                    DocumentationFile = ""
                    DebugSymbols = "false"
                    FileAlignment = "4096"
                    IncrementalBuild = "false"
                    Optimize = "true"
                    OutputPath = "bin\Release\"
                    RegisterForComInterop = "false"
                    RemoveIntegerChecks = "false"
                    TreatWarningsAsErrors = "false"
                    WarningLevel = "4"
                />
            </Settings>
            <References>
                <Reference
                    Platform = "Windows CE"
                    Name = "MSCorLib"
                    AssemblyName = "mscorlib"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System"
                    AssemblyName = "System"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System.Drawing"
                    AssemblyName = "System.Drawing"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System.Windows.Forms"
                    AssemblyName = "System.Windows.Forms"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System.XML"
                    AssemblyName = "System.Xml"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System.Data"
                    AssemblyName = "System.Data"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE"
                    Name = "System.Windows.Forms.DataGrid"
                    AssemblyName = "System.Windows.Forms.DataGrid"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System.CF.Design"
                    AssemblyName = "System.CF.Design"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System.CF.Design.UI"
                    AssemblyName = "System.CF.Design.UI"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System.CF.Windows.Forms"
                    AssemblyName = "System.CF.Windows.Forms"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System.CF.Drawing"
                    AssemblyName = "System.CF.Drawing"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System"
                    AssemblyName = "System"
                    Private = "False"
                />
                <Reference
                    Platform = "Windows CE-Designer"
                    Name = "System.CF.Windows.Forms.DataGrid"
                    AssemblyName = "System.CF.Windows.Forms.DataGrid"
                />
            </References>
        </Build>
        <Files>
            <Include>
                <File
                    RelPath = "AssemblyInfo.cs"
                    SubType = "Code"
                    BuildAction = "Compile"
                />
                <File
                    RelPath = "Form1.cs"
                    SubType = "Form"
                    BuildAction = "Compile"
                />
                <File
                    RelPath = "Form1.resx"
                    DependentUpon = "Form1.cs"
                    BuildAction = "EmbeddedResource"
                />
            </Include>
        </Files>
    </ECSHARP>
</VisualStudioProject>

