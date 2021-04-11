# Track-My-Day
Track My Day acts like a personalised daily activity tracker which comes with a Calendar which keeps the track of your schedule. User must sign up and login to mark the events in the Calendar. Users can also register using google sign up. User can mark their free time, by clicking on any date. There are fields such as Subject, Start Time, End Time ,Description, Is Full day. User can also edit or remove an event. User can able to view its individual record by signing up.
##Installation Instructions##

##Download Microsoft Visual Studio 2019 or any other version ##
##On the start Window, click on Clone a Repository
##Enter or copy paste the repository location, and the select Clone
##Select Save
##Visual Studio Automatically loads and opens the solution from the repository
##Add a edmx file by right clicking on the solution->Add item->Data->EF Designer From Data->Select Your Database->Submit
Make Sure to check the connection String in Web.config file which matches your Sql server Instance.

##For Google Login:

**You will need a ClientID and Client Secret

Open developers.google.com
Open the Google API Console Credentials page.
Click Select a project, then NEW PROJECT, and enter a name for the project, and optionally, edit the provided project ID. Click Create.
On the Credentials page, select Create credentials, then OAuth client ID.
You may be prompted to set a product name on the Consent screen; if so, click Configure consent screen, supply the requested information, and click Save to return to the Credentials screen.
Select Web Application for the Application Type. Follow the instructions to enter JavaScript origins, redirect URIs, or both.
Click Create.
On the page that appears, copy the client ID and client secret to your clipboard, as you will need them when you configure your client library.
Paste that to StartupAuth.cs Google Authentication Function at the End.
**##Technologies Used:

##FrontEnd: C# Html CSS Bootstrap Jquery
##BackEnd: (Local db)Sql Server****(Microsoft Sql Management Studio)

##Asp.net MVC Project with a Google Login Functionality##

Database File is Attached in the Project.
