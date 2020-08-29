# MvxXFModalNavigation
This project is for demonstration purposes only. It demonstrates the behaviour of modals inside applications written in Xamarin.Forms using MvvmCross.

This app has 4 screens: A, B, C and D. Screen C an D are decorated with a `[MvxModalPresentation]` attribute.

- Screen A can navigate to screen B
- Screen B can navigate to screen C (which will open as a modal)
- Screen C can navigate to screen D (which will open inside the already opened modal)

## Expected behavior
- When the user is on screen C (the first page inside the modal), the user can not go back using a back button.
- When the user is on Screen D (the second page inside the modal), the user can go back to screen C using a back button.

## Actual behavior

### ✔ iOS
Applicaion works as expected. There is no back button on screen C. There is a back button on screen D that navigates back to screen C.

### ✔ UWP
Applicaion works as expected. There is no back button on screen C. There is a back button on screen D that navigates back to screen C.

### Android
A user can navigate back to a previous screen on two ways. Using the back button provided by the application and using the back button provided by the system.

#### ✔ back button provided by application
Navigating back is done by using the back button in the top left of the application. When using this button, the applicaion works as expected. There is no back button on screen C. There is a back button on screen D that navigates back to screen C.

#### ❌ back button provided by the system
Navigating back is done by using a hardware back key, software back button at the bottom of the screen or by system-wide gestures. When using this button, the application **does not work as expected**.
- When the user presses the back button on screen C, the modal closes.
- When the user presses the back button on screen D, the modal closes also in stead of returning to screen C. User is back at screen B.
