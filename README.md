# Archive of Queer Care - Dancefloor Platform

## Overview

This is a virtual web archive documenting the history of queer care around the US through decades.

Author: Malika Buribayeva, Archer Benedict, Prof. Joseph Amodei.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Unity Hub is installed on your machine.
- A compatible version of Unity installed through Unity Hub (Unity 6 or higher).

## How to Run

Follow these steps to run the project on your machine:

1. Clone the repository.
2. Add the project root folder as a Unity project on Unity Hub.
3. Open the project on Unity Hub.
4. In the hierarchy, you should see the ARENA game object with two scripts: Arena Client Scene and Arena MQTT Client. If it's not there, follow the unity-library usage instructions here:
    ```https://docs.arenaxr.org/content/unity/```
5. To run any ARENA-based projects on Unity, it is necessary to sign in to ARENA through the ARENA game object. Follow these instructions to access the Editor mode on Unity and log in with your credentials:
    ```https://docs.arenaxr.org/content/unity/editor.html```


## How to Edit

There are the following limitations of how Unity could be used to modify the ARENA project:

1. As of 1 October, 2024, it is only possible to edit the objects added to the scene that are pulled from the Persistence Database through the ARENA file system. To be able to see the objects in a Unity scene, you need to add the objects on the ARENA web editor first and attach the Dropbox links with 3D assets to them. Read more here:
    ```https://docs.arenaxr.org/content/architecture/persistence.html```

2. Editing a scene is only possible during Runtime, as Unity pulls data from ARENA in live. Run the scene and update the necessary parameters of objects, then export the models with glTF Export. Details found here:
    ```https://docs.arenaxr.org/content/unity/models.html```

3. Update the scene objects, **still in the Runtime mode** , by using the *Publish Unity Data* and *Publish json Data* options, so the object info is updated on the ARENA side when you run it on the web. More details here:
    ```https://docs.arenaxr.org/content/unity/objects.html```

4. You can stop Runtime when you are done editing after making sure the objects were updates. Run the project again if more things need to be added or changed.

P.S. ARENA Documentation suggests that any type of Unity GameObject could be added to ARENA if an ArenaObject script is attached to it. This is not entirely true, since ARENA still has to recognize Unity GameObjects as some type of ARENA objects when viewing the web editor. The light maps, for example cannot be transfered to ARENA, but it is possible to add navigation meshes, so it's important to monitor ARENA updates.
