# Cheret
Cheret: kheh'-ret - An engraving tool, stylus, chisel, graving tool

## Description 
This is a web-based tool for creating church websites.  The goal is to provide a simple site for churches to create and update their site.
The site will be composed mainly of a large form.  This form will be saved to a database then used to generate the site based on a chosen template.

## Templates
At launch, the goal will be to have at least 3 templates.  Templates will be required to adhere to a predefined standard that will allow information from the users settings to be injected into the html of the page.

### Tempalte Requirements
- Angluar
- Must have the following pages/sections
  - Home
  - About
  - Services
  - Sermons
  - Ministries
  - Calendar
  - Contact

A section is defined as an HTML document.  A section can appear anywhere in the site as long as it does appear.
For example: There can be a single page template that has no routing; all of the information is on a single, scrollable page.  There would have to be components for each of the sections. 

There will be a tempalte skelleton provided.

## Creating a Template
### Color Schemes
*The color schemes will be based on the [Material Design pattern](https://material.io/design/color/the-color-system.html#color-theme-creation)*.

Four colors are required: **Primary, Secondary, Surface, and Background** and each will have a "on color" ascociated with it (the color of the text on the color).  Since this is based off of Material Design, which relies heavily on cards, these colors don't necessarily have to be used in the intended way.  Since the color values will be dropped in, you can use these in whatever way seems best to you and the template you are making.

You will have the option to let the user choose these four colors, some of the colors, or non at all.  It is recommmended that you allow the user to choose the colors, however there can be cases where the colors shouldn't change.

#### Primary
This is the main color that will show up in the site.

#### Secondary
This is the color that will be used to highlight certain elements of the page.  This could include buttons or the main content of the page.

#### Surface
This is the color that will appear in the backgound of every element that is not scrollable.  In some cases, this may be the background of the entire page.
If the site is a single page site, this color can be uses to color sections of the page.

#### Background
This is the background of anything that has scrollable content on it.  Most of the time, the body tag should have this as it's background color.
