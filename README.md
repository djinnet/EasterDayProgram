# EasterDayProgram
This windows form project is develop in Visual studio 2022 and with .NET 6.0 version.

This is mainly used as answer to an coding test with OnlinePOS company.

The Project is made in two parts:
App
- windows form project
HolidayLibrary
- class library which contains the calculation for easter

The design of the form contains of datetimepicker, button, and labels.
 
There is an easter icon in the resource folder.

The text in the form is in Danish, but the code is in english.

# User manual:

* Select a year in the year inputfield. There is a limit from 1753 to 9998.

* Then press the button with the text "Search for Easter Day".

* The result should appear in large text.

# Image of software:
![image](https://user-images.githubusercontent.com/9974608/159710002-f6a8c82e-2539-4286-b76c-5f6040c2bda5.png)


# Flowchart of the software:
```mermaid
graph TD
    A(Software loads up) -->B[User selected the year]
    B --> C[User pressed button 'Søg efter påskedag']
    C --> D[Get the selected year]
    D --> E[Do easter sunday calculation with the selected year]
    E --> F[Get datatime object from the easter sunday calculation]
    F --> G[Format datetime into string with dateformat 'dddd, dd MMMM yyyy' for da-DK CultureInfo]
    G --> H[Set dateformat string into result label.]
    H --> J{User}
    J --> |Retry on another year| B
    J --> T(stop / close the software)
```


Credit: Djinnet
