# Pretty Good Bootstrap Base Theme Orchard Theme: How to...



This section deals with common scenarios you could encounter when you use PGBBT as a base theme.


## ...build upon the built-in styling by using LESS?

This is the preferred way of using PGBBT. Just have a site.less in your theme and import the LESS files needed by you (see [Structure](Structure.md) for the list of available LESS stylesheets) there. E.g. you could import the whole original site.less from PGBBT if you need all the styling but you can only include e.g. reset and structure if you only want to use normalization and grid system styles. The individual LESS files all import their own dependencies so you really only need to import what you intend to use.


## ...build upon the built-in styling without using LESS?

You have two options:
If you want to add to the default styling and just want to override some properties, then just create a stylesheet with a name anything else than site.css in the root of your theme's Styles folder and write your styling there. You also have to include this stylesheet: see how to do this on this page under how to include own resources.
You can cherry-pick individual stylesheets containing only a discrete part of styling. Take a look at the Styles folder of the theme and you'll see the options. See [Structure](Structure.md) for the options.


## ...use a custom favicon?

Just add a favicon.ico to the root of your theme's Images folder. **Actually for the sake of simplicity, please do add a favicon.ico to your own theme even if you use the default one** (just copy-paste the default one from the PGBT folder), otherwise a non-existent icon will be included!


##...add own global shapes?

Place an Insertions.cshtml template into your theme's Views folder. This will override the default Insertions.cshtml. Look into it for how to add new shapes to the layout. If you want to keep the defaults, you should override AdditionalInsertions.cshtml.


## ...include own resources (stylesheets, scripts)?

Place a Resources.cshtml template into your theme's Views folder. This will override the default Resources.cshtml. Look into it for how to add resources to the document. If you want to keep the defaults, you should override AdditionalResources.cshtml.