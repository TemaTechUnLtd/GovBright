# GovBright
Technical test for a full stack senior developer position

### Requirement
A government department needs a website to allow members of the public to give feedback
about the lighting outside of their home. They would like you to create a .Net MVC ( or blazor) website
using the responsive style contained in the Government Digital Services (GDS) Design
System (https://design-system.service.gov.uk/). The information they want to collect should
include the following:
* name (string, max 50 chars)
* email address (string)
* Home Address
* are they happy with the level of lighting (Boolean, yes/no radio buttons)
* level of brightness (int, 1-10 scale, 1 being very dark, 10 being very bright,
dropdown)  
  
When creating the website, you should be mindful of the following:
* Solid principals
* Entity framework with code-first migrations
* Validation
* A repository pattern.
* Any relevant unit tests.  
   
As with GDS principals, we should ask one question per page, allowing the user to navigate
backward and forwards through their answers and also allow the user to check their
answers before submission (https://design-system.service.gov.uk/patterns/check-
answers/).  

### Optional Extras
The following are optional elements you may want to include in your project:
* Use a postcode lookup service.
* Technical Architecture diagram
* Add a secure admin area to view submissions.
* Use of .Net Tag Helpers.
* Build pipeline.
