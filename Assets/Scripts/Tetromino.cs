using UnityEngine;
using UnityEngine.Tilemaps;
public enum Tetromino
{
    I,
    O,
    T,
    L,
    J,
    S,
    Z,
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialise()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}