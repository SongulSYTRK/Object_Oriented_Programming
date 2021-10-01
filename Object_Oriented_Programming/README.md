## What is Class ?
<br> It is the whole brought together by members who have common characteristics.
<br< It is a system that stores variables and methods together.
<br> Our class need Access Modifiers. If you dont have access modifiers, you dont see properties of class .
<br>     Access Modifiers(Erişim belirteçleri) 
<br> 1:Public: You see all solution                                                                                                                                         <br> <br> 2:private :you see this class                                                                                                                                                 <br> 3:internel: If you dont define access modifiers , your objects modifiers internal .you see this project
   ```
public class Computer 
{

 public string cpu; 
 public string displaycard;
 public int memoryCapacity;
 public string displayScreen;
 
 }
 ```
 
 ## What is Constructor ?
 It determines the Instance taking rules according to which conditions in the class we created.
 Each class have constructor . you dont write any constructor, it has empty constructor in background
 The constructor method is used to initialize our class.The constructor method will be triggered when the class is instantiated, making the class ready for use and initializing it. 
 Constructor's name has to be same with class name 
 
 You can define more overload 
 ```
  public class Car    //Class
    {
        //property shortcut prop+tab+tab
        public string Brand { get; set; }
        public string EngineSize { get; set; }
        public string Model { get; set; }
        // constructor shortcut ctor+tab+tab
        
   public Car(string marka ) // constructor 
 {
            this.Brand = marka;
            
  }      
 
  ```

