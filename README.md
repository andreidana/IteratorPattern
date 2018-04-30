# IteratorPattern

**Definition** 
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

**Applicability**
Use the Iterator pattern 

- to access an aggregate object's contents without exposing its internal representation.  
- to support multiple traversals of aggregate objects.  
- to provide a uniform interface for traversing different aggregate structures (that is, to support polymorphic iteration). 

**Consequences**

- It supports variations in the traversal of an aggregate
- Iterators simplify the Aggregate interface
- More than one traversal can be pending on an aggregate

**Related Patterns**
