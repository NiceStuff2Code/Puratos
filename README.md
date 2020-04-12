# Puratos
information about Puratos application

### Structuur van de applicatie
1. Puratos-Domain: Business laag
2. Puratos-UI: Presentatielaag

__**Met daarbij de portabel, Android, IOS en UWP projecten.**__

### Gebruikte API's bij dit project
Het is dus zo dat we voor bepaalde functionalieiten een specifieke API hebben moeten gebruiken met hierbij een overzicht:

| API NAME            | beschrijving |
| -------------       | ------------- |
| Xamarin.Forms.Maps  | Zorgt voor een google maps widget |

### Gebruik van Xamarin.Forms.Maps
bij de business laag hebben we gebruik kunnen maken door 
```c#
using Xamarin.Forms.Maps; //Google Maps API specific code
```
aan de code toe te voegen.
