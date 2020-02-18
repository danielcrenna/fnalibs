This is fnalibs, an archive containing the native libraries used by FNA.

These are the folders included:

- x86: 32-bit Windows
- x64: 64-bit Windows
- lib64: Linux (64-bit only)
- osx: macOS (64-bit only)

The library dependency list is as follows:

- SDL2, used as the platform layer
- MojoShader, used in the Graphics namespace
- FAudio, used in the Audio/Media namespaces
- SDL2_image, only used for Texture2D.FromStream and Texture2D.SaveAsPng/Jpeg
- libtheorafile, only used for VideoPlayer
