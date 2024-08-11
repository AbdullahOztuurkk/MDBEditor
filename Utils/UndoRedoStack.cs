using MDBEditor.Helpers;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor.Utils;

public interface IUndoRedoStack<T>
{
    void Save(T Object);
    void Undo();
    void Redo();

}

public class UndoRedoStack : IUndoRedoStack<Image>
{
    private Stack<Image> UndoStack;
    private Stack<Image> RedoStack;
    public bool CanUndo => UndoStack.Count > 0;
    public bool CanRedo => RedoStack.Count > 0;
    private PictureBox PictureBox { get; set; }
    public UndoRedoStack(PictureBox pictureBox)
    {
        UndoStack = new Stack<Image>();
        RedoStack = new Stack<Image>();
        PictureBox = pictureBox;
    }

    public void Save(Image img)
    {
        UndoStack.Push(img);
        RedoStack.Clear();
    }

    public void Redo()
    {
        if (CanRedo)
        {
            Image image = RedoStack.Pop();
            UndoStack.Push(image);
            PictureBox.SetImage(image);
        }
    }

    public void Undo()
    {
        if (CanUndo)
        {
            Image image = UndoStack.Pop();
            RedoStack.Push(image);
            PictureBox.SetImage(image);
        }
    }
}
