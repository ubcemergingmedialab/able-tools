# Tools

This folder contains numbered folders, each containing a set tool, and a sample scene explaining how to use it.

## Tools

| # | Tool | Description |
| - | ---- | ----------- |
| 0 | Example | Brief sample of tool template and ideal documentation |

## Contributing

* When creating a new tool, make sure to fully comment all code involved. 
* Include a scene titled "Example" showcasing how to use the tool.
* Everything in the scene should be as intuitive and easy to under stand as possible. When instructions are unclear, make sure to include instructions using text meshes in the scene.
* All code should be in the "EML" namespace. When a tool occupies multiple scripts, bundle the scripts together under a seperate sub namespace for that tool.

## Sample Code Header

When writing a new script, include the below template above the class declaration. For the tested with section, include the Unity version you used to write the script. If possible, test with 2018.4, and only use newer versions if the script requires newer features.

```
/*
* Summary: Tool is for xyz
* Use: Attach script to xyz object. See example scene for detailed instructions.
* Tested with: Unity 2018.4, 2019.2
*/
```
