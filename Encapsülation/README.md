## Encapsülation 
When we want external access to any member of the Class, we use encapsulation when we want to access indirectly in line with a certain condition.
 When we want to control access, we manipulate get and set methods to properties.
 When we want to get the value held on the property, we use the get method, and when we want to assign a value, we use the set method.

<br>Data Hiding: The user will have no idea about the inner implementation of the class. It will not be visible to the user that how the class is stored values in the variables. He only knows that we are passing the values to accessors and variables are getting initialized to that value.
<br>Increased Flexibility: We can make the variables of the class as read-only or write-only depending on our requirement. If we wish to make the variables as read-only then we have to only use Get Accessor in the code. If we wish to make the variables as write-only then we have to only use Set Accessor.
<br>Reusability: Encapsulation also improves the re-usability and easy to change with new requirements.
<br>Testing code is easy: Encapsulated code is easy to test for unit testing.


<br> private int _age;    //  we closed access
