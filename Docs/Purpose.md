# Pretty Good Bootstrap Base Theme Orchard Theme: What's the Great Purpose?



This theme is built with the same purpose as the original [Pretty Good Base Theme](https://github.com/Lombiq/Pretty-Good-Base-Theme): to provide a solid, extensible, foundation for building your own Orchard theme upon, based on [Twitter's Bootstrap](http://getbootstrap.com/). You shouldn't use this theme on its own, but inherit from it when you write your own theme (mark it as BaseTheme in your Theme.txt).

The theme provides the following:

- Includes Bootstrap's LESS files
- Includes modularly structured LESS files (and their compiled CSS counterparts) to employ Bootstrap in Orchard among others for reset, structure, navigation and forms
- Adapts Bootstrap for Orchard by re-using Bootstrap's stylesheets as LESS resources and glueing them to Orchard's markup, without the usage of shape template overrides. This way Orchard's semantic css classes are kept and the markup is not modified for e.g. using Bootstrap's grid system.
- Makes adding a favicon extremely easy (just drop it in)