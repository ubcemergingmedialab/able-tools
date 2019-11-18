# 2. Floor Scaler

The floor scaler tool provides general, cross platform tools for incorporating the room scale walkable area into a VR environment

The tool comes with two primary components:
* FloorObjectScaler.cs - A monobehaviour script that scales the attached object. Configurable via an optional height override
* Floor.prefab - A prefab quad that displays the convex hull of the play area. Useful for displaying visible walkable area