# Xamarin_MVVM
This is a basic app that let you create a sample Xamarin Project Contains HamburgerMenu, MVVM Project Setup and ListView which shows contact details.

<p align="center">
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/ContactPage.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/NewContact.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/EditContact.png" width="20%" height="25%"/>
</p>

This project was made by learning Xamarin Forms and see how it interacts with other layers of the application.
When I started learning Xamarin development, I couldn't find sample projects in MVVM architecture. So I searched through web and developed my own. I posted this so that this project might be helpl those people who started learning xamarin Forms. I'm  still learning. This project is merely my attempt to put something together based on the learning put across youtube and Udemy couses and in the official Microsoft documentation.

## Platforms
This project will run in Windows ,iOS and Android. Currently I have only developed only for Android. You guys can easily add an iOS or Windows project. Below procedure shows how to run this for iOS and Windows.

It might seem like a hack, but when I need to do this I follow these steps:

- You need to create a totally new Xamarin.Forms solution in a temporary location on the Mac with exactly the same name as the existing project. Close the solution.

- Copy the platform project you need (in this case the iOS project folder) into your existing solution folder using Finder.

- Open your existing solution, right-click Add existing project and then choose the new project.

- Because the new solution you made had the same name, the namespace and other settings should all match, and the references should 'just work'. If the reference to the common code didn't work, delete and re-add it. Also don't forgot to synchronize the version of Xamarin.Forms NuGet being used.

``` 
Note: it is also possible to just create a 'new' iOS project, add the Xamarin.Forms NuGet and 
then copy the required AppDelegate.cs code from another Xamarin.Forms solution, 
but I find the above process easier.
```


## Architecture
The Model-View-ViewModel (MVVM) pattern helps to cleanly separate the business and presentation logic of an application from its user interface (UI). Maintaining a clean separation between application logic and the UI helps to address numerous development issues and can make an application easier to test, maintain, and evolve. It can also greatly improve code re-use opportunities and allows developers and UI designers to more easily collaborate when developing their respective parts of an app.
There are three core components in the MVVM pattern: the model, the view, and the view model. Each serves a distinct purpose.

<p align="center">
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/mvvm.png" width="70%" height="70%"/> 
</p>

## Functionalities
**1. Add New Contacts**
**2. Edit Existing Contacts**
**3. Shows List of contacts**
**4. Hamburger Menu**

<p align="center">
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/HamburgerMenu.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/ProfilePage.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/MessagePage.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/ContactPage.png" width="20%" height="25%"/>
</p>

**5. Call the contact directly**

<p align="center">
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/ContextAction.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/CallAction.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/CallOptions.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/DialPage.png" width="20%" height="25%"/>
</p>

**6. Delete Contact**

<p align="center">
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/ContextAction.png" width="20%" height="25%"/>
<img src="https://github.com/shankarmadeshvaran/Xamarin_MVVM/blob/master/ScreenShots/DeleteAction.png" width="20%" height="25%"/>
</p>

## Enhancements and Features
 Going to implement a **local database** to project -> To **Save** and **Edit** contact details for real time usage.
 I'll implement lot more features whenever something popup in my mind.
 
 ```
 As I mentioned above I have implemented local database to this project and pushed it into new repo named Xamarin_Contacts. Go ahead and refer that repository link which I mentioned below. I have implemented
 local database SQLite and developed in MVVM architecture(Mostly every features are fall under MVVM).
 Consider star the repo if you like it.Thanks
 ```
 [**Xamarin_Contacts Repository(Used SQLite and also in MVVM Pattern)**](https://github.com/shankarmadeshvaran/Xamarin_Contacts)
 
 ## Issues
 I'll constantly update this project whenever I find the great coding standards and better architecture. I still getting feedback abovt my MVVM project structure. So when you came across any error or better method to do code , feel free to raise a issue or contact me via [Twitter](https://twitter.com/Shankar__am)

## More Updates
Follow me on [Twitter](https://twitter.com/Shankar__am) to get the latest update about features, code and more. 
Consider star the repo if you like it. 

## References
1. [MVVM Pattern](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm)
2. [Getting started with Xamarin Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
