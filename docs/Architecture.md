#MAGMA
##Software Architecture Document
Reversion History


|Date|Version|Description|Authors|
|----|-------|-----------|-------|
|10/9/16|1.0|Sprint 2 doc|Brandon, Ryan, Tony|


#Table of Contents
1. Introduction
  1.1 Purpose
  1.2 References
  1.3 Glossary
2. Architectural Overview
3. Architectural Goals and Constraints
4. View
  
#1. Introduction
**1.1 Purpose**
  
  This document provides a comprehensive architectural overview of the game MAGMA's system. 
  It's intent is to convey the architectural decisions made on the system.

**1.2 References**
  
  None at this time.
  
**1.3 Glossary**
  
  None at this time.
  
#2. Architectural Overview

This document presents the architecture as a sequence diagram that breaks down the build of the game into more detailed segments.
This displays the major parts to the code and breaks it down to see how they are focused on differently, but all lead towards
building the one game.

#3. Architectural Goals and Constraints

Goal: To provide the users with a challenging strategy game where they must get two players moving in unison to seperate locations
on the map.

Constraints: The sprites must move in unison. So while one set of controls will be used for both sprites, the sprites are independent
and should not be affected the same why by each other's obstacles.

The map should interact with the characters appropriately (i.e. user should not be able to walk through a solid wall).

#4 View

![Architecture Diagram](/architecture.png)
