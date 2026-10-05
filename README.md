# Flappy Bird Clone

A small, in-progress Flappy Bird-style game project made with Unity. The current project is a 2D setup using Unity's Universal Render Pipeline and includes a sample scene with a physics-based player controller.

## Current Features

- Click the left mouse button to apply upward movement to the player.
- A `Rigidbody2D`-based controller with a jump force adjustable in the Inspector.
- `SampleScene` configured as the project's build scene.

This is an early project foundation; pipe obstacles, scoring, menus, and finished game art are not included yet.

## Requirements

- Unity `6000.6.0f1` (Unity 6)

## Open the Project

1. Clone this repository.
2. In Unity Hub, choose **Add project from disk** and select the `Flappy Bird Clone` folder in the repository.
3. Open `Assets/Scenes/SampleScene.unity` and press Play.
4. Click in the Game view to make the player move upward.

Unity will restore the packages listed in `Flappy Bird Clone/Packages/manifest.json` when the project opens.

## Project Layout

```text
Flappy Bird Clone/
  Assets/
    Scenes/SampleScene.unity
    Scripits/PlayerController.cs
    Settings/
  Packages/
  ProjectSettings/
```

The `Scripits` directory name is preserved as it currently exists in the Unity project.