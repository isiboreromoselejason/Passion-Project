# Passion-Project
**Contact Management System**
The project is about a contact management system that manages contact for users. The system will allow users to manage their contacts by adding contact, updating contact, deleting contacts and searching for contacts.

**Running This Project**

* Project > bookshop Properties > Change target framework to 4.7.2
    
* Make sure there is SQL Express installed on your system
    
* Tools > Nuget Package Manager > Package Manage Console > update-database
    
* Check that the database is created using (View > SQL Server Object Explorer > ..)
    
* Run API commands through CURL to create new contacts, users and categories.


**Features**
* Search Contacts
* Group Contacts by category
* Contacts CRUD (Create, Read, Update and Delete) operations.
* User-friendly interface with responsive design

**Contact API Routes**
* Get - api/Contacts
* Get - api/Contacts/:Id
* Post - api/Contacts
* Update - api/Contacts/:Id
* Delete - api/Contacts/:Id
 
**Category API Routes**
* Get - api/Categories
* Get - api/Categories/:Id
* Post - api/Categories
* Update - api/Categories/:Id
* Delete - api/Categories/:Id

**Users API Routes**
* Get - api/Users
* Get - api/Users/:Id
* Post - api/Users
* Update - api/Users/:Id
* Delete - api/Users/:Id
