# Godot Tips and Snippets

## Logger.cs

Pop this file somewhere in your repo (I usually have a "Scripts" folder for random stuff like this) and it gives you a convenient singleton logger, with a few different log levels. You can use it from any where by calling `Logger.Info(<anything>)` or `Logger.Warn`, `Logger.Error`, and `Logger.Debug`.

You can also set the log level in the Logger file, and if set it won't log messages that fall "below" the level that has been set.
