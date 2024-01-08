# Addressable Sprite Loader

This script was developed in 2021 during the Quadroom game development. It utilizes the Unity Addressables system to load sprites into a `SpriteRenderer` from memory.

## Usage

1. Attach the `AddressableSpriteLoader` script to a GameObject in your Unity project.
2. Assign a sprite asset using the `loadableSpriteAsset` field in the inspector.
3. Attach a `SpriteRenderer` component to the same GameObject and assign it to the `spriteRenderer` field in the inspector.

## Important Note

Make sure to mark the checkbox "Addressable" on the sprites you intend to load using this script.

## Functions

### LoadSpriteFromMemory

This function initiates the loading of the sprite from memory. It checks if the necessary fields (`loadableSpriteAsset` and `spriteRenderer`) are assigned before starting the loading process.

### UnloadSpriteInMemory

This function unloads the sprite from memory by setting the sprite on the `SpriteRenderer` to `null` and releasing the handle obtained during loading.

### LoadingSpriteFromMemory Coroutine

This coroutine handles the asynchronous loading of the sprite asset using Unity's `Addressables` system. Once loaded successfully, it sets the sprite on the `SpriteRenderer`.
