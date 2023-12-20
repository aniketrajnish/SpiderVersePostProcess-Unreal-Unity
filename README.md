# SpiderVersePostProcess-Unreal-Unity
 Spiderverse-inspired stylized post-processing effect for Unreal Engine and Unity.
 
https://github.com/aniketrajnish/StylizedPostProcess-Unreal-Unity/assets/58925008/47c07dc8-42ae-4418-99b3-5e1c68463bd9

## Usage
### Unity
* Download the `.unitypackage` from the [Releases Section](https://github.com/aniketrajnish/StylizedPostProcess-Unreal-Unity/releases/tag/v001-unity).
* Open/Create a new URP Unity project.
* Import the package into the project.
* Enable the Stylized Renderer Feature in your URP Renderer (generally in `Assets/Settings` folder) by adding the `Stylized Renderer Feature` to the Renderer Features.
* Control the Renderer Feature's properties by adding a `Global Volume` component to your scene.
* Add `Makra/Stylized PP` override to the Volume component. The custom post-processing contains the following components-
  
  | Property           | Description                                                                                       |
  |--------------------|---------------------------------------------------------------------------------------------------|
  | **Threshold**      | Minimum brightness for the effect to be applied                               |
  | **Intensity**      | Strength/Brightness of the effect                                                              |
  | **Scatter**        | How much screen space the effect occupies                                             |  
  | **Dots Density**   | Density of the benday dots                            |
  | **Dots Cutoff**    | Cutoff value of benday dots                                 |
  | **Scroll Velocity** | Velocity of the dots scrolling over the screen                  |
* You can use the Unity Project in `src/UnityStylizedPP` for reference.

https://github.com/aniketrajnish/SpiderVersePostProcess-Unreal-Unity/assets/58925008/5b4cba4b-7982-4098-b80e-482948f007dc

### Unreal Engine
* Download the Unreal Project from the [Releases Section](https://github.com/aniketrajnish/SpiderVersePostProcess-Unreal-Unity/releases/tag/v001-unreal).
* Use the map in the Unreal Project as a reference.
* To implement the stylized post-processing in your project, migrate the `Content/StylizedPP` from the project you downloaded above to your Unreal Project.
* Add a `PostProcessVolume` component to the level.
* Make sure that `Infinite Extent` is checked in the Post Process Volume Settings.
* Assign the `M_PP_Stylized_Inst` material to the Post Process Materials.
* Control the post process properties by going to thet `M_PP_Stylized_Inst` and changing the following parameters-
  
  | Property             | Description                                                                                                                                                           |
  |----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|
  | **Benday Clip**      | Minimum brightness for the effect to be applied                                                |
  | **Density Benday**   | Density of the benday dots                                        |
  | **Density Line**     | Density of the hatching lines                                             |
  | **Direction Benday** | Direction of Benday Pattern                                                |
  | **Direction Line**   | Direction of Hatching Pattern                    |
  | **Spec Mult**        | Intensity and spread of specular highlights                                                        |
* To create a stencil mask for the benday dots to be applied only on specific objects, go to project settings and change the `Custom Depth-Stencil Pass` to `Enabled with Stencil`.
* In the mesh that you want to render the benday dots upon, enable the `Render CustomDepth Pass` option and change the `Custom Stencil Value` to 1.
 
https://github.com/aniketrajnish/SpiderVersePostProcess-Unreal-Unity/assets/58925008/040f165c-beb3-4eb2-b466-0c11bd1f2c14

## Contributing
Contributions to the project are welcome. Currently working on:
* Fixing glitches with persistent shadows in UE5.
* Add hatching lines to the shadows in Unity.
  
## License
MIT License
