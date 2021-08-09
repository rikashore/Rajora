# Rajora #
A wrapper around Clash Of Clan's API

# Getting Started #
To get started you need a few things

- An API key from [Clash Of Clans API site](https://developer.clashofclans.com/)

Next install the package

```bash
dotnet add package Rajora
```

Now in your code, create a new `RajoraClient`.

```cs
var rajora = new RajoraClient("<AUTH TOKEN>");
```

Where auth token is the api key you got from the developer site.

## Examples ##

### Getting a player ###

```cs
var rajora = new RajoraClient("<AUTH TOKEN>");

var player = await rajora.GetPlayerAsync("player tag here");
```
