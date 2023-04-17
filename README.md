# GovBright
Herein lies a technical test for a full stack senior developer position.

I was not successful in the application ( I didnt recieve any feedback as to why) but I enjoyed the process of putting this together and have shared it in the hopes that others may find it of use.

Recieved: 24/03/23  
Submitted: 28/03/23

## Tech Overview:
* Blazor Server
* Sass
* .Net 7
* Basic Authentication
* Entity Framework Code First
* API data retrieval
* XUnit

## Setup
1.  Create a free account at https://postcoder.com/ and put your api key in AddressService.cs 
2.  Change the connection strings in appsettings.json to point to your local instace of SQL Server
3.  Run migrations and create databases for both the authentication (Govbright.Web project ) and data (Govbright.DAL project) features

Have a click about and feel free to make any ammends/suggestions/constructive feedback.

Thanks for reading (^_^)

# Software Engineer Competency Assessment

### Introduction
The purpose of this assessment is to test for a basic level of competency, combined with the
ability to learn new skills where needed. We require you to do a set of tasks for submission
prior to an interview. Should you be subsequently called for an interview, you may also be
asked questions about this assessment within the context of the business analyst working
on the project.

### Requirement
A government department needs a website to allow members of the public to give feedback
about the lighting outside of their home. They would like you to create a .Net MVC (or blazor) website
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
