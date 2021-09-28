## What is inheritance ?
<br> Inheritance in biology is the same as inheritance in software.
<br> In software, we add features to subclasses through parentclasses.
<br> parentclasses must have common properties to inherit.

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
