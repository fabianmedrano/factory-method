# factory-method

The Factory Method pattern is useful when you want to decouple the creation of objects from their use. In the game code you don't need to know how military units are created, you just need to know how to use them. This allows you to change the way units are created without having to modify the game code. For example, if in the future you want to add a new type of military unit, you would only need to create a new subclass of MilitaryUnit and a new factory for that subclass, without having to modify the game code.
