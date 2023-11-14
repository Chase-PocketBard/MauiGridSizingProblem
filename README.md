# MauiGridSizingProblem
## Overview
The `GridItemsView` for .NET MAUI `CollectionView` has some strange behavior. Two separate issues are equally illustrated by this project:
### Issue 1
When loading items into the GridItemsView that contain images hosted at an external URL, the images do not load until the window is resized (or, on mobile platforms, the orientation changes).
This is a problem on:
- Windows
- MacCatalyst
- iOS

### Issue 2
When resizing the window (or changing orientation on mobile platforms), the relative proportions of items are preserved on Windows, but not on MacCatalyst or iOS.
This is a problem on:
- MacCatalyst
- iOS

## Setup
Follow the steps to run a typical .NET MAUI project on desired platform.

## Repro Steps
### Windows
1. Run on Windows
2. (Optional) Scroll down and load a few extra items
3. Resize the window

#### ✖️ Issue 1
Expected Result: As items load images, `GridItemsView` cells are resized to accommodate images (including at startup)

Actual Result: Grid cells are not resized until the entire window is resized

#### ✔️ Issue 2
Expected Result: Grid items maintain their relative size and proportions, while the entire grid container resizes to fit the screen

Actual Result: As Expected

### Android
1. Run on Android device or Emulator
2. (Optional) Scroll down and load a few extra items
3. Change device orientation

#### ✔️ Issue 1
Expected Result: As items load images, `GridItemsView` cells are resized to accommodate images (including at startup)

Actual Result: As Expected

#### ✔️ Issue 2
Expected Result: As device orientation changes, grid items maintain their relative proportions, while the entire grid container resizes to fit the new allocated space

Actual Result: As Expected

### MacCatalyst
1. Run on Mac device
2. (Optional) Scroll down and load a few extra items
3. Resize Window

#### ✔️ Issue 1
Expected Result: As items load images, `GridItemsView` cells are resized to accommodate images (including at startup)

Actual Result: As Expected

#### ✖️ Issue 2
Expected Result: As screen size changes, grid items maintain their relative proportions, while the entire `CollectionView` container resizes to fit the new allocated space

Actual Result: Grid cells are resized horizontally, but maintain their vertical space, changing the height/width their contents to fit.

#### Video

https://github.com/Chase-PocketBard/MauiGridSizingProblem/assets/115745354/66580846-0acb-4ff5-a718-69ca8009092f

### iOS
1. Run on iOS Simulator or device
2. (Optional) Scroll down and load a few extra items
3. Change device orientation

#### ✖️ Issue 1
Expected Result: As items load images, `GridItemsView` cells are resized to accommodate images (including at startup)

Actual Result: Images are shown, but are warped in height (as if it's trying to display them at "actual" scale, rather than a pixel-density-appropriate scale?)

#### ✖️ Issue 2
Expected Result: As device orientation changes, grid items maintain their relative proportions, while the entire grid container resizes to fit the new allocated space

Actual Result: Grid cells are resized horizontally, but maintain their height, changing the height/width ratio of their contents.

#### Video

https://github.com/Chase-PocketBard/MauiGridSizingProblem/assets/115745354/7a820175-cd23-4c1c-9eb7-22567bef64c1

