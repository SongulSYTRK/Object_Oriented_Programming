## What is inheritance ?
<br> Inheritance in biology is the same as inheritance in software.
 In software, we add features to subclasses through parentclasses.
parentclasses must have common properties to inherit.
It is the process by which object of one class aquire the properties or features of objects of another class. The concept of inheritance provide the idea of reusability means we can add additional features to an existing class without Modifying it. This is possible by driving a new class from the existing one. The new class will have the combined features of both the classes. Example: Robine is a part of the class flying bird which is again a part of the class bird.

 ```
 public class Category : parentsclass  // parentsclass is ancestor of the category.We added it as a using system 
 
 
 ```
 
 ## Override 
 It is the structure in which we give new abilities to the abilities from the ancestor class by overriding the ability loaded on it in the subclass.If you write with vitual , you can do override into subclass.
 
  ```
  public virtual string CallSound() => "Generally phone's sound  ";   // We write in parentclass 
 
  ```
 
  **How can we override ?**
   ```
  public override string CallSound()
        {
            return "Nokia telefon sesi ";
        }
   public override string ShowInformation() => base.ShowInformation() + $"Anten : {this.Anten}";
 
   ```
