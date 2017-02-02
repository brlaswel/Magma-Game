#Magma Documentation

###A document on how the code for 'Magma' works

Magma is a game developed in Visual Studios by Anthony Freitas, Brandon Laswell, and Ryan Goodman. In order to play the
game a user would need a copy of the executable files and the appropriate .dll files necessary for the game to run. In
the code we use the libraries associated with the Rectangle class. These "Rectangles" act as image boxes that you may
assign operations to. Each rectangle is designed a specific tag and is then placed onto the grid that is the game's
background. The rectangles picture get implemented in their own special class in the Enviroment.Tiles namespace. These
pictures are inputted from a resource folder appropriately.

####The "Enviroment" namespace deals with all the "tiles" or individual rectangles to be placed on the grid. 
The class "Image
Uploader" deals with specific intereactions that happen to tiles themselves in which a change to their appearance happens.
For example: inside of the class are functions that cause the button to shift from it's starting position, to an indented
position that indicates it has been pressed. This function indicates when this should happen and which tag to change it to.
Another example is the function that is related to the "ButtonDown" function; which is the ButtonUp function that does the
same thing only with the reverse effect. The last type of image to get updated in the "Image Uploader" class are the flames.
Both sets of flames are designated a tag based on if they are red flames or blue flames. These flames are then able to be
turned off if the corresponding button is pressed. This procedure is broken up into two functions: FlameOff and FlameOn. The
FlameOff functions take in the string that is associated with which color button is pressed, and which level the pressed 
button is on, and then proceeds to turn off all the flames on that level accordingly. This is the same for the FlameOn button
except it is not called when a button is pressed, rather it is called 10 seconds after the button has been pressed and then
turns all the flames back on.

Also inside the "Enviroment" namespace is the "Tile" class. This is the class that assigns each rectangle it's properties.
Each rectangle is turned into a tile by creating the image to be 40 x 40 with a designated x-location and y-location value
in place when created. It is also responsible for assigning which picture goes to which rectangle, and which tags are assigned
to what rectangles. This is all done to each piece on the map so that everything fits in the grid accordingly and is easier to
manage.

The "TileBuilder" class in the "Enviroment" namespace designates what the rectangles are when they are built into the program,
creating the appropriate "tile" for it.

The last class in the "Enviroment" namespace is the "TileSorter" class. This class stores all the tiles in a series of arrays
based on the tile's assigned flag. So if the flag assigned to the array is the same as an obstacle, it will block the player's
movement. If the flag is designated as a hazard, it will remove a life if the wrong color player touches it. It also allows
toggles to turn off when activated by the same color player. Lastly, it allows two exits to be on the level that can be accessed
by either color player, but must be accessed by both at the same time to advance to the next level.

####Another namespace is the "Control" namespace. 
The "Control" namespaces has two classes: the "Interaction" class and the "Movement" class.

The "Interaction" class handles all tile interactions in the game, including collision detection.Operations return true if there 
is an intersection between the passed rectangle and any rectangle in the chosen array

The "Movement" class handles movement of the player characters and calls appropriate collision operations. Each player can move
one of four directions, up, down, left, or right. When a key is pressed, a keylistener in the "GameWindow" class calls the
function that is matched with the pressed key in the "Movement" class and proceeds to move or not move depending on what lies
in the tile that the players would be moving to.

####The "Game" namespace has 3 classes in it, along with a subdirectory called "Levels" that has 3 more classes in it.

In "Game.Levels", there are 3 classes named Level1, Level2, and Level3. Each level creates a new window that populates a grid
based on the information provided. Each level starts off with 4 rows of walls that block off the edges of the map, and then is
uniquely populated with at least one Red Magma, one Blue Magma, two staircases, one red button, one blue button, and an 
assortment of red/blue flames and walls. Each level also must have a timer set that will continue to count down until it reaches
0.

Outside of the "Game.Levels" namespace are the three other classes. One of which being the "Level" class. This is the parent class 
that new levels must inherit. All operations for building levels are contained here. Stores created tiles in a multidimensional 
grid and then sends them to the TileSorter class. To create new levels You would have to add a level to the "Levels" folder and
populate it there.

Another class in the "Game" namespace is the "GameManager" class. This class keeps track of important in-games events, such as:
decrement lives when a hazard is struck, decrementing the clock, checking to see if a toggle can be activated or not, checking to
see if the victory condition has been met, setting the lives, determining the current level displayed, and deactivating the toggle.

The last class in this namespace is the "LevelBuilder" class. This class stores the functions to be called in the "Game.Level"
classes so that the grid on each level is appropriately populated with the right tiles in the correct location. It has a border that
automatically populates each level, and then contains functions to add each individual player, any generic tile, and also contains
a fuction that creates a row of tiles in a user-defined direction for a user-defined set of tiles.

All of this code works together to create the game known as "Magma".
