## Singleton

**Singleton** es un patrón de deseño creacional que nos permite asegurarnos de que una clase tenga una única instancia, a la ves que proporcioan un pinto de acceso global de dicha instancia.

**dotnet new console -o "AppSingleton"**

### Solución

Se tiene que seguir dos pasos:

-   Hacer privado el constructor por defecto para evitar que otros objetos utilicen el operador **new** con la clase Singleton.
- Crear un método de creación estático que actúe como constructor.
