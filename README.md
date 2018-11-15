# Godot Tips and Snippets

## General Tips

* If you add a file manually, don't forget to add it to `<YourProject>.csproj`

## Logger.cs

Pop this file somewhere in your repo (I usually have a "Scripts" folder for random stuff like this) and it gives you a convenient singleton logger, with a few different log levels. You can use it from any where by calling `Logger.Info(<anything>)` or `Logger.Warn`, `Logger.Error`, and `Logger.Debug`.

You can also set the log level in the Logger file, and if set it won't log messages that fall "below" the level that has been set.

## `tasks.json` and `launch.json`

If you are using VSCode, you can add these to the `.vscode` folder in your repo to enable some nice quick launch tasks.

From `tasks.json` you get a build command, that builds your C# project (if you are using C#), and a launch command that will run your game.

`launch.json` gives you a launcher that will connect to a running Godot instance to debug (again, useful if you are using C#).
