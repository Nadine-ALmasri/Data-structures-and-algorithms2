# LinkedList
This code provides an implementation of a singly linked list in C#. It includes a Node class that represents a node in the linked list, and a LinkedList class that manages the list operations.

## Summary
The linked list implementation provides the following functionality:

- Creation of an empty linked list
- Insertion of nodes at the head of the list
- adds a new node with the given value to the end of the list
- adds a new node with the given new value immediately before the first node that has the value specified
- adds a new node with the given new value immediately after the first node that has the value specified

## Description
The Node class represents a node in the linked list. It has two properties: Value, which stores the value of the node, and Next, which points to the next node in the list.

The List class manages the operations on the linked list. It has a Head property that points to the first node in the list. The class provides the following methods:

- AddFirstList(int value) ,AddLastList(int value) : Inserts a new node with the given value at the head or the tail of the linked list.
- 
## Approach & Efficiency
- Insertion: The Insert method adds a new node at the head of the linked list. It has a time complexity of O(1) since it always inserts at the beginning of the list.
## Solution:
The provided code implements the LinkedList class with the required methods to append nodes at the end, insert nodes before a specified node, and insert nodes after a specified node. The methods traverse the linked list and update the references accordingly to perform the desired insertions. The implementation ensures proper error handling, such as throwing exceptions when necessary (e.g., if a value is not found).







