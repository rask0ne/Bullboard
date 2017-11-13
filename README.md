# Bullboard
***
### Why do you need this application?

This app will let you quickly find any goods which people might sell right now or put up for sale some good and interesting stuff.

### Requirements

Any modern browser.

### Analogs

* [Baraholka Onliner.by](https://baraholka.onliner.by/)
* [ay.by](http://ay.by/)
* [olx.by](https://www.olx.by/)

# Requirements Document 
## 1 Introduction
The designed software is a web app which shall provide an convenient platform for buying and selling different goods.
## 2 User Requirements

### 2.1 Software Interfaces

#### Used technologies
- HTML, CSS, Typescipt and Angular (front-end)
- C#, ASP.NET MVC and Entity Framework (backend)
- SQL to store information about users and their ads
=======
- HTML, CSS, Javascript, Typescipt and Angular (front-end)
- C#, ASP.NET (backend)
- SQL Server to store information about users and their ads

### 2.2 User Interfaces

User interface will provide facilities to create and delete bulletins, register and edit profiles. More details you'll see in mockups.

### 2.3 User Characteristics
- People who want to sell their stuff or buy something they need. No limits.

### 2.4 Assumptions and Dependencies
- Performance issues in old browsers.
- Easy extensibility and changeability of content.

## 3 System Requirements
To use this application, you need a device with Enternet access and web browser installed. Recommended browsers:
- Google Chrome
- Mozilla Firefox
- Microsoft Edge

### 3.1 Functional Requirements
3.1.1 Functional and user-friendly interface for people to create their own bulletins and find things they need.

3.1.2 Internalization of toolset and content in Russian and English. Implemented by icons on bottom of the page

3.1.3 Implemention of database storing information about users and their bulletins.

3.1.4 Ability to share bulletins to different social networks.

3.1.5 Registration of user by e-mail with confirmation or authentification by social networks.

3.1.6 Validation of information while user is registering, creating new bulletin or using advanced search to prevent his wrong data input.

3.1.7 Editable user profile in profile page.

### 3.2 Non-Functional Requirements
1) Secure HTTPS channel
#### 3.2.1 SOFTWARE QUALITY ATTRIBUTES
- Performance - this platform may not be highweight because there will not be a lot of information, mostly bulletin and user info. That is why loading of the app will only depend on users internet.

- Reliability - the main idea of this application is to be active 24 hours per day because necessity in different goods may wake up in a person at any time. So everyone may enter the app whenever he wants.