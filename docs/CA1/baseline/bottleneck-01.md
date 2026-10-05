Bottleneck-01

**What**: Game spends a huge amount of time renderig cube meshes
**Where**: PlayerLoop: Render.Mesh
**Numbers**:
Main Thread: 29.39 ms
Setpass Calls: 4
GC allocated: 131 B
**Verdict**:
CPU bound, reducting render scale did not improve frame time, so GPU is not the issue.
**Fix to try**:
Reduce the amount of meshes being rendered each frame.