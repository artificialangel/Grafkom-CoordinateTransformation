# Grafkom - Coordinate Transformation

Project Unity 3D untuk mata kuliah Grafika Komputer: demo Sistem Koordinat dan Transformasi.

## Struktur Folder

| Folder | Isi |
|--------|-----|
| `Assets/Scripts/` | Script C# untuk demo |
| `Assets/Materials/` | Material warna untuk objek di scene |
| `Assets/Scenes/` | Scene Unity (`SampleScene`) |
| `Docs/` | Screenshot hasil demo |

## Script

| File | Dipakai untuk |
|------|---------------|
| `CoordinateSystemDemo.cs` | Demo Coordinate System: menggambar sumbu X, Y, Z dan mencetak nilainya ke Console |
| `PositionDemo.cs` | Demo Position: membandingkan `position` dengan `localPosition`, serta `Translate()` dengan `Space.World` dan `Space.Self` |
| `ScaleDemo.cs` | Demo Scale: membandingkan `localScale` dengan `lossyScale`, dan scaling per sumbu X, Y, Z |
| `HierarchyDemo.cs` | Demo Hierarchy: pengaruh geser, putar, dan scale parent terhadap child |
| `RotationDemo.cs` | Demo Rotation: rotasi per sumbu, `eulerAngles` vs `rotation` (quaternion), gimbal lock dan cara menghindarinya |

## Dokumentasi Hasil Demo

### Coordinate System (`CoordinateSystemDemo.cs`)

![Coordinate System](Docs/SS_Coordinate.png)

Script dipasang di GameObject kosong `CoordinateDemo`. Di Scene view terlihat tiga garis dari titik origin: merah (sumbu X), hijau (sumbu Y), dan biru (sumbu Z). Console mencetak arah ketiga sumbu serta hasil `Cross(X, Y) = (0, 0, 1)` pada sistem koordinat Unity (left-handed, Y up).

### Position (`PositionDemo.cs`)

![Position](Docs/SS_Position.png)

Script dipasang pada object Child. Klik kanan komponen **Position Demo (Script)** di Inspector untuk memilih demo: **Log position vs localPosition**, **Translate (Space.World)**, dan **Translate (Space.Self)**.

### Scale (`ScaleDemo.cs`)

![Scale](Docs/SS_Scale.png)

Script dipasang pada object Child. Klik kanan komponen **Scale Demo (Script)** untuk memilih demo: **Log localScale vs lossyScale**, **Scale sumbu X saja**, **Scale sumbu Y saja**, **Scale sumbu Z saja**, dan **Reset scale**.

### Rotation (`RotationDemo.cs`)

![Rotation](Docs/SS_Rotation.png)

Script dipasang pada object Child. Klik kanan komponen **Rotation Demo (Script)** untuk memilih demo: rotasi sumbu X, Y, Z, **Euler: set eulerAngles**, **Quaternion: set rotation**, **Gimbal lock (Euler X = 90)**, dan **Hindari gimbal lock (Quaternion)**. Pada screenshot, nilai Rotation Child berubah menjadi X = 45 setelah **Rotasi sumbu X**.