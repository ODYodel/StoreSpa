# Product Search Prototype - by [@MayoWelch](https://twitter.com/MayoWelch)

This repo contains an aspnetcore + Vue.js 2 starter template (VS2017).The template is based
on the [original updated starter template](https://github.com/MarkPieszak/aspnetcore-Vue-starter)
which was based on the [original starter templates](https://blogs.msdn.microsoft.com/webdev/2017/02/14/building-single-page-applications-on-asp-net-core-with-javascriptservices/) (Angular, Knockout, React, Aurelia), which can be found [here](https://github.com/aspnet/JavaScriptServices/tree/dev/templates)

 
---

# Table of Contents

* [Features](#features)
* [Prerequisites](#prerequisites)
* [Installation - Getting Started!](#installation)
* [To-Dos](#upcoming-features)
* [Extras](#extras)
* [Special Thanks](#special-thanks)
* [License](#license)

# Features

- **ASP.NET Core 2.0**
  - Web API
- **VueJS 2**
  - Vuex (State Store)
- **Webpack 2**
  - HMR (Hot Module Replacement/Reloading)
- **Bootstrap**
- ...more details to come...

# Prerequisites:
 * nodejs > 6
 * VS2017
 * dotnet core 2.0
 * Important: Must have a walmart Open Api Key : https://developer.walmartlabs.com/

# Installation / Getting Started:
 * Clone this repo
 * At the repo's root directory run `dotnet restore`
 * Restore Node dependencies by running `npm install`
 * Set your apiKey using the following command `dotnet user-secrets set "WalMartOpenAPIKey" "{APIKey}"
 * Run unit test dotnet test
 * Run the application (`dotnet run` or `npm run dev`)
 
 or
 
 * Run the application in VSCode or Visual Studio 2017 (Hit `F5`)
 * Browse to [http://localhost:5000](http://localhost:5000)

# Extras

- Get Chrome DevTools for Vue [here](https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd)


# To-Dos

**[TODO]**
 * Add photo carousel to product images
 * Add store to manage application state
 * UI Tests (Jest)
 * Refine server response to return only needed fields from json (faster loadtime on mobile and slower connections)
 * Scaling - investigate cacheing server and client side
 * Tweak CSS to fit more align with the brand I was going for.

----

# Found a Bug? Want to Contribute?

Nothing's ever perfect, but please let me know by creating an issue (make sure there isn't an existing one about it already), and we'll try and work out a fix for it! If you have any good ideas, or want to contribute, feel free to either make an Issue with the Proposal, or just make a PR from your Fork.

----

### Special Thanks

Many thanks go out to [@MarkPieszak](http://twitter.com/MarkPieszak) for putting out the template.

----

# License

[![MIT License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat)](/LICENSE) 
