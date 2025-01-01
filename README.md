# Derail Valley Simulator mod template

This is a basic start that will help you get started with a mod for the game Derail Valley Simulator.

<br>

### Table of contents
- [Development setup](#development-setup)

<br>

## Development setup

### 1. Download & install a code editor

A full IDE is not required, but recommended. This template is made and tested with MS Visual Studio 2022.
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/)
- [Jetbrains Rider](https://www.jetbrains.com/rider/)

Visual Studio Code is also supported with numerous extensions, such as [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) or [C# for VSCode](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp).
- [Visual Studio Code](https://code.visualstudio.com/)

### 2. Download this template

`git-clone` this repo or [download the ZIP](https://github.com/MikevanBreePXL/dv-simulator-UMM-mod-template/archive/refs/heads/main.zip) and extract it to a memorable and manageable location.

As long as you work on your mod, this folder should be your project continously throughout development.

<b><u>If you intend to publish/release your mod, you should create a new repository for it. Forking is possible, but not recommended.</u></b>

### 3. Open the project in your IDE

Open the project by double-clicking the `.sln` file in the root of the project folder.

### 4. Update the mod references

In order for your code editor to view IntelliSense and compile your code, you need to update the references to the game's DLLs, and UnityModManager's DLL.

<u>These include all classes and methods that you are able to call for your mod.</u>

1. Right click the `Class Library (.NET Framework)` project "DerailValleyMod" and select `Add` → `Reference...` 

> These files contain the game's classes and methods that you can call/use in your own code.

2. Update the paths of the reference `.dll` files to your specific case: 

    - Located at the installation directory of `UnityModManager`, used to install the game's modloader and additional mods:
        - `UnityModManager.dll`

    - Located inside the game's installation directory, in a subfolder `.../DerailValley/DerailValley_Data/Managed/`:
        - `Assembly-CSharp.dll`
            > Used for the game's modloader.
        - `UnityEngine.dll`
            > Used for the game's engine.
        - `UnityEngine.CoreModule.dll`
            > Used for the game's engine.
        - `UnityEngine.InputLegacyModule.dll`
            > Used for the game's keyboard/mouse input tracking.

> `UnityEngine.InputModule.dll` is also present in the game's installation directory, but it is not used throughout the game and seems lacking in any classes or methods. It only contains a namespace called `UnityEngineInternal`.

3. Double check `copyLocal` is set to `false` for all references.

> These files are already present in the game's installation directory, and should not be copied to your mod export folder.

- Open the Solution Explorer in your IDE/code editor.
- Open the `References` folder located under the project file `DerailValleyMod.csproj`
- Right-click all added/updated references and select `Properties`
- Set `Copy Local` to `false` for all references.

### 5. Changing the mod name

> Whilst the mod template is barebones, the exported mod requires a seperate `info.json` file for extra information, shown in UnityModManager. There's a working example `info.json` file present in the root of the project folder.

There are 2 fields that need to be monitored for mod name changes:

- `"AssemblyName"` :  This should be the exact name of the .dll file that is made when building the project.
- `"EntryMethod"` :  This is the initial method that is called when the mod is loaded into the game. The name should match the following format: `"<Namespace>.<ClassName>.<MethodName>"`

### 6. Creating a mod build/release

1. Select Debug or Release mode in the IDE/code editor.
2. Build the solution by pressing `Ctrl+Shift+B` or `Build → Build Solution`.
3. The mod will be built to the `bin/Release` or `bin/Debug` folder.
4. Copy the `.dll` file from the generated folder into a new seperate folder, with a location of your liking.
5. Adjust the `info.json` file to your liking and copy it to the same folder as the `.dll` file.
6. Copy the created folder into the `Mods` folder of your game installation.
    - The `.dll` file should now be at `.../DerailValley/Mods/<ModFolderName>/xxx.dll`.