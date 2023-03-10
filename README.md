# Emerald AI 3.0 :electron:
## Repository for implementing Emerald AI with Hurricane VR

### **26 January 2023**

Today We started working on Emerald AI integration with Hurricane VR for our upcoming VR multiplayer title, Hexagonia.

The game will involve a two-tier system, whereby the player will have to switch between the roles of a base builder, which will be a more relaxed birds eye experience and that of a defender which will carry the player to the "trenches" of combat on the map in 1st person mode.



https://user-images.githubusercontent.com/3580918/214931763-45e959cc-5208-4c8f-87ad-a6ff55c2b385.mp4

As part of the initial work, We are adding different animations to the soldiers that will attack and defend the other players on the map, which the player will be fighting alongside in the "defender" mode. 

Next work will involve utilizing Emerald AI to make these two soldiers find and attack each other on their random patrols.

---

### **29 January 2023**

We installed Emerald AI and setup two soldiers, one male and one female with different factions that are set as enemies. All the combat and movement attacks, the needed behaviors as well as the navmesh setup is in place. However, We cannot get them to fight yet :)



https://user-images.githubusercontent.com/3580918/215336285-72f7d38f-26a8-47a7-99c3-82c58395db28.mp4

We will have to figure out what is causing them not to see / engage with each other.

### **30 January 2023**

Emerald AI 3.0 is now implemented correctly. Posting 1v1 and 3v3 combat scenario videos below:


https://user-images.githubusercontent.com/3580918/215542306-b9dc6aca-94ea-4f0e-9341-514616b03c7d.mp4


https://user-images.githubusercontent.com/3580918/215542449-56d865ee-1976-4855-9751-30266dbf126c.mp4


### **31 January 2023**

We integrated our Hexagonia base map with Emerald AI and now the soliders obey the rules of impassable terrain (the mountains in this case) in their navigation:


https://user-images.githubusercontent.com/3580918/215926214-90e21d2e-d858-41b5-832b-d8a2b72ec400.mp4


### **4 February 2023**

The Emerald AI basic integration & patrolling on Hexagonia map is done. We now have 6 unique soldier types with own animations, who patrol their "zone" and engage with enemies that get within their detection range (usually players on left and right). 

We tried to capture both the birds eye view action as well as a close up by recording the Unity window:
![Hexagonia 6Party GIF](https://user-images.githubusercontent.com/3580918/216798841-d0e9e01f-4d93-42b7-8818-d9c29deb07c4.gif)

High res, longer recording can be found below: 

https://www.youtube.com/watch?v=yH042BskNw4

Next steps will involve despawning soldiers after death after a predetermined time, as well as hooking into OnDeath events to tally scores for each player in this simulation of AI wars.

### **7 February 2023**

We were able to get the score calculation & displaying, however the OnKillTarget event is adding score for every attacker on a single target - i.e. if 3 soldiers are attacking an enemy soldier and one of them kills the enemy, all 3 get scores! Emerald AI support team sent us a fix which we should hopefully implement and test.

Meanwhile, we were able to implement the non-AI target feature which we will need for Hexagonia tiles to be destroyed by soldiers.


https://user-images.githubusercontent.com/3580918/217333866-6a8f131c-8247-499c-82df-64eff4e88369.mp4

Took us a while to figure out that the non-AI target requires a collider (not written in tutorial!) but now it is working as intended!

UPDATE 2: 

The score keeping system is fixed, now each kill, regardless of how many AI-agents were fighting, counts as 1 score:

https://user-images.githubusercontent.com/3580918/217378557-3cb4f49a-20fb-4ab1-aa07-5b286ad2a3a7.mp4


### **8 February 2023**

Instead of displaying the score in the top right corner "the old school way", we thought about novel ways to utilize XR for a different way to inform the players about the current score. One idea was to utilize "flags" and use the flag color/height as a quick way to inform who is leading and who is behind. 

Here is how it looks in practice:

![hexagon flags](https://user-images.githubusercontent.com/3580918/217621833-6a4228d6-ae7e-44a6-982e-130cfa0869be.png)

Adding score values to the Y scale value of the flag prefab gives the desired effect, however we will need to adjust the multiplier for something that is not as dramatic:

https://user-images.githubusercontent.com/3580918/217623337-6fa4cee6-c234-4e3b-8432-fbb5ac00e459.mp4



