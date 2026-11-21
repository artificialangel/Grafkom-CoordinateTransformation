# Grafkom - Coordinate Transformation

Project Unity 3D untuk mata kuliah Grafika Komputer: demo Sistem Koordinat dan Transformasi.

## Struktur Folder

| Folder | Isi |
|--------|-----|
| `Assets/Scripts/` | Script C# untuk demo |
| `Assets/Materials/` | Material warna untuk objek di scene |
| `Assets/Scenes/` | Scene Unity (`SampleScene`) |

## Script

| File | Dipakai untuk |
|------|---------------|
| `CoordinateSystemDemo.cs` | Demo Coordinate System: menggambar sumbu X, Y, Z dan mencetak nilainya ke Console |
| `PositionDemo.cs` | Demo Position: membandingkan `position` dengan `localPosition`, serta `Translate()` dengan `Space.World` dan `Space.Self` |
| `ScaleDemo.cs` | Demo Scale: membandingkan `localScale` dengan `lossyScale`, dan scaling per sumbu X, Y, Z |
| `HierarchyDemo.cs` | Demo Hierarchy: pengaruh geser, putar, dan scale parent terhadap child |
| `RotationDemo.cs` | Demo Rotation: rotasi per sumbu, `eulerAngles` vs `rotation` (quaternion), gimbal lock dan cara menghindarinya |
