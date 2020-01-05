# cloudscribe.Metaweblog is a re-useable implementation of the Metaweblog API for ASP.NET Core

It was implemented for use in [cloudscribe SimpleContent](https://github.com/joeaudette/cloudscribe.SimpleContent), but could be used by anyone who would like to add Metaweblog API support to their web application.

# Note the code in this repo is no longer used, the official code is now in the cloudscribe.SimpleContent repo

https://github.com/cloudscribe/cloudscribe.SimpleContent

## What the heck is Metaweblog API

MetaWeblog API is something you can use to create, edit, and publish content using desktop tools such as [Open Live Writer](https://github.com/OpenLiveWriter/OpenLiveWrite). I specifically created this project in order to be able to use Open Live Writer with cloudscribe.SimpleContent, but I abstracted things so that others could use it too. Just implement and plugin your own implementation of [IMetaWeblogService](https://github.com/joeaudette/cloudscribe.MetaWeblog/blob/master/src/cloudscribe.MetaWeblog/IMetaWeblogService.cs).

Note that this is not a generalized solution for XmlRpc, it is specifically an implementation of the MetaWeblog API

You can get it from nuget by adding this in your project.json dependencies

    "cloudscribe.MetaWeblog": "3.0.*"

If you have questions please visit our community forum https://www.cloudscribe.com/forum


