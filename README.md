# Object Oriented Programming and C#

## Instructions

This repository contains challenges you to undertake in pairs on C#.

(The instructions below assume you have got your laptop setup ready for running C# applications as per the pre-journey)

To get started you should "fork" this repository into your own Git account and the clone down to your machine.

Once cloned you can run the tests by running:

```
dotnet restore
```

followed by 

```
dotnet test
```


You'll see that all the tests are currently failing.

Working in your pairs you job is to one by one fix the failing tests.

We recommend working on one persons machine during pairing but once your session has ended send over the code to your pair so that you both have a copy.

## Some facts about your objects

The objects you'll be working with are all types of Cat

Here's some facts about Cats....

By definition the blueprint for ALL cats is that they can do the following things:

    * Eat
    * Sleep
    * Run

They ALL have the following attributes

    * A piece of data that says whether they are asleep or not 
    * An average height represented in centimetres
    * A piece of data that indicates their setting such as "domestic" or "wild"
    * ALL cats go to sleep exactly the same way

After a cat has eaten its food their reaction tends to differ between species

    * A Lion will let out a victorious roar
    * A cheetah will let out a snoring sound as it becomes tired following a chase
    * A domestic cat tends to let our a purring sound


As a bonus exercise some domestic cats will randomly let out a dismissive "It will do I suppose" comment following eating.

We've created the Cat interface to get you started 

## Your solution should have...

* The usage of a C# interface

* The usage of a C# abstract class

* The usage of encapsulation, abstraction, polymorphism and inheritance