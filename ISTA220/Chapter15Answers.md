# ISTA220 C# Chapter 15 Homework

### Ryan Oberlin

1. What is the difference between a property and a field?
*properties evaluate and access data. fields store data.*

2. What is the difference between a property and a method?
*a property is a field that acts like a method*

3. What is your understanding of encapsulation?
*encapsulation protects or prevents unnecessary data from being accessed by the user.*

4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?  
*The need for standards in naming conventions so multiple people can work on the same project with less confusion. Yes.*  

5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property.  
*File System design.
Data logging/journaling*

6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.

7. What are restrictions on the use of properties?
*A property name is an Identifier, which is a text string that must begin with either a letter or an underscore. Identifiers and property names may contain letters, numerals, underscores, or periods; but cannot begin with a numeral or period.
Public property names cannot contain lowercase letters.
Private property names must contain some lowercase letters.
Property names prefixed with % represent system and user environment variables. These are never entered into the Property table. The permanent settings of environment variables can only be modified using the Environment Table.*

8. What is an object initializer? What is the syntax for an object initializer?  
*it assigns values to fields or properties. Object object = new Object {stuff, things};*
