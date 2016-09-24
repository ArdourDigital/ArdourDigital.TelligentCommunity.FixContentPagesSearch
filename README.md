# Content Search Category for Telligent Community

![Build Status](https://ardourdigital.visualstudio.com/_apis/public/build/definitions/8b5ba8e6-4059-46da-8ac1-e2bcf922c889/11/badge)

Content Search Category plugin for Telligent Community.

An issue exists in Telligent Community (aka Zimbra Social/Community) 7.x - 9.x where the "Content" filter on the search results page does not work correctly.

The issue can be seen by the "Content" option in the content type list appearing in lowercase, and selecting it returning all results, rather than just the content pages.

[More information on the issue is on the Telligent Community](https://community.telligent.com/community/f/developer-forum/1143331/search-results-facet-on-content-is-broken).

## Supported Versions
This plugin should work with the following versions of Telligent Community, which are affected by this bug
- Telligent Community 9.x
- Telligent Community 8.x
- Telligent Community 7.x (NOTE - The bug doesn't stop the "content" category working in 7.x, but still displays content in lowercase which is inconsistent with the other filters)

## Installation

You can install the plugin by [downloading the latest version](https://github.com/ArdourDigital/ArdourDigital.TelligentCommunity.FixContentPagesSearch/releases/latest) and adding it to your sites `bin` folder, or if you are using Visual Studio you can use nuget:

```
Install-Package ArdourDigital.TelligentCommunity.ContentsSearch
```

The plugin can then be enabled by logging in as an administrator, and going to `Administration` > `Extensions` and finding `Ardour Digital - Fix Content Pages Search`, check the `Enabled` check box, and `Save`.