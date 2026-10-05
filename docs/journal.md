No.2 Endless Runner (Procedural Biomes) - chunk generator, difficulty curves, pooling. Vertical-slice by W6: 1 biome, 10+ chunks, mission system, Android device build. 

I am creating a endless runner where the player will fight enemies by jumping, attcking them then dashing to attck the next one. The Game will have multiple characters with differnt attacks

Core Verb: Dash

One thing to cut: Differnt characters.

Week2

**CPU**

CPU: 15.96 ms
Rendering: 2 setpass calls
Memory: 4 Gc allocated in frame.

swipeDp = 50f
tapMax = .3f

| Test | Expected |
|------|----------|
| Press Home, wait 10 s, return | Paused, panel visible, audio silent, progress saved | ✅
| Pull the notification shade down and up | Paused |✅
| Neighbour calls you, you hang up | Paused, game resumes only on Resume |✅
| Screen off with the power button, back on | Paused |
| Force stop from Settings, relaunch | Progress restored from the save |✅

Week3

Worst-frame Main Thread: frame 1522 / 2254, 29.39 ms

Tallest PlayerLoop marker: Semaphore.WaitForSignal 13.00 ms
Top 3 Hierarchy Entries
Semaphore.WaitForSignal	13.00 ms
Render.Mesh 3.64 ms
Physics.SyncTransforms 2.34 ms

GC.Collect: No

**Rendering**

SetPass calls: 4
Batches (Draw calls): 0
Triangles: 3.1k
Vertices: 6.2k

Gfx.WaitForPresentOnGfxThread: 13.00 ms

**Memory**

Total Reserved: 249.8 MB
GC Allocated in Frame: 131 B
Textures: 64.3 MB
Meshes: 6.1 KB
Audio: 1.1 MB

*Snapshot:*
Largest Categories:
Android Runtime .93 GB
Executables & Mapped .7GB
Native 221.8 MB

full scale:
main thread ~16.75 ms
Gfx.WaitForPresentOnGfxThread : 9.99 ms

~16.75 ms
Gfx.WaitForPresentOnGfxThread : 7.01 ms

Verdict: CPU Bound, probable cause tallest plaerloop marker

